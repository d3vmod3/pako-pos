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
            lstOptions = new ListBox();
            grpBoxActivityLogs = new GroupBox();
            dataGridView1 = new DataGridView();
            grpBoxBackupDatabase = new GroupBox();
            btnChoosePath = new Button();
            btnSaveDbaseBackupLocation = new Button();
            label1 = new Label();
            txtDbaseLocation = new TextBox();
            lblDescription = new Label();
            folderBrowserDialogDbaseBackupLocation = new FolderBrowserDialog();
            btnBackup = new Button();
            grpBoxActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpBoxBackupDatabase.SuspendLayout();
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
            grpBoxActivityLogs.Controls.Add(dataGridView1);
            grpBoxActivityLogs.Location = new Point(138, 12);
            grpBoxActivityLogs.Name = "grpBoxActivityLogs";
            grpBoxActivityLogs.Size = new Size(1028, 427);
            grpBoxActivityLogs.TabIndex = 0;
            grpBoxActivityLogs.TabStop = false;
            grpBoxActivityLogs.Text = "Activity Logs";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1016, 399);
            dataGridView1.TabIndex = 0;
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
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 451);
            Controls.Add(grpBoxBackupDatabase);
            Controls.Add(grpBoxActivityLogs);
            Controls.Add(lstOptions);
            Name = "Options";
            Text = "Options";
            Load += Options_Load;
            grpBoxActivityLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpBoxBackupDatabase.ResumeLayout(false);
            grpBoxBackupDatabase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOptions;
        private GroupBox grpBoxActivityLogs;
        private DataGridView dataGridView1;
        private GroupBox grpBoxBackupDatabase;
        private Button btnSaveDbaseBackupLocation;
        private Label label1;
        private TextBox txtDbaseLocation;
        private Label lblDescription;
        private Button btnChoosePath;
        private FolderBrowserDialog folderBrowserDialogDbaseBackupLocation;
        private Button btnBackup;
    }
}