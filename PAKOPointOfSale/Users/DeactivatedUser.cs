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
    public partial class DeactivatedUser : Form
    {
        private int _userId;
        public DeactivatedUser(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            if (_userId > 0)
            {
                LoadUserData();
                PopulateUserTypes();
            }
        }
        private void PopulateUserTypes()
        {
            using (var context = new AppDbContext())
            {
                cmbRole.DataSource = context.UserTypes.ToList();
                cmbRole.DisplayMember = "type_name";
                cmbRole.ValueMember = "id";
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = "UPDATE Users SET is_active = @isActive WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@isActive", 1); // 1 = active, 0 = inactive
                        cmd.Parameters.AddWithValue("@id", _userId); // _userId should be set before opening this form

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User activated successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User not found or already active.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }
        private void LoadUserData()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT u.*, ut.name AS user_type_name
                        FROM Users u
                        INNER JOIN UserTypes ut ON u.user_type_id = ut.id
                        WHERE u.id = @id
                    ";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUsername.Text = reader["username"].ToString();
                                txtFirstName.Text = reader["first_name"].ToString();
                                txtMiddleName.Text = reader["middle_name"] != DBNull.Value ? reader["middle_name"].ToString() : "";
                                txtLastName.Text = reader["last_name"].ToString();
                                dtpBirthdate.Value = Convert.ToDateTime(reader["birthday"]);
                                cmbGender.SelectedItem = reader["gender"].ToString();
                                txtSuffix.Text = reader["suffix"] != DBNull.Value ? reader["suffix"].ToString() : "";
                                cmbRole.SelectedValue = Convert.ToInt32(reader["user_type_id"]);
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
