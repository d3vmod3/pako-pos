namespace PAKOPointOfSale.Products
{
    partial class ProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewLinkColumn();
            productbrandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            category_name = new DataGridViewTextBoxColumn();
            supplier_name = new DataGridViewTextBoxColumn();
            productdescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            skuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitofmeasurementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costpriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitpriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datereceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateexpirationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            productBindingSource = new BindingSource(components);
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnExport = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            cmbFilterType = new ComboBox();
            btnFilter = new Button();
            btnClearFilter = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, barcode, product_name, productbrandDataGridViewTextBoxColumn, category_name, supplier_name, productdescriptionDataGridViewTextBoxColumn, productcodeDataGridViewTextBoxColumn, skuDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitofmeasurementDataGridViewTextBoxColumn, costpriceDataGridViewTextBoxColumn, unitpriceDataGridViewTextBoxColumn, remarksDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, datereceivedDataGridViewTextBoxColumn, dateexpirationDataGridViewTextBoxColumn, is_active, createdatDataGridViewTextBoxColumn, edit });
            dataGridView1.DataSource = productBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1344, 516);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.True;
            id.Visible = false;
            id.Width = 23;
            // 
            // barcode
            // 
            barcode.DataPropertyName = "barcode";
            barcode.HeaderText = "Barcode";
            barcode.Name = "barcode";
            barcode.ReadOnly = true;
            barcode.Width = 75;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product Name";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            product_name.Resizable = DataGridViewTriState.True;
            product_name.SortMode = DataGridViewColumnSortMode.Automatic;
            product_name.VisitedLinkColor = Color.Black;
            product_name.Width = 109;
            // 
            // productbrandDataGridViewTextBoxColumn
            // 
            productbrandDataGridViewTextBoxColumn.DataPropertyName = "product_brand";
            productbrandDataGridViewTextBoxColumn.HeaderText = "Brand";
            productbrandDataGridViewTextBoxColumn.Name = "productbrandDataGridViewTextBoxColumn";
            productbrandDataGridViewTextBoxColumn.ReadOnly = true;
            productbrandDataGridViewTextBoxColumn.Width = 63;
            // 
            // category_name
            // 
            category_name.DataPropertyName = "category_name";
            category_name.HeaderText = "Category";
            category_name.Name = "category_name";
            category_name.ReadOnly = true;
            category_name.Width = 80;
            // 
            // supplier_name
            // 
            supplier_name.DataPropertyName = "supplier_name";
            supplier_name.HeaderText = "Supplier";
            supplier_name.Name = "supplier_name";
            supplier_name.ReadOnly = true;
            supplier_name.Width = 75;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            productdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            productdescriptionDataGridViewTextBoxColumn.Width = 92;
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
            productcodeDataGridViewTextBoxColumn.DataPropertyName = "product_code";
            productcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            productcodeDataGridViewTextBoxColumn.ReadOnly = true;
            productcodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            skuDataGridViewTextBoxColumn.HeaderText = "SKU";
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.ReadOnly = true;
            skuDataGridViewTextBoxColumn.Width = 53;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 78;
            // 
            // unitofmeasurementDataGridViewTextBoxColumn
            // 
            unitofmeasurementDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement";
            unitofmeasurementDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitofmeasurementDataGridViewTextBoxColumn.Name = "unitofmeasurementDataGridViewTextBoxColumn";
            unitofmeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            unitofmeasurementDataGridViewTextBoxColumn.Width = 54;
            // 
            // costpriceDataGridViewTextBoxColumn
            // 
            costpriceDataGridViewTextBoxColumn.DataPropertyName = "cost_price";
            costpriceDataGridViewTextBoxColumn.HeaderText = "Cost Price";
            costpriceDataGridViewTextBoxColumn.Name = "costpriceDataGridViewTextBoxColumn";
            costpriceDataGridViewTextBoxColumn.ReadOnly = true;
            costpriceDataGridViewTextBoxColumn.Width = 85;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitpriceDataGridViewTextBoxColumn.Width = 83;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            remarksDataGridViewTextBoxColumn.Visible = false;
            remarksDataGridViewTextBoxColumn.Width = 77;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Visible = false;
            statusDataGridViewTextBoxColumn.Width = 64;
            // 
            // datereceivedDataGridViewTextBoxColumn
            // 
            datereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received";
            datereceivedDataGridViewTextBoxColumn.HeaderText = "Date Received";
            datereceivedDataGridViewTextBoxColumn.Name = "datereceivedDataGridViewTextBoxColumn";
            datereceivedDataGridViewTextBoxColumn.ReadOnly = true;
            datereceivedDataGridViewTextBoxColumn.Width = 106;
            // 
            // dateexpirationDataGridViewTextBoxColumn
            // 
            dateexpirationDataGridViewTextBoxColumn.DataPropertyName = "date_expiration";
            dateexpirationDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            dateexpirationDataGridViewTextBoxColumn.Name = "dateexpirationDataGridViewTextBoxColumn";
            dateexpirationDataGridViewTextBoxColumn.ReadOnly = true;
            dateexpirationDataGridViewTextBoxColumn.Width = 111;
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            is_active.Visible = false;
            is_active.Width = 46;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.MinimumWidth = 70;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit Product";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 70;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(WinFormsApp1.Model.Product);
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(12, 115);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            lblSearch.Click += lblSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(63, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(326, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1119, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Goldenrod;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(1200, 108);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(1368, 636);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 530);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1386, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 136);
            label1.Name = "label1";
            label1.Size = new Size(181, 16);
            label1.TabIndex = 7;
            label1.Text = "Click the product name to edit";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-53, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1439, 106);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1281, 108);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 145;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Impact", 47.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(576, 13);
            label2.Name = "label2";
            label2.Size = new Size(413, 76);
            label2.TabIndex = 146;
            label2.Text = "PRODUCTS LIST";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 113);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 147;
            label3.Text = "Filter By:";
            // 
            // cmbFilterType
            // 
            cmbFilterType.FormattingEnabled = true;
            cmbFilterType.Items.AddRange(new object[] { "", "Date and Time", "Date Received", "Expiration Date", "Status", "Stock" });
            cmbFilterType.Location = new Point(551, 109);
            cmbFilterType.Name = "cmbFilterType";
            cmbFilterType.Size = new Size(216, 23);
            cmbFilterType.TabIndex = 148;
            cmbFilterType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 255, 128);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Location = new Point(773, 109);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 149;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(255, 128, 128);
            btnClearFilter.FlatStyle = FlatStyle.Popup;
            btnClearFilter.Location = new Point(854, 109);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(75, 23);
            btnClearFilter.TabIndex = 150;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1368, 788);
            ControlBox = false;
            Controls.Add(btnClearFilter);
            Controls.Add(btnFilter);
            Controls.Add(cmbFilterType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnExport);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsList";
            Load += ProductsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnExport;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Label label3;
        private ComboBox cmbFilterType;
        private Button btnFilter;
        private Button btnClearFilter;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewLinkColumn product_name;
        private DataGridViewTextBoxColumn productbrandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn category_name;
        private DataGridViewTextBoxColumn supplier_name;
        private DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitofmeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datereceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateexpirationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn edit;
    }
}