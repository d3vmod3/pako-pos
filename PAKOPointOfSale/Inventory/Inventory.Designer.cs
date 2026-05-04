namespace PAKOPointOfSale.Inventory
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvRecentlyAdded = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txSearchQuery = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            dgvLowStocks = new DataGridView();
            product_name2 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            dgvOutOfStocks = new DataGridView();
            product_name3 = new DataGridViewTextBoxColumn();
            supplier3 = new DataGridViewTextBoxColumn();
            cmbShowItemsRecentyAdded = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbShowItemsLowStocks = new ComboBox();
            label7 = new Label();
            cmbShowItemsOutOfStocks = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecentlyAdded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutOfStocks).BeginInit();
            SuspendLayout();
            // 
            // dgvRecentlyAdded
            // 
            dgvRecentlyAdded.AllowUserToAddRows = false;
            dgvRecentlyAdded.AllowUserToDeleteRows = false;
            dgvRecentlyAdded.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentlyAdded.Columns.AddRange(new DataGridViewColumn[] { product_name, created_at });
            dgvRecentlyAdded.Location = new Point(12, 133);
            dgvRecentlyAdded.Name = "dgvRecentlyAdded";
            dgvRecentlyAdded.ReadOnly = true;
            dgvRecentlyAdded.RowHeadersVisible = false;
            dgvRecentlyAdded.Size = new Size(392, 569);
            dgvRecentlyAdded.TabIndex = 0;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Recently Added";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Low Stocks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(858, 115);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Out of Stocks";
            // 
            // txSearchQuery
            // 
            txSearchQuery.Location = new Point(108, 5);
            txSearchQuery.Name = "txSearchQuery";
            txSearchQuery.Size = new Size(296, 23);
            txSearchQuery.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Search Product:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(410, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dgvLowStocks
            // 
            dgvLowStocks.AllowUserToAddRows = false;
            dgvLowStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvLowStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStocks.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvLowStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStocks.Columns.AddRange(new DataGridViewColumn[] { product_name2, quantity, supplier });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvLowStocks.DefaultCellStyle = dataGridViewCellStyle7;
            dgvLowStocks.Location = new Point(435, 133);
            dgvLowStocks.Name = "dgvLowStocks";
            dgvLowStocks.ReadOnly = true;
            dgvLowStocks.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dgvLowStocks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStocks.Size = new Size(383, 569);
            dgvLowStocks.TabIndex = 12;
            dgvLowStocks.CellContentClick += dgvLowStocks_CellContentClick;
            // 
            // product_name2
            // 
            product_name2.DataPropertyName = "product_name";
            product_name2.HeaderText = "Product";
            product_name2.Name = "product_name2";
            product_name2.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Remaining Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // supplier
            // 
            supplier.DataPropertyName = "supplier";
            supplier.HeaderText = "Supplier";
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            // 
            // dgvOutOfStocks
            // 
            dgvOutOfStocks.AllowUserToAddRows = false;
            dgvOutOfStocks.AllowUserToDeleteRows = false;
            dgvOutOfStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutOfStocks.Columns.AddRange(new DataGridViewColumn[] { product_name3, supplier3 });
            dgvOutOfStocks.Location = new Point(858, 133);
            dgvOutOfStocks.Name = "dgvOutOfStocks";
            dgvOutOfStocks.ReadOnly = true;
            dgvOutOfStocks.RowHeadersVisible = false;
            dgvOutOfStocks.Size = new Size(392, 569);
            dgvOutOfStocks.TabIndex = 13;
            // 
            // product_name3
            // 
            product_name3.DataPropertyName = "product_name";
            product_name3.HeaderText = "Product";
            product_name3.Name = "product_name3";
            product_name3.ReadOnly = true;
            // 
            // supplier3
            // 
            supplier3.DataPropertyName = "supplier";
            supplier3.HeaderText = "Supplier";
            supplier3.Name = "supplier3";
            supplier3.ReadOnly = true;
            // 
            // cmbShowItemsRecentyAdded
            // 
            cmbShowItemsRecentyAdded.FormattingEnabled = true;
            cmbShowItemsRecentyAdded.Items.AddRange(new object[] { "25", "50", "100", "All" });
            cmbShowItemsRecentyAdded.Location = new Point(283, 107);
            cmbShowItemsRecentyAdded.Name = "cmbShowItemsRecentyAdded";
            cmbShowItemsRecentyAdded.Size = new Size(121, 23);
            cmbShowItemsRecentyAdded.TabIndex = 14;
            cmbShowItemsRecentyAdded.SelectedIndexChanged += cmbShowItemsRecentyAdded_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 110);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "Show Items:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(623, 105);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 17;
            label6.Text = "Show Items:";
            // 
            // cmbShowItemsLowStocks
            // 
            cmbShowItemsLowStocks.FormattingEnabled = true;
            cmbShowItemsLowStocks.Items.AddRange(new object[] { "25", "50", "100", "All" });
            cmbShowItemsLowStocks.Location = new Point(697, 102);
            cmbShowItemsLowStocks.Name = "cmbShowItemsLowStocks";
            cmbShowItemsLowStocks.Size = new Size(121, 23);
            cmbShowItemsLowStocks.TabIndex = 16;
            cmbShowItemsLowStocks.SelectedIndexChanged += cmbShowItemsLowStocks_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1055, 110);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 19;
            label7.Text = "Show Items:";
            // 
            // cmbShowItemsOutOfStocks
            // 
            cmbShowItemsOutOfStocks.FormattingEnabled = true;
            cmbShowItemsOutOfStocks.Items.AddRange(new object[] { "0", "25", "50", "100", "All" });
            cmbShowItemsOutOfStocks.Location = new Point(1129, 107);
            cmbShowItemsOutOfStocks.Name = "cmbShowItemsOutOfStocks";
            cmbShowItemsOutOfStocks.Size = new Size(121, 23);
            cmbShowItemsOutOfStocks.TabIndex = 18;
            cmbShowItemsOutOfStocks.SelectedIndexChanged += cmbShowItemsOutOfStocks_SelectedIndexChanged;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 714);
            Controls.Add(label7);
            Controls.Add(cmbShowItemsOutOfStocks);
            Controls.Add(label6);
            Controls.Add(cmbShowItemsLowStocks);
            Controls.Add(label5);
            Controls.Add(cmbShowItemsRecentyAdded);
            Controls.Add(dgvOutOfStocks);
            Controls.Add(dgvLowStocks);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(txSearchQuery);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRecentlyAdded);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentlyAdded).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutOfStocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRecentlyAdded;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txSearchQuery;
        private Label label4;
        private Button btnSubmit;
        private DataGridView dgvLowStocks;
        private DataGridViewTextBoxColumn product_name2;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn created_at;
        private DataGridView dgvOutOfStocks;
        private DataGridViewTextBoxColumn product_name3;
        private DataGridViewTextBoxColumn supplier3;
        private ComboBox cmbShowItemsRecentyAdded;
        private Label label5;
        private Label label6;
        private ComboBox cmbShowItemsLowStocks;
        private Label label7;
        private ComboBox cmbShowItemsOutOfStocks;
    }
}