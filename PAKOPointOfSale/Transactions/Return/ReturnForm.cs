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

namespace PAKOPointOfSale.Transactions.Return
{
    public partial class ReturnForm : Form
    {
        private int _id;
        private string _invoiceNumber;
        private List<DataGridViewRow> _selectedItems;
        public ReturnForm(int id, string invoiceNumber, List<DataGridViewRow> selectedItems)
        {
            InitializeComponent();
            _id = id;
            _invoiceNumber = invoiceNumber;
            _selectedItems = selectedItems;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            lblInvoiceNumber.Text = _invoiceNumber;
            if (_selectedItems != null && _selectedItems.Count > 0)
            {
                foreach (DataGridViewRow row in _selectedItems)
                {
                    int rowIndex = dgvReturnItems.Rows.Add(); // add a new empty row
                    dgvReturnItems.Rows[rowIndex].Cells["id"].Value = row.Cells["id"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["product_id"].Value = row.Cells["product_id"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["product_code"].Value = row.Cells["product_code"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["product_name"].Value = row.Cells["product_name"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["product_brand"].Value = row.Cells["product_brand"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["quantity"].Value = row.Cells["quantity"].Value; dgvReturnItems.Rows[rowIndex].Cells["unit_price"].Value = row.Cells["unit_price"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["total_amount"].Value = row.Cells["total_amount"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["vat_amount"].Value = row.Cells["vat_amount"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["vatable_sales"].Value = row.Cells["vatable_sales"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["vat_exempt"].Value = row.Cells["vat_exempt"].Value; dgvReturnItems.Rows[rowIndex].Cells["discount"].Value = row.Cells["discount"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["discount_type"].Value = row.Cells["discount_type"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["unit_of_measurement"].Value = row.Cells["unit_of_measurement"].Value;
                    dgvReturnItems.Rows[rowIndex].Cells["transaction_id"].Value = row.Cells["transaction_id"].Value;
                }
            }


        }

        private void dgvReturnItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var confirmForm = new ActionConfirmation("Please confirm admin credentials to proceed.", true, "return");
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                string connString = PAKOPointOfSale.Program.ConnString;
                string returnNumber = SalesInvoiceFunctions.GenerateNextReturnNumber();

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlTransaction sqlTrans = conn.BeginTransaction())
                    {
                        decimal totalVatAmount = 0;
                        decimal totalVatableSales = 0;
                        decimal totalVatExempt = 0;
                        decimal totalSubTotal = 0;
                        decimal totalGrandTotal = 0;

                        foreach (DataGridViewRow row in dgvReturnItems.Rows)
                        {
                            if (row.IsNewRow) continue;

                            totalVatAmount += Convert.ToDecimal(row.Cells["vat_amount"].Value ?? 0);
                            totalVatableSales += Convert.ToDecimal(row.Cells["vatable_sales"].Value ?? 0);
                            totalVatExempt += Convert.ToDecimal(row.Cells["vat_exempt"].Value ?? 0);
                            totalSubTotal += Convert.ToDecimal(row.Cells["total_amount"].Value ?? 0);
                        }

                        totalGrandTotal = totalSubTotal;


                        // 1️⃣ Create new transaction record (for return)
                        string insertTransactionQuery = @"
                        INSERT INTO Transactions 
                        (invoice_number, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total,
                            payment_method, cash_received, cash_change, status, transaction_type, created_at)
                        VALUES 
                        (@invoice_number, @vat_amount, @vatable_sales, @vat_exempt, @sub_total, @grand_total,
                            @payment_method, @cash_received, @cash_change, @status, @transaction_type, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                        int newTransactionId;
                        using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@invoice_number", _invoiceNumber);
                            cmd.Parameters.AddWithValue("@vat_amount", totalVatAmount);
                            cmd.Parameters.AddWithValue("@vatable_sales", totalVatableSales);
                            cmd.Parameters.AddWithValue("@vat_exempt", totalVatExempt);
                            cmd.Parameters.AddWithValue("@sub_total", totalSubTotal);
                            cmd.Parameters.AddWithValue("@grand_total", totalGrandTotal);

                            cmd.Parameters.AddWithValue("@payment_method", "cash");
                            cmd.Parameters.AddWithValue("@cash_received", 0);
                            cmd.Parameters.AddWithValue("@cash_change", 0);
                            cmd.Parameters.AddWithValue("@status", "refund");
                            cmd.Parameters.AddWithValue("@transaction_type", "Return");

                            newTransactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2️⃣ Create return header in ReturnTransactions table
                        string insertReturnTransactionQuery = @"
                        INSERT INTO ReturnTransactions (return_number, invoice_number, transaction_id)
                        VALUES (@return_number, @invoice_number, @transaction_id);
                        SELECT SCOPE_IDENTITY();";

                        int returnTransactionId;
                        using (SqlCommand cmd = new SqlCommand(insertReturnTransactionQuery, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@return_number", returnNumber);
                            cmd.Parameters.AddWithValue("@invoice_number", _invoiceNumber);
                            cmd.Parameters.AddWithValue("@transaction_id", newTransactionId);
                            returnTransactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        decimal totalReturnAmount = 0;

                        // 3️⃣ Loop through each returned item
                        foreach (DataGridViewRow row in dgvReturnItems.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            decimal returnQty = Convert.ToDecimal(row.Cells["quantity"].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells["unit_price"].Value);
                            decimal totalAmount = Convert.ToDecimal(row.Cells["total_amount"].Value);
                            decimal vatAmount = Convert.ToDecimal(row.Cells["vat_amount"].Value ?? 0);
                            decimal vatableSales = Convert.ToDecimal(row.Cells["vatable_sales"].Value ?? 0);
                            decimal vatExempt = Convert.ToDecimal(row.Cells["vat_exempt"].Value ?? 0);
                            decimal discount = Convert.ToDecimal(row.Cells["discount"].Value ?? 0);
                            string discountType = row.Cells["discount_type"].Value?.ToString() ?? "none";
                            string unitOfMeasurement = row.Cells["unit_of_measurement"].Value?.ToString() ?? "";
                            totalReturnAmount += totalAmount;

                            // 🧾 Insert returned item into SalesInvoiceItems table
                            string insertSalesItemQuery = @"
                            INSERT INTO SalesInvoiceItems 
                            (transaction_id, product_id, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, 
                                discount, discount_type, total_amount, unit_of_measurement, transaction_type)
                            VALUES 
                            (@transaction_id, @product_id, @quantity, @unit_price, @vat_amount, @vatable_sales, @vat_exempt,
                                @discount, @discount_type, @total_amount, @unit_of_measurement, @transaction_type)";
                            using (SqlCommand cmd = new SqlCommand(insertSalesItemQuery, conn, sqlTrans))
                            {
                                cmd.Parameters.AddWithValue("@transaction_id", newTransactionId);
                                cmd.Parameters.AddWithValue("@product_id", productId);
                                cmd.Parameters.AddWithValue("@quantity", returnQty);
                                cmd.Parameters.AddWithValue("@unit_price", unitPrice);
                                cmd.Parameters.AddWithValue("@vat_amount", vatAmount);
                                cmd.Parameters.AddWithValue("@vatable_sales", vatableSales);
                                cmd.Parameters.AddWithValue("@vat_exempt", vatExempt);
                                cmd.Parameters.AddWithValue("@discount", discount);
                                cmd.Parameters.AddWithValue("@discount_type", discountType);
                                cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                                cmd.Parameters.AddWithValue("@unit_of_measurement", unitOfMeasurement);
                                cmd.Parameters.AddWithValue("@transaction_type", "Return");
                                cmd.ExecuteNonQuery();
                            }

                            // 🏷️ Update product stock (add back returned quantity)
                            string updateProductQuery = "UPDATE Products SET quantity = quantity + @qty WHERE id = @product_id";
                            using (SqlCommand cmd = new SqlCommand(updateProductQuery, conn, sqlTrans))
                            {
                                cmd.Parameters.AddWithValue("@qty", returnQty);
                                cmd.Parameters.AddWithValue("@product_id", productId);
                                cmd.ExecuteNonQuery();
                            }
                        }


                        //// 7️⃣ Update total return amount in Transactions table
                        //string updateTotalQuery = "UPDATE Transactions SET grand_total = @total WHERE id = @id";
                        //using (SqlCommand cmd = new SqlCommand(updateTotalQuery, conn, sqlTrans))
                        //{
                        //    cmd.Parameters.AddWithValue("@total", totalReturnAmount);
                        //    cmd.Parameters.AddWithValue("@id", newTransactionId);
                        //    cmd.ExecuteNonQuery();
                        //}

                        // ✅ Commit all
                        sqlTrans.Commit();

                        MessageBox.Show(
                            $"Return Transaction Successful!\nReturn No: {returnNumber}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        Transactions.PrintReturnReceipt.GenerateReturnReceiptFromTransactionId(newTransactionId);
                        this.Close();
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
