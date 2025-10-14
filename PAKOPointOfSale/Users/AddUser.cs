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
using WinFormsApp1.Data;

namespace PAKOPointOfSale.Users
{
    public partial class AddUser : Form
    {
        public int _userId;
        public AddUser()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            LoadUserRoles();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection string from Program.cs
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Users
                        (username, password, first_name, middle_name, last_name, birthday, gender, suffix, user_type_id, created_at)
                        VALUES
                        (@username, @password, @first_name, @middle_name, @last_name, @birthday, @gender, @suffix, @user_type_id, @created_at)
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", "password123"); // change to hashed if needed
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@middle_name", string.IsNullOrEmpty(txtMiddleName.Text) ? (object)DBNull.Value : txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@birthday", dtpBirthdate.Value);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "Unspecified");
                        cmd.Parameters.AddWithValue("@suffix", string.IsNullOrEmpty(txtSuffix.Text) ? (object)DBNull.Value : txtSuffix.Text);
                        cmd.Parameters.AddWithValue("@user_type_id", (int)cmbRole.SelectedValue);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@is_active", false);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }
    }
}
