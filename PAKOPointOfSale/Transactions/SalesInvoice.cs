using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace PAKOPointOfSale.Transactions
{
    public partial class SalesInvoice : Form
    {
        private DataTable productsTable;
        private Double manualCashInputAmount = 0.00;
        public SalesInvoice()
        {
            InitializeComponent();
        }

        private void SalesInvoice_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
        public void AddProductToCart(int id, string product, string brand, string unit, decimal price, string category, int quantity, decimal subTotal)
        {
            // Create a new row in your DataGridView (e.g., dgvCart)
            string VATableSales = Convert.ToString(SalesInvoiceFunctions.getVATableSales(price, quantity));
            string VATAmount = Convert.ToString(SalesInvoiceFunctions.getVATAmount(price, quantity));

            //string VATExempt = Convert.ToString(SalesInvoiceFunctions.getVATExempt(price, quantity));
            dtgvCart.Rows.Add(id, 0, product, brand, unit, quantity, price, category, "none", "0.00", subTotal, VATableSales, VATAmount, "0.00");
            ComputeGrandTotal();
        }

        private void ComputeGrandTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgvCart.Rows)
            {
                if (row.Cells["subTotal"].Value != null)
                {
                    decimal subTotal = Convert.ToDecimal(row.Cells["subTotal"].Value);
                    //int qty = Convert.ToInt32(row.Cells["appliedQty"].Value);
                    total += subTotal;
                }
            }

            lblTotal.Text = total.ToString("#,##0.00"); // or just total.ToString("N2")
        }

        private void num_CashAmount_ValueChanged(object sender, EventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txtCash.Text)) - Convert.ToDecimal(lblTotal.Text));
        }

        private void num_CashAmount_KeyUp(object sender, KeyEventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txtCash.Text)) - Convert.ToDecimal(lblTotal.Text));
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
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtgvCart.Rows[e.RowIndex];
            string columnName = dtgvCart.Columns[e.ColumnIndex].Name;


            // Only recalculate subtotal when quantity or unit price changes
            if (columnName == "appliedQty" || columnName == "unit_price")
            {
                decimal qty = 0, price = 0;

                string discountType = row.Cells["discountType"].Value.ToString();

                if (row.Cells["appliedQty"].Value != null)
                    decimal.TryParse(row.Cells["appliedQty"].Value.ToString(), out qty);

                if (row.Cells["unit_price"].Value != null)
                    decimal.TryParse(row.Cells["unit_price"].Value.ToString(), out price);

                // Compute subtotal for this row
                decimal subTotal = qty * price;
                row.Cells["subTotal"].Value = subTotal.ToString("0.00");

                row.Cells["vatableSales"].Value = Convert.ToString(SalesInvoiceFunctions.getVATableSales(price, qty));
                row.Cells["vatAmount"].Value = Convert.ToString(SalesInvoiceFunctions.getVATAmount(price, qty));

                if (discountType != "none")
                {
                    RecalculateValues(discountType, dtgvCart.CurrentRow);
                }

            }
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
                                WHERE p.is_active = 1 and p.barcode=@code";
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
                            decimal subTotal = price * quantity;
                            // Validation: Do not add if quantity is 0
                            if (quantity <= 0)
                            {
                                MessageBox.Show("Cannot add product with quantity 0.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtScannedBarcode.Clear();
                                txtScannedBarcode.Focus();
                                return;
                            }

                            // Add product to cart
                            AddProductToCart(product_id, product, brand, unit, price, category, quantity, subTotal);

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
            //bool isInsufficientCash = Convert.ToDecimal(lblTotal.Text) < Convert.ToDecimal(txtCash.Text);
            if (validateTransaction())
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();
                    SqlTransaction sqlTran = conn.BeginTransaction(); // begin transaction for safety

                    //try
                    //{
                    // Generate invoice number


                    // Calculate totals from DataGridView
                    decimal totalOfSubtotal = 0;
                    decimal totalVatAmount = 0;
                    decimal totalVatableSales = 0;
                    decimal totalVatExempt = 0;
                    decimal grandTotal = Convert.ToDecimal(lblTotal.Text);

                    foreach (DataGridViewRow row in dtgvCart.Rows)
                    {
                        if (row.Cells["appliedQty"].Value != null && row.Cells["unit_price"].Value != null)
                        {
                            decimal quantity = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                            decimal vatableSales = Convert.ToDecimal(row.Cells["vatableSales"].Value);
                            decimal vatAmount = Convert.ToDecimal(row.Cells["vatAmount"].Value);
                            decimal vatExempt = Convert.ToDecimal(row.Cells["vatExempt"].Value);
                            decimal subsubTotal = Convert.ToDecimal(row.Cells["subTotal"].Value);
                            decimal discount = 0;
                            //decimal discount = row.Cells["Discount"].Value != null ? Convert.ToDecimal(row.Cells["Discount"].Value) : 0;
                            decimal totalAmount = (quantity * unitPrice) - discount;
                            totalVatableSales += vatableSales;
                            totalVatAmount += vatAmount;
                            totalVatExempt += vatExempt;
                            totalOfSubtotal += subsubTotal;
                            //grandTotal += totalAmount;
                        }
                    }

                    // Insert into Transactions table
                    string insertTransaction = @"
                INSERT INTO Transactions (invoice_number,transaction_type ,vat_amount, vatable_sales, vat_exempt, sub_total, grand_total, payment_method, status,cash_received,cash_change,created_at)
                VALUES (@invoice,@transactionType, @vatAmount, @vatableSales, @vatExempt, @subTotal, @grandTotal, @payment, @status,@cashReceived,@cashChange,@created_at);
                SELECT SCOPE_IDENTITY();"; // get the inserted transaction id
                    string invoiceNumber = SalesInvoiceFunctions.GenerateNextInvoiceNumber();
                    ;
                    int transactionId;
                    using (SqlCommand cmd = new SqlCommand(insertTransaction, conn, sqlTran))
                    {
                        cmd.Parameters.AddWithValue("@invoice", invoiceNumber);
                        cmd.Parameters.AddWithValue("@transactionType", "Sales Invoice");
                        cmd.Parameters.AddWithValue("@vatAmount", totalVatAmount);
                        cmd.Parameters.AddWithValue("@vatableSales", totalVatableSales);
                        cmd.Parameters.AddWithValue("@vatExempt", totalVatExempt);
                        cmd.Parameters.AddWithValue("@subTotal", totalOfSubtotal);
                        cmd.Parameters.AddWithValue("@grandTotal", grandTotal);
                        cmd.Parameters.AddWithValue("@payment", "cash");
                        cmd.Parameters.AddWithValue("@cashReceived", Convert.ToDecimal(txtCash.Text));
                        cmd.Parameters.AddWithValue("@cashChange", Convert.ToDecimal(lblChange.Text));
                        cmd.Parameters.AddWithValue("@status", "success");
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

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
                            decimal vatableSales = Convert.ToDecimal(row.Cells["vatableSales"].Value);
                            decimal vatAmount = Convert.ToDecimal(row.Cells["vatAmount"].Value);
                            decimal vatExempt = Convert.ToDecimal(row.Cells["vatExempt"].Value);
                            decimal discountAmount = Convert.ToDecimal(row.Cells["discountAmount"].Value);
                            string discountType = row.Cells["discountType"].Value.ToString();
                            string unit = row.Cells["unit_of_measurement"].Value.ToString();
                            decimal totalAmount = (quantity * unitPrice) - discountAmount;


                            // Insert SalesInvoiceItem
                            string insertItem = @"
                            INSERT INTO SalesInvoiceItems 
                            (transaction_id, product_id, quantity, unit_price, discount, discount_type, total_amount, unit_of_measurement,vatable_sales,vat_amount,vat_exempt,transaction_type)
                            VALUES (@transId, @prodId, @qty, @unitPrice, @discount, @discountType, @total, @unit,@vatableSales,@vatAmount,@vatExempt,@transactioType)";

                            using (SqlCommand cmdItem = new SqlCommand(insertItem, conn, sqlTran))
                            {
                                cmdItem.Parameters.AddWithValue("@transId", transactionId);
                                cmdItem.Parameters.AddWithValue("@prodId", productId);
                                cmdItem.Parameters.AddWithValue("@qty", quantity);
                                cmdItem.Parameters.AddWithValue("@unitPrice", unitPrice);
                                cmdItem.Parameters.AddWithValue("@discount", discountAmount);
                                cmdItem.Parameters.AddWithValue("@discountType", discountType);
                                cmdItem.Parameters.AddWithValue("@total", totalAmount);
                                cmdItem.Parameters.AddWithValue("@unit", unit);
                                cmdItem.Parameters.AddWithValue("@vatableSales", vatableSales);
                                cmdItem.Parameters.AddWithValue("@vatAmount", vatAmount);
                                cmdItem.Parameters.AddWithValue("@vatExempt", vatExempt);
                                cmdItem.Parameters.AddWithValue("@transactioType", "salesInvoice");



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
                    dtgvCart.Rows.Clear();

                    DialogResult result = MessageBox.Show(
                        "Transaction successfully saved with invoice: " + invoiceNumber +
                        "\n\nWould you like to print the receipt?",
                        "Success",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
);

                    if (result == DialogResult.Yes)
                    {
                        //Transactions.ReceiptPrinter receiptForm = new Transactions.ReceiptPrinter();
                        //receiptForm.GenerateReceiptFromDatabase(invoiceNumber);
                        Transactions.PrintSalesInvoiceReceipt.GenerateReceiptFromDatabase(invoiceNumber);
                    }
                    else
                    {
                        // ❌ Optionally do nothing or close the form
                        MessageBox.Show("You chose not to print the receipt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //}
                    //catch (Exception ex)
                    //{
                    //    sqlTran.Rollback();
                    //    MessageBox.Show("Error saving transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}


                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "1";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCash.Text.Trim() != "")
            {
                lblChange.Text = Convert.ToString(Convert.ToDecimal(txtCash.Text) - Convert.ToDecimal(lblTotal.Text));
            }
            else
            {
                lblChange.Text = "0.00";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtCash.Text = "1000.00";
        }

        private void btn5h_Click(object sender, EventArgs e)
        {
            txtCash.Text = "500.00";
        }

        private void btn2h_Click(object sender, EventArgs e)
        {
            txtCash.Text = "200.00";
        }

        private void btn1h_Click(object sender, EventArgs e)
        {
            txtCash.Text = "100.00";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
        }

        private void txtCash_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnKey2_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "2";
        }

        private void btnKey3_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "3";
        }

        private void btnKey4_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "4";
        }

        private void btnKey5_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "5";
        }

        private void btnKey6_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "6";
        }

        private void btnKey7_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "7";
        }

        private void btnKey8_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "8";
        }

        private void btnKey9_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + ".";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text = txtCash.Text + "0";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            bool hasSelectedItems = false;

            foreach (DataGridViewRow row in dtgvCart.Rows)
            {
                // Make sure the row is not new
                if (!row.IsNewRow)
                {
                    // Check if the "select" cell is checked
                    object value = row.Cells["select"].Value;
                    if (value != null && value != DBNull.Value)
                    {
                        hasSelectedItems = true;
                        break; // No need to continue, we found at least one
                    }
                }
            }

            if (!hasSelectedItems)
            {
                MessageBox.Show("Please select at least one item from the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var applyDiscountForm = new Transactions.Discounts.DiscountTypes();
                applyDiscountForm.DiscountSelected += ApplyDiscountToSelectedRows;
                applyDiscountForm.Show();
            }


        }
        private void ApplyDiscountToSelectedRows(string selectedDiscount)
        {
            foreach (DataGridViewRow row in dtgvCart.Rows)
            {
                // Check if the row is selected
                bool isSelected = row.Cells["select"].Value?.ToString() == "1";

                if (!isSelected)
                    continue;

                // Get original values
                decimal price = Convert.ToDecimal(row.Cells["unit_price"].Value);
                decimal qty = Convert.ToDecimal(row.Cells["appliedQty"].Value);
                decimal originalSubTotal = price * qty;

                if (selectedDiscount == "None")
                {
                    // Restore original values
                    row.Cells["DiscountType"].Value = "None";
                    row.Cells["discountAmount"].Value = 0m;
                    row.Cells["subTotal"].Value = originalSubTotal;
                    row.Cells["vatAmount"].Value = 0.12m * (originalSubTotal / 1.12m);
                    row.Cells["vatExempt"].Value = 0.00m;
                }
                else
                {
                    // Apply selected discount
                    row.Cells["DiscountType"].Value = selectedDiscount;
                    decimal discountAmount = 0m;

                    if (selectedDiscount.Contains("Senior Citizen 5%") || selectedDiscount.Contains("Person With Disability 5%"))
                    {
                        discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.05m, qty);
                        row.Cells["vatAmount"].Value = 0.00m;
                        row.Cells["vatExempt"].Value = 0.12m * ((price * qty) / 1.12m);
                    }
                    else if (selectedDiscount.Contains("Senior Citizen 20%") || selectedDiscount.Contains("Person With Disability 20%") ||
                             selectedDiscount.Contains("National Athletes and Coaches 20%"))
                    {
                        discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.20m, qty);
                        if (!selectedDiscount.Contains("National Athletes and Coaches 20%"))
                        {
                            row.Cells["vatAmount"].Value = 0.00m;
                            row.Cells["vatExempt"].Value = 0.12m * ((price * qty) / 1.12m);
                        }
                    }

                    // Update row with discount
                    row.Cells["discountAmount"].Value = discountAmount;
                    row.Cells["subTotal"].Value = originalSubTotal - discountAmount;
                }
            }
        }

        private void RecalculateValues(string selectedDiscountType, DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;

            decimal price = Convert.ToDecimal(selectedRow.Cells["unit_price"].Value);
            decimal qty = Convert.ToDecimal(selectedRow.Cells["appliedQty"].Value);
            decimal originalSubTotal = price * qty;

            if (selectedDiscountType == "None")
            {
                // Restore original values
                selectedRow.Cells["DiscountType"].Value = "None";
                selectedRow.Cells["discountAmount"].Value = 0m;
                selectedRow.Cells["subTotal"].Value = originalSubTotal;
                selectedRow.Cells["vatAmount"].Value = 0.12m * (originalSubTotal / 1.12m);
                selectedRow.Cells["vatExempt"].Value = 0.00m;
            }
            else
            {
                // Apply selected discount
                selectedRow.Cells["DiscountType"].Value = selectedDiscountType;
                decimal discountAmount = 0m;

                if (selectedDiscountType.Contains("Senior Citizen 5%") || selectedDiscountType.Contains("Person With Disability 5%"))
                {
                    discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.05m, qty);
                    selectedRow.Cells["vatAmount"].Value = 0.00m;
                    selectedRow.Cells["vatExempt"].Value = 0.12m * ((price * qty) / 1.12m);
                }
                else if (selectedDiscountType.Contains("Senior Citizen 20%") || selectedDiscountType.Contains("Person With Disability 20%") ||
                         selectedDiscountType.Contains("National Athletes and Coaches 20%"))
                {
                    discountAmount = SalesInvoiceFunctions.getSCDiscount(price, 0.20m, qty);

                    // For 20% SC/PWD, exempt from VAT (except athletes)
                    if (!selectedDiscountType.Contains("National Athletes and Coaches 20%"))
                    {
                        selectedRow.Cells["vatAmount"].Value = 0.00m;
                        selectedRow.Cells["vatExempt"].Value = 0.12m * ((price * qty) / 1.12m);
                    }
                }

                // Update row with discount
                selectedRow.Cells["discountAmount"].Value = discountAmount;
                selectedRow.Cells["subTotal"].Value = originalSubTotal - discountAmount;
            }
        }

        public void setDiscounts()
        {

        }

        private void btnClearCash_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
        }

        private bool validateTransaction()
        {
            if (dtgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isSufficient())
            {
                return false;
            }
            return true;
        }
        private bool isSufficient()
        {
            if (txtCash.Text.Trim() != "")
            {
                double cash = Convert.ToDouble(txtCash.Text.Trim());
                double total = Convert.ToDouble(lblTotal.Text);
                if (cash < total)
                {
                    MessageBox.Show("Insufficient Cash Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please choose Cash Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
