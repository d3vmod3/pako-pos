using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace PAKOPointOfSale.UAC
{
    public partial class UAC : Form
    {
        private DataTable permissionsDt;
        public UAC()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void UAC_Load(object sender, EventArgs e)
        {
            LoadUserRoles();
            loadPermissions();

            dataGridView1.DataSource = permissionsDt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;








        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("User Access Control", "edit"))
            {
                btnUpdate.Visible = false;
            }

        }

        private void ReadOnlySelectedPermissions()
        {
            // Loop through all rows and disable specific checkboxes
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["module_name2"].Value == null)
                    continue;

                string module = row.Cells["module_name2"].Value.ToString();

                // 🔹 For "Sales Invoice" — disable can_edit and can_delete
                if (module.Equals("Sales Invoice", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_edit2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_edit2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                }

                else if (module.Equals("Transactions", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_edit2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_edit2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_add2"].ReadOnly = true;
                    row.Cells["can_add2"].Style.BackColor = Color.LightGray;
                }


                // 🔹 For "User Access Control" — disable can_add and can_delete
                else if (module.Equals("User Access Control", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_add2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_add2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                }

                else if (module.Equals("Sales", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_add2"].ReadOnly = true;
                    row.Cells["can_edit2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_add2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_edit2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                }
                else if (module.Equals("Top 5 Selling", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_add2"].ReadOnly = true;
                    row.Cells["can_edit2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_add2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_edit2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                }
                else if (module.Equals("Low in Stock", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["can_add2"].ReadOnly = true;
                    row.Cells["can_edit2"].ReadOnly = true;
                    row.Cells["can_delete2"].ReadOnly = true;
                    row.Cells["can_add2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_edit2"].Style.BackColor = Color.LightGray;
                    row.Cells["can_delete2"].Style.BackColor = Color.LightGray;
                }


            }

            // Optional: make module_name column read-only
            if (dataGridView1.Columns.Contains("module_name"))
            {
                dataGridView1.Columns["module_name2"].ReadOnly = true;
            }
        }
        private void LoadUserRoles()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // Get all roles from the database
                    var roles = db.UserTypes
                                  .OrderBy(r => r.name)
                                  .ToList();

                    // Bind to ComboBox
                    cmbRole.DataSource = roles;
                    cmbRole.DisplayMember = "name";
                    cmbRole.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user roles: " + ex.Message);
            }
        }
        private void LoadPermissionsForRole(int userTypeId)
        {
            try
            {
                string connString = Program.ConnString; // or wherever your connection string is defined

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            module_name,
                            can_view,
                            can_add,
                            can_edit,
                            can_delete
                        FROM Permissions
                        WHERE user_type_id = @user_type_id
                        ORDER BY module_name;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_type_id", userTypeId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            permissionsDt = new DataTable();
                            adapter.Fill(permissionsDt);

                            dataGridView1.DataSource = permissionsDt;

                            // Optional formatting
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            //dataGridView1.Columns["Module2"].ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading permissions: " + ex.Message);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedValue != null)
            {
                LoadPermissionsForRole(Convert.ToInt32(cmbRole.SelectedValue));
                ReadOnlySelectedPermissions();
            }
        }

        private void cmbRole_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please select a role first.");
                    return;
                }

                // Commit any edits in DataGridView
                dataGridView1.EndEdit();



                int userTypeId = Convert.ToInt32(cmbRole.SelectedValue);
                string connString = Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;


                        // ✅ Correct column names based on your SELECT query
                        string moduleName = row.Cells["module_name2"].Value?.ToString();
                        bool canView = Convert.ToBoolean(row.Cells["can_view2"].Value ?? false);
                        bool canAdd = Convert.ToBoolean(row.Cells["can_add2"].Value ?? false);
                        bool canEdit = Convert.ToBoolean(row.Cells["can_edit2"].Value ?? false);
                        bool canDelete = Convert.ToBoolean(row.Cells["can_delete2"].Value ?? false);

                        string updateQuery = @"
                            UPDATE Permissions
                            SET 
                                can_view = @can_view,
                                can_add = @can_add,
                                can_edit = @can_edit,
                                can_delete = @can_delete
                            WHERE user_type_id = @user_type_id 
                            AND module_name = @module_name;
                        ";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@module_name", moduleName);
                            cmd.Parameters.AddWithValue("@can_view", canView);
                            cmd.Parameters.AddWithValue("@can_add", canAdd);
                            cmd.Parameters.AddWithValue("@can_edit", canEdit);
                            cmd.Parameters.AddWithValue("@can_delete", canDelete);
                            cmd.Parameters.AddWithValue("@user_type_id", userTypeId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Permissions successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving permissions: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UAC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
