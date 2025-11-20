using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using PAKOPointOfSale.Model;

namespace PAKOPointOfSale.Transactions
{
    public partial class ViewAdjustmentReason : Form
    {
        private int _transaction_id;
        private string _invoice_number;
        private string _transaction_type;

        public ViewAdjustmentReason(int transaction_id, string invoice_number, string transaction_type)
        {
            _transaction_id = transaction_id;
            _invoice_number = invoice_number;
            _transaction_type = transaction_type;
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void ViewAdjustmentReason_Load(object sender, EventArgs e)
        {
            // Load the reason into txtReason.Text
            string reason = GetReason();
            txtReason.Text = reason;
        }

        private string GetReason()
        {
            string reason = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnString))
                {
                    conn.Open();
                    string query = queryString();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", _transaction_id);
                        cmd.Parameters.AddWithValue("@invoice_number", _invoice_number);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            reason = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reason: " + ex.Message);
            }

            return reason;
        }

        private string queryString()
        {
            // If transaction_type is "Void", get reason from Transactions table
            if (_transaction_type.Equals("Void", StringComparison.OrdinalIgnoreCase))
            {
                return "SELECT TOP 1 reason FROM VoidTransactions WHERE invoice_number = @invoice_number AND transaction_id = @transaction_id";
            }
            else
            {
                // Otherwise, get reason from ReturnTransactions table
                return "SELECT TOP 1 reason FROM ReturnTransactions WHERE invoice_number = @invoice_number AND transaction_id = @transaction_id";
            }
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAdjustmentReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }
    }
}
