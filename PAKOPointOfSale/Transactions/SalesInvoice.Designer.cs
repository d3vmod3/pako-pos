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
            productBindingSource = new BindingSource(components);
            userTypeBindingSource = new BindingSource(components);
            btnSearchProduct = new Button();
            dtgvCart = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            select = new DataGridViewCheckBoxColumn();
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
            remove = new DataGridViewButtonColumn();
            label1 = new Label();
            btnConfirm = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            lblChange = new Label();
            label6 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
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
            btnSearchProduct.Location = new Point(12, 12);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(149, 38);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // dtgvCart
            // 
            dtgvCart.AllowUserToAddRows = false;
            dtgvCart.AllowUserToDeleteRows = false;
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCart.Columns.AddRange(new DataGridViewColumn[] { id, select, product, brand, unit_of_measurement, appliedQty, unit_price, category, discountType, discountAmount, subTotal, vatableSales, vatAmount, vatExempt, remove });
            dtgvCart.Location = new Point(12, 56);
            dtgvCart.Name = "dtgvCart";
            dtgvCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgvCart.Size = new Size(1450, 973);
            dtgvCart.TabIndex = 4;
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
            // select
            // 
            select.FalseValue = "0";
            select.HeaderText = "Select to Apply Discount";
            select.Name = "select";
            select.TrueValue = "1";
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
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
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
            // 
            // subTotal
            // 
            subTotal.DataPropertyName = "subTotal";
            subTotal.HeaderText = "Sub Total";
            subTotal.Name = "subTotal";
            // 
            // vatableSales
            // 
            vatableSales.DataPropertyName = "vatableSales";
            vatableSales.HeaderText = "VATable Sales";
            vatableSales.Name = "vatableSales";
            // 
            // vatAmount
            // 
            vatAmount.DataPropertyName = "vatAmount";
            vatAmount.HeaderText = "VAT Amount";
            vatAmount.Name = "vatAmount";
            // 
            // vatExempt
            // 
            vatExempt.DataPropertyName = "vatExempt";
            vatExempt.HeaderText = "VAT Exempt";
            vatExempt.Name = "vatExempt";
            // 
            // remove
            // 
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.Text = "Remove";
            remove.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 47);
            label1.TabIndex = 5;
            label1.Text = "Grand Total:";
            label1.Click += label1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(345, 852);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 61);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 852);
            button2.Name = "button2";
            button2.Size = new Size(75, 61);
            button2.TabIndex = 7;
            button2.Text = "Park";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblChange);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 690);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 156);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(148, 104);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(85, 47);
            lblChange.TabIndex = 12;
            lblChange.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 66);
            label6.Name = "label6";
            label6.Size = new Size(85, 47);
            label6.TabIndex = 10;
            label6.Text = "0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(210, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 47);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(165, 47);
            label3.TabIndex = 7;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(147, 47);
            label2.TabIndex = 6;
            label2.Text = "Change:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 625);
            label4.Name = "label4";
            label4.Size = new Size(103, 47);
            label4.TabIndex = 8;
            label4.Text = "Cash:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtScannedBarcode
            // 
            txtScannedBarcode.Location = new Point(167, 21);
            txtScannedBarcode.Name = "txtScannedBarcode";
            txtScannedBarcode.Size = new Size(256, 23);
            txtScannedBarcode.TabIndex = 9;
            txtScannedBarcode.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn1h);
            groupBox2.Controls.Add(btn2h);
            groupBox2.Controls.Add(btn5h);
            groupBox2.Controls.Add(btn1k);
            groupBox2.Location = new Point(7, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 123);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quick Amounts";
            // 
            // btn1h
            // 
            btn1h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1h.Location = new Point(319, 22);
            btn1h.Name = "btn1h";
            btn1h.Size = new Size(88, 87);
            btn1h.TabIndex = 31;
            btn1h.Text = "₱100";
            btn1h.UseVisualStyleBackColor = true;
            btn1h.Click += btn1h_Click;
            // 
            // btn2h
            // 
            btn2h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn2h.Location = new Point(214, 22);
            btn2h.Name = "btn2h";
            btn2h.Size = new Size(88, 87);
            btn2h.TabIndex = 30;
            btn2h.Text = "₱200";
            btn2h.UseVisualStyleBackColor = true;
            btn2h.Click += btn2h_Click;
            // 
            // btn5h
            // 
            btn5h.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn5h.Location = new Point(109, 22);
            btn5h.Name = "btn5h";
            btn5h.Size = new Size(88, 87);
            btn5h.TabIndex = 29;
            btn5h.Text = "₱500";
            btn5h.UseVisualStyleBackColor = true;
            btn5h.Click += btn5h_Click;
            // 
            // btn1k
            // 
            btn1k.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1k.Location = new Point(6, 22);
            btn1k.Name = "btn1k";
            btn1k.Size = new Size(88, 87);
            btn1k.TabIndex = 0;
            btn1k.Text = "₱1000";
            btn1k.UseVisualStyleBackColor = true;
            btn1k.Click += button1_Click_1;
            // 
            // btnKey1
            // 
            btnKey1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKey1.Location = new Point(7, 136);
            btnKey1.Name = "btnKey1";
            btnKey1.Size = new Size(116, 105);
            btnKey1.TabIndex = 32;
            btnKey1.Text = "1";
            btnKey1.UseVisualStyleBackColor = true;
            btnKey1.Click += button6_Click;
            // 
            // btnKey2
            // 
            btnKey2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey2.Location = new Point(160, 136);
            btnKey2.Name = "btnKey2";
            btnKey2.Size = new Size(116, 105);
            btnKey2.TabIndex = 33;
            btnKey2.Text = "2";
            btnKey2.UseVisualStyleBackColor = true;
            btnKey2.Click += btnKey2_Click;
            // 
            // btnKey3
            // 
            btnKey3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey3.Location = new Point(304, 136);
            btnKey3.Name = "btnKey3";
            btnKey3.Size = new Size(116, 105);
            btnKey3.TabIndex = 34;
            btnKey3.Text = "3";
            btnKey3.UseVisualStyleBackColor = true;
            btnKey3.Click += btnKey3_Click;
            // 
            // btnKey4
            // 
            btnKey4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey4.Location = new Point(7, 267);
            btnKey4.Name = "btnKey4";
            btnKey4.Size = new Size(116, 105);
            btnKey4.TabIndex = 35;
            btnKey4.Text = "4";
            btnKey4.UseVisualStyleBackColor = true;
            btnKey4.Click += btnKey4_Click;
            // 
            // btnKey7
            // 
            btnKey7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey7.Location = new Point(7, 393);
            btnKey7.Name = "btnKey7";
            btnKey7.Size = new Size(116, 105);
            btnKey7.TabIndex = 36;
            btnKey7.Text = "7";
            btnKey7.UseVisualStyleBackColor = true;
            btnKey7.Click += btnKey7_Click;
            // 
            // btnKey9
            // 
            btnKey9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey9.Location = new Point(304, 393);
            btnKey9.Name = "btnKey9";
            btnKey9.Size = new Size(116, 105);
            btnKey9.TabIndex = 37;
            btnKey9.Text = "9";
            btnKey9.UseVisualStyleBackColor = true;
            btnKey9.Click += btnKey9_Click;
            // 
            // btnKey5
            // 
            btnKey5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey5.Location = new Point(160, 267);
            btnKey5.Name = "btnKey5";
            btnKey5.Size = new Size(116, 105);
            btnKey5.TabIndex = 38;
            btnKey5.Text = "5";
            btnKey5.UseVisualStyleBackColor = true;
            btnKey5.Click += btnKey5_Click;
            // 
            // btnKey8
            // 
            btnKey8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey8.Location = new Point(160, 393);
            btnKey8.Name = "btnKey8";
            btnKey8.Size = new Size(116, 105);
            btnKey8.TabIndex = 39;
            btnKey8.Text = "8";
            btnKey8.UseVisualStyleBackColor = true;
            btnKey8.Click += btnKey8_Click;
            // 
            // btnKey6
            // 
            btnKey6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKey6.Location = new Point(304, 267);
            btnKey6.Name = "btnKey6";
            btnKey6.Size = new Size(116, 105);
            btnKey6.TabIndex = 40;
            btnKey6.Text = "6";
            btnKey6.UseVisualStyleBackColor = true;
            btnKey6.Click += btnKey6_Click;
            // 
            // btnClearCash
            // 
            btnClearCash.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClearCash.Location = new Point(304, 517);
            btnClearCash.Name = "btnClearCash";
            btnClearCash.Size = new Size(116, 105);
            btnClearCash.TabIndex = 41;
            btnClearCash.Text = "CLEAR";
            btnClearCash.UseVisualStyleBackColor = true;
            btnClearCash.Click += btnClearCash_Click;
            // 
            // txtCash
            // 
            txtCash.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCash.Location = new Point(98, 624);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(322, 50);
            txtCash.TabIndex = 42;
            txtCash.TextChanged += textBox1_TextChanged_1;
            txtCash.KeyPress += textBox1_KeyPress;
            txtCash.MouseLeave += txtCash_MouseLeave;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDot.Location = new Point(7, 517);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(116, 105);
            btnDot.TabIndex = 43;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn00
            // 
            btn00.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn00.Location = new Point(160, 517);
            btn00.Name = "btn00";
            btn00.Size = new Size(116, 105);
            btn00.TabIndex = 44;
            btn00.Text = "0";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.Location = new Point(1290, 12);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(172, 38);
            btnApplyDiscount.TabIndex = 45;
            btnApplyDiscount.Text = "Apply Discount";
            btnApplyDiscount.UseVisualStyleBackColor = true;
            btnApplyDiscount.Click += button1_Click_2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKey2);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtCash);
            panel1.Controls.Add(btn00);
            panel1.Controls.Add(btnKey1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnKey3);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(btnKey4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClearCash);
            panel1.Controls.Add(btnKey7);
            panel1.Controls.Add(btnKey6);
            panel1.Controls.Add(btnKey9);
            panel1.Controls.Add(btnKey8);
            panel1.Controls.Add(btnKey5);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1468, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 1041);
            panel1.TabIndex = 46;
            // 
            // SalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(btnApplyDiscount);
            Controls.Add(txtScannedBarcode);
            Controls.Add(dtgvCart);
            Controls.Add(btnSearchProduct);
            Name = "SalesInvoice";
            Text = "Sales Invoice";
            WindowState = FormWindowState.Maximized;
            Load += SalesInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource userTypeBindingSource;
        private Button btnSearchProduct;
        private DataGridView dtgvCart;
        private Label label1;
        private Button btnConfirm;
        private Button button2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label lblTotal;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewCheckBoxColumn select;
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
        private DataGridViewButtonColumn remove;
    }
}