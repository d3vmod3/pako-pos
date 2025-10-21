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
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.DimGray;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 9.75F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Deffective" });
            cmbStatus.Location = new Point(902, 522);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(353, 24);
            cmbStatus.TabIndex = 109;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Font = new Font("Microsoft Sans Serif", 9.75F);
            num_quantity.Location = new Point(906, 151);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(350, 22);
            num_quantity.TabIndex = 108;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtRemarks.Location = new Point(903, 347);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(353, 161);
            txtRemarks.TabIndex = 107;
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Font = new Font("Microsoft Sans Serif", 9.75F);
            num_unitPrice.Location = new Point(905, 308);
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(350, 22);
            num_unitPrice.TabIndex = 106;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Font = new Font("Microsoft Sans Serif", 9.75F);
            num_costPrice.Location = new Point(905, 257);
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(350, 22);
            num_costPrice.TabIndex = 105;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.BackColor = Color.DimGray;
            cmbUnitofMeasurements.FlatStyle = FlatStyle.Popup;
            cmbUnitofMeasurements.Font = new Font("Microsoft Sans Serif", 9.75F);
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(906, 202);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(349, 24);
            cmbUnitofMeasurements.TabIndex = 104;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.BackColor = Color.DimGray;
            cmbCategory.FlatStyle = FlatStyle.Popup;
            cmbCategory.Font = new Font("Segoe UI", 9.75F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(264, 206);
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
            cmbSupplier.Font = new Font("Segoe UI", 9.75F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(264, 154);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(369, 25);
            cmbSupplier.TabIndex = 102;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(902, 595);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(353, 22);
            dtpDateExpiration.TabIndex = 101;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpDateReceived.Location = new Point(902, 552);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(353, 22);
            dtpDateReceived.TabIndex = 100;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSubmit.Location = new Point(1034, 695);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(106, 27);
            btnSubmit.TabIndex = 99;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblDateExpiration.Location = new Point(746, 601);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(108, 18);
            lblDateExpiration.TabIndex = 98;
            lblDateExpiration.Text = "Date Expiration";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.Location = new Point(746, 558);
            label7.Name = "label7";
            label7.Size = new Size(104, 18);
            label7.TabIndex = 97;
            label7.Text = "Date Received";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblStatus.Location = new Point(746, 522);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 18);
            lblStatus.TabIndex = 96;
            lblStatus.Text = "Status";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblRemarks.Location = new Point(756, 348);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(69, 18);
            lblRemarks.TabIndex = 95;
            lblRemarks.Text = "Remarks";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblUnitPrice.Location = new Point(749, 310);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(72, 18);
            lblUnitPrice.TabIndex = 94;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblCostPrice.Location = new Point(747, 259);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(78, 18);
            lblCostPrice.TabIndex = 93;
            lblCostPrice.Text = "Cost Price";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblUnitofMeasurement.Location = new Point(746, 205);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(154, 18);
            lblUnitofMeasurement.TabIndex = 92;
            lblUnitofMeasurement.Text = "Unit of Measurements";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblQuantity.Location = new Point(746, 154);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 18);
            lblQuantity.TabIndex = 91;
            lblQuantity.Text = "Quantity";
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 9.75F);
            txtSKU.Location = new Point(264, 591);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(369, 25);
            txtSKU.TabIndex = 90;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 9.75F);
            txtProductCode.Location = new Point(264, 539);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(369, 25);
            txtProductCode.TabIndex = 89;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.75F);
            txtDescription.Location = new Point(264, 361);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(369, 161);
            txtDescription.TabIndex = 88;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Font = new Font("Segoe UI", 9.75F);
            txtProductBrand.Location = new Point(264, 315);
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(369, 25);
            txtProductBrand.TabIndex = 87;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 9.75F);
            txtProductName.Location = new Point(264, 256);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(369, 25);
            txtProductName.TabIndex = 86;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblSKU.Location = new Point(143, 599);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(39, 18);
            lblSKU.TabIndex = 85;
            lblSKU.Text = "SKU";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblProductCode.Location = new Point(130, 545);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(100, 18);
            lblProductCode.TabIndex = 84;
            lblProductCode.Text = "Product Code";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblProductDescription.Location = new Point(120, 362);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(139, 18);
            lblProductDescription.TabIndex = 83;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblProductBrand.Location = new Point(120, 316);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(103, 18);
            lblProductBrand.TabIndex = 82;
            lblProductBrand.Text = "Product Brand";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblProductName.Location = new Point(120, 265);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(108, 18);
            lblProductName.TabIndex = 81;
            lblProductName.Text = "Product  Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblCategory.Location = new Point(120, 214);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 18);
            lblCategory.TabIndex = 80;
            lblCategory.Text = "Category";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblSupplierID.Location = new Point(121, 161);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(61, 18);
            lblSupplierID.TabIndex = 79;
            lblSupplierID.Text = "Supplier";
            lblSupplierID.Click += lblSupplierID_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Microsoft Sans Serif", 11.25F);
            chkIsActive.Location = new Point(1186, 641);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(66, 22);
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
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 112;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Impact", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(565, 26);
            label1.Name = "label1";
            label1.Size = new Size(345, 65);
            label1.TabIndex = 113;
            label1.Text = "ADD PRODUCTS";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1146, 695);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 27);
            btnClose.TabIndex = 114;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 9.75F);
            txtBarcode.Location = new Point(264, 285);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(369, 25);
            txtBarcode.TabIndex = 116;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.Location = new Point(120, 286);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 115;
            label2.Text = "Barcode";
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1370, 788);
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
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}