
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesList));
            dataGridView1 = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnExport = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblcategorieslist = new Label();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editCategory = new DataGridViewButtonColumn();
            deleteCategory = new DataGridViewButtonColumn();
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
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.CadetBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, descriptionDataGridViewTextBoxColumn, productsDataGridViewTextBoxColumn, editCategory, deleteCategory });
            dataGridView1.DataSource = categoryBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(1334, 544);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // btnExport
            // 
            btnExport.BackColor = Color.Gold;
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(1186, 108);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 22);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Search";
            label1.Click += label1_Click;
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
            lblcategorieslist.Font = new Font("Impact", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcategorieslist.ForeColor = Color.White;
            lblcategorieslist.Location = new Point(568, 9);
            lblcategorieslist.Name = "lblcategorieslist";
            lblcategorieslist.Size = new Size(490, 82);
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
            pictureBox3.Location = new Point(-3, 684);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1377, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 152;
            pictureBox3.TabStop = false;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Category Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
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
            editCategory.HeaderText = "";
            editCategory.Name = "editCategory";
            editCategory.ReadOnly = true;
            editCategory.Text = "Edit";
            editCategory.UseColumnTextForButtonValue = true;
            // 
            // deleteCategory
            // 
            deleteCategory.HeaderText = "";
            deleteCategory.Name = "deleteCategory";
            deleteCategory.ReadOnly = true;
            deleteCategory.Text = "Delete";
            deleteCategory.UseColumnTextForButtonValue = true;
            // 
            // CategoriesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1358, 788);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(lblcategorieslist);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnExport);
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
        private Button btnExport;
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
        private PictureBox pictureBox3;
        private Label dtpFrom;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn editCategory;
        private DataGridViewButtonColumn deleteCategory;
    }
}