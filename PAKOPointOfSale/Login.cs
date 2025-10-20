using Microsoft.Data.SqlClient;

namespace PAKOPointOfSale
{
    public partial class Login : Form
    {
        public int user_type_id;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            
            int userTypeId = LoginUser(username, password);

            if (userTypeId > 0)
            {
                LoggedInUser.CurrentUser = username;
                LoggedInUser.CurrentUserTypeId = userTypeId;

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MDIParent1 mainMenuForm = new MDIParent1();
                if (userTypeId == 3)
                {
                    Transactions.SalesInvoice salesInvoiceForm = new Transactions.SalesInvoice();
                    salesInvoiceForm.ShowDialog();
                }
                mainMenuForm.Show();
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
                SELECT id, user_type_id
                FROM Users
                WHERE username = @username AND password = @password AND is_active = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // (later you can hash this)

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(reader.GetOrdinal("user_type_id"));
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
    }
}
