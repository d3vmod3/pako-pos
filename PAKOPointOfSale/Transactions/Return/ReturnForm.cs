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
        private decimal currentQuantity = 0;
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
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvReturnItems.Rows[e.RowIndex];

                // Get the value from the "quantity" column
                currentQuantity = Convert.ToDecimal(row.Cells["quantity"].Value);

                // Optional: convert to int if it's numeric

                // Example: show it in a message box or use it in your logic

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            var confirmForm = new ActionConfirmation("Please confirm admin credentials to proceed.", true, "return");
            if (confirmForm.ShowDialog() != DialogResult.OK)
                return;


            string reason = "";
            Transactions.Return.ReturnReason reasonForm = new Transactions.Return.ReturnReason();
            
            
            reasonForm.Reason += (string reasonValue) =>
            {
                reason = reasonValue;
            };

            reasonForm.ShowDialog();

            string connString = PAKOPointOfSale.Program.ConnString;
            string returnNumber = SalesInvoiceFunctions.GenerateNextReturnNumber();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlTransaction sqlTrans = conn.BeginTransaction())
                {
                    try
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
                    INSERT INTO ReturnTransactions (return_number, invoice_number, transaction_id,reason)
                    VALUES (@return_number, @invoice_number, @transaction_id,@reason);
                    SELECT SCOPE_IDENTITY();";

                        int returnTransactionId;
                        using (SqlCommand cmd = new SqlCommand(insertReturnTransactionQuery, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@return_number", returnNumber);
                            cmd.Parameters.AddWithValue("@invoice_number", _invoiceNumber);
                            cmd.Parameters.AddWithValue("@transaction_id", newTransactionId);
                            cmd.Parameters.AddWithValue("@reason", reason);
                            returnTransactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

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

                            // 🧾 Insert returned item into ReturnItems table
                            string insertReturnItemQuery = @"
                            INSERT INTO ReturnItems 
                            (return_transaction_id, product_id, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, 
                             discount, discount_type, total_amount, unit_of_measurement, transaction_type)
                            VALUES 
                            (@return_transaction_id, @product_id, @quantity, @unit_price, @vat_amount, @vatable_sales, @vat_exempt,
                             @discount, @discount_type, @total_amount, @unit_of_measurement, @transaction_type)";
                            using (SqlCommand cmd = new SqlCommand(insertReturnItemQuery, conn, sqlTrans))
                            {
                                cmd.Parameters.AddWithValue("@return_transaction_id", returnTransactionId);
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

                        // ✅ Commit all operations
                        sqlTrans.Commit();

                        MessageBox.Show(
                            $"Return Transaction Successful!\nReturn No: {returnNumber}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        Transactions.PrintReturnReceipt.GenerateReturnReceiptFromTransactionId(newTransactionId);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        sqlTrans.Rollback();
                        MessageBox.Show($"An error occurred while processing the return:\n{ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReturnItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex < 0) return;


            DataGridViewRow row = dgvReturnItems.Rows[e.RowIndex];
            string columnName = dgvReturnItems.Columns[e.ColumnIndex].Name;


            // Only recalculate subtotal when quantity or unit price changes
            if (columnName == "quantity" || columnName == "unit_price")
            {
                decimal currentQuantityApplied = Convert.ToDecimal(row.Cells["quantity"].Value);
                if (currentQuantity < currentQuantityApplied)
                {
                    MessageBox.Show(
                        "Return quantity must not be greater than what was purchased.",
                        "Invalid Return Quantity",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                //if(currentQuantityApplied < Convert.ToDecimal(row.Cells["quantity"].Value))
                //{6

                //}
                decimal qty = 0, price = 0;

                string discountType = row.Cells["discount_type"].Value.ToString();

                if (row.Cells["quantity"].Value != null)
                    decimal.TryParse(row.Cells["quantity"].Value.ToString(), out qty);

                if (row.Cells["unit_price"].Value != null)
                    decimal.TryParse(row.Cells["unit_price"].Value.ToString(), out price);

                // Compute subtotal for this row
                decimal subTotal = qty * price;
                row.Cells["total_amount"].Value = subTotal.ToString("0.00");

                row.Cells["vatable_sales"].Value = Convert.ToString(SalesInvoiceFunctions.getVATableSales(price, qty));
                row.Cells["vat_amount"].Value = Convert.ToString(SalesInvoiceFunctions.getVATAmount(price, qty));

                if (discountType != "none")
                {
                    RecalculateValues(discountType, dgvReturnItems.CurrentRow);
                }

            }
            //ComputeGrandTotal();
        }

        private void QuantityColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvReturnItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvReturnItems.CurrentCell.ColumnIndex == dgvReturnItems.Columns["quantity"].Index)
            {
                // Unsubscribe previous handlers to avoid duplicates
                e.Control.KeyPress -= QuantityColumn_KeyPress;
                e.Control.KeyPress += QuantityColumn_KeyPress;
            }
            else
            {
                // Remove handler for all other columns
                e.Control.KeyPress -= QuantityColumn_KeyPress;
            }
        }

        private void RecalculateValues(string selectedDiscountType, DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;

            decimal price = Convert.ToDecimal(selectedRow.Cells["unit_price"].Value);
            decimal qty = Convert.ToDecimal(selectedRow.Cells["quantity"].Value);
            decimal originalSubTotal = price * qty;

            if (selectedDiscountType == "None")
            {
                // Restore original values
                selectedRow.Cells["discount_type"].Value = "None";
                selectedRow.Cells["discount"].Value = 0m;
                selectedRow.Cells["total_amount"].Value = originalSubTotal;
                selectedRow.Cells["vat_amount"].Value = 0.12m * (originalSubTotal / 1.12m);
                selectedRow.Cells["vat_exempt"].Value = 0.00m;
            }
            else
            {
                // Apply selected discount
                selectedRow.Cells["discount_type"].Value = selectedDiscountType;
                decimal discountAmount = 0m;

                if (selectedDiscountType.Contains("Senior Citizen 5%") || selectedDiscountType.Contains("Person With Disability 5%"))
                {
                    discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.05m, qty);
                    selectedRow.Cells["vat_amount"].Value = 0.00m;
                    selectedRow.Cells["vat_exempt"].Value = 0.12m * ((price * qty) / 1.12m);
                }
                else if (selectedDiscountType.Contains("Senior Citizen 20%") || selectedDiscountType.Contains("Person With Disability 20%") ||
                         selectedDiscountType.Contains("National Athletes and Coaches 20%"))
                {
                    discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.20m, qty);

                    // For 20% SC/PWD, exempt from VAT (except athletes)
                    if (!selectedDiscountType.Contains("National Athletes and Coaches 20%"))
                    {
                        selectedRow.Cells["vat_amount"].Value = 0.00m;
                        selectedRow.Cells["vat_exempt"].Value = 0.12m * ((price * qty) / 1.12m);
                    }
                }

                // Update row with discount
                selectedRow.Cells["discount"].Value = discountAmount;
                selectedRow.Cells["total_amount"].Value = originalSubTotal - discountAmount;
            }
        }

        
    }
}
