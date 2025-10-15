namespace PAKOPointOfSale.Transactions
{
    partial class SalesInvoice
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
            productBindingSource = new BindingSource(components);
            userTypeBindingSource = new BindingSource(components);
            btnSearchProduct = new Button();
            dtgvCart = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            appliedQty = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            lblChange = new Label();
            label6 = new Label();
            lblTotal = new Label();
            num_CashAmount = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_CashAmount).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(WinFormsApp1.Model.Product);
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(12, 12);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(149, 38);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // dtgvCart
            // 
            dtgvCart.AllowUserToAddRows = false;
            dtgvCart.AllowUserToDeleteRows = false;
            dtgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCart.Columns.AddRange(new DataGridViewColumn[] { id, product, brand, unit_of_measurement, appliedQty, unit_price, category, remove });
            dtgvCart.Location = new Point(12, 56);
            dtgvCart.Name = "dtgvCart";
            dtgvCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgvCart.Size = new Size(789, 587);
            dtgvCart.TabIndex = 4;
            dtgvCart.CellContentClick += dtgvCart_CellContentClick;
            dtgvCart.CellEndEdit += dtgvCart_CellEndEdit;
            dtgvCart.CellValueChanged += dtgvCart_CellValueChanged;
            dtgvCart.EditingControlShowing += dtgvCart_EditingControlShowing;
            dtgvCart.KeyPress += dtgvCart_KeyPress;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            // 
            // product
            // 
            product.HeaderText = "Product";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.Name = "brand";
            brand.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // appliedQty
            // 
            appliedQty.HeaderText = "Quantity";
            appliedQty.Name = "appliedQty";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // remove
            // 
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.Text = "Remove";
            remove.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 47);
            label1.TabIndex = 5;
            label1.Text = "Grand Total:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1145, 582);
            button1.Name = "button1";
            button1.Size = new Size(75, 61);
            button1.TabIndex = 6;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1064, 582);
            button2.Name = "button2";
            button2.Size = new Size(75, 61);
            button2.TabIndex = 7;
            button2.Text = "Park";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblChange);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(num_CashAmount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(807, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 231);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(148, 165);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(85, 47);
            lblChange.TabIndex = 12;
            lblChange.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 71);
            label6.Name = "label6";
            label6.Size = new Size(85, 47);
            label6.TabIndex = 10;
            label6.Text = "0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(210, 24);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 47);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0.00";
            // 
            // num_CashAmount
            // 
            num_CashAmount.DecimalPlaces = 2;
            num_CashAmount.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_CashAmount.Location = new Point(103, 119);
            num_CashAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            num_CashAmount.Name = "num_CashAmount";
            num_CashAmount.Size = new Size(304, 46);
            num_CashAmount.TabIndex = 11;
            num_CashAmount.ValueChanged += num_CashAmount_ValueChanged;
            num_CashAmount.KeyUp += num_CashAmount_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 118);
            label4.Name = "label4";
            label4.Size = new Size(103, 47);
            label4.TabIndex = 8;
            label4.Text = "Cash:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(165, 47);
            label3.TabIndex = 7;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 165);
            label2.Name = "label2";
            label2.Size = new Size(147, 47);
            label2.TabIndex = 6;
            label2.Text = "Change:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // SalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 655);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtgvCart);
            Controls.Add(btnSearchProduct);
            Name = "SalesInvoice";
            Text = "SalesInvoice";
            Load += SalesInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_CashAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource userTypeBindingSource;
        private Button btnSearchProduct;
        private DataGridView dtgvCart;
        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private NumericUpDown num_CashAmount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label lblTotal;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblChange;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn appliedQty;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn category;
        private DataGridViewButtonColumn remove;
    }
}