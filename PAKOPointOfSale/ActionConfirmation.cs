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
    public partial class ActionConfirmation : Form
    {
        private string _message = "";
        private bool _is_admin = false;
        private string _action = "";
        public ActionConfirmation(string message = "", bool is_admin = false, string action = "")
        {
            _message = message;
            _is_admin = is_admin;
            _action = action;
            InitializeComponent();
        }

        private void ActionConfirmation_Load(object sender, EventArgs e)
        {
            lblMessage.Text = _message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ConfirmAdminLogin(username, password))
            {
                MessageBox.Show("Invalid admin credentials.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If confirmation is successful
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool ConfirmAdminLogin(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    string query = @"
                        SELECT COUNT(*) 
                        FROM Users 
                        WHERE username = @username 
                          AND password = @password 
                          AND user_type_id = 2"; // 2 = admin

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login verification failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
