
namespace PAKOPointOfSale.Categories
{
    partial class CategoriesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>w
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesList));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isactiveDataGridViewCheckBoxColumn = new DataGridViewTextBoxColumn();
            productsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editCategory = new DataGridViewButtonColumn();
            categoryBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnPrint = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblcategorieslist = new Label();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.CadetBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, dataGridViewTextBoxColumn3, descriptionDataGridViewTextBoxColumn, isactiveDataGridViewCheckBoxColumn, productsDataGridViewTextBoxColumn, editCategory });
            dataGridView1.DataSource = categoryBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(1334, 527);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "name";
            dataGridViewTextBoxColumn3.HeaderText = "Category Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // isactiveDataGridViewCheckBoxColumn
            // 
            isactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_active";
            isactiveDataGridViewCheckBoxColumn.HeaderText = "Active";
            isactiveDataGridViewCheckBoxColumn.Name = "isactiveDataGridViewCheckBoxColumn";
            isactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            isactiveDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.False;
            isactiveDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            productsDataGridViewTextBoxColumn.HeaderText = "Products";
            productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            productsDataGridViewTextBoxColumn.ReadOnly = true;
            productsDataGridViewTextBoxColumn.Visible = false;
            // 
            // editCategory
            // 
            editCategory.DataPropertyName = "id";
            editCategory.HeaderText = "";
            editCategory.Name = "editCategory";
            editCategory.ReadOnly = true;
            editCategory.Text = "Edit";
            editCategory.UseColumnTextForButtonValue = true;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1105, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 22);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gold;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1186, 108);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 22);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(468, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-8, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1394, 101);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Image = Properties.Resources.PakoLogo;
            pictureBox2.Location = new Point(-3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(276, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblcategorieslist
            // 
            lblcategorieslist.AutoSize = true;
            lblcategorieslist.BackColor = SystemColors.ControlDarkDark;
            lblcategorieslist.Font = new Font("Impact", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcategorieslist.ForeColor = Color.White;
            lblcategorieslist.Location = new Point(568, 9);
            lblcategorieslist.Name = "lblcategorieslist";
            lblcategorieslist.Size = new Size(441, 75);
            lblcategorieslist.TabIndex = 11;
            lblcategorieslist.Text = "CATEGORIES LIST";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1267, 108);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 22);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDarkDark;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(-3, 667);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1377, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 152;
            pictureBox3.TabStop = false;
            // 
            // CategoriesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1358, 752);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(lblcategorieslist);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories List";
            Load += CategoryList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnPrint;
        private TextBox txtSearch;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn archive;
        private BindingSource categoryBindingSource;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblcategorieslist;
        private Button btnClose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isactiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn editCategory;
        private PictureBox pictureBox3;
    }
}