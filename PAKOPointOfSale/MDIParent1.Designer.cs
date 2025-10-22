
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
            menuStrip = new MenuStrip();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
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
            btnClearFilters = new Button();
            pictureBox3 = new PictureBox();
            timerDateandTime = new System.Windows.Forms.Timer(components);
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 766);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1367, 22);
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
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvTop5SellingProducts.Location = new Point(17, 3);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dtgvTop5SellingProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgvTop5SellingProducts.Size = new Size(626, 283);
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
            label2.Location = new Point(243, 318);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(243, 336);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 318);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.White;
            dtpFrom.Location = new Point(12, 336);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(208, 23);
            dtpFrom.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(dtgvTop5SellingProducts);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 306);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top 5 Selling Products";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Khaki;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(467, 336);
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
            comboBoxSalesFilter.Location = new Point(1027, 337);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(134, 23);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1027, 319);
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
            dtpFromSales.Location = new Point(676, 336);
            dtpFromSales.Name = "dtpFromSales";
            dtpFromSales.Size = new Size(170, 23);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(680, 318);
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
            label7.Location = new Point(861, 318);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 25;
            label7.Text = "To:";
            // 
            // dtpToSales
            // 
            dtpToSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpToSales.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpToSales.Location = new Point(855, 337);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(166, 23);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.BackColor = Color.Goldenrod;
            btnFilterDateSales.FlatStyle = FlatStyle.Popup;
            btnFilterDateSales.ForeColor = Color.Black;
            btnFilterDateSales.Location = new Point(1280, 336);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(73, 23);
            btnFilterDateSales.TabIndex = 27;
            btnFilterDateSales.Text = "Filter";
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
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(676, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 306);
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
            lblGrandTotal.Location = new Point(461, 217);
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
            lblGrossSales.Location = new Point(461, 124);
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
            lblNetSales.Location = new Point(461, 37);
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
            label9.Location = new Point(100, 217);
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
            label8.Location = new Point(100, 124);
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
            label4.Location = new Point(100, 37);
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
            label10.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(520, 34);
            label10.Name = "label10";
            label10.Size = new Size(350, 80);
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
            btnPos.Location = new Point(1171, 155);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(148, 101);
            btnPos.TabIndex = 4;
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += button1_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackgroundImage = Properties.Resources.category_icon_png_17;
            btnCategories.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategories.Location = new Point(46, 155);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(139, 103);
            btnCategories.TabIndex = 164;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackgroundImage = Properties.Resources.products;
            btnProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducts.Location = new Point(232, 155);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(135, 103);
            btnProducts.TabIndex = 165;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackgroundImage = Properties.Resources.suppliers;
            btnSuppliers.BackgroundImageLayout = ImageLayout.Stretch;
            btnSuppliers.Location = new Point(417, 155);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(137, 103);
            btnSuppliers.TabIndex = 166;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackgroundImage = Properties.Resources.transactions;
            btnTransactions.BackgroundImageLayout = ImageLayout.Stretch;
            btnTransactions.Location = new Point(608, 157);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(144, 101);
            btnTransactions.TabIndex = 167;
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackgroundImage = Properties.Resources.users;
            btnUsers.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsers.Location = new Point(797, 155);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(135, 101);
            btnUsers.TabIndex = 168;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnUac
            // 
            btnUac.BackgroundImage = Properties.Resources.UAC;
            btnUac.BackgroundImageLayout = ImageLayout.Stretch;
            btnUac.Location = new Point(977, 155);
            btnUac.Name = "btnUac";
            btnUac.Size = new Size(150, 101);
            btnUac.TabIndex = 169;
            btnUac.UseVisualStyleBackColor = true;
            btnUac.Click += btnUac_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(52, 262);
            label13.Name = "label13";
            label13.Size = new Size(126, 29);
            label13.TabIndex = 170;
            label13.Text = "CATEGORIES";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(243, 262);
            label14.Name = "label14";
            label14.Size = new Size(113, 29);
            label14.TabIndex = 171;
            label14.Text = "PRODUCTS";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(429, 262);
            label15.Name = "label15";
            label15.Size = new Size(113, 29);
            label15.TabIndex = 172;
            label15.Text = "SUPPLIERS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(601, 262);
            label16.Name = "label16";
            label16.Size = new Size(155, 29);
            label16.TabIndex = 173;
            label16.Text = "TRANSACTIONS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(830, 260);
            label17.Name = "label17";
            label17.Size = new Size(73, 29);
            label17.TabIndex = 174;
            label17.Text = "USERS";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(1029, 259);
            label18.Name = "label18";
            label18.Size = new Size(51, 29);
            label18.TabIndex = 175;
            label18.Text = "UAC";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(1220, 260);
            label19.Name = "label19";
            label19.Size = new Size(50, 29);
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
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FloralWhite;
            btnClearFilters.FlatStyle = FlatStyle.Popup;
            btnClearFilters.ForeColor = Color.Black;
            btnClearFilters.Location = new Point(1168, 337);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(106, 23);
            btnClearFilters.TabIndex = 177;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 677);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1377, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 179;
            pictureBox3.TabStop = false;
            // 
            // timerDateandTime
            // 
            timerDateandTime.Enabled = true;
            timerDateandTime.Interval = 1000;
            timerDateandTime.Tick += timer1_Tick_1;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1367, 788);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(btnClearFilters);
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
            Controls.Add(btnFilter);
            Controls.Add(btnFilterDateSales);
            Controls.Add(label7);
            Controls.Add(dtpToSales);
            Controls.Add(label6);
            Controls.Add(dtpFromSales);
            Controls.Add(label3);
            Controls.Add(comboBoxSalesFilter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(label1);
            Controls.Add(dtpFrom);
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
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
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
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDateandTime;
    }
}



