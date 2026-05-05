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
using System;
using System.Windows.Forms;

namespace PAKOPointOfSale.Users
{
    public partial class UsersList : Form
    {
        private DataTable usersTable;
        public UsersList()
        {
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadPermissions();
            this.KeyPreview = true;

        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("Users", "add"))
            {
                btnAdd.Visible = false;
            }
            if (!LoggedInUser.HasPermission("Users", "edit"))
            {
                if (dataGridView1.Columns.Contains("edit"))
                {
                    dataGridView1.Columns["edit"].Visible = false;
                }
            }

        }
        private void loadUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    // Select all users (adjust columns as needed)
                    string query = @"
                        SELECT 
                            u.id, 
                            u.username, 
                            u.first_name, 
                            u.middle_name, 
                            u.last_name, 
                            u.gender,
                            u.birthday,
                            u.suffix,
                            u.is_active,
                            u.created_at,
                            ut.name AS user_type
                        FROM Users u
                        INNER JOIN UserTypes ut ON u.user_type_id = ut.id
                    ";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        usersTable = new DataTable();
                        da.Fill(usersTable);

                        dataGridView1.DataSource = usersTable; // Bind DataTable to DataGridView
                    }
                }
                DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns["edit"];
                c.FlatStyle = FlatStyle.Flat;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.DefaultCellStyle.BackColor = Color.LightBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                EditUser editUserForm = new EditUser(userId);
                editUserForm.ShowDialog(); // modal so user finishes editing first
                loadUsers();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();

            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Users List",
                description: "Clicked Add button",
                payload: null
            );

            adduser.ShowDialog();
            loadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (usersTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = usersTable;
            }
            else
            {
                string rowFilter = $@"
            username LIKE '%{filter}%' OR 
            first_name LIKE '%{filter}%' OR 
            last_name LIKE '%{filter}%' OR
            middle_name LIKE '%{filter}%'
                ";

                DataView dv = new DataView(usersTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Users List",
                description: "Clicked Close button",
                payload: null
            );
            this.Close();
        }

        private void UsersList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                ActivityLogs.Log(
                    user: LoggedInUser.FullName,
                    action: "click",
                    module: "Categories List",
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
                    FileName = "Categories.csv"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csvContent = new StringBuilder();

                        // Include only visible columns
                        var visibleColumns = dataGridView1.Columns
                            .Cast<DataGridViewColumn>()
                            .Where(c => c.Visible && !string.Equals(c.HeaderText, "", StringComparison.OrdinalIgnoreCase))
                            .ToList();

                        // Write header row
                        csvContent.AppendLine(string.Join(",", visibleColumns.Select(c => "\"" + c.HeaderText + "\"")));

                        // Write data rows
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue; // skip the new row placeholder

                            var values = visibleColumns.Select(c =>
                            {
                                var cellValue = row.Cells[c.Index].Value?.ToString() ?? "";
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
                            module: "Users List",
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
                            module: "Users List",
                            description: "Clicked Cancelled",
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
