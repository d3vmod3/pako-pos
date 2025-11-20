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
    public partial class EditProduct : Form
    {
        private int _productId;
        private string _productName;
        private string _barcode;
        private string _productCode;
        private string _productSku;
        public EditProduct(int product_id)
        {
            _productId = product_id;
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            LoadSuppliers();       // Load suppliers into cmbSupplier
            LoadCategories();      // Load categories into cmbCategory
            populate();
        }
        private void populate()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                                SELECT * 
                                FROM Products
                                WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _productId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProductName.Text = reader["product_name"].ToString();
                                txtProductBrand.Text = reader["product_brand"].ToString();
                                txtDescription.Text = reader["product_description"].ToString();
                                txtBarcode.Text = reader["barcode"].ToString();
                                txtProductCode.Text = reader["product_code"].ToString();
                                txtSKU.Text = reader["sku"].ToString();
                                num_quantity.Text = reader["quantity"].ToString();
                                num_low_quantity.Text = reader["low_stock_quantity"].ToString();
                                cmbUnitofMeasurements.Text = reader["unit_of_measurement"].ToString();
                                num_costPrice.Text = reader["cost_price"].ToString();
                                num_unitPrice.Text = reader["unit_price"].ToString();
                                txtRemarks.Text = reader["remarks"].ToString();
                                dtpDateReceived.Value = Convert.ToDateTime(reader["date_received"]);
                                dtpDateExpiration.Value = Convert.ToDateTime(reader["date_expiration"]);

                                // Set ComboBoxes by Value
                                cmbSupplier.SelectedValue = reader["supplier_id"] == "Unknown"
                                    ? "Unknown"
                                    : reader["supplier_id"];

                                cmbCategory.SelectedValue = reader["category_id"] == "Unknown"
                                    ? "Unknown"
                                    : reader["category_id"];
                                cmbUnitofMeasurements.Text = reader["unit_of_measurement"].ToString();
                                cmbStatus.Text = reader["status"].ToString();
                                chkIsActive.Checked = Convert.ToBoolean(reader["is_active"]);

                                _productName = reader["product_name"].ToString();
                                _productCode = reader["product_code"].ToString();
                                _barcode = reader["barcode"].ToString();
                                _productSku = reader["sku"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        emptyRow["name"] = "Unknown"; // empty display
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
                        emptyRow["name"] = "Unknown"; // empty display
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

        }

        private Boolean validateForm()
        {
            //if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            //{
            //    MessageBox.Show("Please enter the Barciode", "Validation Error",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtBarcode.Focus();
            //    return false;
            //}

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter the Product Name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }
            if (_productSku != txtSKU.Text)
            {
                if (IsSkuExists(txtSKU.Text))
                {
                    MessageBox.Show("SKU already exists. Please use a different one.",
                                    "Duplicate SKU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSKU.Focus();
                    return false;
                }
            }
            //if (_productCode != txtProductCode.Text)
            //{
            //    if (IsProductCodeExists(txtProductCode.Text))
            //    {
            //        MessageBox.Show("Product Code already exists. Please use a different one.",
            //                        "Duplicate Product Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtProductCode.Focus();
            //        return false;
            //    }
            //}

            //if (_barcode != txtBarcode.Text)
            //{
            //    if (IsProductBardcodeExists(txtBarcode.Text))
            //    {
            //        MessageBox.Show("Barcode already exists. Please use a different one.",
            //                        "Duplicate Barcode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtBarcode.Focus();
            //        return false;
            //    }
            //}



            if (dtpDateReceived.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date Received cannot be in the future.", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateReceived.Focus();
                return false;
            }

            // --- Date Expiration ---
            if (dtpDateExpiration.Value.Date < DateTime.Now.Date.AddMonths(1))
            {
                MessageBox.Show("Date Expiration must be more than a month from today.", "Invalid Date",
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

            if (cmbUnitofMeasurements.SelectedItem == "")
            {
                MessageBox.Show("Please select a Unit of Measurement.",
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

        //private bool IsProductBardcodeExists(string barcode)
        //{
        //    string connString = PAKOPointOfSale.Program.ConnString;
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();
        //        string query = "SELECT COUNT(*) FROM Products WHERE barcode = @barcode";
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@barcode", barcode);
        //            return (int)cmd.ExecuteScalar() > 0;
        //        }
        //    }
        //}

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (!validateForm()) // Make sure you have a validateForm() method
                return;

            string connString = PAKOPointOfSale.Program.ConnString;

            //try
            //{
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string sql = @"
                UPDATE Products
                SET 
                    supplier_id = @supplier_id,
                    category_id = @category_id,
                    product_name = @product_name,
                    product_brand = @product_brand,
                    product_description = @product_description,
                    barcode = @barcode,
                    product_code = @product_code,
                    sku = @sku,
                    quantity = @quantity,
                    low_stock_quantity = @low_stock_quantity,
                    unit_of_measurement = @unit_of_measurement,
                    cost_price = @cost_price,
                    unit_price = @unit_price,
                    remarks = @remarks,
                    status = @status,
                    date_received = @date_received,
                    date_expiration = @date_expiration,
                    is_active = @is_active
                WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Parameters
                    cmd.Parameters.AddWithValue("@id", _productId);
                    cmd.Parameters.AddWithValue("@supplier_id", cmbSupplier.SelectedValue != null ? cmbSupplier.SelectedValue : DBNull.Value);
                    cmd.Parameters.AddWithValue("@category_id", cmbCategory.SelectedValue != null ? cmbCategory.SelectedValue : DBNull.Value);
                    cmd.Parameters.AddWithValue("@product_name", txtProductName.Text.Trim());
                    cmd.Parameters.AddWithValue("@product_brand", string.IsNullOrWhiteSpace(txtProductBrand.Text) ? DBNull.Value : txtProductBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@product_description", string.IsNullOrWhiteSpace(txtDescription.Text) ? DBNull.Value : txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@barcode", string.IsNullOrWhiteSpace(txtBarcode.Text) ? DBNull.Value : txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@product_code", string.IsNullOrWhiteSpace(txtProductCode.Text) ? DBNull.Value : txtProductCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@sku", string.IsNullOrWhiteSpace(txtSKU.Text) ? DBNull.Value : txtSKU.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", decimal.Parse(num_quantity.Text.Trim()));
                    cmd.Parameters.AddWithValue("@low_stock_quantity", decimal.Parse(num_low_quantity.Text.Trim()));
                    cmd.Parameters.AddWithValue("@unit_of_measurement", cmbUnitofMeasurements.Text.Trim());
                    cmd.Parameters.AddWithValue("@cost_price", decimal.Parse(num_costPrice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@unit_price", decimal.Parse(num_unitPrice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@remarks", string.IsNullOrWhiteSpace(txtRemarks.Text) ? DBNull.Value : txtRemarks.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_received", dtpDateReceived.Value);
                    cmd.Parameters.AddWithValue("@date_expiration", dtpDateExpiration.Value);
                    cmd.Parameters.AddWithValue("@is_active", chkIsActive.Checked);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // or reload your products grid
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
