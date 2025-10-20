namespace PAKOPointOfSale.Transactions
{
    partial class SearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProduct));
            label1 = new Label();
            txtSearch = new TextBox();
            productBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            addToCart = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblsearchproduct = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Search Product:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(107, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(WinFormsApp1.Model.Product);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_name, addToCart, id, productdescriptionDataGridViewTextBoxColumn, productcodeDataGridViewTextBoxColumn, skuDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitofmeasurementDataGridViewTextBoxColumn, costpriceDataGridViewTextBoxColumn, unitpriceDataGridViewTextBoxColumn, remarksDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, datereceivedDataGridViewTextBoxColumn, dateexpirationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1346, 437);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // addToCart
            // 
            addToCart.DataPropertyName = "id";
            addToCart.HeaderText = "Action";
            addToCart.Name = "addToCart";
            addToCart.ReadOnly = true;
            addToCart.Text = "Add";
            addToCart.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            productdescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
            productcodeDataGridViewTextBoxColumn.DataPropertyName = "product_code";
            productcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            productcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            skuDataGridViewTextBoxColumn.HeaderText = "SKU";
            skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            skuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitofmeasurementDataGridViewTextBoxColumn
            // 
            unitofmeasurementDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement";
            unitofmeasurementDataGridViewTextBoxColumn.HeaderText = "Unit of Measurement";
            unitofmeasurementDataGridViewTextBoxColumn.Name = "unitofmeasurementDataGridViewTextBoxColumn";
            unitofmeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costpriceDataGridViewTextBoxColumn
            // 
            costpriceDataGridViewTextBoxColumn.DataPropertyName = "cost_price";
            costpriceDataGridViewTextBoxColumn.HeaderText = "cost_price";
            costpriceDataGridViewTextBoxColumn.Name = "costpriceDataGridViewTextBoxColumn";
            costpriceDataGridViewTextBoxColumn.ReadOnly = true;
            costpriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datereceivedDataGridViewTextBoxColumn
            // 
            datereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received";
            datereceivedDataGridViewTextBoxColumn.HeaderText = "Date Received";
            datereceivedDataGridViewTextBoxColumn.Name = "datereceivedDataGridViewTextBoxColumn";
            datereceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateexpirationDataGridViewTextBoxColumn
            // 
            dateexpirationDataGridViewTextBoxColumn.DataPropertyName = "date_expiration";
            dateexpirationDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            dateexpirationDataGridViewTextBoxColumn.Name = "dateexpirationDataGridViewTextBoxColumn";
            dateexpirationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1371, 90);
            pictureBox2.TabIndex = 112;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // lblsearchproduct
            // 
            lblsearchproduct.AutoSize = true;
            lblsearchproduct.BackColor = Color.DimGray;
            lblsearchproduct.Font = new Font("Impact", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearchproduct.ForeColor = Color.White;
            lblsearchproduct.Location = new Point(464, 12);
            lblsearchproduct.Name = "lblsearchproduct";
            lblsearchproduct.Size = new Size(396, 65);
            lblsearchproduct.TabIndex = 114;
            lblsearchproduct.Text = "SEARCH PRODUCT";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-14, 567);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 151;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1283, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 152;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SearchProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 654);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(lblsearchproduct);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchProduct";
            WindowState = FormWindowState.Maximized;
            Load += SearchProduct_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productbrandDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblsearchproduct;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewButtonColumn addToCart;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitofmeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datereceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateexpirationDataGridViewTextBoxColumn;
        private PictureBox pictureBox3;
        private Button button1;
    }
}