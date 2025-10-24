using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions
{
    public partial class lbViewTransaction : Form
    {
        private int _id;
        private string _invoiceNumber;
        private int countAlreadyReturneditems = 0;
        private string adjustment_number = "";
        public lbViewTransaction(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void ViewTransaction_Load(object sender, EventArgs e)
        {
            LoadTransactionDetails();
            validateData();
        }
        private void LoadTransactionDetails()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                // Load transaction header
                using (var cmdHeader = new SqlCommand(@"
            SELECT id, invoice_number, sub_total, grand_total, vat_amount, vatable_sales, 
                   vat_exempt, payment_method, cash_received, cash_change, status, transaction_type, created_at
            FROM Transactions
            WHERE id = @id", conn))
                {
                    cmdHeader.Parameters.AddWithValue("@id", _id);
                    using (var reader = cmdHeader.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _invoiceNumber = reader["invoice_number"].ToString();
                            int transactionId = Convert.ToInt32(reader["id"]);
                            lblTransactionId.Text = transactionId.ToString().PadLeft(6, '0');
                            lblInvoiceNumber.Text = reader["invoice_number"].ToString();
                            lblSubTotal.Text = Convert.ToDecimal(reader["sub_total"]).ToString("N2");
                            lblGrandTotal.Text = Convert.ToDecimal(reader["grand_total"]).ToString("N2");
                            lblVatableSales.Text = Convert.ToDecimal(reader["vat_amount"]).ToString("N2");
                            lblVatAmount.Text = Convert.ToDecimal(reader["vat_amount"]).ToString("N2");
                            lblVatExempt.Text = Convert.ToDecimal(reader["vat_exempt"]).ToString("N2");
                            lblPaymentMethod.Text = reader["payment_method"].ToString();
                            lblCashReceived.Text = Convert.ToDecimal(reader["cash_received"]).ToString("N2");
                            lblTransactionType.Text = reader["transaction_type"].ToString();
                            lblChange.Text = Convert.ToDecimal(reader["cash_change"]).ToString("N2");
                            lblTransactionDate.Text = Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm");
                        }
                    }
                }
                string query = queryString(lblTransactionType.Text);
                // Load transaction items
                using (var cmdItems = new SqlCommand(query, conn))
                {
                    cmdItems.Parameters.AddWithValue("@invoiceNumber", _invoiceNumber);
                    cmdItems.Parameters.AddWithValue("@transactionId", _id);


                    DataTable dtItems = new DataTable();
                    using (var adapter = new SqlDataAdapter(cmdItems))
                    {
                        adapter.Fill(dtItems);
                    }

                    dgvItems.DataSource = dtItems;
                }

                // Disable checkbox for already returned items
                if (dgvItems.Columns.Contains("selectReturn"))
                {
                    HashSet<int> returnedProductIds = new HashSet<int>();
                    Dictionary<int, int> returnedQuantities = new Dictionary<int, int>(); // store product_id + returned quantity

                    using (var cmd = new SqlCommand(@"
                        SELECT si.product_id, si.quantity
                        FROM ReturnItems si
                        INNER JOIN ReturnTransactions rt ON si.return_transaction_id = rt.id
                        WHERE rt.invoice_number = @invoiceNumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@invoiceNumber", lblInvoiceNumber.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productId = Convert.ToInt32(reader["product_id"]);
                                int quantityReturned = Convert.ToInt32(reader["quantity"]);

                                // Add to dictionary (in case multiple returns exist for same product)
                                if (returnedQuantities.ContainsKey(productId))
                                    returnedQuantities[productId] += quantityReturned;
                                else
                                    returnedQuantities[productId] = quantityReturned;

                                returnedProductIds.Add(productId);
                            }
                        }
                    }

                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                        int originalQty = Convert.ToInt32(row.Cells["quantity"].Value);

                        if (returnedQuantities.TryGetValue(productId, out int returnedQty))
                        {
                            int remainingQty = Math.Max(originalQty - returnedQty, 0);
                            row.Cells["remainingQty"].Value = remainingQty; // ✅ update DataGridView
                            row.Cells["quantity"].Value = originalQty; // ✅ update DataGridView

                            // mark as returned if no quantity remains
                            if (remainingQty == 0)
                            {
                                countAlreadyReturneditems += 1;
                                row.Cells["selectReturn"].ReadOnly = true;
                                row.Cells["selectReturn"].Style.BackColor = Color.DarkGray;
                                row.Cells["selectReturn"].Value = false;
                            }
                        }
                    }
                }


                // Load void or return series number
                string transactionType = lblTransactionType.Text;

                if (transactionType == "Void" || transactionType == "Sales Invoice")
                {
                    
                    using (var cmdVoid = new SqlCommand("SELECT void_number, invoice_number, transaction_id FROM VoidTransactions WHERE invoice_number = @invoiceNumber", conn))
                    {
                        cmdVoid.Parameters.AddWithValue("@invoiceNumber", lblInvoiceNumber.Text);
                        lblAdjustmentNumber.Text = "";
                        using (var reader = cmdVoid.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblVoidOrReturn.Visible = true;
                                lblAdjustmentNumber.Visible = true;
                                lblVoidOrReturn.Text = "Void No.: ";
                                lblAdjustmentNumber.Text = reader["void_number"].ToString();
                                adjustment_number = reader["void_number"].ToString();
                                cmbInvoiceAction.SelectedItem = "Void";
                                cmbInvoiceAction.Enabled = false;
                                btnProceed.Enabled = false;
                                dgvItems.ReadOnly = true;
                                btnViewReason.Visible = true;
                            }
                            else
                            {
                                lblVoidOrReturn.Visible = false;
                                lblAdjustmentNumber.Visible = false;
                                cmbInvoiceAction.SelectedItem = "";
                                cmbInvoiceAction.Enabled = true;
                                btnProceed.Enabled = true;
                                dgvItems.ReadOnly = false;
                                btnViewReason.Visible = false;
                            }
                        }
                    }
                }
                else if (transactionType == "Return" || transactionType == "Sales Invoice")
                {
                    
                    using (var cmdReturn = new SqlCommand("SELECT TOP 1 * FROM ReturnTransactions WHERE invoice_number = @invoiceNumber and transaction_id=@transactionId  ORDER BY id DESC", conn))
                    {
                        cmdReturn.Parameters.AddWithValue("@invoiceNumber", lblInvoiceNumber.Text);
                        cmdReturn.Parameters.AddWithValue("@transactionId", lblTransactionId.Text);
                        lblAdjustmentNumber.Text = "";

                        using (var reader = cmdReturn.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ✅ check if all rows are gray before running this block
                                bool allGray = true;
                                foreach (DataGridViewRow row in dgvItems.Rows)
                                {
                                    if (row.IsNewRow) continue;

                                    var cellColor = row.Cells["selectReturn"].Style.BackColor;
                                    if (cellColor != Color.DarkGray)
                                    {
                                        allGray = false;
                                        break;
                                    }
                                }

                                if (allGray)
                                {
                                    lblVoidOrReturn.Visible = true;
                                    lblAdjustmentNumber.Visible = true;
                                    lblVoidOrReturn.Text = "Return No.: ";
                                    lblAdjustmentNumber.Text = reader["return_number"].ToString();
                                    btnViewReason.Visible = true;
                                    adjustment_number = reader["return_number"].ToString();
                                    cmbInvoiceAction.SelectedItem = "Return";
                                    //cmbInvoiceAction.Enabled = false;
                                    btnProceed.Enabled = false;
                                    dgvItems.ReadOnly = true;
                                }
                                else
                                {
                                    lblVoidOrReturn.Visible = true;
                                    btnViewReason.Visible = true;
                                    lblAdjustmentNumber.Visible = true;
                                    lblVoidOrReturn.Text = "Return No.: ";
                                    lblAdjustmentNumber.Text = reader["return_number"].ToString();
                                    adjustment_number = reader["return_number"].ToString();
                                    cmbInvoiceAction.SelectedItem = "Return";
                                    //cmbInvoiceAction.Enabled = false;
                                    btnProceed.Enabled = false;
                                    dgvItems.ReadOnly = true;



                                }
                            }
                            else
                            {
                                lblVoidOrReturn.Visible = false;
                                lblAdjustmentNumber.Visible = false;
                                cmbInvoiceAction.SelectedItem = "";
                                cmbInvoiceAction.Enabled = true;
                                btnProceed.Enabled = true;
                                btnViewReason.Visible = false;
                            }
                        }
                    }
                }
            }
        }


        private void validateData()
        {
            if (lblTransactionType.Text == "Void")
            {
                cmbInvoiceAction.SelectedItem = "Void";
                cmbInvoiceAction.Enabled = false;
                btnProceed.Enabled = false;

            }
            if (lblTransactionType.Text == "Return")
            {
                cmbInvoiceAction.SelectedItem = "Return";
                cmbInvoiceAction.Enabled = false;
                btnProceed.Enabled = false;
            }
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {

            if (cmbInvoiceAction.SelectedItem?.ToString() == "Void")
            {
                if (countAlreadyReturneditems > 0)
                {
                    //lblReturnNote.Visible = true;
                    MessageBox.Show("Sales invoices with returned items cannot be voided. Select all items and use 'Return' in the Invoice Action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Transactions.Void.VoidForm voidSalesInvoiceForm = new Transactions.Void.VoidForm(_id, _invoiceNumber);
                    if (voidSalesInvoiceForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            else if (cmbInvoiceAction.SelectedItem?.ToString() == "Return")
            {
                var selectedItems = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    bool isSelected = row.Cells["selectReturn"].Value?.ToString() == "1";
                    if (isSelected)
                    {
                        selectedItems.Add(row);
                    }
                }
                if (selectedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one item to return.", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Transactions.Return.ReturnForm returnItemsForm = new Transactions.Return.ReturnForm(_id, _invoiceNumber, selectedItems);

                    if(returnItemsForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose an action", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbInvoiceAction.Focus();
            }

        }


        private void cmbInvoiceAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAction = cmbInvoiceAction.SelectedItem?.ToString();

            if (selectedAction == "Return")
            {
                dgvItems.Columns["selectReturn"].Visible = true;
                dgvItems.Columns["remainingQty"].Visible = true;
                if (countAlreadyReturneditems > 0)
                {
                    lblReturnNote.Visible = true;
                }
                if(lblVoidOrReturn.Text == "Return No.: ")
                {
                    dgvItems.Columns["remainingQty"].Visible = false;
                    dgvItems.Columns["quantity"].HeaderText = "Returned Quantity";
                }
            }
            else
            {
                dgvItems.Columns["selectReturn"].Visible = false;
                dgvItems.Columns["remainingQty"].Visible = false;
            }
        }

        private string queryString(string transaction_type)
        {
            if (transaction_type == "Sales Invoice")
            {
                return @"
                SELECT 
                    si.id,
                    si.product_id,
                    p.product_code,
                    p.product_name,
                    p.product_brand,
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
                WHERE si.transaction_id = @transactionId
                ORDER BY si.id;";
            }
            else if (transaction_type == "Return")
            {
                return @"
                SELECT 
                    ri.id,
                    ri.product_id,
                    p.product_code,
                    p.product_name,
                    p.product_brand,
                    ri.quantity,
                    ri.unit_price,
                    ri.total_amount,
                    ri.vat_amount,
                    ri.vatable_sales,
                    ri.vat_exempt,
                    ri.discount,
                    ri.discount_type,
                    ri.unit_of_measurement,
                    rt.invoice_number,
                    rt.transaction_id AS original_transaction_id
                FROM ReturnItems ri
                INNER JOIN Products p ON ri.product_id = p.id
                INNER JOIN ReturnTransactions rt ON ri.return_transaction_id = rt.id
                WHERE rt.transaction_id = @transactionId
                ORDER BY ri.id;";
            }
            else if (transaction_type == "Void")
            {
                return @"
                SELECT 
                    vt.id,
                    vt.invoice_number,
                    vt.void_number,
                    vt.reason,
                    si.id AS item_id,
                    si.product_id,
                    p.product_code,
                    p.product_name,
                    p.product_brand,
                    si.quantity,
                    si.unit_price,
                    si.total_amount,
                    si.vat_amount,
                    si.vatable_sales,
                    si.vat_exempt,
                    si.discount,
                    si.discount_type,
                    si.unit_of_measurement
                FROM VoidTransactions vt
                INNER JOIN SalesInvoiceItems si ON vt.transaction_id = si.transaction_id
                INNER JOIN Products p ON si.product_id = p.id
                WHERE vt.transaction_id = @transactionId
                ORDER BY vt.id;";
            }

            throw new InvalidOperationException($"Unknown transaction type: {transaction_type}");
        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTransactionType.Text == "Void")
            {
                //view void receipt
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Void_{adjustment_number}.pdf");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });

            }
            if (lblTransactionType.Text == "Return")
            {
                //view return receipt
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Return_{adjustment_number}.pdf");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });

            }
            if (lblTransactionType.Text == "Sales Invoice")
            {
                //view Sales Invoice receipt
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Receipt_{lblInvoiceNumber.Text}.pdf");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });

            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblInvoiceNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAdjustmentNumber_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewReason_Click(object sender, EventArgs e)
        {
            Transactions.ViewAdjustmentReason viewReasonForm = new Transactions.ViewAdjustmentReason(Convert.ToInt32(lblTransactionId.Text),lblInvoiceNumber.Text,lblTransactionType.Text);
            viewReasonForm.ShowDialog();
            
        }
    }
}
