namespace PAKOPointOfSale.Transactions.Return
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            lblInvoiceNumber = new Label();
            label3 = new Label();
            dgvReturnItems = new DataGridView();
            salesInvoiceItemBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnClose = new Button();
            id = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_brand = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            remainingQty = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(753, 112);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(69, 20);
            lblInvoiceNumber.TabIndex = 7;
            lblInvoiceNumber.Text = "000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(598, 111);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 6;
            label3.Text = "Invoice Number:";
            // 
            // dgvReturnItems
            // 
            dgvReturnItems.AllowUserToAddRows = false;
            dgvReturnItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvReturnItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnItems.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvReturnItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnItems.Columns.AddRange(new DataGridViewColumn[] { id, product_id, product_code, product_name, product_brand, quantity, remainingQty, unit_of_measurement, unit_price, discount_type, discount, total_amount, vatable_sales, vat_amount, vat_exempt, transaction_id, remove });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReturnItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReturnItems.Location = new Point(12, 140);
            dgvReturnItems.Name = "dgvReturnItems";
            dgvReturnItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dgvReturnItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReturnItems.Size = new Size(1346, 532);
            dgvReturnItems.TabIndex = 8;
            dgvReturnItems.CellClick += dgvReturnItems_CellClick;
            dgvReturnItems.CellContentClick += dgvReturnItems_CellContentClick;
            dgvReturnItems.CellEndEdit += dgvReturnItems_CellEndEdit;
            dgvReturnItems.EditingControlShowing += dgvReturnItems_EditingControlShowing;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1168, 111);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Confirm Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(352, 16);
            label1.TabIndex = 10;
            label1.Text = "Adjust the \"Quantity to Return\"  for each item to be returned.";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Location = new Point(-1, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1370, 103);
            pictureBox5.TabIndex = 154;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-9, 649);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 155;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 156;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Impact", 47.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(547, 11);
            label2.Name = "label2";
            label2.Size = new Size(499, 76);
            label2.TabIndex = 157;
            label2.Text = "RETURN ITEMS LIST";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1274, 111);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 24);
            btnClose.TabIndex = 158;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            // 
            // product_code
            // 
            product_code.DataPropertyName = "product_code";
            product_code.HeaderText = "Product Code";
            product_code.Name = "product_code";
            product_code.ReadOnly = true;
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
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Quantity to Return";
            quantity.Name = "quantity";
            // 
            // remainingQty
            // 
            remainingQty.HeaderText = "Remaining Quantity";
            remainingQty.Name = "remainingQty";
            remainingQty.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            discount_type.ReadOnly = true;
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Sub Total";
            total_amount.Name = "total_amount";
            total_amount.ReadOnly = true;
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            vatable_sales.ReadOnly = true;
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            vat_amount.ReadOnly = true;
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            transaction_id.HeaderText = "Transaction ID";
            transaction_id.Name = "transaction_id";
            transaction_id.ReadOnly = true;
            transaction_id.Visible = false;
            // 
            // remove
            // 
            remove.DataPropertyName = "id";
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.Text = "Remove Item";
            remove.UseColumnTextForButtonValue = true;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1168, 111);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Confirm Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(330, 16);
            label1.TabIndex = 10;
            label1.Text = "Adjust the applied quantity for each item to be returned.";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Location = new Point(-1, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1370, 103);
            pictureBox5.TabIndex = 154;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-16, 686);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1415, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 155;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 156;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Impact", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(555, 9);
            label2.Name = "label2";
            label2.Size = new Size(533, 82);
            label2.TabIndex = 157;
            label2.Text = "RETURN ITEMS LIST";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1274, 111);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 24);
            btnClose.TabIndex = 158;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 788);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvReturnItems);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnForm";
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumber;
        private Label label3;
        private DataGridView dgvReturnItems;
        private BindingSource salesInvoiceItemBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private Label label1;
        private DataGridViewTextBoxColumn trasaction_id;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnClose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn remainingQty;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewButtonColumn remove;
    }
}