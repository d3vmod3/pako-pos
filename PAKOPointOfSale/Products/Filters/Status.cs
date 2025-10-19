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
    public partial class Status : Form
    {
        public string StatusType { get; private set; } = "";

        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem.ToString() != "")
            {
                StatusType = cmbStatus.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Choose Status",
                                 "Invalid Status",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }
    }
}
