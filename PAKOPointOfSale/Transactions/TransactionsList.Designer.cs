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
            salesinvoiceitemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            viewInvoice = new DataGridViewButtonColumn();
            transactionBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgvTransactions
            // 
            dtgvTransactions.AllowUserToAddRows = false;
            dtgvTransactions.AllowUserToDeleteRows = false;
            dtgvTransactions.AutoGenerateColumns = false;
            dtgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTransactions.Columns.AddRange(new DataGridViewColumn[] { id, invoicenumberDataGridViewTextBoxColumn, vatamountDataGridViewTextBoxColumn, vatablesalesDataGridViewTextBoxColumn, vatexemptDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn, grandtotalDataGridViewTextBoxColumn, paymentmethodDataGridViewTextBoxColumn, cashreceivedDataGridViewTextBoxColumn, cashchangeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, salesinvoiceitemsDataGridViewTextBoxColumn, viewInvoice });
            dtgvTransactions.DataSource = transactionBindingSource;
            dtgvTransactions.Location = new Point(12, 134);
            dtgvTransactions.Name = "dtgvTransactions";
            dtgvTransactions.ReadOnly = true;
            dtgvTransactions.Size = new Size(1346, 521);
            dtgvTransactions.TabIndex = 0;
            dtgvTransactions.CellContentClick += dtgvTransactions_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            invoicenumberDataGridViewTextBoxColumn.HeaderText = "Invoice Number";
            invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            invoicenumberDataGridViewTextBoxColumn.ReadOnly = true;
            invoicenumberDataGridViewTextBoxColumn.Width = 107;
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
            subtotalDataGridViewTextBoxColumn.Width = 75;
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
            paymentmethodDataGridViewTextBoxColumn.Width = 114;
            // 
            // cashreceivedDataGridViewTextBoxColumn
            // 
            cashreceivedDataGridViewTextBoxColumn.DataPropertyName = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.HeaderText = "Cash Received";
            cashreceivedDataGridViewTextBoxColumn.Name = "cashreceivedDataGridViewTextBoxColumn";
            cashreceivedDataGridViewTextBoxColumn.ReadOnly = true;
            cashreceivedDataGridViewTextBoxColumn.Width = 99;
            // 
            // cashchangeDataGridViewTextBoxColumn
            // 
            cashchangeDataGridViewTextBoxColumn.DataPropertyName = "cash_change";
            cashchangeDataGridViewTextBoxColumn.HeaderText = "Change";
            cashchangeDataGridViewTextBoxColumn.Name = "cashchangeDataGridViewTextBoxColumn";
            cashchangeDataGridViewTextBoxColumn.ReadOnly = true;
            cashchangeDataGridViewTextBoxColumn.Width = 73;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 64;
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
            viewInvoice.Width = 5;
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
            label1.Location = new Point(13, 110);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Invoice Number:";
            // 
            // TransactionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 749);
            Controls.Add(label1);
            Controls.Add(dtgvTransactions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            Load += TransactionsList_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvTransactions;
        private TextBox txtSearch;
        private Label label1;
        private BindingSource transactionBindingSource;
        private TextBox textBox1;
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
        private DataGridViewTextBoxColumn salesinvoiceitemsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn viewInvoice;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Label label5;
    }
}