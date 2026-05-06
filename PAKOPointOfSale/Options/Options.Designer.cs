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
            lstOptions = new ListBox();
            grpBoxActivityLogs = new GroupBox();
            btnExport = new Button();
            btnFilter = new Button();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            dgvActivityLogs = new DataGridView();
            timestamp = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            module = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            payload = new DataGridViewTextBoxColumn();
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
            lstOptions.FormattingEnabled = true;
            lstOptions.ItemHeight = 15;
            lstOptions.Items.AddRange(new object[] { "Activity Logs", "Backup Database" });
            lstOptions.Location = new Point(12, 12);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(120, 424);
            lstOptions.TabIndex = 0;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // grpBoxActivityLogs
            // 
            grpBoxActivityLogs.Controls.Add(btnExport);
            grpBoxActivityLogs.Controls.Add(btnFilter);
            grpBoxActivityLogs.Controls.Add(label4);
            grpBoxActivityLogs.Controls.Add(dtpTo);
            grpBoxActivityLogs.Controls.Add(label3);
            grpBoxActivityLogs.Controls.Add(dtpFrom);
            grpBoxActivityLogs.Controls.Add(dgvActivityLogs);
            grpBoxActivityLogs.Location = new Point(138, 12);
            grpBoxActivityLogs.Name = "grpBoxActivityLogs";
            grpBoxActivityLogs.Size = new Size(1028, 427);
            grpBoxActivityLogs.TabIndex = 0;
            grpBoxActivityLogs.TabStop = false;
            grpBoxActivityLogs.Text = "Activity Logs";
            grpBoxActivityLogs.Enter += grpBoxActivityLogs_Enter;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(469, 31);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 160;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(388, 31);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 159;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 15);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 158;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(195, 32);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(187, 23);
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
            dtpFrom.Location = new Point(3, 31);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(185, 23);
            dtpFrom.TabIndex = 155;
            // 
            // dgvActivityLogs
            // 
            dgvActivityLogs.AllowUserToAddRows = false;
            dgvActivityLogs.AllowUserToDeleteRows = false;
            dgvActivityLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLogs.Columns.AddRange(new DataGridViewColumn[] { timestamp, user, module, action, description, payload });
            dgvActivityLogs.Location = new Point(6, 61);
            dgvActivityLogs.Name = "dgvActivityLogs";
            dgvActivityLogs.ReadOnly = true;
            dgvActivityLogs.RowHeadersVisible = false;
            dgvActivityLogs.Size = new Size(1016, 360);
            dgvActivityLogs.TabIndex = 0;
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
            grpBoxBackupDatabase.Size = new Size(1028, 427);
            grpBoxBackupDatabase.TabIndex = 1;
            grpBoxBackupDatabase.TabStop = false;
            grpBoxBackupDatabase.Text = "Backup Database";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(921, 22);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(101, 23);
            btnBackup.TabIndex = 5;
            btnBackup.Text = "Backup Now";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnChoosePath
            // 
            btnChoosePath.Location = new Point(301, 26);
            btnChoosePath.Name = "btnChoosePath";
            btnChoosePath.Size = new Size(75, 23);
            btnChoosePath.TabIndex = 4;
            btnChoosePath.Text = "Select Folder";
            btnChoosePath.UseVisualStyleBackColor = true;
            btnChoosePath.Click += btnChoosePath_Click;
            // 
            // btnSaveDbaseBackupLocation
            // 
            btnSaveDbaseBackupLocation.Location = new Point(921, 398);
            btnSaveDbaseBackupLocation.Name = "btnSaveDbaseBackupLocation";
            btnSaveDbaseBackupLocation.Size = new Size(101, 23);
            btnSaveDbaseBackupLocation.TabIndex = 3;
            btnSaveDbaseBackupLocation.Text = "Save Changes";
            btnSaveDbaseBackupLocation.UseVisualStyleBackColor = true;
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
            txtDbaseLocation.Location = new Point(6, 55);
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
            // addActivityLogsTableBindingSource
            // 
            addActivityLogsTableBindingSource.DataSource = typeof(Migrations.AddActivityLogsTable);
            // 
            // addActivityLogsTableBindingSource1
            // 
            addActivityLogsTableBindingSource1.DataSource = typeof(Migrations.AddActivityLogsTable);
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 451);
            Controls.Add(grpBoxActivityLogs);
            Controls.Add(lstOptions);
            Controls.Add(grpBoxBackupDatabase);
            Name = "Options";
            Text = "Options";
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