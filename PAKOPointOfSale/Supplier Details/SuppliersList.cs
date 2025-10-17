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

namespace PAKOPointOfSale.Supplier_Details
{
    public partial class SuppliersList : Form
    {
        private DataTable suppliersTable;
        public SuppliersList()
        {
            InitializeComponent();
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            loadSuppliers();
        }

        public void loadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();


                    string query = @"SELECT id,name,address,contact_number,account_number,gateway,created_at,is_active FROM SupplierDetails";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        suppliersTable = new DataTable();
                        da.Fill(suppliersTable);

                        dataGridView1.DataSource = suppliersTable; // Bind DataTable to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier_Details.AddSupplierDetails addSupplierForm = new Supplier_Details.AddSupplierDetails();
            addSupplierForm.ShowDialog();
            loadSuppliers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                Supplier_Details.EditSupplierDetails editSupplierForm = new Supplier_Details.EditSupplierDetails(supplierId);
                editSupplierForm.ShowDialog(); // modal so user finishes editing first
                loadSuppliers();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (suppliersTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = suppliersTable;
            }
            else
            {
                // Filter by name, contact_number, or address
                string rowFilter = $"name LIKE '%{filter}%' OR contact_number LIKE '%{filter}%' OR address LIKE '%{filter}%'";
                DataView dv = new DataView(suppliersTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
