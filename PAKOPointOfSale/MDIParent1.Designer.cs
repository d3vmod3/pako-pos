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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lblTime = new Label();
            lblDate = new Label();
            label11 = new Label();
            label12 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { setupToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1374, 24);
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
            statusStrip.Location = new Point(0, 766);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1374, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.BackColor = Color.White;
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pos_terminal;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1187, 135);
            button1.Name = "button1";
            button1.Size = new Size(169, 131);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgvTop5SellingProducts
            // 
            dtgvTop5SellingProducts.AllowUserToAddRows = false;
            dtgvTop5SellingProducts.AllowUserToDeleteRows = false;
            dtgvTop5SellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTop5SellingProducts.BackgroundColor = SystemColors.ControlLight;
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dtgvTop5SellingProducts.Location = new Point(13, 17);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dtgvTop5SellingProducts.Size = new Size(639, 271);
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
            label2.BackColor = Color.DarkGoldenrod;
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 311);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Date To";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(394, 305);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGoldenrod;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 309);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Date From";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.White;
            dtpFrom.Location = new Point(127, 303);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(208, 23);
            dtpFrom.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(dtgvTop5SellingProducts);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 311);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top 5 Selling Products";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Khaki;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(595, 648);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // comboBoxSalesFilter
            // 
            comboBoxSalesFilter.FormattingEnabled = true;
            comboBoxSalesFilter.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            comboBoxSalesFilter.Location = new Point(795, 274);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(561, 23);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(676, 281);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 19;
            label3.Text = "Choose Quick Filter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(676, 309);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 21;
            label5.Text = "Choose Date Range:";
            // 
            // dtpFromSales
            // 
            dtpFromSales.CalendarMonthBackground = Color.White;
            dtpFromSales.CalendarTrailingForeColor = SystemColors.AppWorkspace;
            dtpFromSales.Location = new Point(836, 303);
            dtpFromSales.Name = "dtpFromSales";
            dtpFromSales.Size = new Size(263, 23);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGoldenrod;
            label6.ForeColor = Color.White;
            label6.Location = new Point(795, 309);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 23;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGoldenrod;
            label7.ForeColor = Color.White;
            label7.Location = new Point(1105, 311);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 25;
            label7.Text = "To";
            // 
            // dtpToSales
            // 
            dtpToSales.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpToSales.Location = new Point(1131, 303);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(225, 23);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.BackColor = Color.Khaki;
            btnFilterDateSales.FlatStyle = FlatStyle.Popup;
            btnFilterDateSales.ForeColor = Color.Black;
            btnFilterDateSales.Location = new Point(1280, 649);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(76, 23);
            btnFilterDateSales.TabIndex = 27;
            btnFilterDateSales.Text = "Filter Date";
            btnFilterDateSales.UseVisualStyleBackColor = false;
            btnFilterDateSales.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.CadetBlue;
            groupBox2.Controls.Add(lblGrandTotal);
            groupBox2.Controls.Add(lblGrossSales);
            groupBox2.Controls.Add(lblNetSales);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(676, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 312);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sales";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Impact", 36F);
            lblGrandTotal.ForeColor = Color.Black;
            lblGrandTotal.Location = new Point(411, 210);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(112, 60);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "0.00";
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Impact", 36F);
            lblGrossSales.ForeColor = Color.Black;
            lblGrossSales.Location = new Point(411, 117);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(112, 60);
            lblGrossSales.TabIndex = 4;
            lblGrossSales.Text = "0.00";
            // 
            // lblNetSales
            // 
            lblNetSales.AutoSize = true;
            lblNetSales.Font = new Font("Impact", 36F);
            lblNetSales.ForeColor = Color.Black;
            lblNetSales.Location = new Point(411, 30);
            lblNetSales.Name = "lblNetSales";
            lblNetSales.Size = new Size(112, 60);
            lblNetSales.TabIndex = 3;
            lblNetSales.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 36F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(50, 210);
            label9.Name = "label9";
            label9.Size = new Size(259, 60);
            label9.TabIndex = 2;
            label9.Text = "Grand Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 36F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(50, 117);
            label8.Name = "label8";
            label8.Size = new Size(267, 60);
            label8.TabIndex = 1;
            label8.Text = "Gross Sales:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 36F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(50, 30);
            label4.Name = "label4";
            label4.Size = new Size(219, 60);
            label4.TabIndex = 0;
            label4.Text = "Net Sales:";
            // 
            // timeReloadData
            // 
            timeReloadData.Interval = 5000;
            timeReloadData.Tick += timeReloadData_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 677);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1374, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 152;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-3, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1377, 104);
            pictureBox2.TabIndex = 153;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 154;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.FlatStyle = FlatStyle.System;
            label10.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(359, 33);
            label10.Name = "label10";
            label10.Size = new Size(698, 80);
            label10.TabIndex = 155;
            label10.Text = "INVENTORY MANAGEMENT ";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.DimGray;
            lblTime.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(1208, 83);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(26, 29);
            lblTime.TabIndex = 160;
            lblTime.Text = "0";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.DimGray;
            lblDate.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(1208, 43);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(26, 29);
            lblDate.TabIndex = 159;
            lblDate.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DimGray;
            label11.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1105, 82);
            label11.Name = "label11";
            label11.Size = new Size(66, 29);
            label11.TabIndex = 158;
            label11.Text = "Time:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DimGray;
            label12.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1105, 44);
            label12.Name = "label12";
            label12.Size = new Size(62, 29);
            label12.TabIndex = 157;
            label12.Text = "Date:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1327, 2);
            button2.Name = "button2";
            button2.Size = new Size(38, 23);
            button2.TabIndex = 162;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1374, 788);
            Controls.Add(button2);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnFilter);
            Controls.Add(btnFilterDateSales);
            Controls.Add(label7);
            Controls.Add(dtpToSales);
            Controls.Add(label6);
            Controls.Add(dtpFromSales);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBoxSalesFilter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(label1);
            Controls.Add(dtpFrom);
            Controls.Add(button1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            TransparencyKey = Color.White;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private Label lblTime;
        private Label lblDate;
        private Label label11;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
    }
}



