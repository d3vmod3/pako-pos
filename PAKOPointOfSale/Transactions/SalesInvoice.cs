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
using WinFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAKOPointOfSale.Transactions
{
    public partial class SalesInvoice : Form
    {
        private DataTable productsTable;

        public SalesInvoice()
        {
            InitializeComponent();
        }

        private void SalesInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            Transactions.SearchProduct searchProductForm = new Transactions.SearchProduct(this);
            searchProductForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Check if the clicked column is the "Remove" button column
            if (dtgvCart.Columns[e.ColumnIndex].Name == "remove") // Replace "Remove" with your button column name
            {
                // Optional: Confirm before removing
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this item?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dtgvCart.Rows.RemoveAt(e.RowIndex);

                    // Optional: Update grand total here if needed
                    ComputeGrandTotal();
                }
            }
        }
        public void AddProductToCart(int id, string product, string brand, string unit, decimal price, string category, int quantity)
        {
            // Create a new row in your DataGridView (e.g., dgvCart)
            dtgvCart.Rows.Add(id, product, brand, unit, quantity, price, category);
            ComputeGrandTotal();
        }

        private void ComputeGrandTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgvCart.Rows)
            {
                if (row.Cells["unit_price"].Value != null && row.Cells["appliedQty"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["unit_price"].Value);
                    int qty = Convert.ToInt32(row.Cells["appliedQty"].Value);
                    total += price * qty;
                }
            }

            lblTotal.Text = total.ToString("#,##0.00"); // or just total.ToString("N2")
        }

        private void num_CashAmount_ValueChanged(object sender, EventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(num_CashAmount.Value) - Convert.ToDecimal(lblTotal.Text));
        }

        private void num_CashAmount_KeyUp(object sender, KeyEventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(num_CashAmount.Value) - Convert.ToDecimal(lblTotal.Text));
        }

        private void dtgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ComputeGrandTotal();
        }

        private void dtgvCart_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void QuantityColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check if the current column is "Quantity"
            if (dtgvCart.CurrentCell.ColumnIndex == dtgvCart.Columns["appliedQty"].Index)
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

        private void dtgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ComputeGrandTotal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtScannedBarcode.Text.Trim();

            if (string.IsNullOrEmpty(barcode))
                return;


            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();

                // Query product by barcode
                string query = @"
                                SELECT p.id,product_name,c.name as category,product_brand,quantity,unit_of_measurement,unit_price
                                FROM Products as p LEFT JOIN Categories c ON p.category_id = c.id
                                WHERE p.is_active = 1 and p.product_code=@code";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", barcode);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int product_id = Convert.ToInt32(reader["id"]);
                            string product = reader["product_name"].ToString();
                            string brand = reader["product_brand"].ToString();
                            string unit = reader["unit_of_measurement"].ToString();
                            decimal price = Convert.ToDecimal(reader["unit_price"]);
                            string category = reader["category"].ToString();
                            int quantity = 1; // default to 1 when scanned

                            // Validation: Do not add if quantity is 0
                            if (quantity <= 0)
                            {
                                MessageBox.Show("Cannot add product with quantity 0.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtScannedBarcode.Clear();
                                txtScannedBarcode.Focus();
                                return;
                            }

                            // Add product to cart
                            AddProductToCart(product_id, product, brand, unit, price, category, quantity);

                            // Clear the textbox for next scan
                            txtScannedBarcode.Clear();
                            txtScannedBarcode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Product not found for barcode: " + barcode, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtScannedBarcode.Clear();
                            txtScannedBarcode.Focus();
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generate invoice number here if status is success
            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction(); // begin transaction for safety

                //try
                //{
                    // Generate invoice number
                    

                    // Calculate totals from DataGridView
                    decimal subTotal = 0;
                    decimal vatAmount = 0;
                    decimal vatableSales = 0;
                    decimal vatExempt = 0;
                    decimal grandTotal = Convert.ToDecimal(lblTotal.Text);

                    foreach (DataGridViewRow row in dtgvCart.Rows)
                    {
                        if (row.Cells["appliedQty"].Value != null && row.Cells["unit_price"].Value != null)
                        {
                            decimal quantity = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                            decimal discount = 0;
                            //decimal discount = row.Cells["Discount"].Value != null ? Convert.ToDecimal(row.Cells["Discount"].Value) : 0;
                            decimal totalAmount = (quantity * unitPrice) - discount;

                            subTotal += quantity * unitPrice;
                            //grandTotal += totalAmount;
                        }
                    }

                    // Insert into Transactions table
                    string insertTransaction = @"
                INSERT INTO Transactions (invoice_number, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total, payment_method, status,cash_received,cash_change)
                VALUES (@invoice, @vatAmount, @vatable, @vatExempt, @subTotal, @grandTotal, @payment, @status,@cashReceived,@cashChange);
                SELECT SCOPE_IDENTITY();"; // get the inserted transaction id
                string invoiceNumber = GenerateNextInvoiceNumber();
                int transactionId;
                    using (SqlCommand cmd = new SqlCommand(insertTransaction, conn, sqlTran))
                    {
                        cmd.Parameters.AddWithValue("@invoice", invoiceNumber);
                        cmd.Parameters.AddWithValue("@vatAmount", vatAmount);
                        cmd.Parameters.AddWithValue("@vatable", vatableSales);
                        cmd.Parameters.AddWithValue("@vatExempt", vatExempt);
                        cmd.Parameters.AddWithValue("@subTotal", subTotal);
                        cmd.Parameters.AddWithValue("@grandTotal", grandTotal);
                        cmd.Parameters.AddWithValue("@payment", "cash");
                        cmd.Parameters.AddWithValue("@cashReceived", num_CashAmount.Value);
                        cmd.Parameters.AddWithValue("@cashChange", Convert.ToDecimal(lblChange.Text));
                        cmd.Parameters.AddWithValue("@status", "success");

                        transactionId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert each cart item into SalesInvoiceItems
                    foreach (DataGridViewRow row in dtgvCart.Rows)
                    {
                        if (row.Cells["appliedQty"].Value != null && row.Cells["unit_price"].Value != null)
                        {
                            int productId = Convert.ToInt32(row.Cells["id"].Value);
                            decimal quantity = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells["unit_price"].Value);
                            //decimal discount = row.Cells["Discount"].Value != null ? Convert.ToDecimal(row.Cells["Discount"].Value) : 0;
                            decimal discount = 0;
                            //string discountType = row.Cells["DiscountType"].Value?.ToString() ?? null;
                            string discountType = "none";
                            decimal totalAmount = (quantity * unitPrice) - discount;
                            string unit = row.Cells["unit_of_measurement"].Value.ToString();

                            // Insert SalesInvoiceItem
                            string insertItem = @"
                            INSERT INTO SalesInvoiceItems 
                            (transaction_id, product_id, quantity, unit_price, discount, discount_type, total_amount, unit_of_measurement)
                            VALUES (@transId, @prodId, @qty, @unitPrice, @discount, @discountType, @total, @unit)";

                            using (SqlCommand cmdItem = new SqlCommand(insertItem, conn, sqlTran))
                            {
                                cmdItem.Parameters.AddWithValue("@transId", transactionId);
                                cmdItem.Parameters.AddWithValue("@prodId", productId);
                                cmdItem.Parameters.AddWithValue("@qty", quantity);
                                cmdItem.Parameters.AddWithValue("@unitPrice", unitPrice);
                                cmdItem.Parameters.AddWithValue("@discount", discount);
                                cmdItem.Parameters.AddWithValue("@discountType", (object)discountType ?? DBNull.Value);
                                cmdItem.Parameters.AddWithValue("@total", totalAmount);
                                cmdItem.Parameters.AddWithValue("@unit", unit);

                                cmdItem.ExecuteNonQuery();
                            }

                            // Deduct quantity from Products table
                            string updateStock = @"
                                UPDATE Products
                                SET quantity = quantity - @soldQty
                                WHERE id = @prodId";

                            using (SqlCommand cmdStock = new SqlCommand(updateStock, conn, sqlTran))
                            {
                                cmdStock.Parameters.AddWithValue("@soldQty", quantity);
                                cmdStock.Parameters.AddWithValue("@prodId", productId);

                                cmdStock.ExecuteNonQuery();
                            }
                        }
                    }

                    // Commit transaction
                    sqlTran.Commit();

                    MessageBox.Show("Transaction successfully saved with invoice: " + invoiceNumber, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvCart.Rows.Clear();
                //}
                //catch (Exception ex)
                //{
                //    sqlTran.Rollback();
                //    MessageBox.Show("Error saving transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


            }
        }
        private string GenerateNextInvoiceNumber()
        {
            string lastInvoice = null;
            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();
                string query = "SELECT TOP 1 invoice_number FROM Transactions WHERE status='success' ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        lastInvoice = result.ToString();
                }

                int nextNumber = 1;

                if (!string.IsNullOrEmpty(lastInvoice))
                {
                    if (int.TryParse(lastInvoice, out int lastNumber))
                        nextNumber = lastNumber + 1;
                }

                // Pad with zeros to make 6 digits
                return nextNumber.ToString("D6"); // e.g., "000001", "000002"
            }
        }
    }
}
