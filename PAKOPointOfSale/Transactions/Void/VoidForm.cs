using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Void
{
    public partial class VoidForm : Form
    {
        private int _id;
        private string _invoiceNumber;
        public VoidForm(int id, string invoiceNumber)
        {
            _id = id;
            _invoiceNumber = invoiceNumber;
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            if (!adminConfirmedVoid())
                return;

            if (MessageBox.Show("Are you sure you want to void this transaction?", "Confirm Void", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;


            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1) Get original transaction
                            decimal subTotal = 0m, grandTotal = 0m, vatAmount = 0m, vatableSales = 0m, vatExempt = 0m;
                            string paymentMethod = "";
                            decimal cashReceived = 0m, cashChange = 0m;
                            DateTime createdAt = DateTime.Now;

                            using (var cmd = new SqlCommand(@"
                        SELECT *
                        FROM Transactions
                        WHERE id = @id AND status = 'Success'", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id", _id);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        subTotal = Convert.ToDecimal(reader["sub_total"]);
                                        grandTotal = Convert.ToDecimal(reader["grand_total"]);
                                        vatAmount = Convert.ToDecimal(reader["vat_amount"]);
                                        vatableSales = Convert.ToDecimal(reader["vatable_sales"]);
                                        vatExempt = Convert.ToDecimal(reader["vat_exempt"]);
                                        paymentMethod = reader["payment_method"].ToString();
                                        cashReceived = Convert.ToDecimal(reader["cash_received"]);
                                        cashChange = Convert.ToDecimal(reader["cash_change"]);
                                        createdAt = Convert.ToDateTime(reader["created_at"]);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Original transaction not found or already voided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }

                            // 2) Insert void transaction
                            string voidInvoiceNumber = _invoiceNumber;
                            using (var cmd = new SqlCommand(@"
                        INSERT INTO Transactions 
                        (invoice_number, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total, payment_method, cash_received, cash_change, status, transaction_type, created_at)
                        VALUES (@invoice_number, @vat_amount, @vatable_sales, @vat_exempt, @sub_total, @grand_total, @payment_method, @cash_received, @cash_change, 'voided', 'Void', @created_at);
                        SELECT SCOPE_IDENTITY();", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@invoice_number", voidInvoiceNumber);
                                cmd.Parameters.AddWithValue("@vat_amount", vatAmount);
                                cmd.Parameters.AddWithValue("@vatable_sales", vatableSales);
                                cmd.Parameters.AddWithValue("@vat_exempt", vatExempt);
                                cmd.Parameters.AddWithValue("@sub_total", subTotal);
                                cmd.Parameters.AddWithValue("@grand_total", grandTotal);
                                cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
                                cmd.Parameters.AddWithValue("@cash_received", cashReceived);
                                cmd.Parameters.AddWithValue("@cash_change", cashChange);
                                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                                int voidTransactionId = Convert.ToInt32(cmd.ExecuteScalar());

                                // ✅ 2.5) Add record to VoidTransactions table
                                string voidNumber = SalesInvoiceFunctions.GenerateNextVoidNumber();
                                using (var cmdVoid = new SqlCommand(@"
                                    INSERT INTO VoidTransactions (void_number, invoice_number, transaction_id)
                                    VALUES (@void_number, @invoice_number, @transaction_id);", conn, tran))
                                {
                                    cmdVoid.Parameters.AddWithValue("@void_number", voidNumber);
                                    cmdVoid.Parameters.AddWithValue("@invoice_number", voidInvoiceNumber);
                                    cmdVoid.Parameters.AddWithValue("@transaction_id", voidTransactionId); // original transaction being voided
                                    cmdVoid.ExecuteNonQuery();
                                }


                                // 3) Copy items and return quantities to stock
                                using (var cmdItems = new SqlCommand(@"
                                    -- Insert void items
                                    INSERT INTO SalesInvoiceItems 
                                        (transaction_id, product_id, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, total_amount, discount, discount_type, unit_of_measurement, transaction_type)
                                    SELECT 
                                        @voidTransactionId, product_id, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, total_amount, discount, discount_type, unit_of_measurement, 'void'
                                    FROM SalesInvoiceItems
                                    WHERE transaction_id = @originalTransactionId;

                                    -- Update stock
                                    UPDATE p
                                    SET p.quantity = p.quantity + si.quantity
                                    FROM Products p
                                    INNER JOIN SalesInvoiceItems si ON si.product_id = p.id
                                    WHERE si.transaction_id = @originalTransactionId;
                                ", conn, tran))
                                {
                                    cmdItems.Parameters.AddWithValue("@voidTransactionId", voidTransactionId);
                                    cmdItems.Parameters.AddWithValue("@originalTransactionId", _id);
                                    cmdItems.ExecuteNonQuery();
                                }

                                tran.Commit();
                                Transactions.PrintVoidReceipt.GenerateVoidReceiptFromTransactionId(voidTransactionId);
                                MessageBox.Show("Transaction successfully voided.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Error voiding transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool adminConfirmedVoid()
        {
            //input pin of the admin first before proceeding
            return true;
        }

        private void VoidForm_Load(object sender, EventArgs e)
        {
            lblInvoiceNumber.Text = _invoiceNumber;
        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string pdfPath = Path.Combine(appPath, $"Receipt_{_invoiceNumber}.pdf");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }
    }
}
