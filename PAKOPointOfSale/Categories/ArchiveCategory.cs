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

namespace PAKOPointOfSale.Categories
{
    public partial class ArchiveCategory : Form
    {
        private int _categoryId;
        public ArchiveCategory(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }
        private void LoadCategoryData()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT name,description FROM categories where id=@id";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _categoryId);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCategoryName.Text = reader["name"].ToString();
                                txtDescription.Text = reader["description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Category not found.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = "UPDATE Categories SET is_active = @isActive WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@isActive", 0); // 1 = active, 0 = inactive
                        cmd.Parameters.AddWithValue("@id", _categoryId); // _userId should be set before opening this form

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category activated successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Category not found or already active.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
