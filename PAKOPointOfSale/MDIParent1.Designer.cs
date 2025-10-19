namespace PAKOPointOfSale
{
    partial class MDIParent1
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
            menuStrip = new MenuStrip();
            setupToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            supplierProductsToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem1 = new ToolStripMenuItem();
            userAccessControlToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            resetAllToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            button1 = new Button();
            dtgvTop5SellingProducts = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            total_quantity_sold = new DataGridViewTextBoxColumn();
            total_sales = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnFilter = new Button();
            comboBoxSalesFilter = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            dtpFromSales = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpToSales = new DateTimePicker();
            btnFilterDateSales = new Button();
            groupBox2 = new GroupBox();
            lblGrandTotal = new Label();
            lblGrossSales = new Label();
            lblNetSales = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            timeReloadData = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { setupToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1258, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, usersToolStripMenuItem, supplierProductsToolStripMenuItem, suppliersToolStripMenuItem, transactionsToolStripMenuItem, usersToolStripMenuItem1, userAccessControlToolStripMenuItem });
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(49, 20);
            setupToolStripMenuItem.Text = "Setup";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(179, 22);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(179, 22);
            usersToolStripMenuItem.Text = "Products";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // supplierProductsToolStripMenuItem
            // 
            supplierProductsToolStripMenuItem.Name = "supplierProductsToolStripMenuItem";
            supplierProductsToolStripMenuItem.Size = new Size(179, 22);
            supplierProductsToolStripMenuItem.Text = "Supplier Products";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(179, 22);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(179, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem1
            // 
            usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            usersToolStripMenuItem1.Size = new Size(179, 22);
            usersToolStripMenuItem1.Text = "Users";
            usersToolStripMenuItem1.Click += usersToolStripMenuItem1_Click;
            // 
            // userAccessControlToolStripMenuItem
            // 
            userAccessControlToolStripMenuItem.Name = "userAccessControlToolStripMenuItem";
            userAccessControlToolStripMenuItem.Size = new Size(179, 22);
            userAccessControlToolStripMenuItem.Text = "User Access Control";
            userAccessControlToolStripMenuItem.Click += userAccessControlToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetAllToolStripMenuItem, logoutToolStripMenuItem1 });
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(61, 20);
            logoutToolStripMenuItem.Text = "Settings";
            // 
            // resetAllToolStripMenuItem
            // 
            resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            resetAllToolStripMenuItem.Size = new Size(119, 22);
            resetAllToolStripMenuItem.Text = "Reset All";
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(119, 22);
            logoutToolStripMenuItem1.Text = "Logout";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 543);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1258, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pos_terminal;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1165, 27);
            button1.Name = "button1";
            button1.Size = new Size(81, 68);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgvTop5SellingProducts
            // 
            dtgvTop5SellingProducts.AllowUserToAddRows = false;
            dtgvTop5SellingProducts.AllowUserToDeleteRows = false;
            dtgvTop5SellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dtgvTop5SellingProducts.Location = new Point(11, 29);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dtgvTop5SellingProducts.Size = new Size(258, 190);
            dtgvTop5SellingProducts.TabIndex = 11;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // total_quantity_sold
            // 
            total_quantity_sold.DataPropertyName = "total_quantity_sold";
            total_quantity_sold.HeaderText = "Total Quantity Sold";
            total_quantity_sold.Name = "total_quantity_sold";
            total_quantity_sold.ReadOnly = true;
            // 
            // total_sales
            // 
            total_sales.DataPropertyName = "total_sales";
            total_sales.HeaderText = "Total Sales";
            total_sales.Name = "total_sales";
            total_sales.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 171);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Date To";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(93, 165);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 142);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Date From";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(93, 136);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvTop5SellingProducts);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 235);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top 5 Selling Products";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(218, 194);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // comboBoxSalesFilter
            // 
            comboBoxSalesFilter.FormattingEnabled = true;
            comboBoxSalesFilter.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            comboBoxSalesFilter.Location = new Point(1125, 207);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(121, 23);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1006, 210);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 19;
            label3.Text = "Choose Quick Filter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 215);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 21;
            label5.Text = "Choose Date Range:";
            // 
            // dtpFromSales
            // 
            dtpFromSales.Location = new Point(486, 209);
            dtpFromSales.Name = "dtpFromSales";
            dtpFromSales.Size = new Size(200, 23);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 215);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 23;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(692, 215);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 25;
            label7.Text = "To";
            // 
            // dtpToSales
            // 
            dtpToSales.Location = new Point(718, 209);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(200, 23);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.Location = new Point(924, 207);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(76, 23);
            btnFilterDateSales.TabIndex = 27;
            btnFilterDateSales.Text = "Filter Date";
            btnFilterDateSales.UseVisualStyleBackColor = true;
            btnFilterDateSales.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblGrandTotal);
            groupBox2.Controls.Add(lblGrossSales);
            groupBox2.Controls.Add(lblNetSales);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(324, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(922, 299);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sales";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(98, 88);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(28, 15);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "0.00";
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Location = new Point(98, 57);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(28, 15);
            lblGrossSales.TabIndex = 4;
            lblGrossSales.Text = "0.00";
            // 
            // lblNetSales
            // 
            lblNetSales.AutoSize = true;
            lblNetSales.Location = new Point(98, 29);
            lblNetSales.Name = "lblNetSales";
            lblNetSales.Size = new Size(28, 15);
            lblNetSales.TabIndex = 3;
            lblNetSales.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 88);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 2;
            label9.Text = "Grand Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 57);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 1;
            label8.Text = "Gross Sales:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 29);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Net Sales:";
            // 
            // timeReloadData
            // 
            timeReloadData.Interval = 5000;
            timeReloadData.Tick += timeReloadData_Tick;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 565);
            Controls.Add(btnFilterDateSales);
            Controls.Add(label7);
            Controls.Add(dtpToSales);
            Controls.Add(label6);
            Controls.Add(dtpFromSales);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBoxSalesFilter);
            Controls.Add(groupBox2);
            Controls.Add(btnFilter);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(label1);
            Controls.Add(dtpFrom);
            Controls.Add(button1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            WindowState = FormWindowState.Maximized;
            Load += SuperAdminForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem setupToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem supplierProductsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem1;
        private ToolStripMenuItem userAccessControlToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private Button button1;
        private DataGridView dtgvTop5SellingProducts;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn total_quantity_sold;
        private DataGridViewTextBoxColumn total_sales;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label1;
        private DateTimePicker dtpFrom;
        private GroupBox groupBox1;
        private Button btnFilter;
        private ComboBox comboBoxSalesFilter;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpFromSales;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpToSales;
        private Button btnFilterDateSales;
        private GroupBox groupBox2;
        private Label lblGrandTotal;
        private Label lblGrossSales;
        private Label lblNetSales;
        private Label label9;
        private Label label8;
        private Label label4;
        private System.Windows.Forms.Timer timeReloadData;
    }
}



