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
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).BeginInit();
            SuspendLayout();
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(770, 507);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 142;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Deffective", "Damaged" });
            cmbStatus.Location = new Point(676, 397);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(257, 23);
            cmbStatus.TabIndex = 141;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Location = new Point(680, 26);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(254, 23);
            num_quantity.TabIndex = 140;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(677, 222);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(257, 161);
            txtRemarks.TabIndex = 139;
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Location = new Point(679, 183);
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(254, 23);
            num_unitPrice.TabIndex = 138;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Location = new Point(679, 132);
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(254, 23);
            num_costPrice.TabIndex = 137;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(680, 77);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(253, 23);
            cmbUnitofMeasurements.TabIndex = 136;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(189, 80);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(257, 23);
            cmbCategory.TabIndex = 135;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(189, 28);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(257, 23);
            cmbSupplier.TabIndex = 134;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(676, 470);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(257, 23);
            dtpDateExpiration.TabIndex = 133;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Location = new Point(676, 427);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(257, 23);
            dtpDateReceived.TabIndex = 132;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(858, 504);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 131;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Location = new Point(536, 476);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(86, 15);
            lblDateExpiration.TabIndex = 130;
            lblDateExpiration.Text = "Date Expiration";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 433);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 129;
            label7.Text = "Date Received";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(536, 397);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 128;
            lblStatus.Text = "Status";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(537, 233);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(52, 15);
            lblRemarks.TabIndex = 127;
            lblRemarks.Text = "Remarks";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(539, 185);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(58, 15);
            lblUnitPrice.TabIndex = 126;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Location = new Point(537, 134);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(60, 15);
            lblCostPrice.TabIndex = 125;
            lblCostPrice.Text = "Cost Price";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Location = new Point(536, 80);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(124, 15);
            lblUnitofMeasurement.TabIndex = 124;
            lblUnitofMeasurement.Text = "Unit of Measurements";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(536, 29);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 123;
            lblQuantity.Text = "Quantity";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(189, 465);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(257, 23);
            txtSKU.TabIndex = 122;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(189, 413);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(257, 23);
            txtProductCode.TabIndex = 121;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(189, 235);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(257, 161);
            txtDescription.TabIndex = 120;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Location = new Point(189, 189);
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(257, 23);
            txtProductBrand.TabIndex = 119;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(189, 130);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(257, 23);
            txtProductName.TabIndex = 118;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(65, 473);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(28, 15);
            lblSKU.TabIndex = 117;
            lblSKU.Text = "SKU";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(65, 421);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(80, 15);
            lblProductCode.TabIndex = 116;
            lblProductCode.Text = "Product Code";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(65, 243);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 115;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Location = new Point(65, 197);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(83, 15);
            lblProductBrand.TabIndex = 114;
            lblProductBrand.Text = "Product Brand";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(65, 138);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(87, 15);
            lblProductName.TabIndex = 113;
            lblProductName.Text = "Product  Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(65, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 112;
            lblCategory.Text = "Category";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Location = new Point(65, 31);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(50, 15);
            lblSupplierID.TabIndex = 111;
            lblSupplierID.Text = "Supplier";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 552);
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
            Name = "EditProduct";
            Text = "EditProducts";
            Load += EditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).EndInit();
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
    }
}