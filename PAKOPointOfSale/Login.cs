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
            string username = txtUsername.Text; // Make sure your TextBox is named txtUsername
            string password = txtPassword.Text; // Make sure your TextBox is named txtPassword

            if (LoginUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open main form and hide login
                this.Hide();
                //MainForm mainForm = new MainForm(); // Replace with your main form
                //mainForm.Show();
                switch (user_type_id)
                {
                    case 1:
                        MDIParent1 SuperAdminForm = new MDIParent1();
                        SuperAdminForm.Show();
                        break;
                    case 2:
                        //Dashboard Dashboard = new Dashboard();
                        //Dashboard.Show();
                        break;
                    case 3:
                        Cashier Cashier = new Cashier();
                        Cashier.Show();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool LoginUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    string query = "SELECT user_type_id FROM Users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Use hashed passwords in production!


                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            user_type_id = Convert.ToInt32(result);
                            return true;
                        }
                        else
                        {
                            return false; // Login failed
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
