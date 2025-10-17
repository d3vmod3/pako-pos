namespace PAKOPointOfSale.Supplier_Details
{
    partial class SuppliersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersList));
            btnPrint = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gatewayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            supplierDetailsBindingSource = new BindingSource(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gold;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Location = new Point(1150, 101);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(79, 24);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(1065, 101);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 24);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(77, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(433, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(-133, 7);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Search:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactnumberDataGridViewTextBoxColumn, accountnumberDataGridViewTextBoxColumn, gatewayDataGridViewTextBoxColumn, is_active, createdatDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn, edit });
            dataGridView1.DataSource = supplierDetailsBindingSource;
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1343, 520);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            // 
            // accountnumberDataGridViewTextBoxColumn
            // 
            accountnumberDataGridViewTextBoxColumn.DataPropertyName = "account_number";
            accountnumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            accountnumberDataGridViewTextBoxColumn.Name = "accountnumberDataGridViewTextBoxColumn";
            // 
            // gatewayDataGridViewTextBoxColumn
            // 
            gatewayDataGridViewTextBoxColumn.DataPropertyName = "gateway";
            gatewayDataGridViewTextBoxColumn.HeaderText = "Gateway";
            gatewayDataGridViewTextBoxColumn.Name = "gatewayDataGridViewTextBoxColumn";
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
            // productsDataGridViewTextBoxColumn
            // 
            productsDataGridViewTextBoxColumn.DataPropertyName = "products";
            productsDataGridViewTextBoxColumn.HeaderText = "products";
            productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            productsDataGridViewTextBoxColumn.Visible = false;
            // 
            // edit
            // 
            edit.DataPropertyName = "id";
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // supplierDetailsBindingSource
            // 
            supplierDetailsBindingSource.DataSource = typeof(SupplierDetails);
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1370, 95);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 146;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Impact", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(607, 18);
            label1.Name = "label1";
            label1.Size = new Size(334, 63);
            label1.TabIndex = 147;
            label1.Text = "SUPPLIERS LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 148;
            label2.Text = "Search:";
            label2.Click += label2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Location = new Point(1259, 101);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 24);
            btnClose.TabIndex = 149;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-33, 657);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 150;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // SuppliersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 749);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuppliersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suppliers List";
            WindowState = FormWindowState.Maximized;
            Load += SuppliersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private BindingSource supplierDetailsBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gatewayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn edit;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnClose;
        private PictureBox pictureBox3;
    }
}