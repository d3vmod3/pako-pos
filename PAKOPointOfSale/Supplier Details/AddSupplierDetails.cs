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
using static System.Net.Mime.MediaTypeNames;

namespace PAKOPointOfSale.Supplier_Details
{
    public partial class AddSupplierDetails : Form
    {
        public AddSupplierDetails()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                return;
            }
            string connString = PAKOPointOfSale.Program.ConnString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO SupplierDetails 
                (name, address, contact_number, account_number, gateway, created_at, is_active)
                VALUES 
                (@name, @address, @contact_number, @account_number, @gateway, @created_at, @is_active)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", string.IsNullOrWhiteSpace(txtAddress.Text) ? DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact_number", string.IsNullOrWhiteSpace(txtContactNumber.Text) ? DBNull.Value : txtContactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@account_number", string.IsNullOrWhiteSpace(txtAccountNumber.Text) ? DBNull.Value : txtAccountNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@gateway", string.IsNullOrWhiteSpace(txtGateway.Text) ? DBNull.Value : txtGateway.Text.Trim());
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Today);
                        cmd.Parameters.AddWithValue("@is_active", false);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validateForm()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier's name.");
                txtSupplierName.Focus();
                return false;
            }
            if (isAlreadyExists() == true)
            {

                MessageBox.Show("Supplier name already exists. Please choose another one.");
                txtSupplierName.Focus();
                return false;
            }

            return true;
        }

        private void AddSupplierDetails_Load(object sender, EventArgs e)
        {

        }
        public bool isAlreadyExists()
        {

            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SupplierDetails WHERE name = @name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim());
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

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits only
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit max length to 10
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length >= 10)
            {
                e.Handled = true; // prevent typing more than 10 digits
            }
        }

        private void AddSupplierDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
