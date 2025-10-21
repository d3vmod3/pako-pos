using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SuperAdminForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            DateTime today = DateTime.Today;

            // Calculate the start of the week (Monday)
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime weekStart = today.AddDays(-diff);

            // End of the week (Sunday)
            DateTime weekEnd = weekStart.AddDays(6);

            // Set the DateTimePickers
            dtpFrom.Value = weekStart;
            dtpTo.Value = weekEnd;

            // Load grid for this week
            LoadTop5SellingProducts(weekStart, weekEnd);
            comboBoxSalesFilter.SelectedItem = "Daily"; // default
            timeReloadData.Start();
        }

        private void LoadTop5SellingProducts(DateTime fromDate, DateTime toDate)
        {
            string connString = Program.ConnString;

            string query = @"
               SELECT TOP 5
                    p.product_name AS [product_name],
                    SUM(sii.quantity) - ISNULL((
                        SELECT SUM(ri.quantity)
                        FROM ReturnItems ri
                        INNER JOIN ReturnTransactions rt
                            ON ri.return_transaction_id = rt.id
                        WHERE ri.product_id = sii.product_id
                    ), 0) AS [total_quantity_sold],
                    SUM(sii.total_amount) - ISNULL((
                        SELECT SUM(ri.total_amount)
                        FROM ReturnItems ri
                        INNER JOIN ReturnTransactions rt
                            ON ri.return_transaction_id = rt.id
                        WHERE ri.product_id = sii.product_id
                    ), 0) AS [total_sales]
                FROM SalesInvoiceItems sii
                INNER JOIN Products p
                    ON sii.product_id = p.id
                INNER JOIN Transactions t
                    ON sii.transaction_id = t.id
                WHERE 
                    t.transaction_type = 'Sales Invoice'
                    AND t.status = 'success'
                    AND t.status = 'success'
                    AND t.created_at BETWEEN @from AND @to
                    AND t.invoice_number NOT IN (SELECT invoice_number FROM VoidTransactions)
                GROUP BY p.product_name,sii.product_id
                ORDER BY [total_quantity_sold] DESC;
            ";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@from", fromDate);
                cmd.Parameters.AddWithValue("@to", toDate.AddDays(1).AddTicks(-1));

                DataTable dt = new DataTable();
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                dtgvTop5SellingProducts.DataSource = dt;
            }
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Users", "view"))
            {
                MessageBox.Show("You do not have permission to view User Accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Users.UsersList usersListForm = new Users.UsersList();
            usersListForm.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Categories", "view"))
            {
                MessageBox.Show("You do not have permission to view Categories.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Categories.CategoriesList categoriesList = new Categories.CategoriesList();
            categoriesList.Show();
        }

        private void userAccessControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("User Access Control", "view"))
            {
                MessageBox.Show("You do not have permission to view User Access Control.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UAC.UAC userAccessControlForm = new UAC.UAC();
            userAccessControlForm.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Suppliers", "view"))
            {
                MessageBox.Show("You do not have permission to view Suppliers.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Supplier_Details.SuppliersList suppliersList = new Supplier_Details.SuppliersList();
            suppliersList.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Products", "view"))
            {
                MessageBox.Show("You do not have permission to view Products.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Products.ProductsList productsForm = new Products.ProductsList();
            productsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Sales Invoice", "view"))
            {
                MessageBox.Show("You do not have permission to create a Sales Invoice.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Transactions.SalesInvoice salesInvoiceForm = new Transactions.SalesInvoice();
            salesInvoiceForm.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInUser.HasPermission("Transactions", "view"))
            {
                MessageBox.Show("You do not have permission to view Transactions", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Transactions.TransactionsList transactionsListForm = new Transactions.TransactionsList();
            transactionsListForm.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadTop5SellingProducts(fromDate, toDate);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime fromDate;
            DateTime toDate = today;

            switch (comboBoxSalesFilter.SelectedItem.ToString())
            {
                case "Daily":
                    fromDate = today;
                    break;
                case "Weekly":
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                    fromDate = today.AddDays(-diff);
                    toDate = fromDate.AddDays(6);
                    break;
                case "Monthly":
                    fromDate = new DateTime(today.Year, today.Month, 1);
                    toDate = fromDate.AddMonths(1).AddDays(-1);
                    break;
                case "Yearly":
                    fromDate = new DateTime(today.Year, 1, 1);
                    toDate = new DateTime(today.Year, 12, 31);
                    break;
                default:
                    fromDate = today;
                    break;
            }



            LoadSales(fromDate, toDate);
        }

        private void LoadSales(DateTime fromDate, DateTime toDate)
        {
            string connString = Program.ConnString;

            string query = @"
                            SELECT
                                t.invoice_number,
                                -- Gross sales: sum of sold items, excluding voided transactions
                                SUM(sii.unit_price * sii.quantity) AS gross_sales,

                                -- Net sales: total amount minus returns
                                SUM(sii.total_amount) - ISNULL(SUM(rt_total.total_return_amount), 0) AS net_sales,

                                -- Grand total: gross sales minus returned amounts
                                SUM(sii.unit_price * sii.quantity) - ISNULL(SUM(rt_total.total_return_amount), 0) AS grand_total
                            FROM Transactions t
                            INNER JOIN SalesInvoiceItems sii ON sii.transaction_id = t.id
                            -- Derived table for total returns per invoice
                            LEFT JOIN (
                                SELECT rt.invoice_number, SUM(ri.total_amount) AS total_return_amount
                                FROM ReturnTransactions rt
                                INNER JOIN ReturnItems ri ON ri.return_transaction_id = rt.id
                                GROUP BY rt.invoice_number
                            ) rt_total ON rt_total.invoice_number = t.invoice_number
                            WHERE t.transaction_type = 'Sales Invoice'
                                  AND t.status = 'success'
                                  AND t.invoice_number NOT IN (SELECT invoice_number FROM VoidTransactions)
                            GROUP BY t.invoice_number
                            ORDER BY t.invoice_number;";
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@from", fromDate.Date);
                cmd.Parameters.AddWithValue("@to", toDate.Date.AddDays(1).AddTicks(-1));

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal grossSales = reader["gross_sales"] != DBNull.Value ? Convert.ToDecimal(reader["gross_sales"]) : 0;
                        decimal netSales = reader["net_sales"] != DBNull.Value ? Convert.ToDecimal(reader["net_sales"]) : 0;
                        decimal grandTotal = reader["grand_total"] != DBNull.Value ? Convert.ToDecimal(reader["grand_total"]) : 0;

                        lblGrossSales.Text = grossSales.ToString("C2");
                        lblNetSales.Text = netSales.ToString("C2");
                        lblGrandTotal.Text = grandTotal.ToString("C2");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime fromDate = dtpFromSales.Value.Date;
            DateTime toDate = dtpToSales.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadSales(fromDate, toDate);

        }

        private void timeReloadData_Tick(object sender, EventArgs e)
        {
            LoadSales(Convert.ToDateTime(dtpFromSales.Value.Date), Convert.ToDateTime(dtpToSales.Value.Date));
            LoadTop5SellingProducts(Convert.ToDateTime(dtpFrom.Value.Date), Convert.ToDateTime(dtpTo.Value.Date));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoggedInUser.Logout(this);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
