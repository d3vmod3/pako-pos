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

namespace PAKOPointOfSale.Supplier_Details
{
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            loadSuppliers();
        }

        public void loadSuppliers() {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    
                    string query = @"SELECT id,name,address,contact_number,account_number,gateway,created_at FROM SupplierDetails";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt; // Bind DataTable to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
    }
}
