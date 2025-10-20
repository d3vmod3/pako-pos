using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    public partial class Remarks : Form
    {
        public string RemarksValue { get; private set; }
        public Remarks()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtRemarks.Text.Trim() == "")
            {
                
                MessageBox.Show("Please input remarks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RemarksValue = txtRemarks.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
