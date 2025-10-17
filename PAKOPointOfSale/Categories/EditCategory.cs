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
    public partial class EditCategory : Form
    {
        private int _categoryId;
        private string _categoryName;

        public EditCategory(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadCategoryData()
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT name,description,is_active FROM categories where id=@id";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _categoryId);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _categoryName = reader["name"].ToString();
                                txtCategoryName.Text = reader["name"].ToString();
                                txtDescription.Text = reader["description"].ToString();
                                chkIsActive.Checked = Convert.ToBoolean(reader["is_active"]);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateForm())
                {
                    return;
                }
                // Connection string from Program.cs
                string connString = PAKOPointOfSale.Program.ConnString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Categories
                        SET 
                            name = @name,
                            description = @description,
                            is_active = @is_active
                        WHERE id = @id
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@is_active", chkIsActive.Checked);
                        cmd.Parameters.AddWithValue("@id", _categoryId);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category updated successfully!");
                            this.Close(); // close the EditUser form
                        }
                        else
                        {
                            MessageBox.Show("Category not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message);
            }
        }
        public bool validateForm()
        {

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.");
                txtCategoryName.Focus();
                return false;
            }

            if (_categoryName != txtCategoryName.Text)
            {
                if (isAlreadyExists() == true)
                {

                    MessageBox.Show("Category name already exists. Please choose another one.");
                    txtCategoryName.Focus();
                    return false;
                }
            }


            return true;
        }

        public bool isAlreadyExists()
        {

            string connString = PAKOPointOfSale.Program.ConnString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Categories WHERE name = @name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
