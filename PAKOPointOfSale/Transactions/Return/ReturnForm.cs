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
    public partial class ReturnForm : Form
    {
        private int _id;
        private string _invoiceNumber;
        public ReturnForm(int id, string invoiceNumber)
        {
            _id = id;
            _invoiceNumber = invoiceNumber;
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
