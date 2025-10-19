using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace PAKOPointOfSale.Products
{
    public partial class ProductsList : Form
    {
        private DataTable productsTable;
        public ProductsList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products.AddProducts addProductForm = new Products.AddProducts();
            addProductForm.ShowDialog();
            LoadProducts();

        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                ORDER BY p.created_at DESC;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        productsTable = new DataTable();
                        adapter.Fill(productsTable);
                        dataGridView1.DataSource = productsTable;
                    }

                    // Optional: auto-size columns
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                Products.EditProduct editProductForm = new Products.EditProduct(productId);
                editProductForm.ShowDialog(); // modal so user finishes editing first
                LoadProducts();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (productsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = productsTable;
            }
            else
            {
                // Filter by multiple columns (product name, code, SKU, brand)
                string rowFilter = $"product_name LIKE '%{filter}%' OR product_code LIKE '%{filter}%' OR sku LIKE '%{filter}%' OR product_brand LIKE '%{filter}%'";
                DataView dv = new DataView(productsTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selected = cmbFilterType.SelectedItem.ToString();
            if (selected == "Stock")
            {
                var filterStocksForm = new Products.Filters.Stocks();

                // Show as dialog and wait for user to press Filter
                if (filterStocksForm.ShowDialog() == DialogResult.OK)
                {
                    decimal filterQty = filterStocksForm.SelectedQuantity;
                    FilterProductsByStock(filterQty);
                }
            }
            else if (selected == "Date and Time")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Date Range");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "created_at");
                }
            }
            else if (selected == "Date Received")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Date Received");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "date_received");
                }
            }
            else if (selected == "Expiration Date")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Expiration Date");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "date_expiration");
                }
            }
            else if (selected == "Status")
            {
                var filterStatusForm = new Products.Filters.Status();

                // Show as dialog and wait for user to press Filter
                if (filterStatusForm.ShowDialog() == DialogResult.OK)
                {
                    string status = filterStatusForm.StatusType;
                    FilterProductsByStatus(status = filterStatusForm.StatusType);
                }
            }
        }
        private void FilterProductsByStock(decimal maxQuantity)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.quantity <= @quantity
                ORDER BY p.quantity ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@quantity", maxQuantity);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }
        private void FilterProductsByStatus(string status)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.status = @status
                ORDER BY p.quantity ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }
        private void FilterProductsByDateRange(DateTime from, DateTime to, string dateField)
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            string query = @"
                    SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.date_received BETWEEN @from AND @to
                ORDER BY " + "p." + dateField + " ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            LoadProducts();
            cmbFilterType.SelectedIndex = 0;
        }
    }
}
