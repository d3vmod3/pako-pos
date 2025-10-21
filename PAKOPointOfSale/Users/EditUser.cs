using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditUser : Form
    {
        private int _userId;
        private string _username = "";
        public EditUser(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            PopulateUserTypes();
            LoadUserData();
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
                                _username = reader["username"].ToString();
                                txtUsername.Text = reader["username"].ToString();
                                txtFirstName.Text = reader["first_name"].ToString();
                                txtMiddleName.Text = reader["middle_name"] != DBNull.Value ? reader["middle_name"].ToString() : "";
                                txtLastName.Text = reader["last_name"].ToString();
                                dtpBirthdate.Value = Convert.ToDateTime(reader["birthday"]);
                                cmbGender.SelectedItem = reader["gender"].ToString();
                                txtSuffix.Text = reader["suffix"] != DBNull.Value ? reader["suffix"].ToString() : "";
                                cmbRole.SelectedValue = Convert.ToInt32(reader["user_type_id"]);
                                chkIsActive.Checked = Convert.ToBoolean(reader["is_active"]);
                                DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                                lblCreatedAt.Text = "Date Created: " + createdAt.ToString("yyyy-MM-dd HH:mm");
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateForm())
                {
                    return;
                }
                // Connection string from Program.cs
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Users
                        SET 
                            username = @username,
                            first_name = @first_name,
                            middle_name = @middle_name,
                            last_name = @last_name,
                            birthday = @birthday,
                            gender = @gender,
                            suffix = @suffix,
                            user_type_id = @user_type_id,
                            is_active = @is_active
                        WHERE id = @id
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@middle_name", string.IsNullOrEmpty(txtMiddleName.Text) ? (object)DBNull.Value : txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@birthday", dtpBirthdate.Value);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "Unspecified");
                        cmd.Parameters.AddWithValue("@suffix", string.IsNullOrEmpty(txtSuffix.Text) ? (object)DBNull.Value : txtSuffix.Text);
                        cmd.Parameters.AddWithValue("@user_type_id", (int)cmbRole.SelectedValue);
                        cmd.Parameters.AddWithValue("@is_active", chkIsActive.Checked);
                        cmd.Parameters.AddWithValue("@id", _userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully!");
                            this.Close(); // close the EditUser form
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        public bool validateForm()
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                txtUsername.Focus();
                return false;
            }

            if (_username != txtUsername.Text)
            {
                if (isUsernameExists() == true)
                {
                    MessageBox.Show("Username already exists. Please choose another one.");
                    txtUsername.Focus();
                    return false;
                }
            }



            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.");
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the last name.");
                txtLastName.Focus();
                return false;
            }

            if (cmbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender.");
                cmbGender.DroppedDown = true;
                return false;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a user role.");
                cmbRole.DroppedDown = true;
                return false;
            }

            // Optional: check if birthdate is in the future
            if (dtpBirthdate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Birthdate cannot be in the future.");
                dtpBirthdate.Focus();
                return false;
            }

            // All good
            return true;
        }

        public bool isUsernameExists()
        {

            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirmForm = new ActionConfirmation("Please confirm admin credentials to proceed.", true, "reset password");
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Users
                        SET 
                            password= @password,
                            is_reset = @isReset
                        WHERE id = @id
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@id", _userId);
                        cmd.Parameters.AddWithValue("@isReset", _userId);
                        cmd.Parameters.AddWithValue("@password", "password123");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password was successfully reset!");
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }
    }
}
