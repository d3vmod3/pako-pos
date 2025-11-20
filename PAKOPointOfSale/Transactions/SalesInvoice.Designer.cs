
namespace PAKOPointOfSale.Transactions
{
    partial class SalesInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoice));
            productBindingSource = new BindingSource(components);
            userTypeBindingSource = new BindingSource(components);
            btnSearchProduct = new Button();
            dtgvCart = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            appliedQty = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            discountType = new DataGridViewTextBoxColumn();
            discountAmount = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            vatableSales = new DataGridViewTextBoxColumn();
            vatAmount = new DataGridViewTextBoxColumn();
            vatExempt = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnConfirm = new Button();
            btnPark = new Button();
            groupBox1 = new GroupBox();
            lblChange = new Label();
            lblDiscountAmount = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtScannedBarcode = new TextBox();
            groupBox2 = new GroupBox();
            btn1h = new Button();
            btn2h = new Button();
            btn5h = new Button();
            btn1k = new Button();
            btnKey1 = new Button();
            btnKey2 = new Button();
            btnKey3 = new Button();
            btnKey4 = new Button();
            btnKey7 = new Button();
            btnKey9 = new Button();
            btnKey5 = new Button();
            btnKey8 = new Button();
            btnKey6 = new Button();
            btnClearCash = new Button();
            txtCash = new TextBox();
            btnDot = new Button();
            btn00 = new Button();
            btnApplyDiscount = new Button();
            panel1 = new Panel();
            btnClearCart = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblDate = new Label();
            lblTime = new Label();
            timeAndDate = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            lblParkLabel = new Label();
            lblParkNumber = new Label();
            btnParkedTransactions = new Button();
            btnScan = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(WinFormsApp1.Model.Product);
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.Khaki;
            btnSearchProduct.FlatStyle = FlatStyle.Popup;
            btnSearchProduct.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchProduct.Location = new Point(12, 108);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(123, 33);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // dtgvCart
            // 
            dtgvCart.AllowUserToAddRows = false;
            dtgvCart.AllowUserToDeleteRows = false;
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCart.Columns.AddRange(new DataGridViewColumn[] { id, product, brand, unit_of_measurement, appliedQty, unit_price, category, discountType, discountAmount, subTotal, vatableSales, vatAmount, vatExempt });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvCart.Location = new Point(12, 147);
            dtgvCart.Name = "dtgvCart";
            dtgvCart.RowHeadersVisible = false;
            dtgvCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvCart.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCart.Size = new Size(996, 501);
            dtgvCart.TabIndex = 4;
            dtgvCart.CellClick += dtgvCart_CellClick;
            dtgvCart.CellContentClick += dtgvCart_CellContentClick;
            dtgvCart.CellEndEdit += dtgvCart_CellEndEdit;
            dtgvCart.CellValueChanged += dtgvCart_CellValueChanged;
            dtgvCart.EditingControlShowing += dtgvCart_EditingControlShowing;
            dtgvCart.KeyPress += dtgvCart_KeyPress;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            // 
            // product
            // 
            product.HeaderText = "Product";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.Name = "brand";
            brand.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // appliedQty
            // 
            appliedQty.HeaderText = "Quantity";
            appliedQty.Name = "appliedQty";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            category.Visible = false;
            // 
            // discountType
            // 
            discountType.DataPropertyName = "discountType";
            discountType.HeaderText = "Discount Type";
            discountType.Name = "discountType";
            discountType.ReadOnly = true;
            // 
            // discountAmount
            // 
            discountAmount.DataPropertyName = "discountAmount";
            discountAmount.HeaderText = "Discount Amount";
            discountAmount.Name = "discountAmount";
            discountAmount.ReadOnly = true;
            discountAmount.Visible = false;
            // 
            // subTotal
            // 
            subTotal.DataPropertyName = "subTotal";
            subTotal.HeaderText = "Total";
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            // 
            // vatableSales
            // 
            vatableSales.DataPropertyName = "vatableSales";
            vatableSales.HeaderText = "VATable Sales";
            vatableSales.Name = "vatableSales";
            vatableSales.ReadOnly = true;
            vatableSales.Visible = false;
            // 
            // vatAmount
            // 
            vatAmount.DataPropertyName = "vatAmount";
            vatAmount.HeaderText = "VAT Amount";
            vatAmount.Name = "vatAmount";
            vatAmount.ReadOnly = true;
            vatAmount.Visible = false;
            // 
            // vatExempt
            // 
            vatExempt.DataPropertyName = "vatExempt";
            vatExempt.HeaderText = "VAT Exempt";
            vatExempt.Name = "vatExempt";
            vatExempt.ReadOnly = true;
            vatExempt.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(147, 34);
            label1.TabIndex = 5;
            label1.Text = "Grand Total:";
            label1.Click += label1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.ForestGreen;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(817, 653);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 33);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += button1_Click;
            // 
            // btnPark
            // 
            btnPark.BackColor = SystemColors.Highlight;
            btnPark.FlatStyle = FlatStyle.Popup;
            btnPark.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnPark.ForeColor = Color.White;
            btnPark.Location = new Point(662, 653);
            btnPark.Name = "btnPark";
            btnPark.Size = new Size(149, 33);
            btnPark.TabIndex = 7;
            btnPark.Text = "Pending";
            btnPark.UseVisualStyleBackColor = false;
            btnPark.Click += button2_Click_Park;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblChange);
            groupBox1.Controls.Add(lblDiscountAmount);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 142);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Impact", 20.25F);
            lblChange.Location = new Point(123, 101);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(62, 34);
            lblChange.TabIndex = 12;
            lblChange.Text = "0.00";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Font = new Font("Impact", 20.25F);
            lblDiscountAmount.Location = new Point(139, 55);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(62, 34);
            lblDiscountAmount.TabIndex = 10;
            lblDiscountAmount.Text = "0.00";
            lblDiscountAmount.Click += lblDiscountAmount_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Impact", 20.25F);
            lblTotal.Location = new Point(172, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 34);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20.25F);
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(118, 34);
            label3.TabIndex = 7;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 20.25F);
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(105, 34);
            label2.TabIndex = 6;
            label2.Text = "Change:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 399);
            label4.Name = "label4";
            label4.Size = new Size(76, 34);
            label4.TabIndex = 8;
            label4.Text = "Cash:";
            // 
            // txtScannedBarcode
            // 
            txtScannedBarcode.Location = new Point(12, 195);
            txtScannedBarcode.Name = "txtScannedBarcode";
            txtScannedBarcode.Size = new Size(181, 23);
            txtScannedBarcode.TabIndex = 9;
            txtScannedBarcode.TextChanged += textBox1_TextChanged;
            txtScannedBarcode.KeyDown += txtScannedBarcode_KeyDown;
            txtScannedBarcode.KeyUp += txtScannedBarcode_KeyUp;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn1h);
            groupBox2.Controls.Add(btn2h);
            groupBox2.Controls.Add(btn5h);
            groupBox2.Controls.Add(btn1k);
            groupBox2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 104);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quick Amounts";
            // 
            // btn1h
            // 
            btn1h.BackColor = Color.YellowGreen;
            btn1h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1h.ForeColor = Color.Black;
            btn1h.Location = new Point(255, 25);
            btn1h.Name = "btn1h";
            btn1h.Size = new Size(74, 69);
            btn1h.TabIndex = 31;
            btn1h.Text = "₱100";
            btn1h.UseVisualStyleBackColor = false;
            btn1h.Click += btn1h_Click;
            // 
            // btn2h
            // 
            btn2h.BackColor = Color.YellowGreen;
            btn2h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn2h.ForeColor = Color.Black;
            btn2h.Location = new Point(170, 26);
            btn2h.Name = "btn2h";
            btn2h.Size = new Size(79, 68);
            btn2h.TabIndex = 30;
            btn2h.Text = "₱200";
            btn2h.UseVisualStyleBackColor = false;
            btn2h.Click += btn2h_Click;
            // 
            // btn5h
            // 
            btn5h.BackColor = Color.YellowGreen;
            btn5h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn5h.ForeColor = Color.Black;
            btn5h.Location = new Point(90, 26);
            btn5h.Name = "btn5h";
            btn5h.Size = new Size(74, 69);
            btn5h.TabIndex = 29;
            btn5h.Text = "₱500";
            btn5h.UseVisualStyleBackColor = false;
            btn5h.Click += btn5h_Click;
            // 
            // btn1k
            // 
            btn1k.BackColor = Color.YellowGreen;
            btn1k.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1k.ForeColor = Color.Black;
            btn1k.Location = new Point(7, 26);
            btn1k.Name = "btn1k";
            btn1k.Size = new Size(77, 69);
            btn1k.TabIndex = 0;
            btn1k.Text = "₱1000";
            btn1k.UseVisualStyleBackColor = false;
            btn1k.Click += button1_Click_1;
            // 
            // btnKey1
            // 
            btnKey1.BackColor = Color.LightSeaGreen;
            btnKey1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKey1.Location = new Point(8, 115);
            btnKey1.Name = "btnKey1";
            btnKey1.Size = new Size(104, 63);
            btnKey1.TabIndex = 32;
            btnKey1.Text = "1";
            btnKey1.UseVisualStyleBackColor = false;
            btnKey1.Click += button6_Click;
            // 
            // btnKey2
            // 
            btnKey2.BackColor = Color.LightSeaGreen;
            btnKey2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey2.Location = new Point(118, 115);
            btnKey2.Name = "btnKey2";
            btnKey2.Size = new Size(104, 63);
            btnKey2.TabIndex = 33;
            btnKey2.Text = "2";
            btnKey2.UseVisualStyleBackColor = false;
            btnKey2.Click += btnKey2_Click;
            // 
            // btnKey3
            // 
            btnKey3.BackColor = Color.LightSeaGreen;
            btnKey3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey3.Location = new Point(228, 113);
            btnKey3.Name = "btnKey3";
            btnKey3.Size = new Size(104, 63);
            btnKey3.TabIndex = 34;
            btnKey3.Text = "3";
            btnKey3.UseVisualStyleBackColor = false;
            btnKey3.Click += btnKey3_Click;
            // 
            // btnKey4
            // 
            btnKey4.BackColor = Color.LightSeaGreen;
            btnKey4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey4.Location = new Point(9, 186);
            btnKey4.Name = "btnKey4";
            btnKey4.Size = new Size(104, 60);
            btnKey4.TabIndex = 35;
            btnKey4.Text = "4";
            btnKey4.UseVisualStyleBackColor = false;
            btnKey4.Click += btnKey4_Click;
            // 
            // btnKey7
            // 
            btnKey7.BackColor = Color.LightSeaGreen;
            btnKey7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey7.Location = new Point(9, 253);
            btnKey7.Name = "btnKey7";
            btnKey7.Size = new Size(104, 60);
            btnKey7.TabIndex = 36;
            btnKey7.Text = "7";
            btnKey7.UseVisualStyleBackColor = false;
            btnKey7.Click += btnKey7_Click;
            // 
            // btnKey9
            // 
            btnKey9.BackColor = Color.LightSeaGreen;
            btnKey9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey9.Location = new Point(228, 251);
            btnKey9.Name = "btnKey9";
            btnKey9.Size = new Size(104, 58);
            btnKey9.TabIndex = 37;
            btnKey9.Text = "9";
            btnKey9.UseVisualStyleBackColor = false;
            btnKey9.Click += btnKey9_Click;
            // 
            // btnKey5
            // 
            btnKey5.BackColor = Color.LightSeaGreen;
            btnKey5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey5.Location = new Point(120, 186);
            btnKey5.Name = "btnKey5";
            btnKey5.Size = new Size(104, 60);
            btnKey5.TabIndex = 38;
            btnKey5.Text = "5";
            btnKey5.UseVisualStyleBackColor = false;
            btnKey5.Click += btnKey5_Click;
            // 
            // btnKey8
            // 
            btnKey8.BackColor = Color.LightSeaGreen;
            btnKey8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey8.Location = new Point(121, 253);
            btnKey8.Name = "btnKey8";
            btnKey8.Size = new Size(104, 60);
            btnKey8.TabIndex = 39;
            btnKey8.Text = "8";
            btnKey8.UseVisualStyleBackColor = false;
            btnKey8.Click += btnKey8_Click;
            // 
            // btnKey6
            // 
            btnKey6.BackColor = Color.LightSeaGreen;
            btnKey6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey6.Location = new Point(228, 184);
            btnKey6.Name = "btnKey6";
            btnKey6.Size = new Size(104, 60);
            btnKey6.TabIndex = 40;
            btnKey6.Text = "6";
            btnKey6.UseVisualStyleBackColor = false;
            btnKey6.Click += btnKey6_Click;
            // 
            // btnClearCash
            // 
            btnClearCash.BackColor = Color.LightSeaGreen;
            btnClearCash.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClearCash.Location = new Point(228, 324);
            btnClearCash.Name = "btnClearCash";
            btnClearCash.Size = new Size(104, 57);
            btnClearCash.TabIndex = 41;
            btnClearCash.Text = "CLEAR";
            btnClearCash.UseVisualStyleBackColor = false;
            btnClearCash.Click += btnClearCash_Click;
            // 
            // txtCash
            // 
            txtCash.Font = new Font("Impact", 15.75F);
            txtCash.Location = new Point(105, 399);
            txtCash.Multiline = true;
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(227, 32);
            txtCash.TabIndex = 42;
            txtCash.TextChanged += textBox1_TextChanged_1;
            txtCash.KeyPress += textBox1_KeyPress;
            txtCash.MouseLeave += txtCash_MouseLeave;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.LightSeaGreen;
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDot.Location = new Point(8, 324);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(105, 57);
            btnDot.TabIndex = 43;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn00
            // 
            btn00.BackColor = Color.LightSeaGreen;
            btn00.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn00.Location = new Point(124, 324);
            btn00.Name = "btn00";
            btn00.Size = new Size(101, 57);
            btn00.TabIndex = 44;
            btn00.Text = "0";
            btn00.UseVisualStyleBackColor = false;
            btn00.Click += btn00_Click;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.FromArgb(192, 64, 0);
            btnApplyDiscount.FlatStyle = FlatStyle.Popup;
            btnApplyDiscount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnApplyDiscount.ForeColor = Color.White;
            btnApplyDiscount.Location = new Point(507, 653);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(149, 35);
            btnApplyDiscount.TabIndex = 45;
            btnApplyDiscount.Text = "Apply Discount";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += button1_Click_2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btnKey2);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtCash);
            panel1.Controls.Add(btn00);
            panel1.Controls.Add(btnKey1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(btnKey3);
            panel1.Controls.Add(btnKey4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClearCash);
            panel1.Controls.Add(btnKey7);
            panel1.Controls.Add(btnKey6);
            panel1.Controls.Add(btnKey9);
            panel1.Controls.Add(btnKey8);
            panel1.Controls.Add(btnKey5);
            panel1.Location = new Point(1014, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 599);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.Coral;
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(31, 653);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(120, 34);
            btnClearCart.TabIndex = 45;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += button1_Click_clear;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1371, 104);
            pictureBox2.TabIndex = 144;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 145;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-4, 693);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1377, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 151;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Impact", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(488, 9);
            label5.Name = "label5";
            label5.Size = new Size(427, 85);
            label5.TabIndex = 152;
            label5.Text = "POINT OF SALE";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1075, 19);
            label7.Name = "label7";
            label7.Size = new Size(62, 29);
            label7.TabIndex = 153;
            label7.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DimGray;
            label8.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1075, 58);
            label8.Name = "label8";
            label8.Size = new Size(66, 29);
            label8.TabIndex = 154;
            label8.Text = "Time:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.DimGray;
            lblDate.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(1178, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(26, 29);
            lblDate.TabIndex = 155;
            lblDate.Text = "0";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.DimGray;
            lblTime.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(1178, 58);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(26, 29);
            lblTime.TabIndex = 156;
            lblTime.Text = "0";
            // 
            // timeAndDate
            // 
            timeAndDate.Enabled = true;
            timeAndDate.Interval = 1000;
            timeAndDate.Tick += timer1_Tick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1330, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 25);
            btnClose.TabIndex = 45;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblParkLabel
            // 
            lblParkLabel.AutoSize = true;
            lblParkLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblParkLabel.Location = new Point(815, 118);
            lblParkLabel.Name = "lblParkLabel";
            lblParkLabel.Size = new Size(126, 16);
            lblParkLabel.TabIndex = 157;
            lblParkLabel.Text = "Pending Number:";
            lblParkLabel.Visible = false;
            // 
            // lblParkNumber
            // 
            lblParkNumber.AutoSize = true;
            lblParkNumber.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblParkNumber.Location = new Point(953, 118);
            lblParkNumber.Name = "lblParkNumber";
            lblParkNumber.Size = new Size(55, 16);
            lblParkNumber.TabIndex = 158;
            lblParkNumber.Text = "000000";
            lblParkNumber.Visible = false;
            // 
            // btnParkedTransactions
            // 
            btnParkedTransactions.BackColor = Color.IndianRed;
            btnParkedTransactions.FlatStyle = FlatStyle.Popup;
            btnParkedTransactions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnParkedTransactions.ForeColor = Color.White;
            btnParkedTransactions.Location = new Point(342, 654);
            btnParkedTransactions.Name = "btnParkedTransactions";
            btnParkedTransactions.Size = new Size(159, 34);
            btnParkedTransactions.TabIndex = 159;
            btnParkedTransactions.Text = "Pending Transactions";
            btnParkedTransactions.UseVisualStyleBackColor = false;
            btnParkedTransactions.Click += btnParkedTransactions_Click;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.IndianRed;
            btnScan.FlatStyle = FlatStyle.Popup;
            btnScan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScan.ForeColor = Color.White;
            btnScan.Location = new Point(142, 109);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(126, 32);
            btnScan.TabIndex = 160;
            btnScan.Text = "Scan Barcode";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Orange;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(155, 654);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(181, 34);
            btnRemove.TabIndex = 161;
            btnRemove.Text = "Remove Selected Item(s)";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // SalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 777);
            Controls.Add(btnRemove);
            Controls.Add(btnScan);
            Controls.Add(btnClearCart);
            Controls.Add(btnParkedTransactions);
            Controls.Add(lblParkNumber);
            Controls.Add(lblParkLabel);
            Controls.Add(btnClose);
            Controls.Add(btnPark);
            Controls.Add(btnConfirm);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnApplyDiscount);
            Controls.Add(dtgvCart);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtScannedBarcode);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Invoice";
            WindowState = FormWindowState.Maximized;
            Load += SalesInvoice_Load;
            KeyDown += SalesInvoice_KeyDown;
            KeyPress += SalesInvoice_KeyPress;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource userTypeBindingSource;
        private Button btnSearchProduct;
        private DataGridView dtgvCart;
        private Label label1;
        private Button btnConfirm;
        private Button btnPark;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private Label lblChange;
        private TextBox txtScannedBarcode;
        private GroupBox groupBox2;
        private Button btn1h;
        private Button btn2h;
        private Button btn5h;
        private Button btn1k;
        private Button btnKey1;
        private Button btnKey2;
        private Button btnKey3;
        private Button btnKey4;
        private Button btnKey7;
        private Button btnKey9;
        private Button btnKey5;
        private Button btnKey8;
        private Button btnKey6;
        private Button btnClearCash;
        private TextBox txtCash;
        private Button btnDot;
        private Button btn00;
        private Button btnApplyDiscount;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label lblDate;
        private Label lblTime;
        private System.Windows.Forms.Timer timeAndDate;
        private Button btnClose;
        private Label lblParkLabel;
        private Label lblParkNumber;
        private Button btnParkedTransactions;
        private Button btnClearCart;
        private Button btnScan;
        private Button btnRemove;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn appliedQty;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn discountType;
        private DataGridViewTextBoxColumn discountAmount;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewTextBoxColumn vatableSales;
        private DataGridViewTextBoxColumn vatAmount;
        private DataGridViewTextBoxColumn vatExempt;
    }
}