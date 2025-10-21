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

namespace PAKOPointOfSale
{
    public partial class ResetPassword : Form
    {
        private int _user_id;
        public ResetPassword(int user_id)
        {
            _user_id = user_id;
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Show password
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                // Hide password
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (!passwordIsConfirmed())
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
                        password = @password,
                        is_reset = @isReset
                    WHERE id = @id
                ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@isReset", false);
                        cmd.Parameters.AddWithValue("@id", _user_id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "You have successfully reset your password.\nPlease log in again with your new password.",
                                "Password Reset Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            LoggedInUser.Logout(this);
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

        private bool passwordIsConfirmed()
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password Confirmation mismatch", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
