using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAKOPointOfSale
{
    public partial class Login : Form
    {
        public int user_type_id;
        public int user_id;
        public string firstName;
        public string lastName;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            int userTypeId = LoginUser(username, password);

            if (userTypeId > 0)
            {
                LoggedInUser.CurrentUser = username;
                LoggedInUser.CurrentUserTypeId = userTypeId;
                LoggedInUser.FirstName = firstName;
                LoggedInUser.LastName = lastName;
                LoggedInUser.CurrentUserTypeId = userTypeId;


                this.Hide();
                MDIParent1 mainMenuForm = new MDIParent1();
                if (is_reset(user_id) == false)
                {
                    if (userTypeId == 3)
                    {
                        Transactions.SalesInvoice salesInvoiceForm = new Transactions.SalesInvoice();
                        salesInvoiceForm.ShowDialog();
                    }
                    else
                    {
                        mainMenuForm.Show();
                    }
                    return;
                }
                else
                {
                    ResetPassword resetPasswordForm = new ResetPassword(user_id);
                    resetPasswordForm.ShowDialog();
                }



            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int LoginUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();
                    string query = @"
                        SELECT id, user_type_id,first_name,last_name
                        FROM Users
                        WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // (later you can hash this)

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user_type_id = reader.GetInt32(reader.GetOrdinal("user_type_id"));
                                user_id = reader.GetInt32(reader.GetOrdinal("id"));
                                firstName = reader.GetString(reader.GetOrdinal("first_name"));
                                lastName = reader.GetString(reader.GetOrdinal("last_name"));
                                return user_type_id;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

            return 0; // Invalid login
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; // show encripted text
            }
            else
            {
                txtPassword.PasswordChar = '*'; // encripted text
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private bool is_reset(int userID)
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();
                string query = @"
                SELECT id, is_reset
                FROM Users
                WHERE is_reset = @isReset and id=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isReset", true);
                    cmd.Parameters.AddWithValue("@id", userID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetBoolean(reader.GetOrdinal("is_reset"));
                        }
                    }
                }
            }
            return false;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login(); // Simulate clicking the login button
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login(); // Simulate clicking the login button
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
