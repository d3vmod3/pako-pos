using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAKOPointOfSale.Transactions.Discounts
{
    public partial class DiscountTypes : Form
    {
        public event Action<string> DiscountSelected;
        public DiscountTypes()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDiscountTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a discount type first.");
                return;
            }

            string selectedDiscount = cmbDiscountTypes.SelectedItem.ToString();

            // Fire the event and send the discount to the main form
            DiscountSelected?.Invoke(selectedDiscount);
        }

        private void DiscountTypes_Load(object sender, EventArgs e)
        {
            cmbDiscountTypes.SelectedIndex = 0;
        }
    }
}
