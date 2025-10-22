using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Return
{
   
    public partial class ReturnReason : Form
    {
        public event Action<string> Reason;
        public ReturnReason()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reason?.Invoke(txtReason.Text.Trim());
            this.Close();
        }

        private void ReturnReason_Load(object sender, EventArgs e)
        {
            
        }
    }
}
