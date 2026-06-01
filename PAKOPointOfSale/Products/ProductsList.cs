using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PAKOPointOfSale.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace PAKOPointOfSale.Products
{
    public partial class ProductsList : Form
    {
        private DataTable productsTable;
        private PrintDocument printDocument = new PrintDocument();
        private int currentRow = 0;
        private List<DataGridViewColumn> printableColumns;
        string[] defaultChecked =
        {
            "Barcode",
            "Product Name",
            "Brand",
            "Category",
            "Code",
            "Quantity",
            "Unit",
            "Unit Price",
            "Date Received",
            "Expiration Date"
        };
        public ProductsList()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products.AddProducts addProductForm = new Products.AddProducts();
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Products List",
                description: "Clicked Add button",
                payload: null
            );
            addProductForm.ShowDialog();
            LoadProducts();

        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            LoadProducts();
            loadPermissions();
            setDefaultDisplayedColumns();
            ApplyColumnVisibility();
        }

        public void setDefaultDisplayedColumns()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string item = checkedListBox1.Items[i].ToString();

                bool isChecked = defaultChecked.Contains(item);
                checkedListBox1.SetItemChecked(i, isChecked);
            }

        }
        private void loadPermissions()
        {
            if (!LoggedInUser.HasPermission("Products", "add"))
            {
                btnAdd.Visible = false;
            }
            if (!LoggedInUser.HasPermission("Products", "edit"))
            {
                if (dataGridView1.Columns.Contains("edit"))
                {
                    dataGridView1.Columns["edit"].Visible = false;
                }
            }

        }
        private void LoadProducts()
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    FORMAT(p.cost_price, 'N2') AS cost_price ,
                    FORMAT(p.unit_price, 'N2') AS unit_price ,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    ISNULL(s.name, 'Unknown') AS supplier_name,
                    ISNULL(c.name, 'Unknown') AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id

                ORDER BY p.created_at DESC;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        productsTable = new DataTable();
                        adapter.Fill(productsTable);
                        dataGridView1.DataSource = productsTable;
                    }

                    // Optional: auto-size columns
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns["edit"];
                c.FlatStyle = FlatStyle.Flat;
                c.DefaultCellStyle.ForeColor = Color.White;
                c.DefaultCellStyle.BackColor = Color.LightBlue;
                               dataGridView1.Columns["unit_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                //dataGridView1.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dataGridView1.Columns["cost_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            // Get the ID of the selected user
            int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                Products.EditProduct editProductForm = new Products.EditProduct(productId);
                editProductForm.ShowDialog(); // modal so user finishes editing first
                LoadProducts();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (productsTable == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''"); // escape single quotes
            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = productsTable;
            }
            else
            {
                // Filter by multiple columns (barcode,product name, code, SKU, brand)
                string rowFilter = $"product_name LIKE '%{filter}%' OR product_code LIKE '%{filter}%' OR sku LIKE '%{filter}%' OR product_brand LIKE '%{filter}%' OR barcode LIKE '%{filter}%'";
                DataView dv = new DataView(productsTable);
                dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Products List",
                description: "Clicked Close button",
                payload: null
            );
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {


            if (cmbFilterType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please choose filter type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFilterType.Focus();
                return;
            }
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Products List",
                description: "Clicked Filter button",
                payload: new
                {
                    filter_type = cmbFilterType.SelectedItem?.ToString()
                }
            );
            string selected = cmbFilterType.SelectedItem.ToString();
            if (selected == "Stock")
            {
                var filterStocksForm = new Products.Filters.Stocks();

                // Show as dialog and wait for user to press Filter
                if (filterStocksForm.ShowDialog() == DialogResult.OK)
                {
                    decimal filterQty = filterStocksForm.SelectedQuantity;
                    FilterProductsByStock(filterQty);
                }
            }
            else if (selected == "Date and Time")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Date Range");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "created_at");
                }
            }
            else if (selected == "Date Received")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Date Received");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "date_received");
                }
            }
            else if (selected == "Expiration Date")
            {
                var dateRangeForm = new Products.Filters.DateRange("Filter by Expiration Date");
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime dateFrom = dateRangeForm.DateFrom;
                    DateTime dateTo = dateRangeForm.DateTo;

                    FilterProductsByDateRange(dateFrom, dateTo, "date_expiration");
                }
            }
            else if (selected == "Status")
            {
                var filterStatusForm = new Products.Filters.Status();

                // Show as dialog and wait for user to press Filter
                if (filterStatusForm.ShowDialog() == DialogResult.OK)
                {
                    string status = filterStatusForm.StatusType;
                    FilterProductsByStatus(status = filterStatusForm.StatusType);
                }
            }
        }
        private void FilterProductsByStock(decimal maxQuantity)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.quantity <= @quantity
                ORDER BY p.quantity ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@quantity", maxQuantity);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }
        private void FilterProductsByStatus(string status)
        {
            string connString = PAKOPointOfSale.Program.ConnString;
            string query = @"
                SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.status = @status
                ORDER BY p.quantity ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }
        private void FilterProductsByDateRange(DateTime from, DateTime to, string dateField)
        {
            string connString = PAKOPointOfSale.Program.ConnString;

            string query = @"
                    SELECT 
                    p.id,
                    p.product_name,
                    p.product_brand,
                    p.barcode,
                    p.product_description,
                    p.product_code,
                    p.sku,
                    p.quantity,
                    p.unit_of_measurement,
                    p.cost_price,
                    p.unit_price,
                    p.remarks,
                    p.status,
                    p.date_received,
                    p.date_expiration,
                    p.created_at,
                    p.is_active,
                    s.name AS supplier_name,
                    c.name AS category_name
                FROM Products p
                LEFT JOIN SupplierDetails s ON p.supplier_id = s.id
                LEFT JOIN Categories c ON p.category_id = c.id
                WHERE p.date_received BETWEEN @from AND @to
                ORDER BY " + "p." + dateField + " ASC;";

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                DataTable dt = new DataTable();
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            LoadProducts();
            cmbFilterType.SelectedIndex = 0;
        }

        private string QuoteCsv(string input)
        {
            if (decimal.TryParse(input, out _) && input.Length >= 10)
                return $"=\"{input}\""; // Force Excel to treat it as string

            if (input.Contains(",") || input.Contains("\"") || input.Contains("\n"))
                return $"\"{input.Replace("\"", "\"\"")}\"";

            return input;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                ActivityLogs.Log(
                    user: LoggedInUser.FullName,
                    action: "click",
                    module: "Products List",
                    description: "Clicked Export button",
                    payload: new
                    {
                        status = "failed",
                        message = "No data to export."
                    }
                );
                return;
            }
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = $"Products_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                    sfd.Title = "Save as CSV";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                            {
                                var visibleColumns = dataGridView1.Columns
                                    .Cast<DataGridViewColumn>()
                                    .Where(c => c.Visible && !string.Equals(c.HeaderText, "", StringComparison.OrdinalIgnoreCase))
                                    .ToList();

                                // Write header
                                sw.WriteLine(string.Join(",", visibleColumns.Select(c => QuoteCsv(c.HeaderText))));

                                // Write rows
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        var cells = visibleColumns.Select(c =>
                                        {
                                            var value = row.Cells[c.Index].Value;

                                            // Prevent barcode scientific notation
                                            if
                                            (
                                                c.HeaderText.ToLower().Contains("barcode")
                                            )
                                            {
                                                value = "=\"" + value + "\""; // Keeps exact digits
                                            }

                                            if (value is DateTime dateValue)
                                            {
                                                return $"\"{dateValue:MM/dd/yyyy}\"";
                                            }

                                            if (value is bool isActive)
                                            {
                                                return $"\"{(isActive ? "Yes" : "No")}\"";
                                            }

                                            return $"\"{value?.ToString().Replace("\"", "\"\"")}\"";
                                        });

                                        sw.WriteLine(string.Join(",", cells));
                                    }
                                }
                            }

                            ActivityLogs.Log(
                                user: LoggedInUser.FullName,
                                action: "click",
                                module: "Products List",
                                description: "Saved CSV File",
                                payload: new
                                {
                                    file = sfd.FileName
                                }
                            );

                            var result = MessageBox.Show("CSV exported successfully!\nDo you want to open it now?", "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {

                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                                {
                                    FileName = sfd.FileName,
                                    UseShellExecute = true
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        ActivityLogs.Log(
                            user: LoggedInUser.FullName,
                            action: "click",
                            module: "Products List",
                            description: "Clicked Cancel button",
                            payload: new
                            {
                                file = sfd.FileName
                            }
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printableColumns = dataGridView1.Columns
        .Cast<DataGridViewColumn>()
        .Where(c => c.Visible && !string.Equals(c.HeaderText, "", StringComparison.OrdinalIgnoreCase))
        .ToList();

            // Reset row index
            currentRow = 0;

            // Setup the PrintDocument
            printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.PrintPage += printDocument1_PrintPage;

            // Show Print Preview
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int y = topMargin;

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font cellFont = new Font("Arial", 9);
            Brush brush = Brushes.Black;

            // Draw title
            string title = "Product Inventory Report";
            e.Graphics.DrawString(title, titleFont, brush, leftMargin, y - 40);

            // Draw date/time
            string date = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
            e.Graphics.DrawString(date, new Font("Arial", 9, FontStyle.Italic), brush, leftMargin, y - 20);

            // Get visible columns excluding "Edit"
            var visibleColumns = dataGridView1.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible && !string.Equals(c.HeaderText, "", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Calculate total width and scaling
            int totalWidth = visibleColumns.Sum(c => c.Width);
            int printableWidth = e.MarginBounds.Width;
            float scale = totalWidth > printableWidth ? (float)printableWidth / totalWidth : 1.0f;

            // Center table horizontally
            int totalScaledWidth = (int)(totalWidth * scale);
            int leftStart = leftMargin + (e.MarginBounds.Width - totalScaledWidth) / 2;

            // Header row
            int x = leftStart;
            int headerHeight = 30;
            foreach (var col in visibleColumns)
            {
                int colWidth = (int)(col.Width * scale);
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, colWidth, headerHeight));
                e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, headerHeight);
                e.Graphics.DrawString(col.HeaderText, headerFont, brush,
                    new RectangleF(x + 4, y + 6, colWidth - 8, headerHeight),
                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                x += colWidth;
            }

            y += headerHeight;

            // Rows
            while (currentRow < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[currentRow];
                if (row.IsNewRow)
                {
                    currentRow++;
                    continue;
                }

                // Compute row height based on the tallest wrapped cell
                int rowHeight = 25;
                foreach (var col in visibleColumns)
                {
                    int colWidth = (int)(col.Width * scale);
                    string text = row.Cells[col.Index].Value?.ToString() ?? "";
                    SizeF textSize = e.Graphics.MeasureString(text, cellFont, colWidth - 8);
                    rowHeight = Math.Max(rowHeight, (int)textSize.Height + 10);
                }

                // Check page overflow
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                // Draw cells
                x = leftStart;
                foreach (var col in visibleColumns)
                {
                    int colWidth = (int)(col.Width * scale);
                    string text = row.Cells[col.Index].Value?.ToString() ?? "";

                    Rectangle rect = new Rectangle(x, y, colWidth, rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);

                    e.Graphics.DrawString(text, cellFont, brush,
                        new RectangleF(rect.X + 4, rect.Y + 4, rect.Width - 8, rect.Height - 8),
                        new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });

                    x += colWidth;
                }

                y += rowHeight;
                currentRow++;
            }

            e.HasMorePages = false;
        }

        private void ProductsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<string, string> columnMap = new Dictionary<string, string>()
        {
            { "Barcode", "barcode" },
            { "Product Name", "product_name" },
            { "Brand", "productbrandDataGridViewTextBoxColumn" },
            { "Category", "category_name" },
            { "Supplier", "supplier_name" },
            { "Description", "productdescriptionDataGridViewTextBoxColumn" },
            { "Code", "productcodeDataGridViewTextBoxColumn" },
            { "SKU", "skuDataGridViewTextBoxColumn" },
            { "Quantity", "quantity" },
            { "Unit", "unitofmeasurementDataGridViewTextBoxColumn" },
            { "Cost Price", "cost_price" },
            { "Unit Price", "unit_price" },
            { "Remarks", "remarksDataGridViewTextBoxColumn" },
            { "Status", "statusDataGridViewTextBoxColumn" },
            { "Date Received", "datereceivedDataGridViewTextBoxColumn" },
            { "Expiration Date", "dateexpirationDataGridViewTextBoxColumn" },
            { "Date Created", "createdatDataGridViewTextBoxColumn" }
        };

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                ApplyColumnVisibility();
            });
        }

        private void ApplyColumnVisibility()
        {
            foreach (var item in checkedListBox1.Items)
            {
                string displayName = item.ToString();

                if (columnMap.ContainsKey(displayName))
                {
                    string columnName = columnMap[displayName];

                    if (dataGridView1.Columns.Contains(columnName))
                    {
                        bool visible = checkedListBox1.CheckedItems.Contains(item);
                        dataGridView1.Columns[columnName].Visible = visible;
                    }
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
