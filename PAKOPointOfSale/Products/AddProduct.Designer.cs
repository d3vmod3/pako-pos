namespace PAKOPointOfSale.Products
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
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
            chkIsActive = new CheckBox();
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
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.DimGray;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Defective" });
            cmbStatus.Location = new Point(938, 289);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(353, 25);
            cmbStatus.TabIndex = 109;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_quantity.Location = new Point(520, 291);
            num_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(369, 25);
            num_quantity.TabIndex = 108;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(688, 470);
            txtRemarks.MaxLength = 50;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(604, 160);
            txtRemarks.TabIndex = 107;
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_unitPrice.Location = new Point(937, 231);
            num_unitPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(350, 25);
            num_unitPrice.TabIndex = 106;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_costPrice.Location = new Point(940, 175);
            num_costPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(350, 25);
            num_costPrice.TabIndex = 105;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.BackColor = Color.DimGray;
            cmbUnitofMeasurements.FlatStyle = FlatStyle.Popup;
            cmbUnitofMeasurements.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "", "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(519, 404);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(369, 25);
            cmbUnitofMeasurements.TabIndex = 104;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.BackColor = Color.DimGray;
            cmbCategory.FlatStyle = FlatStyle.Popup;
            cmbCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(86, 231);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(369, 25);
            cmbCategory.TabIndex = 103;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.BackColor = Color.DimGray;
            cmbSupplier.FlatStyle = FlatStyle.Popup;
            cmbSupplier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(88, 177);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(369, 25);
            cmbSupplier.TabIndex = 102;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(937, 404);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(353, 25);
            dtpDateExpiration.TabIndex = 101;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateReceived.Format = DateTimePickerFormat.Short;
            dtpDateReceived.Location = new Point(939, 346);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(353, 25);
            dtpDateReceived.TabIndex = 100;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSubmit.Location = new Point(576, 658);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 27);
            btnSubmit.TabIndex = 99;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateExpiration.Location = new Point(937, 384);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(104, 17);
            lblDateExpiration.TabIndex = 98;
            lblDateExpiration.Text = "Date Expiration:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(939, 326);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 97;
            label7.Text = "Date Received:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(937, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 17);
            lblStatus.TabIndex = 96;
            lblStatus.Text = "Status:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemarks.Location = new Point(689, 449);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(63, 17);
            lblRemarks.TabIndex = 95;
            lblRemarks.Text = "Remarks:";
            lblRemarks.Click += lblRemarks_Click;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(937, 213);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(69, 17);
            lblUnitPrice.TabIndex = 94;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostPrice.Location = new Point(941, 155);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(71, 17);
            lblCostPrice.TabIndex = 93;
            lblCostPrice.Text = "Cost Price:";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitofMeasurement.Location = new Point(519, 384);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(146, 17);
            lblUnitofMeasurement.TabIndex = 92;
            lblUnitofMeasurement.Text = "Unit of Measurements:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(519, 270);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(64, 17);
            lblQuantity.TabIndex = 91;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += lblQuantity_Click_1;
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(521, 231);
            txtSKU.MaxLength = 32;
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(369, 25);
            txtSKU.TabIndex = 90;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductCode.Location = new Point(521, 175);
            txtProductCode.MaxLength = 12;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(369, 25);
            txtProductCode.TabIndex = 89;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(86, 470);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(572, 161);
            txtDescription.TabIndex = 88;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtProductBrand.Location = new Point(84, 405);
            txtProductBrand.MaxLength = 30;
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(369, 25);
            txtProductBrand.TabIndex = 87;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtProductName.Location = new Point(85, 291);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(369, 25);
            txtProductName.TabIndex = 86;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU.Location = new Point(521, 212);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(35, 17);
            lblSKU.TabIndex = 85;
            lblSKU.Text = "SKU:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductCode.Location = new Point(521, 156);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(94, 17);
            lblProductCode.TabIndex = 84;
            lblProductCode.Text = "Product Code:";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductDescription.Location = new Point(86, 447);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(131, 17);
            lblProductDescription.TabIndex = 83;
            lblProductDescription.Text = "Product Description:";
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductBrand.Location = new Point(84, 383);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(99, 17);
            lblProductBrand.TabIndex = 82;
            lblProductBrand.Text = "Product Brand:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(84, 272);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 17);
            lblProductName.TabIndex = 81;
            lblProductName.Text = "Product  Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(86, 212);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 17);
            lblCategory.TabIndex = 80;
            lblCategory.Text = "Category:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierID.Location = new Point(89, 157);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(61, 17);
            lblSupplierID.TabIndex = 79;
            lblSupplierID.Text = "Supplier:";
            lblSupplierID.Click += lblSupplierID_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(1225, 632);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(64, 21);
            chkIsActive.TabIndex = 110;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1371, 117);
            pictureBox2.TabIndex = 111;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 112;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(613, 16);
            label1.Name = "label1";
            label1.Size = new Size(416, 80);
            label1.TabIndex = 113;
            label1.Text = "ADD PRODUCTS";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(689, 658);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 27);
            btnClose.TabIndex = 114;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtBarcode.Location = new Point(86, 349);
            txtBarcode.MaxLength = 15;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(369, 25);
            txtBarcode.TabIndex = 116;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 329);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 115;
            label2.Text = "Barcode:";
            // 
            // num_low_quantity
            // 
            num_low_quantity.DecimalPlaces = 2;
            num_low_quantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_low_quantity.Location = new Point(521, 346);
            num_low_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_low_quantity.Name = "num_low_quantity";
            num_low_quantity.Size = new Size(369, 25);
            num_low_quantity.TabIndex = 118;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 326);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 117;
            label3.Text = "Low In Stock Quantity:";
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 747);
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
            Name = "AddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProducts";
            Load += AddProducts_Load;
            KeyDown += AddProducts_KeyDown;
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
        private CheckBox chkIsActive;
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