namespace PAKOPointOfSale.Categories
{
    partial class CategoryList
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
            dataGridView1 = new DataGridView();
            categoryIDDataGridView = new DataGridViewTextBoxColumn();
            categorynameDataGridView = new DataGridViewTextBoxColumn();
            descriptionDataGridView = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnPrint = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { categoryIDDataGridView, categorynameDataGridView, descriptionDataGridView });
            dataGridView1.Location = new Point(-2, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 379);
            dataGridView1.TabIndex = 0;
            // 
            // categoryIDDataGridView
            // 
            categoryIDDataGridView.DataPropertyName = "category_id";
            categoryIDDataGridView.HeaderText = "Category ID";
            categoryIDDataGridView.Name = "categoryIDDataGridView";
            categoryIDDataGridView.Width = 200;
            // 
            // categorynameDataGridView
            // 
            categorynameDataGridView.DataPropertyName = "category_name";
            categorynameDataGridView.HeaderText = "Category Name";
            categorynameDataGridView.Name = "categorynameDataGridView";
            categorynameDataGridView.Width = 200;
            // 
            // descriptionDataGridView
            // 
            descriptionDataGridView.DataPropertyName = "description";
            descriptionDataGridView.HeaderText = "Description";
            descriptionDataGridView.Name = "descriptionDataGridView";
            descriptionDataGridView.Width = 200;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(432, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(513, 14);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(366, 23);
            txtSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // CategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 417);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "CategoryList";
            Text = "Categories List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn categoryIDDataGridView;
        private DataGridViewTextBoxColumn categorynameDataGridView;
        private DataGridViewTextBoxColumn descriptionDataGridView;
        private Button btnAdd;
        private Button btnPrint;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}