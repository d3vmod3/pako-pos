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

            if (e.ColumnIndex == dataGridView1.Columns["product_name"].Index)
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
    }
}
