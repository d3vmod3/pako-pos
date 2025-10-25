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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsList));
            dtgvTransactions = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            invoicenumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatamountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatablesalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatexemptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            grandtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentmethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashreceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashchangeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            pictureBox1 = new PictureBox();
            lblsearchproduct = new Label();
            pictureBox3 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvTransactions
            // 
            dtgvTransactions.AllowUserToAddRows = false;
            dtgvTransactions.AllowUserToDeleteRows = false;
            dtgvTransactions.AutoGenerateColumns = false;
            dtgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTransactions.Columns.AddRange(new DataGridViewColumn[] { id, invoicenumberDataGridViewTextBoxColumn, vatamountDataGridViewTextBoxColumn, vatablesalesDataGridViewTextBoxColumn, vatexemptDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn, grandtotalDataGridViewTextBoxColumn, paymentmethodDataGridViewTextBoxColumn, cashreceivedDataGridViewTextBoxColumn, cashchangeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, transaction_type, created_at, return_number, void_number, salesinvoiceitemsDataGridViewTextBoxColumn, viewInvoice });
            dtgvTransactions.DataSource = transactionBindingSource;
            dtgvTransactions.Location = new Point(13, 208);
            dtgvTransactions.Name = "dtgvTransactions";
            dtgvTransactions.ReadOnly = true;
            dtgvTransactions.RowHeadersVisible = false;
            dtgvTransactions.Size = new Size(1343, 467);
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
            // subtotalDataGridViewTextBoxColumn
            // 
            subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            subtotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            subtotalDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // cashreceivedDataGridViewTextBoxColumn
            // 
            cashreceivedDataGridViewTextBoxColumn.DataPropertyName = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.HeaderText = "Cash Received";
            cashreceivedDataGridViewTextBoxColumn.Name = "cashreceivedDataGridViewTextBoxColumn";
            cashreceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashchangeDataGridViewTextBoxColumn
            // 
            cashchangeDataGridViewTextBoxColumn.DataPropertyName = "cash_change";
            cashchangeDataGridViewTextBoxColumn.HeaderText = "Change";
            cashchangeDataGridViewTextBoxColumn.Name = "cashchangeDataGridViewTextBoxColumn";
            cashchangeDataGridViewTextBoxColumn.ReadOnly = true;
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
            label1.BackColor = Color.Khaki;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 118);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Invoice Number:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 143);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(288, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1281, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 22);
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
            pictureBox2.Size = new Size(1370, 103);
            pictureBox2.TabIndex = 113;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 114;
            pictureBox1.TabStop = false;
            // 
            // lblsearchproduct
            // 
            lblsearchproduct.AutoSize = true;
            lblsearchproduct.BackColor = Color.DimGray;
            lblsearchproduct.Font = new Font("Impact", 47.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(558, 14);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(524, 76);
            lblsearchproduct.TabIndex = 115;
            lblsearchproduct.Text = "TRANSACTIONS LIST";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-21, 683);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 151;
            pictureBox3.TabStop = false;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(label4);
            grpFilter.Controls.Add(dtpTo);
            grpFilter.Controls.Add(label3);
            grpFilter.Controls.Add(dtpFrom);
            grpFilter.ForeColor = Color.Black;
            grpFilter.Location = new Point(423, 116);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(627, 50);
            grpFilter.TabIndex = 152;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 21);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 158;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(390, 16);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(231, 23);
            dtpTo.TabIndex = 157;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 156;
            label3.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(77, 15);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(251, 23);
            dtpFrom.TabIndex = 155;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(255, 128, 128);
            btnClearFilter.FlatStyle = FlatStyle.Popup;
            btnClearFilter.ForeColor = Color.Black;
            btnClearFilter.Location = new Point(975, 172);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(75, 23);
            btnClearFilter.TabIndex = 164;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 176);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 163;
            label5.Text = "Filter Transaction Type:";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = SystemColors.ButtonFace;
            cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "All", "Sales Invoice", "Void", "Return" });
            cmbTransactionType.Location = new Point(554, 172);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(328, 23);
            cmbTransactionType.TabIndex = 162;
            cmbTransactionType.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Gold;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(1192, 127);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 22);
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
            Controls.Add(pictureBox3);
            Controls.Add(btnClearFilter);
            Controls.Add(lblsearchproduct);
            Controls.Add(pictureBox1);
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
            Load += TransactionsList_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
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
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn grandtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashreceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashchangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transaction_type;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn return_number;
        private DataGridViewTextBoxColumn void_number;
        private DataGridViewTextBoxColumn salesinvoiceitemsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn viewInvoice;
    }
}