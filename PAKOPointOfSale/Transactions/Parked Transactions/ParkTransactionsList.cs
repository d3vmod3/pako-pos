using Microsoft.Data.SqlClient;
using PAKOPointOfSale.Categories;
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
    public partial class ParkTransactionsList : Form
    {
        private DataTable parkedTransactionsTable;
        public int TransactionId { get; private set; }
        public string ParkNumber { get; private set; }
        public ParkTransactionsList()
        {
            InitializeComponent();
        }
        private void LoadParkedTransactions()
        {
            try
            {
                string connString = Program.ConnString; // reuse your global connection string

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            id,
                            RIGHT(REPLICATE('0', 10) + CAST(id AS VARCHAR(20)), 20) AS TransactionID,
                            invoice_number,
                            sub_total,
                            vat_amount,
                            vatable_sales,
                            vat_exempt,
                            grand_total,
                            payment_method,
                            cash_received,
                            cash_change,
                            status,
                            park_number,
                            transaction_type,
                            remarks,
                            status,
                            created_at
                        FROM Transactions
                        WHERE invoice_number is NULL
                        AND park_number IS NOT NULL
                        AND status='parked'
                        ORDER BY created_at DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        parkedTransactionsTable = new DataTable();
                        adapter.Fill(parkedTransactionsTable);
                        dtgvParkedTransactions.DataSource = parkedTransactionsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        private void ParkTransactionsList_Load_1(object sender, EventArgs e)
        {
            LoadParkedTransactions();
        }

        private void dtgvParkedTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Get the ID of the selected transaction
            int transactionId = Convert.ToInt32(dtgvParkedTransactions.Rows[e.RowIndex].Cells["id"].Value);
            string park_number = dtgvParkedTransactions.Rows[e.RowIndex].Cells["park_number"].Value.ToString();

            if (e.ColumnIndex == dtgvParkedTransactions.Columns["finalized"].Index)
            {
                TransactionId = transactionId;
                ParkNumber = park_number;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (parkedTransactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes

            if (string.IsNullOrEmpty(filter))
            {
                dtgvParkedTransactions.DataSource = parkedTransactionsTable;
            }
            else
            {
                string rowFilter = $@"
                park_number LIKE '%{filter}%' OR 
                remarks LIKE '%{filter}%'
                ";

                DataView dv = new DataView(parkedTransactionsTable);
                dv.RowFilter = rowFilter;
                dtgvParkedTransactions.DataSource = dv;
            }
        }
    }
}
