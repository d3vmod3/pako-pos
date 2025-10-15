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
            btnPrint = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            supplierDetailsBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(917, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(836, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(433, 23);
            txtSearch.TabIndex = 7;
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactnumberDataGridViewTextBoxColumn, accountnumberDataGridViewTextBoxColumn, gatewayDataGridViewTextBoxColumn, is_active, createdatDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn, edit });
            dataGridView1.DataSource = supplierDetailsBindingSource;
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(980, 413);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // supplierDetailsBindingSource
            // 
            supplierDetailsBindingSource.DataSource = typeof(SupplierDetails);
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            contactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountnumberDataGridViewTextBoxColumn
            // 
            accountnumberDataGridViewTextBoxColumn.DataPropertyName = "account_number";
            accountnumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            accountnumberDataGridViewTextBoxColumn.Name = "accountnumberDataGridViewTextBoxColumn";
            accountnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gatewayDataGridViewTextBoxColumn
            // 
            gatewayDataGridViewTextBoxColumn.DataPropertyName = "gateway";
            gatewayDataGridViewTextBoxColumn.HeaderText = "Gateway";
            gatewayDataGridViewTextBoxColumn.Name = "gatewayDataGridViewTextBoxColumn";
            gatewayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            productsDataGridViewTextBoxColumn.DataPropertyName = "products";
            productsDataGridViewTextBoxColumn.HeaderText = "products";
            productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            productsDataGridViewTextBoxColumn.ReadOnly = true;
            productsDataGridViewTextBoxColumn.Visible = false;
            // 
            // edit
            // 
            edit.DataPropertyName = "id";
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // SuppliersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 499);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Name = "SuppliersList";
            Text = "Suppliers List";
            Load += SuppliersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).EndInit();
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
    }
}