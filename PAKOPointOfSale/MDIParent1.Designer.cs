
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            menuStrip = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            activityLogsToolStripMenuItem = new ToolStripMenuItem();
            backupDatabaseToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            dtgvTop5SellingProducts = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            total_quantity_sold = new DataGridViewTextBoxColumn();
            total_sales = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            gbTop5Sellings = new GroupBox();
            btnExportTop5Selling = new Button();
            btnFilter = new Button();
            comboBoxSalesFilter = new ComboBox();
            label3 = new Label();
            dtpFromSales = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpToSales = new DateTimePicker();
            btnFilterDateSales = new Button();
            gbSales = new GroupBox();
            lblGrossSales = new Label();
            lblNetSales = new Label();
            label8 = new Label();
            btnClearFilters = new Button();
            label4 = new Label();
            timeReloadData = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lblTime = new Label();
            lblDate = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            btnPos = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnTransactions = new Button();
            btnUsers = new Button();
            btnUac = new Button();
            pictureBox4 = new PictureBox();
            timerDateandTime = new System.Windows.Forms.Timer(components);
            lblFullName = new Label();
            gbLowStocks = new GroupBox();
            dtgvLowStocks = new DataGridView();
            product_name2 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            gbTop5Sellings.SuspendLayout();
            gbSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            gbLowStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLowStocks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1367, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activityLogsToolStripMenuItem, backupDatabaseToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // activityLogsToolStripMenuItem
            // 
            activityLogsToolStripMenuItem.Name = "activityLogsToolStripMenuItem";
            activityLogsToolStripMenuItem.Size = new Size(180, 22);
            activityLogsToolStripMenuItem.Text = "Activity Logs";
            activityLogsToolStripMenuItem.Click += activityLogsToolStripMenuItem_Click;
            // 
            // backupDatabaseToolStripMenuItem
            // 
            backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            backupDatabaseToolStripMenuItem.Size = new Size(180, 22);
            backupDatabaseToolStripMenuItem.Text = "Backup Database";
            backupDatabaseToolStripMenuItem.Click += backupDatabaseToolStripMenuItem_Click;
            // 
            // dtgvTop5SellingProducts
            // 
            dtgvTop5SellingProducts.AllowUserToAddRows = false;
            dtgvTop5SellingProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgvTop5SellingProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvTop5SellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTop5SellingProducts.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvTop5SellingProducts.Location = new Point(13, 72);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dtgvTop5SellingProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgvTop5SellingProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTop5SellingProducts.Size = new Size(547, 146);
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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(205, 18);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 9;
            label2.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(205, 36);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(185, 25);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 7;
            label1.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.White;
            dtpFrom.Location = new Point(12, 36);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(187, 25);
            dtpFrom.TabIndex = 6;
            // 
            // gbTop5Sellings
            // 
            gbTop5Sellings.BackColor = Color.CadetBlue;
            gbTop5Sellings.Controls.Add(dtgvTop5SellingProducts);
            gbTop5Sellings.Controls.Add(btnExportTop5Selling);
            gbTop5Sellings.Controls.Add(dtpFrom);
            gbTop5Sellings.Controls.Add(label1);
            gbTop5Sellings.Controls.Add(dtpTo);
            gbTop5Sellings.Controls.Add(label2);
            gbTop5Sellings.Controls.Add(btnFilter);
            gbTop5Sellings.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTop5Sellings.ForeColor = Color.Black;
            gbTop5Sellings.Location = new Point(282, 333);
            gbTop5Sellings.Name = "gbTop5Sellings";
            gbTop5Sellings.Size = new Size(575, 230);
            gbTop5Sellings.TabIndex = 13;
            gbTop5Sellings.TabStop = false;
            gbTop5Sellings.Text = "Top 5 Selling Products";
            gbTop5Sellings.Enter += gbTop5Sellings_Enter;
            // 
            // btnExportTop5Selling
            // 
            btnExportTop5Selling.BackColor = Color.Goldenrod;
            btnExportTop5Selling.FlatStyle = FlatStyle.Popup;
            btnExportTop5Selling.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnExportTop5Selling.ForeColor = Color.Black;
            btnExportTop5Selling.Location = new Point(481, 36);
            btnExportTop5Selling.Name = "btnExportTop5Selling";
            btnExportTop5Selling.Size = new Size(75, 23);
            btnExportTop5Selling.TabIndex = 16;
            btnExportTop5Selling.Text = "Export";
            btnExportTop5Selling.UseVisualStyleBackColor = false;
            btnExportTop5Selling.Click += btnExportTop5Selling_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Khaki;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(398, 36);
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
            comboBoxSalesFilter.Items.AddRange(new object[] { "Today", "This Week", "This Month", "This Year" });
            comboBoxSalesFilter.Location = new Point(324, 37);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(102, 25);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(324, 18);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 19;
            label3.Text = "Choose Quick Filter:";
            // 
            // dtpFromSales
            // 
            dtpFromSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpFromSales.CalendarMonthBackground = Color.White;
            dtpFromSales.CalendarTrailingForeColor = SystemColors.AppWorkspace;
            dtpFromSales.Location = new Point(6, 36);
            dtpFromSales.Name = "dtpFromSales";
            dtpFromSales.Size = new Size(144, 25);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 19);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 23;
            label6.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(156, 18);
            label7.Name = "label7";
            label7.Size = new Size(25, 17);
            label7.TabIndex = 25;
            label7.Text = "To:";
            // 
            // dtpToSales
            // 
            dtpToSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpToSales.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpToSales.Location = new Point(156, 36);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(149, 25);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.BackColor = Color.Khaki;
            btnFilterDateSales.FlatStyle = FlatStyle.Popup;
            btnFilterDateSales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnFilterDateSales.ForeColor = Color.Black;
            btnFilterDateSales.Location = new Point(502, 36);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(54, 23);
            btnFilterDateSales.TabIndex = 27;
            btnFilterDateSales.Text = "Filter";
            btnFilterDateSales.UseVisualStyleBackColor = false;
            btnFilterDateSales.Click += button2_Click;
            // 
            // gbSales
            // 
            gbSales.BackColor = Color.CadetBlue;
            gbSales.Controls.Add(lblGrossSales);
            gbSales.Controls.Add(lblNetSales);
            gbSales.Controls.Add(label8);
            gbSales.Controls.Add(btnClearFilters);
            gbSales.Controls.Add(label4);
            gbSales.Controls.Add(label6);
            gbSales.Controls.Add(comboBoxSalesFilter);
            gbSales.Controls.Add(label3);
            gbSales.Controls.Add(dtpFromSales);
            gbSales.Controls.Add(dtpToSales);
            gbSales.Controls.Add(label7);
            gbSales.Controls.Add(btnFilterDateSales);
            gbSales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSales.ForeColor = Color.Black;
            gbSales.Location = new Point(282, 141);
            gbSales.Name = "gbSales";
            gbSales.Size = new Size(574, 186);
            gbSales.TabIndex = 17;
            gbSales.TabStop = false;
            gbSales.Text = "Sales";
            gbSales.Enter += groupBox2_Enter;
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Impact", 26.25F, FontStyle.Bold);
            lblGrossSales.ForeColor = Color.Black;
            lblGrossSales.Location = new Point(324, 128);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(86, 43);
            lblGrossSales.TabIndex = 4;
            lblGrossSales.Text = "0.00";
            // 
            // lblNetSales
            // 
            lblNetSales.AutoSize = true;
            lblNetSales.Font = new Font("Impact", 26.25F, FontStyle.Bold);
            lblNetSales.ForeColor = Color.Black;
            lblNetSales.Location = new Point(324, 71);
            lblNetSales.Name = "lblNetSales";
            lblNetSales.Size = new Size(86, 43);
            lblNetSales.TabIndex = 3;
            lblNetSales.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 26.25F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 128);
            label8.Name = "label8";
            label8.Size = new Size(193, 43);
            label8.TabIndex = 1;
            label8.Text = "Gross Sales:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FloralWhite;
            btnClearFilters.FlatStyle = FlatStyle.Popup;
            btnClearFilters.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClearFilters.ForeColor = Color.Black;
            btnClearFilters.Location = new Point(432, 36);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(64, 24);
            btnClearFilters.TabIndex = 177;
            btnClearFilters.Text = "Clear ";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 26.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 71);
            label4.Name = "label4";
            label4.Size = new Size(159, 43);
            label4.TabIndex = 0;
            label4.Text = "Net Sales:";
            // 
            // timeReloadData
            // 
            timeReloadData.Interval = 5000;
            timeReloadData.Tick += timeReloadData_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-3, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2488, 104);
            pictureBox2.TabIndex = 153;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1367, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 154;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.FlatStyle = FlatStyle.System;
            label10.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(541, 40);
            label10.Name = "label10";
            label10.Size = new Size(341, 80);
            label10.TabIndex = 155;
            label10.Text = "DASHBOARD";
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
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1289, 0);
            button2.Name = "button2";
            button2.Size = new Size(85, 24);
            button2.TabIndex = 162;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btnPos
            // 
            btnPos.BackColor = Color.CadetBlue;
            btnPos.BackgroundImageLayout = ImageLayout.Stretch;
            btnPos.FlatStyle = FlatStyle.Flat;
            btnPos.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPos.Location = new Point(21, 604);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(234, 72);
            btnPos.TabIndex = 4;
            btnPos.Text = "POINT OF SALE";
            btnPos.UseVisualStyleBackColor = false;
            btnPos.Click += button1_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Impact", 20.25F);
            btnCategories.Location = new Point(21, 141);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(234, 72);
            btnCategories.TabIndex = 164;
            btnCategories.Text = "CATEGORIES";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.CadetBlue;
            btnProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Impact", 20.25F);
            btnProducts.Location = new Point(21, 218);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(234, 72);
            btnProducts.TabIndex = 165;
            btnProducts.Tag = "";
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackgroundImageLayout = ImageLayout.Stretch;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Impact", 20.25F);
            btnSuppliers.Location = new Point(21, 295);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(234, 72);
            btnSuppliers.TabIndex = 166;
            btnSuppliers.Text = "SUPPLIERS";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackgroundImageLayout = ImageLayout.Stretch;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Impact", 20.25F);
            btnTransactions.Location = new Point(21, 372);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(234, 72);
            btnTransactions.TabIndex = 167;
            btnTransactions.Text = "TRANSACTIONS";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Impact", 20.25F);
            btnUsers.Location = new Point(21, 449);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(234, 72);
            btnUsers.TabIndex = 168;
            btnUsers.Text = "USERS";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnUac
            // 
            btnUac.BackgroundImageLayout = ImageLayout.Stretch;
            btnUac.FlatStyle = FlatStyle.Flat;
            btnUac.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUac.Location = new Point(21, 526);
            btnUac.Name = "btnUac";
            btnUac.Size = new Size(234, 72);
            btnUac.TabIndex = 169;
            btnUac.Text = "USER ACCESS CONTROL";
            btnUac.UseVisualStyleBackColor = true;
            btnUac.Click += btnUac_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlDarkDark;
            pictureBox4.Image = Properties.Resources.PakoLogo;
            pictureBox4.Location = new Point(0, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(276, 102);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 177;
            pictureBox4.TabStop = false;
            // 
            // timerDateandTime
            // 
            timerDateandTime.Enabled = true;
            timerDateandTime.Interval = 1000;
            timerDateandTime.Tick += timer1_Tick_1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.WhiteSmoke;
            lblFullName.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(1004, 1);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(71, 20);
            lblFullName.TabIndex = 183;
            lblFullName.Text = "Full Name";
            // 
            // gbLowStocks
            // 
            gbLowStocks.BackColor = Color.CadetBlue;
            gbLowStocks.Controls.Add(dtgvLowStocks);
            gbLowStocks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLowStocks.ForeColor = Color.Black;
            gbLowStocks.Location = new Point(862, 141);
            gbLowStocks.Name = "gbLowStocks";
            gbLowStocks.Size = new Size(493, 427);
            gbLowStocks.TabIndex = 185;
            gbLowStocks.TabStop = false;
            gbLowStocks.Text = "Low Stock Products";
            gbLowStocks.Enter += gbLowStocks_Enter;
            // 
            // dtgvLowStocks
            // 
            dtgvLowStocks.AllowUserToAddRows = false;
            dtgvLowStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgvLowStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLowStocks.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgvLowStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLowStocks.Columns.AddRange(new DataGridViewColumn[] { product_name2, quantity, supplier });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtgvLowStocks.DefaultCellStyle = dataGridViewCellStyle7;
            dtgvLowStocks.Location = new Point(6, 24);
            dtgvLowStocks.Name = "dtgvLowStocks";
            dtgvLowStocks.ReadOnly = true;
            dtgvLowStocks.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dtgvLowStocks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtgvLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLowStocks.Size = new Size(481, 391);
            dtgvLowStocks.TabIndex = 11;
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
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 797);
            panel1.TabIndex = 187;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 682);
            button1.Name = "button1";
            button1.Size = new Size(234, 72);
            button1.TabIndex = 188;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 797);
            Controls.Add(lblFullName);
            Controls.Add(pictureBox4);
            Controls.Add(btnUac);
            Controls.Add(btnUsers);
            Controls.Add(btnTransactions);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnCategories);
            Controls.Add(button2);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(label11);
            Controls.Add(gbLowStocks);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(gbSales);
            Controls.Add(gbTop5Sellings);
            Controls.Add(menuStrip);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).EndInit();
            gbTop5Sellings.ResumeLayout(false);
            gbTop5Sellings.PerformLayout();
            gbSales.ResumeLayout(false);
            gbSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            gbLowStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvLowStocks).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private DataGridView dtgvTop5SellingProducts;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn total_quantity_sold;
        private DataGridViewTextBoxColumn total_sales;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label1;
        private DateTimePicker dtpFrom;
        private GroupBox gbTop5Sellings;
        private Button btnFilter;
        private ComboBox comboBoxSalesFilter;
        private Label label3;
        private DateTimePicker dtpFromSales;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpToSales;
        private Button btnFilterDateSales;
        private GroupBox gbSales;
        private Label lblGrossSales;
        private Label lblNetSales;
        private Label label8;
        private Label label4;
        private System.Windows.Forms.Timer timeReloadData;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private Label lblTime;
        private Label lblDate;
        private Label label11;
        private Label label12;
        private Button button2;
        private Button btnPos;
        private Button btnCategories;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnTransactions;
        private Button btnUsers;
        private Button btnUac;
        private PictureBox pictureBox4;
        private Button btnClearFilters;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDateandTime;
        private Label lblFullName;
        private Button btnExportTop5Selling;
        private GroupBox gbLowStocks;
        private DataGridView dtgvLowStocks;
        private DataGridViewTextBoxColumn product_name2;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn supplier;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem activityLogsToolStripMenuItem;
        private ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private Panel panel1;
        private Button button1;
    }
}



