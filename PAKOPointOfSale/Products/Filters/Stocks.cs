using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Products.Filters
{
    public partial class Stocks : Form
    {
        public decimal SelectedQuantity { get; private set; } = 0;
        public Stocks()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedQuantity = num_quantity.Value;

            // close the dialog with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stocks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
