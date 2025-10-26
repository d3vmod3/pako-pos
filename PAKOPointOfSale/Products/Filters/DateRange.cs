using Microsoft.EntityFrameworkCore.Storage;

namespace PAKOPointOfSale.Products.Filters
{
    public partial class DateRange : Form
    {
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
        public string formTitle = "";
        public DateRange(string _formTitle)
        {
            InitializeComponent();
            this.Text = _formTitle;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Capture selected dates
            DateFrom = dtFrom.Value.Date;
            DateTo = dtTo.Value.Date;

            // Ensure From <= To
            if (DateFrom > DateTo)
            {
                MessageBox.Show("The start date cannot be later than the end date.",
                                "Invalid Date Range",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DateRange_Load(object sender, EventArgs e)
        {
            dtTo.MaxDate = DateTime.Today;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}