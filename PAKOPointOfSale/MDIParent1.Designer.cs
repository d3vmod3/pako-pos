
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
            menuStrip = new MenuStrip();
            statusStrip = new StatusStrip();
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
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            pictureBox4 = new PictureBox();
            timerDateandTime = new System.Windows.Forms.Timer(components);
            lblFullName = new Label();
            gbLowStocks = new GroupBox();
            dtgvLowStocks = new DataGridView();
            product_name2 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            gbTop5Sellings.SuspendLayout();
            gbSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            gbLowStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLowStocks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1367, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 766);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1367, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dtgvTop5SellingProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvTop5SellingProducts.Location = new Point(13, 84);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dtgvTop5SellingProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvTop5SellingProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTop5SellingProducts.Size = new Size(513, 146);
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
            label2.ForeColor = Color.Black;
            label2.Location = new Point(205, 18);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(205, 36);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(185, 23);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.White;
            dtpFrom.Location = new Point(7, 36);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(187, 23);
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
            gbTop5Sellings.ForeColor = Color.White;
            gbTop5Sellings.Location = new Point(12, 319);
            gbTop5Sellings.Name = "gbTop5Sellings";
            gbTop5Sellings.Size = new Size(542, 230);
            gbTop5Sellings.TabIndex = 13;
            gbTop5Sellings.TabStop = false;
            gbTop5Sellings.Text = "Top 5 Selling Products";
            gbTop5Sellings.Enter += gbTop5Sellings_Enter;
            // 
            // btnExportTop5Selling
            // 
            btnExportTop5Selling.BackColor = Color.Goldenrod;
            btnExportTop5Selling.FlatStyle = FlatStyle.Popup;
            btnExportTop5Selling.ForeColor = Color.Black;
            btnExportTop5Selling.Location = new Point(474, 36);
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
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(397, 36);
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
            comboBoxSalesFilter.Location = new Point(405, 37);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(203, 23);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(405, 19);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
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
            dtpFromSales.Size = new Size(192, 23);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 23;
            label6.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(207, 19);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 25;
            label7.Text = "To:";
            // 
            // dtpToSales
            // 
            dtpToSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpToSales.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpToSales.Location = new Point(207, 36);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(192, 23);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.BackColor = Color.Khaki;
            btnFilterDateSales.FlatStyle = FlatStyle.Popup;
            btnFilterDateSales.ForeColor = Color.Black;
            btnFilterDateSales.Location = new Point(721, 35);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(73, 23);
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
            gbSales.ForeColor = Color.White;
            gbSales.Location = new Point(560, 319);
            gbSales.Name = "gbSales";
            gbSales.Size = new Size(796, 433);
            gbSales.TabIndex = 17;
            gbSales.TabStop = false;
            gbSales.Text = "Sales";
            gbSales.Enter += groupBox2_Enter;
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Impact", 36F, FontStyle.Italic);
            lblGrossSales.ForeColor = Color.Black;
            lblGrossSales.Location = new Point(366, 202);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(112, 60);
            lblGrossSales.TabIndex = 4;
            lblGrossSales.Text = "0.00";
            // 
            // lblNetSales
            // 
            lblNetSales.AutoSize = true;
            lblNetSales.Font = new Font("Impact", 36F, FontStyle.Italic);
            lblNetSales.ForeColor = Color.Black;
            lblNetSales.Location = new Point(366, 115);
            lblNetSales.Name = "lblNetSales";
            lblNetSales.Size = new Size(112, 60);
            lblNetSales.TabIndex = 3;
            lblNetSales.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 36F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(36, 202);
            label8.Name = "label8";
            label8.Size = new Size(267, 60);
            label8.TabIndex = 1;
            label8.Text = "Gross Sales:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FloralWhite;
            btnClearFilters.FlatStyle = FlatStyle.Popup;
            btnClearFilters.ForeColor = Color.Black;
            btnClearFilters.Location = new Point(609, 36);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(106, 23);
            btnClearFilters.TabIndex = 177;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 36F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 115);
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.FlatStyle = FlatStyle.System;
            label10.Font = new Font("Impact", 54.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(521, 32);
            label10.Name = "label10";
            label10.Size = new Size(391, 91);
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
            btnPos.BackgroundImage = Properties.Resources.pos_terminal;
            btnPos.BackgroundImageLayout = ImageLayout.Stretch;
            btnPos.Location = new Point(1169, 180);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(174, 121);
            btnPos.TabIndex = 4;
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += button1_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackgroundImage = Properties.Resources.category_icon_png_17;
            btnCategories.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategories.Location = new Point(25, 180);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(174, 124);
            btnCategories.TabIndex = 164;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackgroundImage = Properties.Resources.products;
            btnProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducts.Location = new Point(210, 180);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(179, 123);
            btnProducts.TabIndex = 165;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackgroundImage = Properties.Resources.suppliers;
            btnSuppliers.BackgroundImageLayout = ImageLayout.Stretch;
            btnSuppliers.Location = new Point(402, 179);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(181, 123);
            btnSuppliers.TabIndex = 166;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackgroundImage = Properties.Resources.transactions;
            btnTransactions.BackgroundImageLayout = ImageLayout.Stretch;
            btnTransactions.Location = new Point(596, 180);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(176, 123);
            btnTransactions.TabIndex = 167;
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackgroundImage = Properties.Resources.users;
            btnUsers.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsers.Location = new Point(785, 180);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(174, 121);
            btnUsers.TabIndex = 168;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnUac
            // 
            btnUac.BackgroundImage = Properties.Resources.UAC;
            btnUac.BackgroundImageLayout = ImageLayout.Stretch;
            btnUac.Location = new Point(972, 180);
            btnUac.Name = "btnUac";
            btnUac.Size = new Size(185, 121);
            btnUac.TabIndex = 169;
            btnUac.UseVisualStyleBackColor = true;
            btnUac.Click += btnUac_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Impact", 21.75F);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(38, 140);
            label13.Name = "label13";
            label13.Size = new Size(151, 36);
            label13.TabIndex = 170;
            label13.Text = "CATEGORIES";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Impact", 21.75F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(234, 140);
            label14.Name = "label14";
            label14.Size = new Size(138, 36);
            label14.TabIndex = 171;
            label14.Text = "PRODUCTS";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Impact", 21.75F);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(429, 139);
            label15.Name = "label15";
            label15.Size = new Size(138, 36);
            label15.TabIndex = 172;
            label15.Text = "SUPPLIERS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Impact", 21.75F);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(591, 140);
            label16.Name = "label16";
            label16.Size = new Size(187, 36);
            label16.TabIndex = 173;
            label16.Text = "TRANSACTIONS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Impact", 21.75F);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(822, 140);
            label17.Name = "label17";
            label17.Size = new Size(89, 36);
            label17.TabIndex = 174;
            label17.Text = "USERS";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Impact", 21.75F);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(1037, 140);
            label18.Name = "label18";
            label18.Size = new Size(61, 36);
            label18.TabIndex = 175;
            label18.Text = "UAC";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Impact", 21.75F);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(1219, 140);
            label19.Name = "label19";
            label19.Size = new Size(61, 36);
            label19.TabIndex = 171;
            label19.Text = "POS";
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
            lblFullName.Location = new Point(23, 2);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(71, 20);
            lblFullName.TabIndex = 183;
            lblFullName.Text = "Full Name";
            // 
            // gbLowStocks
            // 
            gbLowStocks.BackColor = Color.CadetBlue;
            gbLowStocks.Controls.Add(dtgvLowStocks);
            gbLowStocks.ForeColor = Color.White;
            gbLowStocks.Location = new Point(12, 555);
            gbLowStocks.Name = "gbLowStocks";
            gbLowStocks.Size = new Size(542, 197);
            gbLowStocks.TabIndex = 185;
            gbLowStocks.TabStop = false;
            gbLowStocks.Text = "Low Stock Products";
            // 
            // dtgvLowStocks
            // 
            dtgvLowStocks.AllowUserToAddRows = false;
            dtgvLowStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgvLowStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLowStocks.BackgroundColor = SystemColors.ControlLight;
            dtgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLowStocks.Columns.AddRange(new DataGridViewColumn[] { product_name2, quantity, supplier });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgvLowStocks.DefaultCellStyle = dataGridViewCellStyle5;
            dtgvLowStocks.Location = new Point(15, 22);
            dtgvLowStocks.Name = "dtgvLowStocks";
            dtgvLowStocks.ReadOnly = true;
            dtgvLowStocks.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dtgvLowStocks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLowStocks.Size = new Size(513, 162);
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
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 788);
            Controls.Add(gbLowStocks);
            Controls.Add(lblFullName);
            Controls.Add(pictureBox4);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
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
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(gbSales);
            Controls.Add(gbTop5Sellings);
            Controls.Add(btnPos);
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
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
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
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
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
    }
}



