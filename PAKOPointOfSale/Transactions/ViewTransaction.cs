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
    public partial class ViewTransaction : Form
    {
        private int _id;
        private string _invoiceNumber;
        private int countAlreadyReturneditems = 0;
        public ViewTransaction(int id)
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
                            lblTransactionId.Text = reader["id"].ToString();
                            lblInvoiceNumber.Text = reader["invoice_number"].ToString();
                            lblSubTotal.Text = Convert.ToDecimal(reader["sub_total"]).ToString("N2");
                            lblGrandTotal.Text = Convert.ToDecimal(reader["grand_total"]).ToString("N2");
                            lblVatAmount.Text = Convert.ToDecimal(reader["vat_amount"]).ToString("N2");
                            lblPaymentMethod.Text = reader["payment_method"].ToString();
                            lblCashReceived.Text = Convert.ToDecimal(reader["cash_received"]).ToString("N2");
                            lblTransactionType.Text = reader["transaction_type"].ToString();
                            lblChange.Text = Convert.ToDecimal(reader["cash_change"]).ToString("N2");
                            lblTransactionDate.Text = Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm");
                        }
                    }
                }

                // Load transaction items
                using (var cmdItems = new SqlCommand(@"
                SELECT si.id,
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

                // Disable checkbox for already returned items
                if (dgvItems.Columns.Contains("select"))
                {
                    HashSet<int> returnedProductIds = new HashSet<int>();
                    using (var cmd = new SqlCommand(@"
                SELECT si.product_id
                FROM SalesInvoiceItems si
                INNER JOIN ReturnTransactions rt ON si.transaction_id = rt.transaction_id
                WHERE rt.invoice_number = @invoiceNumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@invoiceNumber", lblInvoiceNumber.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                returnedProductIds.Add(Convert.ToInt32(reader["product_id"]));
                            }
                        }
                    }

                    
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                        if (returnedProductIds.Contains(productId))
                        {
                            countAlreadyReturneditems += 1;
                            row.Cells["select"].ReadOnly = true;
                            row.Cells["select"].Style.BackColor = Color.DarkGray;
                            row.Cells["select"].Value = false;
                           
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
                                lblAdjustmentNumber.Text = "Void Series No.: " + reader["void_number"].ToString();
                                cmbInvoiceAction.SelectedItem = "Void";
                                cmbInvoiceAction.Enabled = false;
                                btnProceed.Enabled = false;
                            }
                            else
                            {
                                lblAdjustmentNumber.Visible = false;
                                cmbInvoiceAction.SelectedItem = "";
                                cmbInvoiceAction.Enabled = true;
                                btnProceed.Enabled = true;
                            }
                        }
                    }
                }
                else if (transactionType == "Return" || transactionType == "Sales Invoice")
                {
                    using (var cmdReturn = new SqlCommand("SELECT * FROM ReturnTransactions WHERE invoice_number = @invoiceNumber", conn))
                    {
                        cmdReturn.Parameters.AddWithValue("@invoiceNumber", lblInvoiceNumber.Text);
                        lblAdjustmentNumber.Text = "";
                        using (var reader = cmdReturn.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblAdjustmentNumber.Text = "Return Series No.: " + reader["return_number"].ToString();
                                cmbInvoiceAction.SelectedItem = "Return";
                                cmbInvoiceAction.Enabled = false;
                                btnProceed.Enabled = false;
                            }
                            else
                            {
                                lblAdjustmentNumber.Visible = false;
                                cmbInvoiceAction.SelectedItem = "";
                                cmbInvoiceAction.Enabled = true;
                                btnProceed.Enabled = true;
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
                    voidSalesInvoiceForm.ShowDialog();
                }
                    
            }
            else if (cmbInvoiceAction.SelectedItem?.ToString() == "Return")
            {
                var selectedItems = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    bool isSelected = row.Cells["select"].Value?.ToString() == "1";
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
                    returnItemsForm.ShowDialog();
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
                dgvItems.Columns["select"].Visible = true;
                if (countAlreadyReturneditems > 0)
                {
                    lblReturnNote.Visible = true;
                }
            }
            else
            {
                dgvItems.Columns["select"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTransactionType.Text == "Void")
            {
                //view void receipt

            }
            if (lblTransactionType.Text == "Return")
            {
                //view return receipt

            }
            if (lblTransactionType.Text == "Sales Invoice")
            {
                //view Sales Invoice receipt

            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
