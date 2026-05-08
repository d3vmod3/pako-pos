namespace PAKOPointOfSale.Options
{
    partial class Options
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
            lstOptions = new ListBox();
            grpBoxActivityLogs = new GroupBox();
            dgvActivityLogs = new DataGridView();
            timestamp = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            module = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            payload = new DataGridViewTextBoxColumn();
            btnExport = new Button();
            btnFilter = new Button();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            grpBoxBackupDatabase = new GroupBox();
            btnBackup = new Button();
            btnChoosePath = new Button();
            btnSaveDbaseBackupLocation = new Button();
            label1 = new Label();
            txtDbaseLocation = new TextBox();
            lblDescription = new Label();
            folderBrowserDialogDbaseBackupLocation = new FolderBrowserDialog();
            addActivityLogsTableBindingSource = new BindingSource(components);
            addActivityLogsTableBindingSource1 = new BindingSource(components);
            grpBoxActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).BeginInit();
            grpBoxBackupDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lstOptions
            // 
            lstOptions.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOptions.FormattingEnabled = true;
            lstOptions.ItemHeight = 19;
            lstOptions.Items.AddRange(new object[] { "Activity Logs", "Backup Database" });
            lstOptions.Location = new Point(12, 12);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(120, 422);
            lstOptions.TabIndex = 0;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // grpBoxActivityLogs
            // 
            grpBoxActivityLogs.Controls.Add(dgvActivityLogs);
            grpBoxActivityLogs.Controls.Add(btnExport);
            grpBoxActivityLogs.Controls.Add(btnFilter);
            grpBoxActivityLogs.Controls.Add(label4);
            grpBoxActivityLogs.Controls.Add(dtpTo);
            grpBoxActivityLogs.Controls.Add(label3);
            grpBoxActivityLogs.Controls.Add(dtpFrom);
            grpBoxActivityLogs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxActivityLogs.Location = new Point(138, 12);
            grpBoxActivityLogs.Name = "grpBoxActivityLogs";
            grpBoxActivityLogs.Size = new Size(1220, 725);
            grpBoxActivityLogs.TabIndex = 0;
            grpBoxActivityLogs.TabStop = false;
            grpBoxActivityLogs.Text = "Activity Logs";
            grpBoxActivityLogs.Enter += grpBoxActivityLogs_Enter;
            // 
            // dgvActivityLogs
            // 
            dgvActivityLogs.AllowUserToAddRows = false;
            dgvActivityLogs.AllowUserToDeleteRows = false;
            dgvActivityLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLogs.Columns.AddRange(new DataGridViewColumn[] { timestamp, user, module, action, description, payload });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvActivityLogs.DefaultCellStyle = dataGridViewCellStyle1;
            dgvActivityLogs.Location = new Point(6, 61);
            dgvActivityLogs.Name = "dgvActivityLogs";
            dgvActivityLogs.ReadOnly = true;
            dgvActivityLogs.RowHeadersVisible = false;
            dgvActivityLogs.Size = new Size(1214, 658);
            dgvActivityLogs.TabIndex = 0;
            dgvActivityLogs.CellContentClick += dgvActivityLogs_CellContentClick;
            // 
            // timestamp
            // 
            timestamp.DataPropertyName = "timestamp";
            timestamp.HeaderText = "Time Stamp";
            timestamp.Name = "timestamp";
            timestamp.ReadOnly = true;
            // 
            // user
            // 
            user.DataPropertyName = "user";
            user.HeaderText = "User";
            user.Name = "user";
            user.ReadOnly = true;
            // 
            // module
            // 
            module.DataPropertyName = "module";
            module.HeaderText = "Module";
            module.Name = "module";
            module.ReadOnly = true;
            // 
            // action
            // 
            action.DataPropertyName = "action";
            action.HeaderText = "Action";
            action.Name = "action";
            action.ReadOnly = true;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // payload
            // 
            payload.DataPropertyName = "payload";
            payload.HeaderText = "Payload";
            payload.Name = "payload";
            payload.ReadOnly = true;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(0, 192, 0);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExport.Location = new Point(519, 32);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 160;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 255, 128);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFilter.Location = new Point(438, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 159;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 15);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 158;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(220, 33);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(212, 25);
            dtpTo.TabIndex = 157;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 156;
            label3.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(6, 33);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(208, 25);
            dtpFrom.TabIndex = 155;
            // 
            // grpBoxBackupDatabase
            // 
            grpBoxBackupDatabase.Controls.Add(btnBackup);
            grpBoxBackupDatabase.Controls.Add(btnChoosePath);
            grpBoxBackupDatabase.Controls.Add(btnSaveDbaseBackupLocation);
            grpBoxBackupDatabase.Controls.Add(label1);
            grpBoxBackupDatabase.Controls.Add(txtDbaseLocation);
            grpBoxBackupDatabase.Controls.Add(lblDescription);
            grpBoxBackupDatabase.Location = new Point(138, 12);
            grpBoxBackupDatabase.Name = "grpBoxBackupDatabase";
            grpBoxBackupDatabase.Size = new Size(513, 220);
            grpBoxBackupDatabase.TabIndex = 1;
            grpBoxBackupDatabase.TabStop = false;
            grpBoxBackupDatabase.Text = "Backup Database";
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(255, 255, 128);
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Location = new Point(275, 173);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(101, 23);
            btnBackup.TabIndex = 5;
            btnBackup.Text = "Backup Now";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnChoosePath
            // 
            btnChoosePath.BackColor = Color.Turquoise;
            btnChoosePath.FlatStyle = FlatStyle.Flat;
            btnChoosePath.Location = new Point(301, 26);
            btnChoosePath.Name = "btnChoosePath";
            btnChoosePath.Size = new Size(75, 23);
            btnChoosePath.TabIndex = 4;
            btnChoosePath.Text = "Select Folder";
            btnChoosePath.UseVisualStyleBackColor = false;
            btnChoosePath.Click += btnChoosePath_Click;
            // 
            // btnSaveDbaseBackupLocation
            // 
            btnSaveDbaseBackupLocation.BackColor = Color.LimeGreen;
            btnSaveDbaseBackupLocation.FlatStyle = FlatStyle.Flat;
            btnSaveDbaseBackupLocation.Location = new Point(141, 173);
            btnSaveDbaseBackupLocation.Name = "btnSaveDbaseBackupLocation";
            btnSaveDbaseBackupLocation.Size = new Size(101, 23);
            btnSaveDbaseBackupLocation.TabIndex = 3;
            btnSaveDbaseBackupLocation.Text = "Save Changes";
            btnSaveDbaseBackupLocation.UseVisualStyleBackColor = false;
            btnSaveDbaseBackupLocation.Click += btnSaveDbaseBackupLocation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 137);
            label1.Name = "label1";
            label1.Size = new Size(476, 15);
            label1.TabIndex = 2;
            label1.Text = "Note: If the textbox is empty, the file will be saved in the same location as the application.";
            // 
            // txtDbaseLocation
            // 
            txtDbaseLocation.Location = new Point(13, 55);
            txtDbaseLocation.Multiline = true;
            txtDbaseLocation.Name = "txtDbaseLocation";
            txtDbaseLocation.ReadOnly = true;
            txtDbaseLocation.Size = new Size(486, 79);
            txtDbaseLocation.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(289, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Choose where the backup database file will be stored.";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1370, 749);
            Controls.Add(lstOptions);
            Controls.Add(grpBoxActivityLogs);
            Controls.Add(grpBoxBackupDatabase);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Options";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            WindowState = FormWindowState.Maximized;
            Load += Options_Load;
            grpBoxActivityLogs.ResumeLayout(false);
            grpBoxActivityLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).EndInit();
            grpBoxBackupDatabase.ResumeLayout(false);
            grpBoxBackupDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOptions;
        private GroupBox grpBoxActivityLogs;
        private DataGridView dgvActivityLogs;
        private GroupBox grpBoxBackupDatabase;
        private Button btnSaveDbaseBackupLocation;
        private Label label1;
        private TextBox txtDbaseLocation;
        private Label lblDescription;
        private Button btnChoosePath;
        private FolderBrowserDialog folderBrowserDialogDbaseBackupLocation;
        private Button btnBackup;
        private BindingSource addActivityLogsTableBindingSource;
        private BindingSource addActivityLogsTableBindingSource1;
        private Button btnExport;
        private Button btnFilter;
        private Label label4;
        private DateTimePicker dtpTo;
        private Label label3;
        private DateTimePicker dtpFrom;
        private DataGridViewTextBoxColumn timestamp;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn module;
        private DataGridViewTextBoxColumn action;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn payload;
    }
}