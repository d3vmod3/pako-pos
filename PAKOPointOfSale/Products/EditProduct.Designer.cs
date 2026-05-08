namespace PAKOPointOfSale.Products
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            chkIsActive = new CheckBox();
            cmbStatus = new ComboBox();
            num_quantity = new NumericUpDown();
            txtRemarks = new TextBox();
            num_unitPrice = new NumericUpDown();
            num_costPrice = new NumericUpDown();
            cmbUnitofMeasurements = new ComboBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            dtpDateExpiration = new DateTimePicker();
            dtpDateReceived = new DateTimePicker();
            btnSubmit = new Button();
            lblDateExpiration = new Label();
            label7 = new Label();
            lblStatus = new Label();
            lblRemarks = new Label();
            lblUnitPrice = new Label();
            lblCostPrice = new Label();
            lblUnitofMeasurement = new Label();
            lblQuantity = new Label();
            txtSKU = new TextBox();
            txtProductCode = new TextBox();
            txtDescription = new TextBox();
            txtProductBrand = new TextBox();
            txtProductName = new TextBox();
            lblSKU = new Label();
            lblProductCode = new Label();
            lblProductDescription = new Label();
            lblProductBrand = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblSupplierID = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            txtBarcode = new TextBox();
            label2 = new Label();
            num_low_quantity = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_low_quantity).BeginInit();
            SuspendLayout();
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(1197, 628);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(64, 21);
            chkIsActive.TabIndex = 142;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.DimGray;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Deffective" });
            cmbStatus.Location = new Point(911, 264);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(353, 25);
            cmbStatus.TabIndex = 141;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_quantity.Location = new Point(480, 266);
            num_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(370, 25);
            num_quantity.TabIndex = 140;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(653, 461);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(609, 161);
            txtRemarks.TabIndex = 139;
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_unitPrice.Location = new Point(911, 207);
            num_unitPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(350, 25);
            num_unitPrice.TabIndex = 138;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_costPrice.Location = new Point(911, 152);
            num_costPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(350, 25);
            num_costPrice.TabIndex = 137;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.BackColor = Color.DimGray;
            cmbUnitofMeasurements.FlatStyle = FlatStyle.Popup;
            cmbUnitofMeasurements.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(481, 384);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(369, 25);
            cmbUnitofMeasurements.TabIndex = 136;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.BackColor = Color.DimGray;
            cmbCategory.FlatStyle = FlatStyle.Popup;
            cmbCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(46, 207);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(378, 25);
            cmbCategory.TabIndex = 135;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.BackColor = Color.DimGray;
            cmbSupplier.FlatStyle = FlatStyle.Popup;
            cmbSupplier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(46, 152);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(378, 25);
            cmbSupplier.TabIndex = 134;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(908, 384);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(353, 25);
            dtpDateExpiration.TabIndex = 133;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateReceived.Format = DateTimePickerFormat.Short;
            dtpDateReceived.Location = new Point(911, 321);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(353, 25);
            dtpDateReceived.TabIndex = 132;
            dtpDateReceived.ValueChanged += dtpDateReceived_ValueChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSubmit.Location = new Point(542, 638);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(85, 28);
            btnSubmit.TabIndex = 131;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDateExpiration.Location = new Point(908, 365);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(104, 17);
            lblDateExpiration.TabIndex = 130;
            lblDateExpiration.Text = "Date Expiration:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(911, 300);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 129;
            label7.Text = "Date Received:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblStatus.Location = new Point(911, 246);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 17);
            lblStatus.TabIndex = 128;
            lblStatus.Text = "Status:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRemarks.Location = new Point(653, 441);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(63, 17);
            lblRemarks.TabIndex = 127;
            lblRemarks.Text = "Remarks:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUnitPrice.Location = new Point(911, 189);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(69, 17);
            lblUnitPrice.TabIndex = 126;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCostPrice.Location = new Point(911, 133);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(71, 17);
            lblCostPrice.TabIndex = 125;
            lblCostPrice.Text = "Cost Price:";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUnitofMeasurement.Location = new Point(481, 364);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(146, 17);
            lblUnitofMeasurement.TabIndex = 124;
            lblUnitofMeasurement.Text = "Unit of Measurements:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(480, 248);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(64, 17);
            lblQuantity.TabIndex = 123;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(481, 207);
            txtSKU.MaxLength = 32;
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(369, 25);
            txtSKU.TabIndex = 122;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductCode.Location = new Point(481, 152);
            txtProductCode.MaxLength = 12;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(369, 25);
            txtProductCode.TabIndex = 121;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(44, 461);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(575, 161);
            txtDescription.TabIndex = 120;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductBrand.Location = new Point(46, 384);
            txtProductBrand.MaxLength = 30;
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(378, 25);
            txtProductBrand.TabIndex = 119;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(46, 265);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(378, 25);
            txtProductName.TabIndex = 118;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSKU.Location = new Point(481, 189);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(35, 17);
            lblSKU.TabIndex = 117;
            lblSKU.Text = "SKU:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProductCode.Location = new Point(481, 131);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(94, 17);
            lblProductCode.TabIndex = 116;
            lblProductCode.Text = "Product Code:";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProductDescription.Location = new Point(44, 441);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(131, 17);
            lblProductDescription.TabIndex = 115;
            lblProductDescription.Text = "Product Description:";
            lblProductDescription.Click += lblProductDescription_Click;
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProductBrand.Location = new Point(46, 364);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(99, 17);
            lblProductBrand.TabIndex = 114;
            lblProductBrand.Text = "Product Brand:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProductName.Location = new Point(47, 246);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 17);
            lblProductName.TabIndex = 113;
            lblProductName.Text = "Product  Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCategory.Location = new Point(46, 188);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 17);
            lblCategory.TabIndex = 112;
            lblCategory.Text = "Category:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSupplierID.Location = new Point(46, 132);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(61, 17);
            lblSupplierID.TabIndex = 111;
            lblSupplierID.Text = "Supplier:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1387, 104);
            pictureBox2.TabIndex = 143;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 144;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(256, 19);
            label1.Name = "label1";
            label1.Size = new Size(319, 60);
            label1.TabIndex = 145;
            label1.Text = "EDIT PRODUCTS";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(642, 638);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(83, 28);
            btnClose.TabIndex = 146;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(46, 322);
            txtBarcode.MaxLength = 15;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(378, 25);
            txtBarcode.TabIndex = 148;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(47, 301);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 147;
            label2.Text = "Barcode:";
            // 
            // num_low_quantity
            // 
            num_low_quantity.DecimalPlaces = 2;
            num_low_quantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_low_quantity.Location = new Point(481, 322);
            num_low_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_low_quantity.Name = "num_low_quantity";
            num_low_quantity.Size = new Size(369, 25);
            num_low_quantity.TabIndex = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(481, 301);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 149;
            label3.Text = "Low In Stock Quantity:";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1299, 737);
            Controls.Add(num_low_quantity);
            Controls.Add(label3);
            Controls.Add(txtBarcode);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(chkIsActive);
            Controls.Add(cmbStatus);
            Controls.Add(num_quantity);
            Controls.Add(txtRemarks);
            Controls.Add(num_unitPrice);
            Controls.Add(num_costPrice);
            Controls.Add(cmbUnitofMeasurements);
            Controls.Add(cmbCategory);
            Controls.Add(cmbSupplier);
            Controls.Add(dtpDateExpiration);
            Controls.Add(dtpDateReceived);
            Controls.Add(btnSubmit);
            Controls.Add(lblDateExpiration);
            Controls.Add(label7);
            Controls.Add(lblStatus);
            Controls.Add(lblRemarks);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblCostPrice);
            Controls.Add(lblUnitofMeasurement);
            Controls.Add(lblQuantity);
            Controls.Add(txtSKU);
            Controls.Add(txtProductCode);
            Controls.Add(txtDescription);
            Controls.Add(txtProductBrand);
            Controls.Add(txtProductName);
            Controls.Add(lblSKU);
            Controls.Add(lblProductCode);
            Controls.Add(lblProductDescription);
            Controls.Add(lblProductBrand);
            Controls.Add(lblProductName);
            Controls.Add(lblCategory);
            Controls.Add(lblSupplierID);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProducts";
            Load += EditProduct_Load;
            KeyDown += EditProduct_KeyDown;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_low_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsActive;
        private ComboBox cmbStatus;
        private NumericUpDown num_quantity;
        private TextBox txtRemarks;
        private NumericUpDown num_unitPrice;
        private NumericUpDown num_costPrice;
        private ComboBox cmbUnitofMeasurements;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private DateTimePicker dtpDateExpiration;
        private DateTimePicker dtpDateReceived;
        private Button btnSubmit;
        private Label lblDateExpiration;
        private Label label7;
        private Label lblStatus;
        private Label lblRemarks;
        private Label lblUnitPrice;
        private Label lblCostPrice;
        private Label lblUnitofMeasurement;
        private Label lblQuantity;
        private TextBox txtSKU;
        private TextBox txtProductCode;
        private TextBox txtDescription;
        private TextBox txtProductBrand;
        private TextBox txtProductName;
        private Label lblSKU;
        private Label lblProductCode;
        private Label lblProductDescription;
        private Label lblProductBrand;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblSupplierID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private TextBox txtBarcode;
        private Label label2;
        private NumericUpDown num_low_quantity;
        private Label label3;
    }
}