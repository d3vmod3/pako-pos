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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gatewayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(561, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(469, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactnumberDataGridViewTextBoxColumn, accountnumberDataGridViewTextBoxColumn, gatewayDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = supplierDetailsBindingSource;
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(980, 413);
            dataGridView1.TabIndex = 5;
            // 
            // supplierDetailsBindingSource
            // 
            supplierDetailsBindingSource.DataSource = typeof(SupplierDetails);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
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
            Text = "SuppliersList";
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gatewayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
    }
}