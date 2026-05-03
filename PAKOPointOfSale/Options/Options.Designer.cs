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
            lbOptions = new ListBox();
            grpBoxActivityLogs = new GroupBox();
            dataGridView1 = new DataGridView();
            grpBoxBackupDatabase = new GroupBox();
            lblDescription = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            grpBoxActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpBoxBackupDatabase.SuspendLayout();
            SuspendLayout();
            // 
            // lbOptions
            // 
            lbOptions.FormattingEnabled = true;
            lbOptions.ItemHeight = 15;
            lbOptions.Items.AddRange(new object[] { "Activity Logs", "Backup Database" });
            lbOptions.Location = new Point(12, 12);
            lbOptions.Name = "lbOptions";
            lbOptions.Size = new Size(120, 424);
            lbOptions.TabIndex = 0;
            lbOptions.SelectedIndexChanged += lbOptions_SelectedIndexChanged;
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
            grpBoxBackupDatabase.Controls.Add(btnSave);
            grpBoxBackupDatabase.Controls.Add(label1);
            grpBoxBackupDatabase.Controls.Add(textBox1);
            grpBoxBackupDatabase.Controls.Add(lblDescription);
            grpBoxBackupDatabase.Location = new Point(138, 12);
            grpBoxBackupDatabase.Name = "grpBoxBackupDatabase";
            grpBoxBackupDatabase.Size = new Size(1028, 427);
            grpBoxBackupDatabase.TabIndex = 1;
            grpBoxBackupDatabase.TabStop = false;
            grpBoxBackupDatabase.Text = "Backup Database";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 37);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(289, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Choose where the backup database file will be stored.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 79);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 157);
            label1.Name = "label1";
            label1.Size = new Size(476, 15);
            label1.TabIndex = 2;
            label1.Text = "Note: If the textbox is empty, the file will be saved in the same location as the application.";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(921, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 451);
            Controls.Add(grpBoxBackupDatabase);
            Controls.Add(grpBoxActivityLogs);
            Controls.Add(lbOptions);
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

        private ListBox lbOptions;
        private GroupBox grpBoxActivityLogs;
        private DataGridView dataGridView1;
        private GroupBox grpBoxBackupDatabase;
        private Button btnSave;
        private Label label1;
        private TextBox textBox1;
        private Label lblDescription;
    }
}