namespace PAKOPointOfSale.Transactions.Return
{
    partial class ReturnForm
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
            lblInvoiceNumber = new Label();
            label3 = new Label();
            dgvReturnItems = new DataGridView();
            salesInvoiceItemBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_brand = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(113, 9);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(43, 15);
            lblInvoiceNumber.TabIndex = 7;
            lblInvoiceNumber.Text = "000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Invoice Number:";
            // 
            // dgvReturnItems
            // 
            dgvReturnItems.AllowUserToAddRows = false;
            dgvReturnItems.AllowUserToDeleteRows = false;
            dgvReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnItems.Columns.AddRange(new DataGridViewColumn[] { id, product_id, product_code, product_name, product_brand, quantity, unit_of_measurement, unit_price, discount_type, discount, total_amount, vatable_sales, vat_amount, vat_exempt, transaction_id, remove });
            dgvReturnItems.Location = new Point(12, 79);
            dgvReturnItems.Name = "dgvReturnItems";
            dgvReturnItems.Size = new Size(776, 290);
            dgvReturnItems.TabIndex = 8;
            dgvReturnItems.CellContentClick += dgvReturnItems_CellContentClick;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // button1
            // 
            button1.Location = new Point(668, 399);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 9;
            button1.Text = "Confirm Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(304, 15);
            label1.TabIndex = 10;
            label1.Text = "Adjust the applied quantity for each item to be returned.";
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            // 
            // product_code
            // 
            product_code.DataPropertyName = "product_code";
            product_code.HeaderText = "Product Code";
            product_code.Name = "product_code";
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            // 
            // product_brand
            // 
            product_brand.DataPropertyName = "product_brand";
            product_brand.HeaderText = "Brand";
            product_brand.Name = "product_brand";
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Applied Quantity";
            quantity.Name = "quantity";
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Sub Total";
            total_amount.Name = "total_amount";
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            transaction_id.HeaderText = "Transaction ID";
            transaction_id.Name = "transaction_id";
            transaction_id.Visible = false;
            // 
            // remove
            // 
            remove.DataPropertyName = "id";
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.Text = "Remove Item";
            remove.UseColumnTextForButtonValue = true;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvReturnItems);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            Name = "ReturnForm";
            Text = "ReturnForm";
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumber;
        private Label label3;
        private DataGridView dgvReturnItems;
        private BindingSource salesInvoiceItemBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private Label label1;
        private DataGridViewTextBoxColumn trasaction_id;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewButtonColumn remove;
    }
}