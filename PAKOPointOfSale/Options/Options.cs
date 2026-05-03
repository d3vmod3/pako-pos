using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Options
{
    public partial class Options : Form
    {
        public string SelectedOption;
        public Options()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (SelectedOption != "")
            {
                switch (SelectedOption)
                {
                    case "Activity Logs":
                        grpBoxActivityLogs.Visible = true;
                        grpBoxBackupDatabase.Visible = false;
                        break;
                    case "Backup Database":
                        grpBoxActivityLogs.Visible = false;
                        grpBoxBackupDatabase.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Invalid option selected.");
                        break;
                }
            }
            
        }
    }
}
