using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Inventory
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cmbShowItemsRecentyAdded.SelectedItem = "25";
            cmbShowItemsLowStocks.SelectedItem = "25";
            cmbShowItemsOutOfStocks.SelectedItem = "25";

            LoadRecentlyAddedProducts();
            LoadLowStockProducts();
            LoadOutOfStocks();
        }



        private void LoadRecentlyAddedProducts()
        {
            string connString = Program.ConnString;

            string searchQuery = txSearchQuery.Text;

            string showTopItemsQuery = @"SELECT TOP " + cmbShowItemsRecentyAdded.SelectedItem + " product_name, created_at from Products WHERE created_at >= DATEADD(day, -7, GETDATE()) AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";
            string showAllItemsQuery = @"SELECT product_name, created_at from Products WHERE created_at >= DATEADD(day, -7, GETDATE()) AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";
            string query = "";
            query = string.IsNullOrEmpty(cmbShowItemsRecentyAdded.SelectedItem?.ToString()) || cmbShowItemsRecentyAdded.SelectedItem?.ToString() == "All" ? showAllItemsQuery : showTopItemsQuery;



            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                DataTable dt = new DataTable();
                conn.Open();


                cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                dgvRecentlyAdded.DataSource = dt;
                dgvRecentlyAdded.Columns["product_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecentlyAdded.Columns["created_at"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void LoadLowStockProducts()
        {
            string connString = Program.ConnString;

            string searchQuery = txSearchQuery.Text;
            string query = "";

            string showAllItemsQuery = @"
               SELECT p.product_name, p.quantity, s.name as 'supplier'
                from Products P 
                LEFT JOIN SupplierDetails s
                ON s.id = p.supplier_id
                WHERE quantity <= low_stock_quantity AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";
            string showTopItemsQuery = @"SELECT TOP " + cmbShowItemsLowStocks.SelectedItem + " p.product_name, p.quantity, s.name as 'supplier' from Products P LEFT JOIN SupplierDetails s ON s.id = p.supplier_id WHERE quantity <= low_stock_quantity AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";

            query = string.IsNullOrEmpty(cmbShowItemsLowStocks.SelectedItem?.ToString()) || cmbShowItemsLowStocks.SelectedItem?.ToString() == "All" ? showAllItemsQuery : showTopItemsQuery;

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                DataTable dt = new DataTable();
                conn.Open();
                cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                dgvLowStocks.DataSource = dt;
                dgvLowStocks.Columns["product_name2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLowStocks.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLowStocks.Columns["supplier"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void LoadOutOfStocks()
        {
            string connString = Program.ConnString;
            string searchQuery = txSearchQuery.Text;
            string query = "";
            string showAllItemsQuery = @"
               SELECT p.product_name, p.quantity, s.name as 'supplier'
                from Products P 
                LEFT JOIN SupplierDetails s
                ON s.id = p.supplier_id
                WHERE quantity = 0
                AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";
            string showTopItemsQuery = @"SELECT TOP " + cmbShowItemsOutOfStocks.SelectedItem + " p.product_name, p.quantity, s.name as 'supplier' from Products P LEFT JOIN SupplierDetails s ON s.id = p.supplier_id WHERE quantity = 0 AND (product_name LIKE @searchQuery OR barcode LIKE @searchQuery OR sku LIKE @searchQuery)";

            query = string.IsNullOrEmpty(cmbShowItemsOutOfStocks.SelectedItem?.ToString()) || cmbShowItemsOutOfStocks.SelectedItem?.ToString() == "All" ? showAllItemsQuery : showTopItemsQuery;

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                DataTable dt = new DataTable();
                conn.Open();
                cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                dgvOutOfStocks.DataSource = dt;
                dgvOutOfStocks.Columns["product_name3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOutOfStocks.Columns["supplier3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLowStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbShowItemsRecentyAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecentlyAddedProducts();
        }

        private void cmbShowItemsLowStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLowStockProducts();
        }

        private void cmbShowItemsOutOfStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOutOfStocks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoadRecentlyAddedProducts();
            LoadLowStockProducts();
            LoadOutOfStocks();
        }
    }
}
