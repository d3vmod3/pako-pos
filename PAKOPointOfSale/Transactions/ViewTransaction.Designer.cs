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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(lbViewTransaction));
            btnProceed = new Button();
            dgvItems = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_brand = new DataGridViewTextBoxColumn();
            selectReturn = new DataGridViewCheckBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            remainingQty = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            transaction = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
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
            lblReturnNote = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblsearchproduct = new Label();
            button1 = new Button();
            lblVoidOrReturn = new Label();
            btnViewReason = new Button();
            ((ISupportInitialize)dgvItems).BeginInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.ForestGreen;
            btnProceed.FlatStyle = FlatStyle.Popup;
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(976, 113);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 25);
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
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, product_code, product_id, product_name, product_brand, selectReturn, transaction_id, dataGridViewTextBoxColumn1, quantity, remainingQty, unit_price, vat_amount, vatable_sales, vat_exempt, discount, discount_type, total_amount, unit_of_measurement, reason, transaction, product });
            dgvItems.DataSource = salesInvoiceItemBindingSource;
            dgvItems.Location = new Point(369, 143);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1000, 548);
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
            // product_code
            // 
            product_code.DataPropertyName = "product_code";
            product_code.HeaderText = "Product Code";
            product_code.Name = "product_code";
            product_code.Visible = false;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "product_id";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Visible = false;
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
            // remainingQty
            // 
            remainingQty.HeaderText = "Remaining Quantity to Return";
            remainingQty.Name = "remainingQty";
            remainingQty.ReadOnly = true;
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
            total_amount.HeaderText = "Subtotal";
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
            // reason
            // 
            reason.HeaderText = "Reason";
            reason.Name = "reason";
            reason.Visible = false;
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
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 250);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 119);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 3;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(34, 291);
            label3.Name = "label3";
            label3.Size = new Size(173, 16);
            label3.TabIndex = 4;
            label3.Text = "Transaction Date and Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 331);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 5;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 372);
            label5.Name = "label5";
            label5.Size = new Size(102, 16);
            label5.TabIndex = 6;
            label5.Text = "VATable Sales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 412);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 7;
            label6.Text = "VAT Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(39, 453);
            label7.Name = "label7";
            label7.Size = new Size(85, 16);
            label7.TabIndex = 8;
            label7.Text = "VAT Exempt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(40, 494);
            label8.Name = "label8";
            label8.Size = new Size(81, 16);
            label8.TabIndex = 9;
            label8.Text = "Grand Total:";
            // 
            // lblTransactionId
            // 
            lblTransactionId.AutoSize = true;
            lblTransactionId.BackColor = Color.Transparent;
            lblTransactionId.FlatStyle = FlatStyle.Popup;
            lblTransactionId.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTransactionId.ForeColor = Color.Black;
            lblTransactionId.Location = new Point(231, 120);
            lblTransactionId.Name = "lblTransactionId";
            lblTransactionId.Size = new Size(49, 16);
            lblTransactionId.TabIndex = 10;
            lblTransactionId.Text = "000000";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.Transparent;
            lblInvoiceNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(229, 250);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(49, 16);
            lblInvoiceNumber.TabIndex = 11;
            lblInvoiceNumber.Text = "000000";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.BackColor = Color.Transparent;
            lblTransactionDate.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTransactionDate.ForeColor = Color.Black;
            lblTransactionDate.Location = new Point(231, 291);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(73, 16);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "mmddyyyy";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblSubTotal.ForeColor = Color.Black;
            lblSubTotal.Location = new Point(231, 331);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(31, 16);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "0.00";
            // 
            // lblVatableSales
            // 
            lblVatableSales.AutoSize = true;
            lblVatableSales.BackColor = Color.Transparent;
            lblVatableSales.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblVatableSales.ForeColor = Color.Black;
            lblVatableSales.Location = new Point(231, 372);
            lblVatableSales.Name = "lblVatableSales";
            lblVatableSales.Size = new Size(31, 16);
            lblVatableSales.TabIndex = 14;
            lblVatableSales.Text = "0.00";
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.BackColor = Color.Transparent;
            lblVatAmount.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblVatAmount.ForeColor = Color.Black;
            lblVatAmount.Location = new Point(231, 412);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(31, 16);
            lblVatAmount.TabIndex = 15;
            lblVatAmount.Text = "0.00";
            // 
            // lblVatExempt
            // 
            lblVatExempt.AutoSize = true;
            lblVatExempt.BackColor = Color.Transparent;
            lblVatExempt.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblVatExempt.ForeColor = Color.Black;
            lblVatExempt.Location = new Point(231, 453);
            lblVatExempt.Name = "lblVatExempt";
            lblVatExempt.Size = new Size(31, 16);
            lblVatExempt.TabIndex = 16;
            lblVatExempt.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.Transparent;
            lblGrandTotal.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblGrandTotal.ForeColor = Color.Black;
            lblGrandTotal.Location = new Point(231, 494);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(31, 16);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "0.00";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.BackColor = Color.Transparent;
            lblPaymentMethod.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(231, 649);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(38, 16);
            lblPaymentMethod.TabIndex = 19;
            lblPaymentMethod.Text = "Cash";
            lblPaymentMethod.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(40, 649);
            label10.Name = "label10";
            label10.Size = new Size(111, 16);
            label10.TabIndex = 18;
            label10.Text = "Payment Method:";
            label10.Visible = false;
            // 
            // lblCashReceived
            // 
            lblCashReceived.AutoSize = true;
            lblCashReceived.BackColor = Color.Transparent;
            lblCashReceived.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblCashReceived.ForeColor = Color.Black;
            lblCashReceived.Location = new Point(230, 531);
            lblCashReceived.Name = "lblCashReceived";
            lblCashReceived.Size = new Size(31, 16);
            lblCashReceived.TabIndex = 21;
            lblCashReceived.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(39, 531);
            label11.Name = "label11";
            label11.Size = new Size(103, 16);
            label11.TabIndex = 20;
            label11.Text = "Cash Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.Transparent;
            lblChange.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(229, 574);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(31, 16);
            lblChange.TabIndex = 23;
            lblChange.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(39, 574);
            label12.Name = "label12";
            label12.Size = new Size(57, 16);
            label12.TabIndex = 22;
            label12.Text = "Change:";
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.Goldenrod;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.ForeColor = Color.Transparent;
            btnViewReceipt.Location = new Point(1202, 113);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(86, 25);
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
            cmbInvoiceAction.Location = new Point(754, 113);
            cmbInvoiceAction.Name = "cmbInvoiceAction";
            cmbInvoiceAction.Size = new Size(206, 23);
            cmbInvoiceAction.TabIndex = 26;
            cmbInvoiceAction.SelectedIndexChanged += cmbInvoiceAction_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(658, 121);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 27;
            label9.Text = "Invoice Action:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.BackColor = Color.Transparent;
            lblTransactionType.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTransactionType.ForeColor = Color.Black;
            lblTransactionType.Location = new Point(229, 153);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(113, 16);
            lblTransactionType.TabIndex = 29;
            lblTransactionType.Text = "Transaction Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(34, 153);
            label14.Name = "label14";
            label14.Size = new Size(116, 16);
            label14.TabIndex = 28;
            label14.Text = "Transaction Type:";
            // 
            // lblAdjustmentNumber
            // 
            lblAdjustmentNumber.AutoSize = true;
            lblAdjustmentNumber.BackColor = Color.Transparent;
            lblAdjustmentNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAdjustmentNumber.ForeColor = Color.Black;
            lblAdjustmentNumber.Location = new Point(229, 209);
            lblAdjustmentNumber.Name = "lblAdjustmentNumber";
            lblAdjustmentNumber.Size = new Size(49, 16);
            lblAdjustmentNumber.TabIndex = 30;
            lblAdjustmentNumber.Text = "000000";
            lblAdjustmentNumber.Visible = false;
            lblAdjustmentNumber.Click += lblAdjustmentNumber_Click;
            // 
            // lblReturnNote
            // 
            lblReturnNote.AutoSize = true;
            lblReturnNote.ForeColor = Color.Black;
            lblReturnNote.Location = new Point(369, 119);
            lblReturnNote.Name = "lblReturnNote";
            lblReturnNote.Size = new Size(277, 15);
            lblReturnNote.TabIndex = 31;
            lblReturnNote.Text = "Note: Gray items indicate they are already returned.";
            lblReturnNote.Visible = false;
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
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlDarkDark;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(-16, 697);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1402, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 152;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Location = new Point(-1, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1387, 103);
            pictureBox5.TabIndex = 153;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DimGray;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-1, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(277, 103);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 154;
            pictureBox6.TabStop = false;
            // 
            // lblsearchproduct
            // 
            lblsearchproduct.AutoSize = true;
            lblsearchproduct.BackColor = Color.DimGray;
            lblsearchproduct.Font = new Font("Impact", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(587, 11);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(448, 82);
            lblsearchproduct.TabIndex = 155;
            lblsearchproduct.Text = "TRANSACTIONS \r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1294, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 156;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblVoidOrReturn
            // 
            lblVoidOrReturn.AutoSize = true;
            lblVoidOrReturn.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblVoidOrReturn.ForeColor = Color.Black;
            lblVoidOrReturn.Location = new Point(37, 209);
            lblVoidOrReturn.Name = "lblVoidOrReturn";
            lblVoidOrReturn.Size = new Size(95, 16);
            lblVoidOrReturn.TabIndex = 32;
            lblVoidOrReturn.Text = "Void or Return:";
            lblVoidOrReturn.Visible = false;
            // 
            // btnViewReason
            // 
            btnViewReason.BackColor = Color.DarkSlateGray;
            btnViewReason.FlatStyle = FlatStyle.Popup;
            btnViewReason.ForeColor = Color.White;
            btnViewReason.Location = new Point(1106, 113);
            btnViewReason.Name = "btnViewReason";
            btnViewReason.Size = new Size(90, 25);
            btnViewReason.TabIndex = 157;
            btnViewReason.Text = "View Reason";
            btnViewReason.UseVisualStyleBackColor = false;
            btnViewReason.Visible = false;
            btnViewReason.Click += btnViewReason_Click;
            // 
            // lbViewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1386, 788);
            Controls.Add(btnViewReason);
            Controls.Add(button1);
            Controls.Add(lblsearchproduct);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(lblVoidOrReturn);
            Controls.Add(lblReturnNote);
            Controls.Add(lblAdjustmentNumber);
            Controls.Add(lblTransactionType);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(cmbInvoiceAction);
            Controls.Add(btnViewReceipt);
            Controls.Add(lblChange);
            Controls.Add(label12);
            Controls.Add(lblCashReceived);
            Controls.Add(label11);
            Controls.Add(lblPaymentMethod);
            Controls.Add(label10);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblVatExempt);
            Controls.Add(lblVatAmount);
            Controls.Add(lblVatableSales);
            Controls.Add(lblSubTotal);
            Controls.Add(lblTransactionDate);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(lblTransactionId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvItems);
            Controls.Add(btnProceed);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lbViewTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Transaction";
            Load += ViewTransaction_Load;
            ((ISupportInitialize)dgvItems).EndInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        //private DataGridViewTextBoxColumn product_code;
        //private DataGridViewTextBoxColumn product_name;
        //private DataGridViewTextBoxColumn product_brand;
        private Label lblReturnNote;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
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
    }
}