namespace PAKOPointOfSale.Transactions
{
    partial class TransactionsList
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dtgvTransactions = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            invoicenumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatamountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatablesalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatexemptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sub_total = new DataGridViewTextBoxColumn();
            grandtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentmethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cash_received = new DataGridViewTextBoxColumn();
            cash_change = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transaction_type = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            return_number = new DataGridViewTextBoxColumn();
            void_number = new DataGridViewTextBoxColumn();
            salesinvoiceitemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            viewInvoice = new DataGridViewButtonColumn();
            transactionBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            lblsearchproduct = new Label();
            grpFilter = new GroupBox();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            btnClearFilter = new Button();
            label5 = new Label();
            cmbTransactionType = new ComboBox();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvTransactions
            // 
            dtgvTransactions.AllowUserToAddRows = false;
            dtgvTransactions.AllowUserToDeleteRows = false;
            dtgvTransactions.AutoGenerateColumns = false;
            dtgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTransactions.Columns.AddRange(new DataGridViewColumn[] { id, invoicenumberDataGridViewTextBoxColumn, vatamountDataGridViewTextBoxColumn, vatablesalesDataGridViewTextBoxColumn, vatexemptDataGridViewTextBoxColumn, sub_total, grandtotalDataGridViewTextBoxColumn, paymentmethodDataGridViewTextBoxColumn, cash_received, cash_change, statusDataGridViewTextBoxColumn, transaction_type, created_at, return_number, void_number, salesinvoiceitemsDataGridViewTextBoxColumn, viewInvoice });
            dtgvTransactions.DataSource = transactionBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgvTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            dtgvTransactions.Location = new Point(12, 147);
            dtgvTransactions.Name = "dtgvTransactions";
            dtgvTransactions.ReadOnly = true;
            dtgvTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dtgvTransactions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTransactions.Size = new Size(1343, 610);
            dtgvTransactions.TabIndex = 0;
            dtgvTransactions.CellContentClick += dtgvTransactions_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            invoicenumberDataGridViewTextBoxColumn.HeaderText = "Invoice Number";
            invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            invoicenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatamountDataGridViewTextBoxColumn
            // 
            vatamountDataGridViewTextBoxColumn.DataPropertyName = "vat_amount";
            vatamountDataGridViewTextBoxColumn.HeaderText = "vat_amount";
            vatamountDataGridViewTextBoxColumn.Name = "vatamountDataGridViewTextBoxColumn";
            vatamountDataGridViewTextBoxColumn.ReadOnly = true;
            vatamountDataGridViewTextBoxColumn.Visible = false;
            // 
            // vatablesalesDataGridViewTextBoxColumn
            // 
            vatablesalesDataGridViewTextBoxColumn.DataPropertyName = "vatable_sales";
            vatablesalesDataGridViewTextBoxColumn.HeaderText = "vatable_sales";
            vatablesalesDataGridViewTextBoxColumn.Name = "vatablesalesDataGridViewTextBoxColumn";
            vatablesalesDataGridViewTextBoxColumn.ReadOnly = true;
            vatablesalesDataGridViewTextBoxColumn.Visible = false;
            // 
            // vatexemptDataGridViewTextBoxColumn
            // 
            vatexemptDataGridViewTextBoxColumn.DataPropertyName = "vat_exempt";
            vatexemptDataGridViewTextBoxColumn.HeaderText = "vat_exempt";
            vatexemptDataGridViewTextBoxColumn.Name = "vatexemptDataGridViewTextBoxColumn";
            vatexemptDataGridViewTextBoxColumn.ReadOnly = true;
            vatexemptDataGridViewTextBoxColumn.Visible = false;
            // 
            // sub_total
            // 
            sub_total.DataPropertyName = "sub_total";
            sub_total.HeaderText = "Sub Total";
            sub_total.Name = "sub_total";
            sub_total.ReadOnly = true;
            // 
            // grandtotalDataGridViewTextBoxColumn
            // 
            grandtotalDataGridViewTextBoxColumn.DataPropertyName = "grand_total";
            grandtotalDataGridViewTextBoxColumn.HeaderText = "Grand Total";
            grandtotalDataGridViewTextBoxColumn.Name = "grandtotalDataGridViewTextBoxColumn";
            grandtotalDataGridViewTextBoxColumn.ReadOnly = true;
            grandtotalDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            paymentmethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            paymentmethodDataGridViewTextBoxColumn.Visible = false;
            // 
            // cash_received
            // 
            cash_received.DataPropertyName = "cash_received";
            cash_received.HeaderText = "Cash Received";
            cash_received.Name = "cash_received";
            cash_received.ReadOnly = true;
            // 
            // cash_change
            // 
            cash_change.DataPropertyName = "cash_change";
            cash_change.HeaderText = "Change";
            cash_change.Name = "cash_change";
            cash_change.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // transaction_type
            // 
            transaction_type.DataPropertyName = "transaction_type";
            transaction_type.HeaderText = "Transaction Type";
            transaction_type.Name = "transaction_type";
            transaction_type.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Transaction Date";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // return_number
            // 
            return_number.DataPropertyName = "return_number";
            return_number.HeaderText = "Return Number";
            return_number.Name = "return_number";
            return_number.ReadOnly = true;
            return_number.Visible = false;
            // 
            // void_number
            // 
            void_number.DataPropertyName = "void_number";
            void_number.HeaderText = "Void Number";
            void_number.Name = "void_number";
            void_number.ReadOnly = true;
            void_number.Visible = false;
            // 
            // salesinvoiceitemsDataGridViewTextBoxColumn
            // 
            salesinvoiceitemsDataGridViewTextBoxColumn.DataPropertyName = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.HeaderText = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.Name = "salesinvoiceitemsDataGridViewTextBoxColumn";
            salesinvoiceitemsDataGridViewTextBoxColumn.ReadOnly = true;
            salesinvoiceitemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewInvoice
            // 
            viewInvoice.HeaderText = "";
            viewInvoice.Name = "viewInvoice";
            viewInvoice.ReadOnly = true;
            viewInvoice.Text = "View Transaction";
            viewInvoice.UseColumnTextForButtonValue = true;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 92);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 2;
            label1.Text = "Search Invoice Number:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 111);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(229, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1264, 105);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1370, 86);
            pictureBox2.TabIndex = 113;
            pictureBox2.TabStop = false;
            // 
            // lblsearchproduct
            // 
            lblsearchproduct.AutoSize = true;
            lblsearchproduct.BackColor = Color.DimGray;
            lblsearchproduct.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(535, 11);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(399, 60);
            lblsearchproduct.TabIndex = 115;
            lblsearchproduct.Text = "TRANSACTIONS LIST";
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(label4);
            grpFilter.Controls.Add(dtpTo);
            grpFilter.Controls.Add(label3);
            grpFilter.Controls.Add(dtpFrom);
            grpFilter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFilter.ForeColor = Color.Black;
            grpFilter.Location = new Point(265, 91);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(533, 50);
            grpFilter.TabIndex = 152;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(270, 23);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 158;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(326, 18);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(195, 25);
            dtpTo.TabIndex = 157;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 156;
            label3.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(77, 17);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(187, 25);
            dtpFrom.TabIndex = 155;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(255, 128, 128);
            btnClearFilter.FlatStyle = FlatStyle.Popup;
            btnClearFilter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilter.ForeColor = Color.Black;
            btnClearFilter.Location = new Point(1078, 106);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(87, 28);
            btnClearFilter.TabIndex = 164;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(827, 93);
            label5.Name = "label5";
            label5.Size = new Size(146, 17);
            label5.TabIndex = 163;
            label5.Text = "Filter Transaction Type:";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = SystemColors.ButtonFace;
            cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "All", "Sales Invoice", "Void", "Return" });
            cmbTransactionType.Location = new Point(821, 111);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(238, 23);
            cmbTransactionType.TabIndex = 162;
            cmbTransactionType.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Gold;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(1171, 105);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(87, 28);
            btnExport.TabIndex = 153;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // TransactionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1368, 769);
            Controls.Add(btnExport);
            Controls.Add(grpFilter);
            Controls.Add(btnClearFilter);
            Controls.Add(lblsearchproduct);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cmbTransactionType);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dtgvTransactions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            WindowState = FormWindowState.Maximized;
            Load += TransactionsList_Load;
            KeyDown += TransactionsList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvTransactions;
        //private TextBox txtSearch;
        private Label label1;
        private BindingSource transactionBindingSource;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button btnClose;
        private Label label5;
        private TextBox txtSearch;
        private Button button1;
        private Label lblsearchproduct;
        private GroupBox grpFilter;
        private Label label4;
        private DateTimePicker dtpTo;
        private Label label3;
        private DateTimePicker dtpFrom;
        private ComboBox cmbTransactionType;
        private Button btnClearFilter;
        private Button btnExport;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatamountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatablesalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatexemptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sub_total;
        private DataGridViewTextBoxColumn grandtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cash_received;
        private DataGridViewTextBoxColumn cash_change;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transaction_type;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn return_number;
        private DataGridViewTextBoxColumn void_number;
        private DataGridViewTextBoxColumn salesinvoiceitemsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn viewInvoice;
    }
}