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
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).BeginInit();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Deffective", "Damaged" });
            cmbStatus.Location = new Point(643, 396);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(257, 23);
            cmbStatus.TabIndex = 109;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Location = new Point(647, 25);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(254, 23);
            num_quantity.TabIndex = 108;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(644, 221);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(257, 161);
            txtRemarks.TabIndex = 107;
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Location = new Point(646, 182);
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(254, 23);
            num_unitPrice.TabIndex = 106;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Location = new Point(646, 131);
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(254, 23);
            num_costPrice.TabIndex = 105;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(647, 76);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(253, 23);
            cmbUnitofMeasurements.TabIndex = 104;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(156, 79);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(257, 23);
            cmbCategory.TabIndex = 103;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(156, 27);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(257, 23);
            cmbSupplier.TabIndex = 102;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(643, 469);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(257, 23);
            dtpDateExpiration.TabIndex = 101;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Location = new Point(643, 426);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(257, 23);
            dtpDateReceived.TabIndex = 100;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(825, 503);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 99;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Location = new Point(503, 475);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(86, 15);
            lblDateExpiration.TabIndex = 98;
            lblDateExpiration.Text = "Date Expiration";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 432);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 97;
            label7.Text = "Date Received";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(503, 396);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 96;
            lblStatus.Text = "Status";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(504, 232);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(52, 15);
            lblRemarks.TabIndex = 95;
            lblRemarks.Text = "Remarks";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(506, 184);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(58, 15);
            lblUnitPrice.TabIndex = 94;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Location = new Point(504, 133);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(60, 15);
            lblCostPrice.TabIndex = 93;
            lblCostPrice.Text = "Cost Price";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Location = new Point(503, 79);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(124, 15);
            lblUnitofMeasurement.TabIndex = 92;
            lblUnitofMeasurement.Text = "Unit of Measurements";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(503, 28);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 91;
            lblQuantity.Text = "Quantity";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(156, 464);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(257, 23);
            txtSKU.TabIndex = 90;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(156, 412);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(257, 23);
            txtProductCode.TabIndex = 89;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(156, 234);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(257, 161);
            txtDescription.TabIndex = 88;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Location = new Point(156, 188);
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(257, 23);
            txtProductBrand.TabIndex = 87;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(156, 129);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(257, 23);
            txtProductName.TabIndex = 86;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(32, 472);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(28, 15);
            lblSKU.TabIndex = 85;
            lblSKU.Text = "SKU";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(32, 420);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(80, 15);
            lblProductCode.TabIndex = 84;
            lblProductCode.Text = "Product Code";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(32, 242);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 83;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Location = new Point(32, 196);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(83, 15);
            lblProductBrand.TabIndex = 82;
            lblProductBrand.Text = "Product Brand";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(32, 137);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(87, 15);
            lblProductName.TabIndex = 81;
            lblProductName.Text = "Product  Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(32, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 80;
            lblCategory.Text = "Category";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Location = new Point(32, 30);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(50, 15);
            lblSupplierID.TabIndex = 79;
            lblSupplierID.Text = "Supplier";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(737, 506);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 110;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 550);
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
            Name = "AddProducts";
            Text = "AddProducts";
            Load += AddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).EndInit();
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
    }
}