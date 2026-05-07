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
using System.Xml.Linq;

namespace PAKOPointOfSale.Supplier_Details
{
    public partial class EditSupplierDetails : Form
    {
        private int _supplierId;
        private string _supplierName;
        public EditSupplierDetails(int supplierId)
        {
            _supplierId = supplierId;
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void EditSupplierDetails_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT name, address, contact_number, email, created_at, is_active 
                       FROM SupplierDetails 
                       WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _supplierId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _supplierName = reader["name"].ToString();
                                txtSupplierName.Text = reader["name"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                txtContactNumber.Text = reader["contact_number"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                chkIsActive.Checked = Convert.ToBoolean(reader["is_active"]);
                                DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                                lblCreatedAt.Text = "Date Created: " + createdAt.ToString("yyyy-MM-dd HH:mm");
                            }
                            else
                            {
                                MessageBox.Show("Supplier not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (_supplierName != txtSupplierName.Text)
            {
                if (isAlreadyExists() == true)
                {

                    MessageBox.Show("Supplier name already exists. Please choose another one.");
                    txtSupplierName.Focus();
                    return false;
                }
            }
            return true;
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
                                    UPDATE SupplierDetails
                                    SET 
                                        name = @name,
                                        address = @address,
                                        contact_number = @contact_number,
                                        email = @email,
                                        is_active = @is_active
                                    WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", string.IsNullOrWhiteSpace(txtAddress.Text) ? DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact_number", string.IsNullOrWhiteSpace(txtContactNumber.Text) ? DBNull.Value : txtContactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@is_active", chkIsActive.Checked);
                        cmd.Parameters.AddWithValue("@id", _supplierId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ActivityLogs.Log(
                                user: LoggedInUser.FullName,
                                action: "click",
                                module: "Edit Supplier Details",
                                description: "Clicked Submit button",
                                payload: new
                                {
                                    name = txtSupplierName.Text,
                                    address = txtAddress.Text,
                                    contactNumber = txtContactNumber.Text,
                                    email = txtEmail.Text,
                                    is_active = chkIsActive.Checked,
                                }
                            );
                            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // or refresh the list form
                        }
                        else
                        {
                            ActivityLogs.Log(
                                user: LoggedInUser.FullName,
                                action: "click",
                                module: "Edit Supplier Details",
                                description: "Clicked Submit button",
                                payload: new
                                {
                                    name = txtSupplierName.Text,
                                    address = txtAddress.Text,
                                    contactNumber = txtContactNumber.Text,
                                    email = txtEmail.Text,
                                    is_active = chkIsActive.Checked,
                                    status = "failed",
                                    message = "No rows were inserted."
                                }
                            );
                            MessageBox.Show("No supplier record was updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Edit Supplier Details",
                description: "Clicked Cancel button",
                payload: null
            );
            this.Close();
        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {

        }

        private void EditSupplierDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
