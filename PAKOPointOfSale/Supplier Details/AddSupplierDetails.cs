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
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
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
    }
}
