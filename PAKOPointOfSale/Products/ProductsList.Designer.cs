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
            productBindingSource = new BindingSource(components);
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnPrint = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            id = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewLinkColumn();
            productbrandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, barcode, product_name, productbrandDataGridViewTextBoxColumn, productdescriptionDataGridViewTextBoxColumn, productcodeDataGridViewTextBoxColumn, skuDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitofmeasurementDataGridViewTextBoxColumn, costpriceDataGridViewTextBoxColumn, unitpriceDataGridViewTextBoxColumn, remarksDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, datereceivedDataGridViewTextBoxColumn, dateexpirationDataGridViewTextBoxColumn, is_active, createdatDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
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
            dataGridView1.Size = new Size(1344, 549);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            btnAdd.Location = new Point(1069, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Goldenrod;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1150, 117);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
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
            pictureBox3.Location = new Point(0, 557);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1386, 79);
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
            pictureBox1.Size = new Size(1439, 107);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1281, 118);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -3);
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
            label2.Font = new Font("Impact", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(576, 17);
            label2.Name = "label2";
            label2.Size = new Size(395, 75);
            label2.TabIndex = 146;
            label2.Text = "PRODUCTS LIST";
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Resizable = DataGridViewTriState.True;
            id.Visible = false;
            // 
            // barcode
            // 
            barcode.DataPropertyName = "barcode";
            barcode.HeaderText = "Barcode";
            barcode.Name = "barcode";
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product Name";
            product_name.Name = "product_name";
            product_name.Resizable = DataGridViewTriState.True;
            product_name.SortMode = DataGridViewColumnSortMode.Automatic;
            product_name.VisitedLinkColor = Color.Black;
            // 
            // productbrandDataGridViewTextBoxColumn
            // 
            productbrandDataGridViewTextBoxColumn.DataPropertyName = "product_brand";
            productbrandDataGridViewTextBoxColumn.HeaderText = "Brand";
            productbrandDataGridViewTextBoxColumn.Name = "productbrandDataGridViewTextBoxColumn";
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            productdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
            productcodeDataGridViewTextBoxColumn.DataPropertyName = "product_code";
            productcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            skuDataGridViewTextBoxColumn.HeaderText = "SKU";
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitofmeasurementDataGridViewTextBoxColumn
            // 
            unitofmeasurementDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement";
            unitofmeasurementDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitofmeasurementDataGridViewTextBoxColumn.Name = "unitofmeasurementDataGridViewTextBoxColumn";
            // 
            // costpriceDataGridViewTextBoxColumn
            // 
            costpriceDataGridViewTextBoxColumn.DataPropertyName = "cost_price";
            costpriceDataGridViewTextBoxColumn.HeaderText = "Cost Price";
            costpriceDataGridViewTextBoxColumn.Name = "costpriceDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // datereceivedDataGridViewTextBoxColumn
            // 
            datereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received";
            datereceivedDataGridViewTextBoxColumn.HeaderText = "Date Received";
            datereceivedDataGridViewTextBoxColumn.Name = "datereceivedDataGridViewTextBoxColumn";
            // 
            // dateexpirationDataGridViewTextBoxColumn
            // 
            dateexpirationDataGridViewTextBoxColumn.DataPropertyName = "date_expiration";
            dateexpirationDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            dateexpirationDataGridViewTextBoxColumn.Name = "dateexpirationDataGridViewTextBoxColumn";
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "supplier";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            categoryDataGridViewTextBoxColumn.HeaderText = "category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Visible = false;
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
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrint);
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
            WindowState = FormWindowState.Minimized;
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
        private Button btnPrint;
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewLinkColumn product_name;
        private DataGridViewTextBoxColumn productbrandDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}