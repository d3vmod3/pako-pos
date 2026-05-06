using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Void
{
    public partial class VoidReason : Form
    {
        public event Action<string> Reason;
        public VoidReason()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reason?.Invoke(txtReason.Text.Trim());
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Transactions List > Set Void Reason",
                description: "Clicked Submit button",
                payload: new
                {
                    reason=txtReason.Text.Trim(),
                }
            );
            this.Close();
        }

        private void VoidReason_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Transactions List > Set Void Reason",
                description: "Clicked Close button",
                payload: null
            );
            this.Close();
        }

        private void VoidReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
