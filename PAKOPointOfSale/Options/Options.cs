using Microsoft.Data.SqlClient;
using ScottPlot.AxisLimitManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Options
{
    public partial class Options : Form
    {
        public string SelectedOption;
        private DataTable activityLogsTable;
        public Options()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (SelectedOption != "")
            {
                switch (SelectedOption)
                {
                    case "Activity Logs":
                        grpBoxActivityLogs.Visible = true;
                        grpBoxBackupDatabase.Visible = false;
                        loadActivityLogs();
                        break;
                    case "Backup Database":
                        grpBoxActivityLogs.Visible = false;
                        grpBoxBackupDatabase.Visible = true;
                        loadBackupDatabaseLocation();
                        break;
                    default:
                        MessageBox.Show("Invalid option selected.");
                        break;
                }
            }

        }

        private void loadActivityLogs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();
                    DateTime startDate = dtpFrom.Value.Date;
                    DateTime endDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                    // Select all users (adjust columns as needed)
                    string query = @"SELECT [timestamp]
                                      ,[user]
                                      ,[module]
                                      ,[action]
                                      ,[description]
                                      ,[payload]
                                  FROM [db_pos].[dbo].[ActivityLogs]
                                    Where timestamp BETWEEN @startDate AND @endDate";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                        da.SelectCommand.Parameters.AddWithValue("@endDate", endDate);

                        activityLogsTable = new DataTable();
                        da.Fill(activityLogsTable);

                        dgvActivityLogs.DataSource = activityLogsTable; // Bind DataTable to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void loadBackupDatabaseLocation()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT [key],value FROM options where [key]='backup_database_location'";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDbaseLocation.Text = reader["value"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Option key not found.");
                                this.Close();
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message);
            }
        }

        private void lstOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOptions.Items.Count != 0)
            {
                switch (lstOptions.SelectedItem)
                {
                    case "Activity Logs":
                        grpBoxActivityLogs.Visible = true;
                        grpBoxBackupDatabase.Visible = false;
                        break;
                    case "Backup Database":
                        grpBoxActivityLogs.Visible = false;
                        grpBoxBackupDatabase.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Invalid option selected.");
                        break;
                }
            }
        }

        private void btnSaveDbaseBackupLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                if (!Path.Exists(txtDbaseLocation.Text))
                {
                    MessageBox.Show("Path not found. Please choose a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"UPDATE options SET value=@value WHERE [key]='backup_database_location'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", txtDbaseLocation.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Backup database location updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error updating backup database location.");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving backup database location: " + ex.Message);
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDbaseBackupLocation.ShowDialog();
            txtDbaseLocation.Text = folderBrowserDialogDbaseBackupLocation.SelectedPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase.backup();
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Options > Backup database",
                description: "Backup Database",
                payload: new
                {
                    file = BackupDatabase._backupFile
                }
            );
        }

        private void grpBoxActivityLogs_Enter(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityLogs.Log(
                    user: LoggedInUser.FullName,
                    action: "click",
                    module: "Activity Logs",
                    description: "Clicked Export button",
                    payload: null
                );
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv", FileName = "Suppliers.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        StringBuilder csv = new StringBuilder();

                        // Add header row (only visible columns with non-empty header)
                        var headers = dgvActivityLogs.Columns.Cast<DataGridViewColumn>()
                                          .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText));
                        csv.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

                        // Add rows (matching the same visible columns)
                        foreach (DataGridViewRow row in dgvActivityLogs.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = headers.Select(c => "\"" + row.Cells[c.Index].Value?.ToString().Replace("\"", "\"\"") + "\"");
                                csv.AppendLine(string.Join(",", cells));
                            }
                        }

                        // Write to file
                        File.WriteAllText(sfd.FileName, csv.ToString(), Encoding.UTF8);

                        ActivityLogs.Log(
                            user: LoggedInUser.FullName,
                            action: "click",
                            module: "Activity Logs",
                            description: "Saved CSV File",
                            payload: new
                            {
                                file = sfd.FileName
                            }
                        );
                        // Ask user if they want to open the file
                        var result = MessageBox.Show("CSV exported successfully!\nDo you want to open it now?", "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                            module: "Activity Logs",
                            description: "Clicked Cancel button",
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
                MessageBox.Show("Error exporting CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Activity Logs",
                description: "Clicked Export button",
                payload: new
                {
                    date_from = dtpFrom.Value.ToString(),
                    date_to = dtpTo.Value.ToString()
                }
            );
        }
    }
}
