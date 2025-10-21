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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PAKOPointOfSale.Products
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadCategories();
            cmbStatus.SelectedIndex = 0;
        }
        private void LoadSuppliers()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT id, name FROM SupplierDetails WHERE is_active = 1 ORDER BY name ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataRow emptyRow = dt.NewRow();
                        emptyRow["id"] = DBNull.Value;
                        emptyRow["name"] = ""; // empty display
                        dt.Rows.InsertAt(emptyRow, 0);

                        cmbSupplier.DisplayMember = "name";
                        cmbSupplier.ValueMember = "id";
                        cmbSupplier.DataSource = dt;

                        // Set default selected index to 0 (empty)
                        cmbSupplier.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCategories()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT id, name FROM Categories ORDER BY name ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataRow emptyRow = dt.NewRow();
                        emptyRow["id"] = DBNull.Value;
                        emptyRow["name"] = ""; // empty display
                        dt.Rows.InsertAt(emptyRow, 0);

                        cmbCategory.DisplayMember = "name";
                        cmbCategory.ValueMember = "id";
                        cmbCategory.DataSource = dt;

                        // Set default selected index to 0 (empty)
                        cmbCategory.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    INSERT INTO Products
                    (supplier_id, category_id, product_name, product_brand, product_description,barcode, product_code, 
                     sku, quantity, unit_of_measurement, cost_price, unit_price, remarks, status, 
                     date_received, date_expiration,is_active,created_at)
                    VALUES
                    (@supplier_id, @category_id, @product_name, @product_brand, @product_description,@barcode, @product_code, 
                     @sku, @quantity, @unit_of_measurement, @cost_price, @unit_price, @remarks, @status, 
                     @date_received, @date_expiration,@is_active, @created_at)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplier_id", cmbSupplier.SelectedValue != null ? cmbSupplier.SelectedValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@category_id", cmbCategory.SelectedValue != null ? cmbSupplier.SelectedValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@product_name", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@product_brand", txtProductBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@product_description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text.Trim());
                        cmd.Parameters.AddWithValue("@product_code", txtProductCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text.Trim());
                        cmd.Parameters.AddWithValue("@quantity", decimal.Parse(num_quantity.Text.Trim()));
                        cmd.Parameters.AddWithValue("@unit_of_measurement", cmbUnitofMeasurements.Text.Trim());
                        cmd.Parameters.AddWithValue("@cost_price", decimal.Parse(num_costPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@unit_price", decimal.Parse(num_unitPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_received", dtpDateReceived.Value);
                        cmd.Parameters.AddWithValue("@date_expiration", dtpDateExpiration.Value);
                        cmd.Parameters.AddWithValue("@is_active", chkIsActive.Checked);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // close the AddProduct form
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
                MessageBox.Show("Error inserting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateForm()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter the Product Name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Please enter the Barciode", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return false;
            }

            if (IsSkuExists(txtSKU.Text))
            {
                MessageBox.Show("SKU already exists. Please use a different one.",
                                "Duplicate SKU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }

            if (IsProductCodeExists(txtProductCode.Text))
            {
                MessageBox.Show("Product Code already exists. Please use a different one.",
                                "Duplicate Product Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductCode.Focus();
                return false;
            }

            if (IsProductBardcodeExists(txtBarcode.Text))
            {
                MessageBox.Show("Barcode Name already exists. Please use a different one.",
                                "Duplicate Barcode Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            



            if (dtpDateReceived.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date Received cannot be in the future.", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateReceived.Focus();
                return false;
            }

            // --- Date Expiration ---
            if (dtpDateExpiration.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Date Expiration must be a future date (after today).", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateExpiration.Focus();
                return false;
            }

            if (!cmbSupplier.Items.Cast<DataRowView>().Any(i => i["name"].ToString() == cmbSupplier.Text))
            {
                MessageBox.Show("Please select a valid Supplier from the list.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupplier.Focus();
                return false;
            }

            // --- Category validation ---
            if (!cmbCategory.Items.Cast<DataRowView>().Any(i => i["name"].ToString() == cmbCategory.Text))
            {
                MessageBox.Show("Please select a valid Category from the list.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (!cmbUnitofMeasurements.Items.Cast<string>().Any(u => u == cmbUnitofMeasurements.Text))
            {
                MessageBox.Show("Please select a valid Unit of Measurement from the list.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUnitofMeasurements.Focus();
                return false;
            }

            // --- Status validation ---
            if (!cmbStatus.Items.Cast<string>().Any(s => s == cmbStatus.Text))
            {
                MessageBox.Show("Please select a valid Status from the list.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }


            return true;
        }

        private bool IsSkuExists(string sku)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Products WHERE sku = @sku";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sku", sku);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private bool IsProductCodeExists(string productCode)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Products WHERE product_code = @product_code";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_code", productCode);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private bool IsProductBardcodeExists(string barcode)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Products WHERE barcode = @barcode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void lblSupplierID_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
