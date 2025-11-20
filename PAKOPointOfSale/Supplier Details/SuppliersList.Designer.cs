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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersList));
            btnExport = new Button();
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
            created_at = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            supplierDetailsBindingSource = new BindingSource(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            dtpFrom = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            btnFilter = new Button();
            btnClearFilter = new Button();
            cmbStatus = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Gold;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(1191, 119);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(79, 24);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1106, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 24);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 121);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 23);
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactnumberDataGridViewTextBoxColumn, accountnumberDataGridViewTextBoxColumn, gatewayDataGridViewTextBoxColumn, is_active, created_at, edit });
            dataGridView1.DataSource = supplierDetailsBindingSource;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1343, 511);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nameDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            addressDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            contactnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            contactnumberDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            contactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountnumberDataGridViewTextBoxColumn
            // 
            accountnumberDataGridViewTextBoxColumn.DataPropertyName = "account_number";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            accountnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            accountnumberDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            accountnumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            accountnumberDataGridViewTextBoxColumn.Name = "accountnumberDataGridViewTextBoxColumn";
            accountnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gatewayDataGridViewTextBoxColumn
            // 
            gatewayDataGridViewTextBoxColumn.DataPropertyName = "gateway";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gatewayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            gatewayDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            gatewayDataGridViewTextBoxColumn.HeaderText = "Gateway";
            gatewayDataGridViewTextBoxColumn.Name = "gatewayDataGridViewTextBoxColumn";
            gatewayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            is_active.DefaultCellStyle = dataGridViewCellStyle7;
            is_active.FillWeight = 85.27919F;
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            created_at.DefaultCellStyle = dataGridViewCellStyle8;
            created_at.FillWeight = 85.27919F;
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // edit
            // 
            edit.DataPropertyName = "id";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            edit.DefaultCellStyle = dataGridViewCellStyle9;
            edit.FillWeight = 203.045685F;
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
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
            pictureBox1.Size = new Size(251, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 146;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Impact", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(440, 82);
            label1.TabIndex = 147;
            label1.Text = "SUPPLIERS LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 102);
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
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1276, 119);
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
            pictureBox3.Location = new Point(-1, 669);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 150;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(317, 121);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(185, 23);
            dtpFrom.TabIndex = 151;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 103);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 152;
            label3.Text = "Date From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 103);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 154;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(532, 121);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(187, 23);
            dtpTo.TabIndex = 153;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Khaki;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Location = new Point(907, 121);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 159;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(255, 128, 128);
            btnClearFilter.FlatStyle = FlatStyle.Popup;
            btnClearFilter.Location = new Point(988, 120);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(75, 23);
            btnClearFilter.TabIndex = 158;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            cmbStatus.Location = new Point(750, 121);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 23);
            cmbStatus.TabIndex = 160;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 102);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 161;
            label5.Text = "Filter Status:";
            // 
            // SuppliersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 770);
            Controls.Add(label5);
            Controls.Add(cmbStatus);
            Controls.Add(btnFilter);
            Controls.Add(btnClearFilter);
            Controls.Add(label4);
            Controls.Add(dtpTo);
            Controls.Add(label3);
            Controls.Add(dtpFrom);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExport);
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
            KeyDown += SuppliersList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExport;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private BindingSource supplierDetailsBindingSource;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnClose;
        private PictureBox pictureBox3;
        private DateTimePicker dtpFrom;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTo;
        private Button btnFilter;
        private Button btnClearFilter;
        private ComboBox cmbStatus;
        private Label label5;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gatewayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewButtonColumn edit;
    }
}