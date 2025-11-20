using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Categories
{

    public partial class CategoriesList : Form
    {
        private DataTable categoriesTable;
        public CategoriesList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            loadCategories();
            this.KeyPreview = true;
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            loadCategories();
            loadPermissions();
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns["editCategory"];
            c.FlatStyle = FlatStyle.Flat;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.LightBlue;

            DataGridViewButtonColumn d = (DataGridViewButtonColumn)dataGridView1.Columns["deleteCategory"];
            d.FlatStyle = FlatStyle.Flat;
            d.DefaultCellStyle.ForeColor = Color.White;
            d.DefaultCellStyle.BackColor = Color.Coral;
        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("Categories", "add"))
            {
                btnAdd.Visible = false;
            }
            if (!LoggedInUser.HasPermission("Categories", "edit"))
            {
                if (dataGridView1.Columns.Contains("editCategory"))
                {
                    dataGridView1.Columns["editCategory"].Visible = false;
                }
            }

        }
        private void loadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    // Select all users (adjust columns as needed)
                    string query = @"SELECT id,name,description FROM categories";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        categoriesTable = new DataTable();
                        da.Fill(categoriesTable);

                        dataGridView1.DataSource = categoriesTable; // Bind DataTable to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int categoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            string categoryName = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();

            if (e.ColumnIndex == dataGridView1.Columns["editCategory"].Index)
            {
                EditCategory editCategoryForm = new EditCategory(categoryId);
                editCategoryForm.ShowDialog(); // modal so user finishes editing first
                loadCategories();

            }
            if (e.ColumnIndex == dataGridView1.Columns["deleteCategory"].Index)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {categoryName}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connString = PAKOPointOfSale.Program.ConnString;
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            conn.Open();

                            string query = @"
                                    DELETE 
                                    FROM Categories
                                    WHERE 
                                        id LIKE @id
                                    ";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("id", categoryId);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        loadCategories();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error searching users: " + ex.Message);
                    }
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (categoriesTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = categoriesTable;
            }
            else
            {
                // Filter by name, contact_number, or address
                string rowFilter = $"name LIKE '%{filter}%'";
                DataView dv = new DataView(categoriesTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message);
            }
        }

        private void CategoriesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
