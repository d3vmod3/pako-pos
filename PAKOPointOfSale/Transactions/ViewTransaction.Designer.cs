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
            btnProceed.Location = new Point(1085, 123);
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
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, product_code, product_id, product_name, product_brand, selectReturn, transaction_id, dataGridViewTextBoxColumn1, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, discount, discount_type, total_amount, unit_of_measurement, transaction, product });
            dgvItems.DataSource = salesInvoiceItemBindingSource;
            dgvItems.Location = new Point(436, 156);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(897, 535);
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
            product_id.Visible = false;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            // 
            // product_brand
            // 
            product_brand.DataPropertyName = "product_brand";
            product_brand.HeaderText = "Brand";
            product_brand.Name = "product_brand";
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
            transaction_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            dataGridViewTextBoxColumn1.HeaderText = "product_id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Applied Quantity";
            quantity.Name = "quantity";
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Subtotal";
            total_amount.Name = "total_amount";
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.DataPropertyName = "unit_of_measurement";
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            // 
            // transaction
            // 
            transaction.DataPropertyName = "transaction";
            transaction.HeaderText = "transaction";
            transaction.Name = "transaction";
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
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 262);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 133);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 303);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 4;
            label3.Text = "Transaction Date and Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 343);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 5;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 384);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 6;
            label5.Text = "VATable Sales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 424);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "VAT Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(39, 465);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 8;
            label7.Text = "VAT Exempt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(40, 506);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 9;
            label8.Text = "Grand Total:";
            // 
            // lblTransactionId
            // 
            lblTransactionId.AutoSize = true;
            lblTransactionId.BackColor = Color.PaleGoldenrod;
            lblTransactionId.FlatStyle = FlatStyle.Popup;
            lblTransactionId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTransactionId.ForeColor = Color.Black;
            lblTransactionId.Location = new Point(270, 133);
            lblTransactionId.Name = "lblTransactionId";
            lblTransactionId.Size = new Size(69, 20);
            lblTransactionId.TabIndex = 10;
            lblTransactionId.Text = "000000";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.PaleGoldenrod;
            lblInvoiceNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(268, 262);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(69, 20);
            lblInvoiceNumber.TabIndex = 11;
            lblInvoiceNumber.Text = "000000";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.BackColor = Color.PaleGoldenrod;
            lblTransactionDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTransactionDate.ForeColor = Color.Black;
            lblTransactionDate.Location = new Point(268, 303);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(89, 20);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "mmddyyyy";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.PaleGoldenrod;
            lblSubTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblSubTotal.ForeColor = Color.Black;
            lblSubTotal.Location = new Point(270, 343);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(44, 20);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "0.00";
            // 
            // lblVatableSales
            // 
            lblVatableSales.AutoSize = true;
            lblVatableSales.BackColor = Color.PaleGoldenrod;
            lblVatableSales.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblVatableSales.ForeColor = Color.Black;
            lblVatableSales.Location = new Point(270, 384);
            lblVatableSales.Name = "lblVatableSales";
            lblVatableSales.Size = new Size(44, 20);
            lblVatableSales.TabIndex = 14;
            lblVatableSales.Text = "0.00";
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.BackColor = Color.PaleGoldenrod;
            lblVatAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblVatAmount.ForeColor = Color.Black;
            lblVatAmount.Location = new Point(270, 424);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(44, 20);
            lblVatAmount.TabIndex = 15;
            lblVatAmount.Text = "0.00";
            // 
            // lblVatExempt
            // 
            lblVatExempt.AutoSize = true;
            lblVatExempt.BackColor = Color.PaleGoldenrod;
            lblVatExempt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblVatExempt.ForeColor = Color.Black;
            lblVatExempt.Location = new Point(270, 465);
            lblVatExempt.Name = "lblVatExempt";
            lblVatExempt.Size = new Size(44, 20);
            lblVatExempt.TabIndex = 16;
            lblVatExempt.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.PaleGoldenrod;
            lblGrandTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.Black;
            lblGrandTotal.Location = new Point(270, 506);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(44, 20);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "0.00";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.BackColor = Color.PaleGoldenrod;
            lblPaymentMethod.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(270, 548);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(47, 20);
            lblPaymentMethod.TabIndex = 19;
            lblPaymentMethod.Text = "cash";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(40, 548);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 18;
            label10.Text = "Payment Method:";
            // 
            // lblCashReceived
            // 
            lblCashReceived.AutoSize = true;
            lblCashReceived.BackColor = Color.PaleGoldenrod;
            lblCashReceived.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCashReceived.ForeColor = Color.Black;
            lblCashReceived.Location = new Point(270, 597);
            lblCashReceived.Name = "lblCashReceived";
            lblCashReceived.Size = new Size(44, 20);
            lblCashReceived.TabIndex = 21;
            lblCashReceived.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(40, 597);
            label11.Name = "label11";
            label11.Size = new Size(134, 20);
            label11.TabIndex = 20;
            label11.Text = "Cash Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.PaleGoldenrod;
            lblChange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(270, 640);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(44, 20);
            lblChange.TabIndex = 23;
            lblChange.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(40, 640);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 22;
            label12.Text = "Change:";
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.Goldenrod;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.ForeColor = Color.Transparent;
            btnViewReceipt.Location = new Point(1166, 123);
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
            cmbInvoiceAction.Location = new Point(909, 124);
            cmbInvoiceAction.Name = "cmbInvoiceAction";
            cmbInvoiceAction.Size = new Size(170, 23);
            cmbInvoiceAction.TabIndex = 26;
            cmbInvoiceAction.SelectedIndexChanged += cmbInvoiceAction_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(817, 128);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 27;
            label9.Text = "Invoice Action:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.BackColor = Color.PaleGoldenrod;
            lblTransactionType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTransactionType.ForeColor = Color.Black;
            lblTransactionType.Location = new Point(268, 175);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(146, 20);
            lblTransactionType.TabIndex = 29;
            lblTransactionType.Text = "Transaction Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(36, 175);
            label14.Name = "label14";
            label14.Size = new Size(151, 20);
            label14.TabIndex = 28;
            label14.Text = "Transaction Type:";
            // 
            // lblAdjustmentNumber
            // 
            lblAdjustmentNumber.AutoSize = true;
            lblAdjustmentNumber.BackColor = Color.PaleGoldenrod;
            lblAdjustmentNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdjustmentNumber.ForeColor = Color.Black;
            lblAdjustmentNumber.Location = new Point(270, 216);
            lblAdjustmentNumber.Name = "lblAdjustmentNumber";
            lblAdjustmentNumber.Size = new Size(69, 20);
            lblAdjustmentNumber.TabIndex = 30;
            lblAdjustmentNumber.Text = "000000";
            lblAdjustmentNumber.Visible = false;
            lblAdjustmentNumber.Click += lblAdjustmentNumber_Click;
            // 
            // lblReturnNote
            // 
            lblReturnNote.AutoSize = true;
            lblReturnNote.ForeColor = Color.White;
            lblReturnNote.Location = new Point(436, 128);
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
            pictureBox5.Size = new Size(1370, 103);
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
            lblsearchproduct.Font = new Font("Impact", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(570, 16);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(400, 75);
            lblsearchproduct.TabIndex = 155;
            lblsearchproduct.Text = "TRANSACTIONS \r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1258, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 156;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblVoidOrReturn
            // 
            lblVoidOrReturn.AutoSize = true;
            lblVoidOrReturn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblVoidOrReturn.ForeColor = Color.Black;
            lblVoidOrReturn.Location = new Point(37, 221);
            lblVoidOrReturn.Name = "lblVoidOrReturn";
            lblVoidOrReturn.Size = new Size(131, 20);
            lblVoidOrReturn.TabIndex = 32;
            lblVoidOrReturn.Text = "Void or Return:";
            lblVoidOrReturn.Visible = false;
            // 
            // lbViewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1343, 788);
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private DataGridViewCheckBoxColumn selectReturn;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn transaction;
        private DataGridViewTextBoxColumn product;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblsearchproduct;
        private Button button1;
        private Label lblVoidOrReturn;
    }
}