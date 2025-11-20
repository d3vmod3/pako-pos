using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace PAKOPointOfSale.Transactions
{
    public partial class TransactionsList : Form
    {
        private DataTable transactionsTable;
        public TransactionsList()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void TransactionsList_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void LoadTransactions()
        {
            try
            {
                string connString = Program.ConnString; // reuse your global connection string

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            t.id,
                            RIGHT(REPLICATE('0', 10) + CAST(t.id AS VARCHAR(20)), 20) AS TransactionID,
                            t.invoice_number,
                            t.sub_total,
                            t.vat_amount,
                            t.vatable_sales,
                            t.vat_exempt,
                            t.grand_total,
                            t.payment_method,
                            t.cash_received,
                            t.cash_change,
                            t.status,
                            t.transaction_type,
                            t.created_at,
                            v.void_number,
                            r.return_number
                        FROM Transactions t
                        LEFT JOIN VoidTransactions v ON t.id = v.transaction_id
                        LEFT JOIN ReturnTransactions r ON t.id = r.transaction_id
                        WHERE t.invoice_number IS NOT NULL
                        ORDER BY t.created_at DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        transactionsTable = new DataTable();
                        adapter.Fill(transactionsTable);
                        dtgvTransactions.DataSource = transactionsTable;
                    }
                }
                cmbTransactionType.SelectedIndex = 0;
                DataGridViewButtonColumn c = (DataGridViewButtonColumn)dtgvTransactions.Columns["viewInvoice"];
                c.FlatStyle = FlatStyle.Flat;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.DefaultCellStyle.BackColor = Color.LightBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        private void dtgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int id = Convert.ToInt32(dtgvTransactions.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dtgvTransactions.Columns["viewInvoice"].Index)
            {
                Transactions.lbViewTransaction viewTransactionForm = new Transactions.lbViewTransaction(id);
                viewTransactionForm.ShowDialog(); // modal so user finishes editing first
                LoadTransactions();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (transactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dtgvTransactions.DataSource = transactionsTable;
            }
            else
            {
                // Filter by multiple columns (product name, code, SKU, brand)
                string rowFilter = $"invoice_number LIKE '%{filter}%' ";
                DataView dv = new DataView(transactionsTable);
                dv.RowFilter = rowFilter;
                dtgvTransactions.DataSource = dv;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (transactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dtgvTransactions.DataSource = transactionsTable;
            }
            else
            {
                // Filter by multiple columns (product name, code, SKU, brand)
                string rowFilter = $"invoice_number LIKE '%{filter}%' ";
                DataView dv = new DataView(transactionsTable);
                dv.RowFilter = rowFilter;
                dtgvTransactions.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transactionsTable == null)
                return;

            string selectedType = cmbTransactionType.SelectedItem?.ToString() ?? "All";
            DateTime startDate = dtpFrom.Value.Date;
            DateTime endDate = dtpTo.Value.Date.AddDays(1); // exclusive end date

            DataView dv = new DataView(transactionsTable);
            List<string> filters = new List<string>();

            if (selectedType != "All")
                filters.Add($"transaction_type = '{selectedType}'");

            filters.Add($"created_at >= #{startDate:MM/dd/yyyy}# AND created_at < #{endDate:MM/dd/yyyy}#");

            dv.RowFilter = string.Join(" AND ", filters);
            dtgvTransactions.DataSource = dv;

            // --- Dynamic column visibility ---
            if (dtgvTransactions.Columns.Contains("return_number") && dtgvTransactions.Columns.Contains("void_number"))
            {
                if (selectedType == "Void")
                {
                    dtgvTransactions.Columns["void_number"].Visible = true;
                    dtgvTransactions.Columns["return_number"].Visible = false;
                }
                else if (selectedType == "Return")
                {
                    dtgvTransactions.Columns["return_number"].Visible = true;
                    dtgvTransactions.Columns["void_number"].Visible = false;
                }
                else
                {
                    dtgvTransactions.Columns["return_number"].Visible = false;
                    dtgvTransactions.Columns["void_number"].Visible = false;
                }
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnClearFilter_Click_1(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgvTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = "Transactions.csv"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csvContent = new StringBuilder();

                        // Only visible columns with headers
                        var visibleColumns = dtgvTransactions.Columns
                            .Cast<DataGridViewColumn>()
                            .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText))
                            .ToList();

                        // Header row
                        csvContent.AppendLine(string.Join(",", visibleColumns.Select(c => "\"" + c.HeaderText + "\"")));

                        // Data rows
                        foreach (DataGridViewRow row in dtgvTransactions.Rows)
                        {
                            if (row.IsNewRow) continue;

                            var values = visibleColumns.Select(c =>
                            {
                                object cellValue = row.Cells[c.Index].Value;

                                // Treat invoice_number, void_number, return_number as string (preserve leading zeros)
                                if (c.Name == "invoice_number" || c.Name == "void_number" || c.Name == "return_number")
                                {
                                    //return "'" + (cellValue?.ToString() ?? "");
                                    //return "=\"" + cellValue + "\"";
                                    cellValue = "=\"" + cellValue + "\"";
                                    return cellValue;
                                }

                                // Format numeric columns as decimal with 2 decimal places
                                else if (c.Name == "sub_total" || c.Name == "cash_received" || c.Name == "cash_change")
                                {
                                    if (decimal.TryParse(cellValue?.ToString(), out decimal decVal))
                                        return decVal.ToString("F2"); // e.g., 123.45
                                    else
                                        return "0.00";
                                }

                                // All other columns: escape quotes
                                else
                                {
                                    return "\"" + (cellValue?.ToString().Replace("\"", "\"\"") ?? "") + "\"";
                                }
                            });

                            csvContent.AppendLine(string.Join(",", values));
                        }

                        File.WriteAllText(sfd.FileName, csvContent.ToString(), Encoding.UTF8);

                        if (MessageBox.Show("Export successful! Do you want to open the file?", "Export Complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message);
            }
        }

        private void TransactionsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
