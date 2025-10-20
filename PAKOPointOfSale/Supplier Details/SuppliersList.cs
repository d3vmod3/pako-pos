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

namespace PAKOPointOfSale.Supplier_Details
{
    public partial class SuppliersList : Form
    {
        private DataTable suppliersTable;
        public SuppliersList()
        {
            InitializeComponent();
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            loadSuppliers();
            loadPermissions();


        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("Suppliers", "add"))
            {
                btnAdd.Visible = false;
            }
            if (!LoggedInUser.HasPermission("Suppliers", "edit"))
            {
                if (dataGridView1.Columns.Contains("edit"))
                {
                    dataGridView1.Columns["edit"].Visible = false;
                }
            }

        }

        public void loadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();


                    string query = @"SELECT id,name,address,contact_number,account_number,gateway,created_at,is_active FROM SupplierDetails";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        suppliersTable = new DataTable();
                        da.Fill(suppliersTable);

                        dataGridView1.DataSource = suppliersTable; // Bind DataTable to DataGridView
                    }
                }
                cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier_Details.AddSupplierDetails addSupplierForm = new Supplier_Details.AddSupplierDetails();
            addSupplierForm.ShowDialog();
            loadSuppliers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                Supplier_Details.EditSupplierDetails editSupplierForm = new Supplier_Details.EditSupplierDetails(supplierId);
                editSupplierForm.ShowDialog(); // modal so user finishes editing first
                loadSuppliers();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (suppliersTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = suppliersTable;
            }
            else
            {
                // Filter by name, contact_number, or address
                string rowFilter = $"name LIKE '%{filter}%' OR contact_number LIKE '%{filter}%' OR address LIKE '%{filter}%'";
                DataView dv = new DataView(suppliersTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (suppliersTable == null || suppliersTable.Rows.Count == 0)
            {
                MessageBox.Show("No data loaded.");
                return;
            }

            try
            {
                // Get date values
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1); // include end of day

                // Start building filter
                string filter = $"created_at >= #{fromDate:MM/dd/yyyy}# AND created_at <= #{toDate:MM/dd/yyyy}#";

                // Add active/inactive filter
                string status = cmbStatus.SelectedItem?.ToString() ?? "All";
                if (status == "Active")
                    filter += " AND is_active = true";
                else if (status == "Inactive")
                    filter += " AND is_active = false";

                // Apply filter to DataView
                suppliersTable.DefaultView.RowFilter = filter;
                dataGridView1.DataSource = suppliersTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering suppliers: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv", FileName = "Suppliers.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csv = new StringBuilder();

                        // Add header row (only visible columns with non-empty header)
                        var headers = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                          .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText));
                        csv.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

                        // Add rows (matching the same visible columns)
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = headers.Select(c => "\"" + row.Cells[c.Index].Value?.ToString().Replace("\"", "\"\"") + "\"");
                                csv.AppendLine(string.Join(",", cells));
                            }
                        }

                        // Write to file
                        File.WriteAllText(sfd.FileName, csv.ToString(), Encoding.UTF8);

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            loadSuppliers();
        }
    }
}
