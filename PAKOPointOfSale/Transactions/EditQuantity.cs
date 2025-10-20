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

namespace PAKOPointOfSale.Transactions
{
    public partial class EditQuantity : Form
    {
        private int _productId;
        private SalesInvoice _salesInvoice;
        public EditQuantity(int productId, SalesInvoice salesInvoice)
        {
            _productId = productId;
            _salesInvoice = salesInvoice;
            InitializeComponent();
        }

        private void EditQuantity_Load(object sender, EventArgs e)
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                                SELECT product_name,c.name as category,product_brand,quantity,unit_of_measurement,unit_price
                                FROM Products as p LEFT JOIN Categories c ON p.category_id = c.id
                                WHERE p.id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _productId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblProductName.Text = reader["product_name"].ToString();
                                lblProductBrand.Text = reader["product_brand"].ToString();
                                lblCurrentQtyValue.Text = reader["quantity"].ToString();
                                lblUOM.Text = reader["unit_of_measurement"].ToString();
                                lblCategory.Text = reader["category"].ToString();
                                lblUnitPrice.Text = reader["unit_price"].ToString();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int product_id = _productId;
                string product = lblProductName.Text;
                string brand = lblProductBrand.Text;
                string unit = lblUOM.Text;
                decimal price = decimal.Parse(lblUnitPrice.Text);
                
                string category = lblCategory.Text;
                decimal quantity = Convert.ToDecimal(num_AppliedQty.Text);
                decimal subTotal = decimal.Parse(lblUnitPrice.Text) * quantity;
                // Add to cart
                _salesInvoice.AddProductToCart(product_id, product, brand, unit, price, category, quantity, subTotal);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message);
            }
        }

    }
}
