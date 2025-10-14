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
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            productIDDataGridView = new DataGridViewTextBoxColumn();
            supplierIDDataGridView = new DataGridViewTextBoxColumn();
            categoryDataGridView = new DataGridViewTextBoxColumn();
            productnameDataGridView = new DataGridViewTextBoxColumn();
            productbrandDataGridView = new DataGridViewTextBoxColumn();
            productdescriptionDataGridView = new DataGridViewTextBoxColumn();
            productcodeDataGridView = new DataGridViewTextBoxColumn();
            skuDataGridView = new DataGridViewTextBoxColumn();
            quantityDataGridView = new DataGridViewTextBoxColumn();
            unitofmeasurementDataGridView = new DataGridViewTextBoxColumn();
            costpriceDataGridView = new DataGridViewTextBoxColumn();
            unitpriceDataGridView = new DataGridViewTextBoxColumn();
            remarksDataGridView = new DataGridViewTextBoxColumn();
            statusDataGridView = new DataGridViewTextBoxColumn();
            datereceivedDataGridView = new DataGridViewTextBoxColumn();
            dateexpirationDataGridView = new DataGridViewTextBoxColumn();
            createdatDataGridView = new DataGridViewTextBoxColumn();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridView, supplierIDDataGridView, categoryDataGridView, productnameDataGridView, productbrandDataGridView, productdescriptionDataGridView, productcodeDataGridView, skuDataGridView, quantityDataGridView, unitofmeasurementDataGridView, costpriceDataGridView, unitpriceDataGridView, remarksDataGridView, statusDataGridView, datereceivedDataGridView, dateexpirationDataGridView, createdatDataGridView });
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1239, 402);
            dataGridView1.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(40, 54);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(103, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(445, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(544, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // productIDDataGridView
            // 
            productIDDataGridView.HeaderText = "Product ID";
            productIDDataGridView.Name = "productIDDataGridView";
            productIDDataGridView.Width = 70;
            // 
            // supplierIDDataGridView
            // 
            supplierIDDataGridView.HeaderText = "Supplier ID";
            supplierIDDataGridView.Name = "supplierIDDataGridView";
            supplierIDDataGridView.Width = 70;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.HeaderText = "Category";
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.Width = 70;
            // 
            // productnameDataGridView
            // 
            productnameDataGridView.HeaderText = "Product Name";
            productnameDataGridView.Name = "productnameDataGridView";
            productnameDataGridView.Width = 70;
            // 
            // productbrandDataGridView
            // 
            productbrandDataGridView.HeaderText = "Product Brand";
            productbrandDataGridView.Name = "productbrandDataGridView";
            productbrandDataGridView.Width = 70;
            // 
            // productdescriptionDataGridView
            // 
            productdescriptionDataGridView.HeaderText = "Product Description";
            productdescriptionDataGridView.Name = "productdescriptionDataGridView";
            productdescriptionDataGridView.Width = 70;
            // 
            // productcodeDataGridView
            // 
            productcodeDataGridView.HeaderText = "Product Code";
            productcodeDataGridView.Name = "productcodeDataGridView";
            productcodeDataGridView.Width = 70;
            // 
            // skuDataGridView
            // 
            skuDataGridView.HeaderText = "SKU";
            skuDataGridView.Name = "skuDataGridView";
            skuDataGridView.Width = 70;
            // 
            // quantityDataGridView
            // 
            quantityDataGridView.HeaderText = "Quantity";
            quantityDataGridView.Name = "quantityDataGridView";
            quantityDataGridView.Width = 70;
            // 
            // unitofmeasurementDataGridView
            // 
            unitofmeasurementDataGridView.HeaderText = "Unit of Measurement";
            unitofmeasurementDataGridView.Name = "unitofmeasurementDataGridView";
            unitofmeasurementDataGridView.Width = 70;
            // 
            // costpriceDataGridView
            // 
            costpriceDataGridView.HeaderText = "Cost Price ";
            costpriceDataGridView.Name = "costpriceDataGridView";
            costpriceDataGridView.Width = 70;
            // 
            // unitpriceDataGridView
            // 
            unitpriceDataGridView.HeaderText = "Unit Price";
            unitpriceDataGridView.Name = "unitpriceDataGridView";
            unitpriceDataGridView.Width = 70;
            // 
            // remarksDataGridView
            // 
            remarksDataGridView.HeaderText = "Remarks";
            remarksDataGridView.Name = "remarksDataGridView";
            remarksDataGridView.Width = 70;
            // 
            // statusDataGridView
            // 
            statusDataGridView.HeaderText = "Status";
            statusDataGridView.Name = "statusDataGridView";
            statusDataGridView.Width = 70;
            // 
            // datereceivedDataGridView
            // 
            datereceivedDataGridView.HeaderText = "Data Received";
            datereceivedDataGridView.Name = "datereceivedDataGridView";
            datereceivedDataGridView.Width = 70;
            // 
            // dateexpirationDataGridView
            // 
            dateexpirationDataGridView.HeaderText = "Date Expiration";
            dateexpirationDataGridView.Name = "dateexpirationDataGridView";
            dateexpirationDataGridView.Width = 70;
            // 
            // createdatDataGridView
            // 
            createdatDataGridView.HeaderText = "Created at";
            createdatDataGridView.Name = "createdatDataGridView";
            createdatDataGridView.Width = 70;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(646, 45);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 500);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Name = "ProductsList";
            Text = "ProductsList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnEdit;
        private DataGridViewTextBoxColumn productIDDataGridView;
        private DataGridViewTextBoxColumn supplierIDDataGridView;
        private DataGridViewTextBoxColumn categoryDataGridView;
        private DataGridViewTextBoxColumn productnameDataGridView;
        private DataGridViewTextBoxColumn productbrandDataGridView;
        private DataGridViewTextBoxColumn productdescriptionDataGridView;
        private DataGridViewTextBoxColumn productcodeDataGridView;
        private DataGridViewTextBoxColumn skuDataGridView;
        private DataGridViewTextBoxColumn quantityDataGridView;
        private DataGridViewTextBoxColumn unitofmeasurementDataGridView;
        private DataGridViewTextBoxColumn costpriceDataGridView;
        private DataGridViewTextBoxColumn unitpriceDataGridView;
        private DataGridViewTextBoxColumn remarksDataGridView;
        private DataGridViewTextBoxColumn statusDataGridView;
        private DataGridViewTextBoxColumn datereceivedDataGridView;
        private DataGridViewTextBoxColumn dateexpirationDataGridView;
        private DataGridViewTextBoxColumn createdatDataGridView;
        private Button btnPrint;
    }
}