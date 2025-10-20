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
        public UAC()
        {
            InitializeComponent();
        }

        private void UAC_Load(object sender, EventArgs e)
        {
            LoadUserRoles();
            loadPermissions();

        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("User Access Control", "edit"))
            {
                btnUpdate.Visible = false;
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
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;

                            // Optional formatting
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            //dataGridView1.Columns["Module"].ReadOnly = true;
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
                        string moduleName = row.Cells["module_name"].Value?.ToString();
                        bool canView = Convert.ToBoolean(row.Cells["can_view"].Value ?? false);
                        bool canAdd = Convert.ToBoolean(row.Cells["can_add"].Value ?? false);
                        bool canEdit = Convert.ToBoolean(row.Cells["can_edit"].Value ?? false);
                        bool canDelete = Convert.ToBoolean(row.Cells["can_delete"].Value ?? false);

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
    }
}
