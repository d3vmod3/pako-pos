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
        public UsersList()
        {
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            loadUsers();
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
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt; // Bind DataTable to DataGridView
                    }
                }
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
            adduser.ShowDialog();
            loadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

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
                WHERE 
                    u.username LIKE @search OR
                    u.first_name LIKE @search OR
                    u.last_name LIKE @search
                ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string searchValue = "%" + txtSearch.Text.Trim() + "%";
                        cmd.Parameters.AddWithValue("@search", searchValue);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            // Hide the ID column
                            if (dataGridView1.Columns.Contains("id"))
                                dataGridView1.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching users: " + ex.Message);
            }
        }
    }
}
