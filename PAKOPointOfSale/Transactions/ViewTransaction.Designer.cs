using System.ComponentModel;

namespace PAKOPointOfSale.Transactions
{
    partial class lbViewTransaction
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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnProceed = new Button();
            dgvItems = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            transaction = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_brand = new DataGridViewTextBoxColumn();
            selectReturn = new DataGridViewCheckBoxColumn();
            remainingQty = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            salesInvoiceItemBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTransactionId = new Label();
            lblInvoiceNumber = new Label();
            lblTransactionDate = new Label();
            lblSubTotal = new Label();
            lblVatableSales = new Label();
            lblVatAmount = new Label();
            lblVatExempt = new Label();
            lblGrandTotal = new Label();
            lblPaymentMethod = new Label();
            label10 = new Label();
            lblCashReceived = new Label();
            label11 = new Label();
            lblChange = new Label();
            label12 = new Label();
            btnViewReceipt = new Button();
            cmbInvoiceAction = new ComboBox();
            label9 = new Label();
            lblTransactionType = new Label();
            label14 = new Label();
            lblAdjustmentNumber = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblsearchproduct = new Label();
            button1 = new Button();
            lblVoidOrReturn = new Label();
            btnViewReason = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            ((ISupportInitialize)dgvItems).BeginInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.ForestGreen;
            btnProceed.FlatStyle = FlatStyle.Popup;
            btnProceed.ForeColor = Color.Black;
            btnProceed.Location = new Point(1080, 103);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(86, 28);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, product_id, transaction_id, dataGridViewTextBoxColumn1, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, discount, discount_type, total_amount, unit_of_measurement, transaction, product, product_code, product_name, product_brand, selectReturn, remainingQty, reason });
            dgvItems.DataSource = salesInvoiceItemBindingSource;
            dgvItems.Location = new Point(295, 135);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1063, 641);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "product_id";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Visible = false;
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            transaction_id.HeaderText = "transaction_id";
            transaction_id.Name = "transaction_id";
            transaction_id.ReadOnly = true;
            transaction_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            dataGridViewTextBoxColumn1.HeaderText = "product_id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            vat_amount.ReadOnly = true;
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            vatable_sales.ReadOnly = true;
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            discount_type.ReadOnly = true;
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Total";
            total_amount.Name = "total_amount";
            total_amount.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.DataPropertyName = "unit_of_measurement";
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // transaction
            // 
            transaction.DataPropertyName = "transaction";
            transaction.HeaderText = "transaction";
            transaction.Name = "transaction";
            transaction.ReadOnly = true;
            transaction.Visible = false;
            // 
            // product
            // 
            product.DataPropertyName = "product";
            product.HeaderText = "product";
            product.Name = "product";
            product.Visible = false;
            // 
            // product_code
            // 
            product_code.DataPropertyName = "product_code";
            product_code.HeaderText = "Product Code";
            product_code.Name = "product_code";
            product_code.Visible = false;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // product_brand
            // 
            product_brand.DataPropertyName = "product_brand";
            product_brand.HeaderText = "Brand";
            product_brand.Name = "product_brand";
            product_brand.ReadOnly = true;
            // 
            // selectReturn
            // 
            selectReturn.DataPropertyName = "selectReturn";
            selectReturn.FalseValue = "0";
            selectReturn.HeaderText = "Select an Item(s) to Return";
            selectReturn.Name = "selectReturn";
            selectReturn.Resizable = DataGridViewTriState.True;
            selectReturn.SortMode = DataGridViewColumnSortMode.Automatic;
            selectReturn.TrueValue = "1";
            selectReturn.Visible = false;
            // 
            // remainingQty
            // 
            remainingQty.HeaderText = "Remaining Quantity to Return";
            remainingQty.Name = "remainingQty";
            remainingQty.ReadOnly = true;
            // 
            // reason
            // 
            reason.HeaderText = "Reason";
            reason.Name = "reason";
            reason.Visible = false;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 205);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 115);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 3;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 248);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 4;
            label3.Text = " Date and Time:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(60, 295);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 5;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 339);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 6;
            label5.Text = "VATable Sales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(32, 387);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 7;
            label6.Text = "VAT Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(39, 433);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 8;
            label7.Text = "VAT Exempt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(43, 479);
            label8.Name = "label8";
            label8.Size = new Size(81, 17);
            label8.TabIndex = 9;
            label8.Text = "Grand Total:";
            // 
            // lblTransactionId
            // 
            lblTransactionId.AutoSize = true;
            lblTransactionId.BackColor = Color.White;
            lblTransactionId.FlatStyle = FlatStyle.Popup;
            lblTransactionId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTransactionId.ForeColor = Color.Black;
            lblTransactionId.Location = new Point(140, 112);
            lblTransactionId.Name = "lblTransactionId";
            lblTransactionId.Size = new Size(63, 20);
            lblTransactionId.TabIndex = 10;
            lblTransactionId.Text = "000000";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.White;
            lblInvoiceNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(140, 205);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(63, 20);
            lblInvoiceNumber.TabIndex = 11;
            lblInvoiceNumber.Text = "000000";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.BackColor = Color.White;
            lblTransactionDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTransactionDate.ForeColor = Color.Black;
            lblTransactionDate.Location = new Point(140, 245);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(87, 20);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "mmddyyyy";
            lblTransactionDate.Click += lblTransactionDate_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.White;
            lblSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSubTotal.ForeColor = Color.Black;
            lblSubTotal.Location = new Point(140, 292);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(40, 20);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "0.00";
            // 
            // lblVatableSales
            // 
            lblVatableSales.AutoSize = true;
            lblVatableSales.BackColor = Color.White;
            lblVatableSales.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblVatableSales.ForeColor = Color.Black;
            lblVatableSales.Location = new Point(140, 339);
            lblVatableSales.Name = "lblVatableSales";
            lblVatableSales.Size = new Size(40, 20);
            lblVatableSales.TabIndex = 14;
            lblVatableSales.Text = "0.00";
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.BackColor = Color.White;
            lblVatAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblVatAmount.ForeColor = Color.Black;
            lblVatAmount.Location = new Point(140, 384);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(40, 20);
            lblVatAmount.TabIndex = 15;
            lblVatAmount.Text = "0.00";
            // 
            // lblVatExempt
            // 
            lblVatExempt.AutoSize = true;
            lblVatExempt.BackColor = Color.White;
            lblVatExempt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblVatExempt.ForeColor = Color.Black;
            lblVatExempt.Location = new Point(140, 430);
            lblVatExempt.Name = "lblVatExempt";
            lblVatExempt.Size = new Size(40, 20);
            lblVatExempt.TabIndex = 16;
            lblVatExempt.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.White;
            lblGrandTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.Black;
            lblGrandTotal.Location = new Point(140, 476);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(40, 20);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "0.00";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.BackColor = Color.Transparent;
            lblPaymentMethod.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(146, 622);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(37, 17);
            lblPaymentMethod.TabIndex = 19;
            lblPaymentMethod.Text = "Cash";
            lblPaymentMethod.Visible = false;
            lblPaymentMethod.Click += lblPaymentMethod_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(11, 622);
            label10.Name = "label10";
            label10.Size = new Size(117, 17);
            label10.TabIndex = 18;
            label10.Text = "Payment Method:";
            label10.Visible = false;
            // 
            // lblCashReceived
            // 
            lblCashReceived.AutoSize = true;
            lblCashReceived.BackColor = Color.White;
            lblCashReceived.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCashReceived.ForeColor = Color.Black;
            lblCashReceived.Location = new Point(140, 521);
            lblCashReceived.Name = "lblCashReceived";
            lblCashReceived.Size = new Size(40, 20);
            lblCashReceived.TabIndex = 21;
            lblCashReceived.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(31, 524);
            label11.Name = "label11";
            label11.Size = new Size(97, 17);
            label11.TabIndex = 20;
            label11.Text = "Cash Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.White;
            lblChange.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(140, 573);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(40, 20);
            lblChange.TabIndex = 23;
            lblChange.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(68, 576);
            label12.Name = "label12";
            label12.Size = new Size(57, 17);
            label12.TabIndex = 22;
            label12.Text = "Change:";
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.Goldenrod;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.ForeColor = Color.Black;
            btnViewReceipt.Location = new Point(1172, 103);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(98, 28);
            btnViewReceipt.TabIndex = 25;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            btnViewReceipt.Click += button1_Click;
            // 
            // cmbInvoiceAction
            // 
            cmbInvoiceAction.BackColor = SystemColors.ActiveBorder;
            cmbInvoiceAction.FlatStyle = FlatStyle.Popup;
            cmbInvoiceAction.FormattingEnabled = true;
            cmbInvoiceAction.Items.AddRange(new object[] { "", "Void", "Return" });
            cmbInvoiceAction.Location = new Point(390, 102);
            cmbInvoiceAction.Name = "cmbInvoiceAction";
            cmbInvoiceAction.Size = new Size(263, 25);
            cmbInvoiceAction.TabIndex = 26;
            cmbInvoiceAction.SelectedIndexChanged += cmbInvoiceAction_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(292, 109);
            label9.Name = "label9";
            label9.Size = new Size(97, 17);
            label9.TabIndex = 27;
            label9.Text = "Invoice Action:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.BackColor = Color.White;
            lblTransactionType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTransactionType.ForeColor = Color.Black;
            lblTransactionType.Location = new Point(140, 159);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(127, 20);
            lblTransactionType.TabIndex = 29;
            lblTransactionType.Text = "Transaction Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(9, 161);
            label14.Name = "label14";
            label14.Size = new Size(112, 17);
            label14.TabIndex = 28;
            label14.Text = "Transaction Type:";
            // 
            // lblAdjustmentNumber
            // 
            lblAdjustmentNumber.AutoSize = true;
            lblAdjustmentNumber.BackColor = Color.White;
            lblAdjustmentNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAdjustmentNumber.ForeColor = Color.Black;
            lblAdjustmentNumber.Location = new Point(142, 65);
            lblAdjustmentNumber.Name = "lblAdjustmentNumber";
            lblAdjustmentNumber.Size = new Size(63, 20);
            lblAdjustmentNumber.TabIndex = 30;
            lblAdjustmentNumber.Text = "000000";
            lblAdjustmentNumber.Click += lblAdjustmentNumber_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Location = new Point(-39, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1585, 95);
            pictureBox5.TabIndex = 153;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblsearchproduct
            // 
            lblsearchproduct.AutoSize = true;
            lblsearchproduct.BackColor = Color.DimGray;
            lblsearchproduct.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(601, 12);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(320, 60);
            lblsearchproduct.TabIndex = 155;
            lblsearchproduct.Text = "TRANSACTIONS \r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1479, 128);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 156;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblVoidOrReturn
            // 
            lblVoidOrReturn.AutoSize = true;
            lblVoidOrReturn.BackColor = Color.White;
            lblVoidOrReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblVoidOrReturn.ForeColor = Color.Black;
            lblVoidOrReturn.Location = new Point(21, 68);
            lblVoidOrReturn.Name = "lblVoidOrReturn";
            lblVoidOrReturn.Size = new Size(99, 17);
            lblVoidOrReturn.TabIndex = 32;
            lblVoidOrReturn.Text = "Void or Return:";
            // 
            // btnViewReason
            // 
            btnViewReason.BackColor = Color.DarkSlateGray;
            btnViewReason.FlatStyle = FlatStyle.Popup;
            btnViewReason.ForeColor = Color.White;
            btnViewReason.Location = new Point(971, 103);
            btnViewReason.Name = "btnViewReason";
            btnViewReason.Size = new Size(103, 28);
            btnViewReason.TabIndex = 157;
            btnViewReason.Text = "View Reason";
            btnViewReason.UseVisualStyleBackColor = false;
            btnViewReason.Click += btnViewReason_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(1276, 102);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 28);
            btnClose.TabIndex = 158;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblPaymentMethod);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblCashReceived);
            panel1.Controls.Add(lblVoidOrReturn);
            panel1.Controls.Add(lblAdjustmentNumber);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblGrandTotal);
            panel1.Controls.Add(lblTransactionType);
            panel1.Controls.Add(lblVatExempt);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblTransactionId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblVatAmount);
            panel1.Controls.Add(lblVatableSales);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblInvoiceNumber);
            panel1.Controls.Add(lblTransactionDate);
            panel1.Controls.Add(lblSubTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 700);
            panel1.TabIndex = 159;
            panel1.Paint += panel1_Paint;
            // 
            // lbViewTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnViewReason);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(lblsearchproduct);
            Controls.Add(pictureBox5);
            Controls.Add(label9);
            Controls.Add(cmbInvoiceAction);
            Controls.Add(btnViewReceipt);
            Controls.Add(dgvItems);
            Controls.Add(btnProceed);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lbViewTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Transaction";
            WindowState = FormWindowState.Maximized;
            Load += ViewTransaction_Load;
            KeyDown += lbViewTransaction_KeyDown;
            ((ISupportInitialize)dgvItems).EndInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTransactionDate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnProceed;
        private DataGridView dgvItems;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTransactionId;
        private Label lblInvoiceNumber;
        private Label lblTransactionDate;
        private Label lblSubTotal;
        private Label lblVatableSales;
        private Label lblVatAmount;
        private Label lblVatExempt;
        private Label lblGrandTotal;
        private Label lblPaymentMethod;
        private Label label10;
        private Label lblCashReceived;
        private Label label11;
        private Label lblChange;
        private Label label12;
        private BindingSource salesInvoiceItemBindingSource;
        private Button btnViewReceipt;
        private ComboBox cmbInvoiceAction;
        private Label label9;
        private Label lblTransactionType;
        private Label label14;
        private Label lblAdjustmentSeries;
        private Label lblAdjustmentNumber;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewCheckBoxColumn select;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Label lblsearchproduct;
        private Button button1;
        private Label lblVoidOrReturn;
        private Button btnViewReason;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private DataGridViewCheckBoxColumn selectReturn;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn remainingQty;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn reason;
        private DataGridViewTextBoxColumn transaction;
        private DataGridViewTextBoxColumn product;
        private Button btnClose;
        private Panel panel1;
    }
}