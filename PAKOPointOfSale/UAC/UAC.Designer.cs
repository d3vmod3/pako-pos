namespace PAKOPointOfSale.UAC
{
    partial class UAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAC));
            dataGridView1 = new DataGridView();
            permissionBindingSource = new BindingSource(components);
            cmbRole = new ComboBox();
            userTypeBindingSource = new BindingSource(components);
            label1 = new Label();
            btnUpdate = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbluserslist = new Label();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usertypeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            module_name = new DataGridViewTextBoxColumn();
            can_view = new DataGridViewCheckBoxColumn();
            can_add = new DataGridViewCheckBoxColumn();
            can_edit = new DataGridViewCheckBoxColumn();
            can_delete = new DataGridViewCheckBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, usertypeidDataGridViewTextBoxColumn, module_name, can_view, can_add, can_edit, can_delete, userTypeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = permissionBindingSource;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(15, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1342, 553);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // permissionBindingSource
            // 
            permissionBindingSource.DataSource = typeof(Model.Permission);
            // 
            // cmbRole
            // 
            cmbRole.DataSource = userTypeBindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(84, 99);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(376, 23);
            cmbRole.TabIndex = 1;
            cmbRole.ValueMember = "id";
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            cmbRole.SelectedValueChanged += cmbRole_SelectedValueChanged;
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Location = new Point(14, 102);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Role";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1172, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Changes";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1393, 91);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lbluserslist
            // 
            lbluserslist.AutoSize = true;
            lbluserslist.BackColor = Color.DimGray;
            lbluserslist.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluserslist.ForeColor = Color.White;
            lbluserslist.Location = new Point(445, 7);
            lbluserslist.Name = "lbluserslist";
            lbluserslist.Size = new Size(641, 80);
            lbluserslist.TabIndex = 19;
            lbluserslist.Text = "USERS ACCESS CONTROL";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1278, 98);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 24);
            btnClose.TabIndex = 150;
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
            pictureBox3.Location = new Point(-10, 684);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1402, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 151;
            pictureBox3.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.MinimumWidth = 300;
            usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            usertypeidDataGridViewTextBoxColumn.Visible = false;
            usertypeidDataGridViewTextBoxColumn.Width = 300;
            // 
            // module_name
            // 
            module_name.DataPropertyName = "module_name";
            module_name.HeaderText = "Module";
            module_name.MinimumWidth = 300;
            module_name.Name = "module_name";
            module_name.Width = 300;
            // 
            // can_view
            // 
            can_view.DataPropertyName = "can_view";
            can_view.HeaderText = "View";
            can_view.MinimumWidth = 250;
            can_view.Name = "can_view";
            can_view.Width = 250;
            // 
            // can_add
            // 
            can_add.DataPropertyName = "can_add";
            can_add.HeaderText = "Add";
            can_add.MinimumWidth = 250;
            can_add.Name = "can_add";
            can_add.Width = 250;
            // 
            // can_edit
            // 
            can_edit.DataPropertyName = "can_edit";
            can_edit.HeaderText = "Edit";
            can_edit.MinimumWidth = 250;
            can_edit.Name = "can_edit";
            can_edit.Width = 250;
            // 
            // can_delete
            // 
            can_delete.DataPropertyName = "can_delete";
            can_delete.HeaderText = "Delete";
            can_delete.MinimumWidth = 300;
            can_delete.Name = "can_delete";
            can_delete.Width = 300;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            userTypeDataGridViewTextBoxColumn.HeaderText = "userType";
            userTypeDataGridViewTextBoxColumn.MinimumWidth = 300;
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.Visible = false;
            userTypeDataGridViewTextBoxColumn.Width = 300;
            // 
            // UAC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1386, 788);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(lbluserslist);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UAC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Access Control";
            Load += UAC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbRole;
        private Label label1;
        private BindingSource userTypeBindingSource;
        private Button btnUpdate;
        private BindingSource permissionBindingSource;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbluserslist;
        private Button btnClose;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usertypeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn module_name;
        private DataGridViewCheckBoxColumn can_view;
        private DataGridViewCheckBoxColumn can_add;
        private DataGridViewCheckBoxColumn can_edit;
        private DataGridViewCheckBoxColumn can_delete;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
    }
}