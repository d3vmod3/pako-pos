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

namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    public partial class ParkTransactionsList : Form
    {
        private DataTable parkedTransactionsTable;
        public int TransactionId { get; private set; }
        public string ParkNumber { get; private set; }
        public ParkTransactionsList()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }
        private void LoadParkedTransactions()
        {
            try
            {
                string connString = Program.ConnString; // reuse your global connection string

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            id,
                            RIGHT(REPLICATE('0', 10) + CAST(id AS VARCHAR(20)), 20) AS TransactionID,
                            invoice_number,
                            sub_total,
                            vat_amount,
                            vatable_sales,
                            vat_exempt,
                            grand_total,
                            payment_method,
                            cash_received,
                            cash_change,
                            status,
                            park_number,
                            transaction_type,
                            remarks,
                            status,
                            created_at
                        FROM Transactions
                        WHERE invoice_number is NULL
                        AND park_number IS NOT NULL
                        AND status='pending'
                        ORDER BY created_at DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        parkedTransactionsTable = new DataTable();
                        adapter.Fill(parkedTransactionsTable);
                        dtgvParkedTransactions.DataSource = parkedTransactionsTable;
                    }
                }
                DataGridViewButtonColumn c = (DataGridViewButtonColumn)dtgvParkedTransactions.Columns["settle"];
                c.FlatStyle = FlatStyle.Flat;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.DefaultCellStyle.BackColor = Color.LightBlue;

                dtgvParkedTransactions.Columns["sub_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DataGridViewButtonColumn d = (DataGridViewButtonColumn)dtgvParkedTransactions.Columns["cancel"];
                d.FlatStyle = FlatStyle.Flat;
                d.DefaultCellStyle.ForeColor = Color.White;
                d.DefaultCellStyle.BackColor = Color.Coral;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        private void ParkTransactionsList_Load_1(object sender, EventArgs e)
        {
            LoadParkedTransactions();
        }

        private void dtgvParkedTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Get the ID of the selected transaction
            int transactionId = Convert.ToInt32(dtgvParkedTransactions.Rows[e.RowIndex].Cells["id"].Value);
            string park_number = dtgvParkedTransactions.Rows[e.RowIndex].Cells["park_number"].Value.ToString();

            if (e.ColumnIndex == dtgvParkedTransactions.Columns["settle"].Index)
            {
                var status = dtgvParkedTransactions.Rows[e.RowIndex].Cells["status"].Value?.ToString();
                if (!string.Equals(status, "pending", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Only pending transactions can be settled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                TransactionId = transactionId;
                ParkNumber = park_number;
                ActivityLogs.Log(
                    user: LoggedInUser.FullName,
                    action: "click",
                    module: "Pending Transactions List",
                    description: "Clicked Settle button",
                    payload: new
                    {
                        pending_number = ParkNumber,
                    }
                );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.ColumnIndex == dtgvParkedTransactions.Columns["cancel"].Index)
            {
                var status = dtgvParkedTransactions.Rows[e.RowIndex].Cells["status"].Value?.ToString();
                if (!string.Equals(status, "pending", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Only pending transactions can be cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel this pending transaction?",
                    "Confirm Cancel",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    TransactionId = transactionId;
                    ParkNumber = park_number;

                    string connString = Program.ConnString;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();

                        string updateParkedTransaction = @"
                            UPDATE Transactions
                            SET status = 'cancelled'
                            WHERE id = @transactionId
                              AND park_number = @parkNumber";

                        using (SqlCommand cmdUpdate = new SqlCommand(updateParkedTransaction, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@transactionId", TransactionId);
                            cmdUpdate.Parameters.AddWithValue("@parkNumber", ParkNumber);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }

                    ActivityLogs.Log(
                        user: LoggedInUser.FullName,
                        action: "click",
                        module: "Pending Transactions List",
                        description: "Clicked Cancel button",
                        payload: new
                        {
                            pending_number = ParkNumber,
                        }
                    );

                    MessageBox.Show("Pending transaction has been cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadParkedTransactions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (parkedTransactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dtgvParkedTransactions.DataSource = parkedTransactionsTable;
            }
            else
            {
                string rowFilter = $@"
                park_number LIKE '%{filter}%' OR 
                remarks LIKE '%{filter}%'
                ";

                DataView dv = new DataView(parkedTransactionsTable);
                dv.RowFilter = rowFilter;
                dtgvParkedTransactions.DataSource = dv;
            }
        }

        private void dtgvParkedTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Pending Transactions List",
                description: "Clicked Close button",
                payload: null
            );
            this.Close();
        }

        private void ParkTransactionsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgvParkedTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                ActivityLogs.Log(
                    user: LoggedInUser.FullName,
                    action: "click",
                    module: "Pending Transactions",
                    description: "Clicked Export button",
                    payload: new
                    {
                        status = "failed",
                        message = "No data to export."
                    }
                );
                return;
            }

            try
            {
                // Ask where to save the CSV
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = $"Pending_Transactions_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csvContent = new StringBuilder();

                        // Include only visible columns
                        var visibleColumns = dtgvParkedTransactions.Columns
                            .Cast<DataGridViewColumn>()
                            .Where(c => c.Visible && !string.Equals(c.HeaderText, "", StringComparison.OrdinalIgnoreCase))
                            .ToList();

                        // Write header row
                        csvContent.AppendLine(string.Join(",", visibleColumns.Select(c => "\"" + c.HeaderText + "\"")));

                        // Write data rows
                        foreach (DataGridViewRow row in dtgvParkedTransactions.Rows)
                        {
                            if (row.IsNewRow) continue; // skip the new row placeholder

                            var values = visibleColumns.Select(c =>
                            {
                                var cellValue = row.Cells[c.Index].Value?.ToString() ?? "";
                                if (
                                        c.Name == "park_number" ||
                                        c.Name == "created_at"
                                    )
                                {
                                    //return "'" + (cellValue?.ToString() ?? "");
                                    //return "=\"" + cellValue + "\"";
                                    cellValue = "=\"" + cellValue + "\"";
                                    return cellValue;
                                }
                                // Escape double quotes for CSV
                                return "\"" + cellValue.Replace("\"", "\"\"") + "\"";
                            });

                            csvContent.AppendLine(string.Join(",", values));
                        }

                        // Save the CSV file
                        File.WriteAllText(sfd.FileName, csvContent.ToString(), Encoding.UTF8);
                        ActivityLogs.Log(
                            user: LoggedInUser.FullName,
                            action: "click",
                            module: "Pending Transactions",
                            description: "Saved CSV File",
                            payload: new
                            {
                                file = sfd.FileName
                            }
                        );
                        // Ask to open it
                        var result = MessageBox.Show("Export successful! Do you want to open the file?", "Export Complete", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                    else
                    {
                        ActivityLogs.Log(
                            user: LoggedInUser.FullName,
                            action: "click",
                            module: "Pending Transactions",
                            description: "Clicked Cancel",
                            payload: new
                            {
                                file = sfd.FileName
                            }
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message);
            }
        }
    }
}
