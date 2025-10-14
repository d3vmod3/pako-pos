namespace PAKOPointOfSale.Supplier_Details
{
    partial class SupplierDetails
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
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnPrint = new Button();
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, contactnumberDataGridViewTextBoxColumn, accountnumberDataGridViewTextBoxColumn, gatewayDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = supplierDetailsBindingSource;
            dataGridView1.Location = new Point(-1, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1093, 413);
            dataGridView1.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(58, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(433, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(515, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(607, 11);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
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
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            addressDataGridViewTextBoxColumn.HeaderText = "address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            contactnumberDataGridViewTextBoxColumn.HeaderText = "contact_number";
            contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            // 
            // accountnumberDataGridViewTextBoxColumn
            // 
            accountnumberDataGridViewTextBoxColumn.DataPropertyName = "account_number";
            accountnumberDataGridViewTextBoxColumn.HeaderText = "account_number";
            accountnumberDataGridViewTextBoxColumn.Name = "accountnumberDataGridViewTextBoxColumn";
            // 
            // gatewayDataGridViewTextBoxColumn
            // 
            gatewayDataGridViewTextBoxColumn.DataPropertyName = "gateway";
            gatewayDataGridViewTextBoxColumn.HeaderText = "gateway";
            gatewayDataGridViewTextBoxColumn.Name = "gatewayDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // productsDataGridViewTextBoxColumn
            // 
            productsDataGridViewTextBoxColumn.DataPropertyName = "products";
            productsDataGridViewTextBoxColumn.HeaderText = "products";
            productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            // 
            // SupplierDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Name = "SupplierDetails";
            Text = "SupplierDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierDetailsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnPrint;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gatewayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private BindingSource supplierDetailsBindingSource;
    }
}