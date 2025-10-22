using System;
using System.Drawing;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Discounts
{
    public partial class DiscountTypes : Form
    {
        // Event passes both the discount name and the regular discount value
        public event Action<string, decimal?> DiscountSelected;

        public DiscountTypes()
        {
            InitializeComponent();
        }

        private void DiscountTypes_Load(object sender, EventArgs e)
        {
            cmbDiscountTypes.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbDiscountTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a discount type first.");
                return;
            }

            string selectedDiscount = cmbDiscountTypes.SelectedItem.ToString();
            decimal? regularDiscountAmount = null;

            if (selectedDiscount == "Regular Discount")
            {
                regularDiscountAmount = num_customDiscount.Value;
            }

            // Fire the event and send both values to the main form
            DiscountSelected?.Invoke(selectedDiscount, regularDiscountAmount);

            num_customDiscount.Value = 0.00m;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDiscountTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscountTypes.SelectedItem?.ToString() == "Regular Discount")
            {
                this.Size = new Size(341, 190);
                panel1.Location = new Point(12, 107);
                num_customDiscount.Focus();
            }
            else
            {
                this.Size = new Size(341, 166);
                panel1.Location = new Point(12, 78);
            }
        }
    }
}
