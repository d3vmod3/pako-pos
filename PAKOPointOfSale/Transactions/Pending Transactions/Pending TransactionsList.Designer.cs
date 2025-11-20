namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    partial class ParkTransactionsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgvParkedTransactions = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            park_number = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            sub_total = new DataGridViewTextBoxColumn();
            grandtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentmethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashreceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashchangeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            remarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactiontypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            settle = new DataGridViewButtonColumn();
            salesinvoiceitemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cancel = new DataGridViewButtonColumn();
            transactionBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvParkedTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgvParkedTransactions
            // 
            dtgvParkedTransactions.AllowUserToAddRows = false;
            dtgvParkedTransactions.AllowUserToDeleteRows = false;
            dtgvParkedTransactions.AutoGenerateColumns = false;
            dtgvParkedTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvParkedTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParkedTransactions.Columns.AddRange(new DataGridViewColumn[] { id, park_number, vat_amount, vatable_sales, vat_exempt, sub_total, grandtotalDataGridViewTextBoxColumn, paymentmethodDataGridViewTextBoxColumn, cashreceivedDataGridViewTextBoxColumn, cashchangeDataGridViewTextBoxColumn, status, remarksDataGridViewTextBoxColumn, transactiontypeDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, settle, salesinvoiceitemsDataGridViewTextBoxColumn, cancel });
            dtgvParkedTransactions.DataSource = transactionBindingSource;
            dtgvParkedTransactions.Location = new Point(12, 49);
            dtgvParkedTransactions.Name = "dtgvParkedTransactions";
            dtgvParkedTransactions.ReadOnly = true;
            dtgvParkedTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dtgvParkedTransactions.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvParkedTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvParkedTransactions.Size = new Size(953, 419);
            dtgvParkedTransactions.TabIndex = 0;
            dtgvParkedTransactions.CellContentClick += dtgvParkedTransactions_CellContentClick;
            dtgvParkedTransactions.CellFormatting += dtgvParkedTransactions_CellFormatting;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 43;
            // 
            // park_number
            // 
            park_number.DataPropertyName = "park_number";
            park_number.HeaderText = "Pending Number";
            park_number.MinimumWidth = 150;
            park_number.Name = "park_number";
            park_number.ReadOnly = true;
            park_number.Width = 150;
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "vat_amount";
            vat_amount.Name = "vat_amount";
            vat_amount.ReadOnly = true;
            vat_amount.Visible = false;
            vat_amount.Width = 95;
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "vatable_sales";
            vatable_sales.Name = "vatable_sales";
            vatable_sales.ReadOnly = true;
            vatable_sales.Visible = false;
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "vat_exempt";
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            vat_exempt.Visible = false;
            vat_exempt.Width = 92;
            // 
            // sub_total
            // 
            sub_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sub_total.DataPropertyName = "sub_total";
            sub_total.HeaderText = "Sub Total";
            sub_total.MinimumWidth = 90;
            sub_total.Name = "sub_total";
            sub_total.ReadOnly = true;
            sub_total.Width = 90;
            // 
            // grandtotalDataGridViewTextBoxColumn
            // 
            grandtotalDataGridViewTextBoxColumn.DataPropertyName = "grand_total";
            grandtotalDataGridViewTextBoxColumn.HeaderText = "Total";
            grandtotalDataGridViewTextBoxColumn.Name = "grandtotalDataGridViewTextBoxColumn";
            grandtotalDataGridViewTextBoxColumn.ReadOnly = true;
            grandtotalDataGridViewTextBoxColumn.Width = 58;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            paymentmethodDataGridViewTextBoxColumn.Visible = false;
            paymentmethodDataGridViewTextBoxColumn.Width = 126;
            // 
            // cashreceivedDataGridViewTextBoxColumn
            // 
            cashreceivedDataGridViewTextBoxColumn.DataPropertyName = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.HeaderText = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.Name = "cashreceivedDataGridViewTextBoxColumn";
            cashreceivedDataGridViewTextBoxColumn.ReadOnly = true;
            cashreceivedDataGridViewTextBoxColumn.Visible = false;
            cashreceivedDataGridViewTextBoxColumn.Width = 105;
            // 
            // cashchangeDataGridViewTextBoxColumn
            // 
            cashchangeDataGridViewTextBoxColumn.DataPropertyName = "cash_change";
            cashchangeDataGridViewTextBoxColumn.HeaderText = "cash_change";
            cashchangeDataGridViewTextBoxColumn.Name = "cashchangeDataGridViewTextBoxColumn";
            cashchangeDataGridViewTextBoxColumn.ReadOnly = true;
            cashchangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 64;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            remarksDataGridViewTextBoxColumn.Width = 77;
            // 
            // transactiontypeDataGridViewTextBoxColumn
            // 
            transactiontypeDataGridViewTextBoxColumn.DataPropertyName = "transaction_type";
            transactiontypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            transactiontypeDataGridViewTextBoxColumn.MinimumWidth = 150;
            transactiontypeDataGridViewTextBoxColumn.Name = "transactiontypeDataGridViewTextBoxColumn";
            transactiontypeDataGridViewTextBoxColumn.ReadOnly = true;
            transactiontypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Pending";
            createdatDataGridViewTextBoxColumn.MinimumWidth = 120;
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            createdatDataGridViewTextBoxColumn.Width = 120;
            // 
            // settle
            // 
            settle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            settle.DataPropertyName = "settle";
            settle.HeaderText = "";
            settle.MinimumWidth = 100;
            settle.Name = "settle";
            settle.ReadOnly = true;
            settle.Text = "Settle";
            settle.UseColumnTextForButtonValue = true;
            // 
            // salesinvoiceitemsDataGridViewTextBoxColumn
            // 
            salesinvoiceitemsDataGridViewTextBoxColumn.DataPropertyName = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.HeaderText = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.Name = "salesinvoiceitemsDataGridViewTextBoxColumn";
            salesinvoiceitemsDataGridViewTextBoxColumn.ReadOnly = true;
            salesinvoiceitemsDataGridViewTextBoxColumn.Visible = false;
            salesinvoiceitemsDataGridViewTextBoxColumn.Width = 134;
            // 
            // cancel
            // 
            cancel.DataPropertyName = "cancel";
            cancel.HeaderText = "";
            cancel.MinimumWidth = 100;
            cancel.Name = "cancel";
            cancel.ReadOnly = true;
            cancel.Resizable = DataGridViewTriState.True;
            cancel.SortMode = DataGridViewColumnSortMode.Automatic;
            cancel.Text = "Cancel";
            cancel.UseColumnTextForButtonValue = true;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(157, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Pending Number:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(881, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(84, 24);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ParkTransactionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(977, 480);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dtgvParkedTransactions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParkTransactionsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkTransactionsList";
            Load += ParkTransactionsList_Load_1;
            KeyDown += ParkTransactionsList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtgvParkedTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvParkedTransactions;
        private BindingSource transactionBindingSource;
        private TextBox txtSearch;
        private Label label1;
        private Button btnClose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn park_number;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn sub_total;
        private DataGridViewTextBoxColumn grandtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashreceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashchangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactiontypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn settle;
        private DataGridViewTextBoxColumn salesinvoiceitemsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn cancel;
    }
}