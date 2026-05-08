namespace PAKOPointOfSale.Users
{
    partial class UsersList
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            usertypeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middlenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suffixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userType = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            userBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            lbluserslist = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, usertypeidDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstnameDataGridViewTextBoxColumn, middlenameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, userType, createdatDataGridViewTextBoxColumn, is_active, edit });
            dataGridView1.DataSource = userBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(14, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1342, 634);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            usertypeidDataGridViewTextBoxColumn.ReadOnly = true;
            usertypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            middlenameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            middlenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            birthdayDataGridViewTextBoxColumn.Width = 120;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            suffixDataGridViewTextBoxColumn.DataPropertyName = "suffix";
            suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            suffixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userType
            // 
            userType.DataPropertyName = "user_type";
            userType.HeaderText = "Role";
            userType.Name = "userType";
            userType.ReadOnly = true;
            userType.Width = 120;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            createdatDataGridViewTextBoxColumn.MinimumWidth = 150;
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            createdatDataGridViewTextBoxColumn.Width = 150;
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            edit.DataPropertyName = "id";
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(77, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(391, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 102);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1067, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(-20, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1406, 88);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbluserslist
            // 
            lbluserslist.AutoSize = true;
            lbluserslist.BackColor = Color.DimGray;
            lbluserslist.FlatStyle = FlatStyle.Popup;
            lbluserslist.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluserslist.ForeColor = Color.White;
            lbluserslist.Location = new Point(573, 11);
            lbluserslist.Name = "lbluserslist";
            lbluserslist.Size = new Size(234, 60);
            lbluserslist.TabIndex = 6;
            lbluserslist.Text = "USERS LIST";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1163, 96);
            button1.Name = "button1";
            button1.Size = new Size(95, 27);
            button1.TabIndex = 7;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1264, 96);
            button2.Name = "button2";
            button2.Size = new Size(91, 27);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1376, 775);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbluserslist);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users List";
            WindowState = FormWindowState.Maximized;
            Load += UsersList_Load;
            KeyDown += UsersList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource userBindingSource;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private Label lbluserslist;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usertypeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userType;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewButtonColumn edit;
    }
}