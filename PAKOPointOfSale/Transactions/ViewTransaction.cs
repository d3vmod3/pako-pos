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

namespace PAKOPointOfSale.Transactions
{
    public partial class ViewTransaction : Form
    {
        private int _id;
        private string _invoiceNumber;
        public ViewTransaction(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void ViewTransaction_Load(object sender, EventArgs e)
        {
            LoadTransactionDetails();
        }
        private void LoadTransactionDetails()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Load transaction header
                    using (var cmdHeader = new SqlCommand(@"
                        SELECT id, invoice_number, sub_total, grand_total, vat_amount, vatable_sales, 
                               vat_exempt, payment_method, cash_received, cash_change, status, created_at
                        FROM Transactions
                        WHERE id = @id", conn))
                    {
                        cmdHeader.Parameters.AddWithValue("@id", _id);
                        using (var reader = cmdHeader.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _invoiceNumber = reader["invoice_number"].ToString();
                                lblInvoiceNumber.Text = reader["invoice_number"].ToString();
                                lblSubTotal.Text = Convert.ToDecimal(reader["sub_total"]).ToString("N2");
                                lblGrandTotal.Text = Convert.ToDecimal(reader["grand_total"]).ToString("N2");
                                lblVatAmount.Text = Convert.ToDecimal(reader["vat_amount"]).ToString("N2");
                                lblPaymentMethod.Text = reader["payment_method"].ToString();
                                lblCashReceived.Text = Convert.ToDecimal(reader["cash_received"]).ToString("N2");
                                lblChange.Text = Convert.ToDecimal(reader["cash_change"]).ToString("N2");
                                //lblStatus.Text = reader["status"].ToString();
                                lblTransactionDate.Text = Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm");
                            }
                        }
                    }

                    // Load transaction items
                    using (var cmdItems = new SqlCommand(@"
                            SELECT si.id,
                                   p.product_code,
                                   p.product_name,
                                   si.quantity,
                                   si.unit_price,
                                   si.total_amount,
                                   si.vat_amount,
                                   si.vatable_sales,
                                   si.vat_exempt,
                                   si.discount,
                                   si.discount_type,
                                   si.unit_of_measurement
                            FROM SalesInvoiceItems si
                            INNER JOIN Products p ON si.product_id = p.id
                            WHERE si.transaction_id = @id
                            ORDER BY si.id", conn))
                    {
                        cmdItems.Parameters.AddWithValue("@id", _id);

                        DataTable dtItems = new DataTable();
                        using (var adapter = new SqlDataAdapter(cmdItems))
                        {
                            adapter.Fill(dtItems);
                        }

                        dgvItems.DataSource = dtItems;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            Transactions.Void.VoidForm voidSalesInvoiceForm = new Transactions.Void.VoidForm(_id, _invoiceNumber);
            voidSalesInvoiceForm.ShowDialog();
        }
    }
}
