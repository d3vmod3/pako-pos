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

namespace PAKOPointOfSale.Transactions
{
    public partial class TransactionsList : Form
    {
        private DataTable transactionsTable;
        public TransactionsList()
        {
            InitializeComponent();
        }

        private void TransactionsList_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void LoadTransactions()
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
                            created_at
                        FROM Transactions
                        ORDER BY created_at DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        transactionsTable = new DataTable();
                        adapter.Fill(transactionsTable);
                        dtgvTransactions.DataSource = transactionsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
        }

        private void dtgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int id = Convert.ToInt32(dtgvTransactions.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dtgvTransactions.Columns["viewInvoice"].Index)
            {
                Transactions.lbViewTransaction viewTransactionForm = new Transactions.lbViewTransaction(id);
                viewTransactionForm.ShowDialog(); // modal so user finishes editing first
                LoadTransactions();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (transactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dtgvTransactions.DataSource = transactionsTable;
            }
            else
            {
                // Filter by multiple columns (product name, code, SKU, brand)
                string rowFilter = $"invoice_number LIKE '%{filter}%' ";
                DataView dv = new DataView(transactionsTable);
                dv.RowFilter = rowFilter;
                dtgvTransactions.DataSource = dv;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (transactionsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dtgvTransactions.DataSource = transactionsTable;
            }
            else
            {
                // Filter by multiple columns (product name, code, SKU, brand)
                string rowFilter = $"invoice_number LIKE '%{filter}%' ";
                DataView dv = new DataView(transactionsTable);
                dv.RowFilter = rowFilter;
                dtgvTransactions.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
