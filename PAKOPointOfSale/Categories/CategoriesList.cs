using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Categories
{
    public partial class CategoriesList : Form
    {
        public CategoriesList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            loadCategories();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            loadCategories();
        }
        private void loadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();

                    // Select all users (adjust columns as needed)
                    string query = @"SELECT id,name,description,is_active FROM categories";

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int categoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                EditCategory editCategoryForm = new EditCategory(categoryId);
                editCategoryForm.ShowDialog(); // modal so user finishes editing first
                loadCategories();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                                    SELECT 
                                        id,
                                        name,
                                        description,
                                        is_active
                                    FROM Categories
                                    WHERE 
                                        name LIKE @search
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string searchValue = "%" + txtSearch.Text.Trim() + "%";
                        cmd.Parameters.AddWithValue("@search", searchValue);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            // Hide the ID column
                            if (dataGridView1.Columns.Contains("id"))
                                dataGridView1.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching users: " + ex.Message);
            }
        }
    }
}
