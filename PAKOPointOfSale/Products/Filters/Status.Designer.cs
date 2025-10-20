namespace PAKOPointOfSale.Products.Filters
{
    partial class Status
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
            cmbStatus = new ComboBox();
            label1 = new Label();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.ActiveBorder;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "", "Good", "Deffective" });
            cmbStatus.Location = new Point(110, 24);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(188, 23);
            cmbStatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose Status:";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Khaki;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Location = new Point(223, 53);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(316, 93);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Controls.Add(cmbStatus);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status";
            Load += Status_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private Label label1;
        private Button btnFilter;
    }
}