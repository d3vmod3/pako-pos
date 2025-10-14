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
            dataGridView1 = new DataGridView();
            permissionBindingSource = new BindingSource(components);
            cmbRole = new ComboBox();
            userTypeBindingSource = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
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
            dataGridView1.Location = new Point(15, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 331);
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
            cmbRole.Location = new Point(85, 18);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
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
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Role";
            // 
            // button1
            // 
            button1.Location = new Point(679, 384);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 3;
            button1.Text = "Update Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            usertypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // module_name
            // 
            module_name.DataPropertyName = "module_name";
            module_name.HeaderText = "module_name";
            module_name.Name = "module_name";
            // 
            // can_view
            // 
            can_view.DataPropertyName = "can_view";
            can_view.HeaderText = "View";
            can_view.Name = "can_view";
            // 
            // can_add
            // 
            can_add.DataPropertyName = "can_add";
            can_add.HeaderText = "Add";
            can_add.Name = "can_add";
            // 
            // can_edit
            // 
            can_edit.DataPropertyName = "can_edit";
            can_edit.HeaderText = "Edit";
            can_edit.Name = "can_edit";
            // 
            // can_delete
            // 
            can_delete.DataPropertyName = "can_delete";
            can_delete.HeaderText = "Delete";
            can_delete.Name = "can_delete";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            userTypeDataGridViewTextBoxColumn.HeaderText = "userType";
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // UAC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 410);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Controls.Add(dataGridView1);
            Name = "UAC";
            Text = "User Access Control";
            Load += UAC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbRole;
        private Label label1;
        private BindingSource userTypeBindingSource;
        private Button button1;
        private BindingSource permissionBindingSource;
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