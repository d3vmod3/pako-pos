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
using WinFormsApp1.Model;

namespace PAKOPointOfSale.Transactions
{
    public partial class SalesInvoice : Form
    {
        private DataTable productsTable;

        public SalesInvoice()
        {
            InitializeComponent();
        }

        private void SalesInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            Transactions.SearchProduct searchProductForm = new Transactions.SearchProduct(this);
            searchProductForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Check if the clicked column is the "Remove" button column
            if (dtgvCart.Columns[e.ColumnIndex].Name == "remove") // Replace "Remove" with your button column name
            {
                // Optional: Confirm before removing
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this item?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dtgvCart.Rows.RemoveAt(e.RowIndex);

                    // Optional: Update grand total here if needed
                    ComputeGrandTotal();
                }
            }
        }
        public void AddProductToCart(int id, string product, string brand, string unit, decimal price, string category, int quantity)
        {
            // Create a new row in your DataGridView (e.g., dgvCart)
            dtgvCart.Rows.Add(id, product, brand, unit, quantity, price, category);
            ComputeGrandTotal();
        }

        private void ComputeGrandTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgvCart.Rows)
            {
                if (row.Cells["unit_price"].Value != null && row.Cells["appliedQty"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["unit_price"].Value);
                    int qty = Convert.ToInt32(row.Cells["appliedQty"].Value);
                    total += price * qty;
                }
            }

            lblTotal.Text = total.ToString("#,##0.00"); // or just total.ToString("N2")
        }

        private void num_CashAmount_ValueChanged(object sender, EventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(num_CashAmount.Value) - Convert.ToDecimal(lblTotal.Text));
        }

        private void num_CashAmount_KeyUp(object sender, KeyEventArgs e)
        {
            lblChange.Text = Convert.ToString(Convert.ToDecimal(num_CashAmount.Value) - Convert.ToDecimal(lblTotal.Text));
        }

        private void dtgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ComputeGrandTotal();
        }

        private void dtgvCart_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void QuantityColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check if the current column is "Quantity"
            if (dtgvCart.CurrentCell.ColumnIndex == dtgvCart.Columns["appliedQty"].Index)
            {
                // Unsubscribe previous handlers to avoid duplicates
                e.Control.KeyPress -= QuantityColumn_KeyPress;
                e.Control.KeyPress += QuantityColumn_KeyPress;
            }
            else
            {
                // Remove handler for all other columns
                e.Control.KeyPress -= QuantityColumn_KeyPress;
            }
        }

        private void dtgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ComputeGrandTotal();
        }
    }
}
