namespace PAKOPointOfSale.Transactions.Discounts
{
    partial class DiscountTypes
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
            cmbDiscountTypes = new ComboBox();
            btnOk = new Button();
            lblNote = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbDiscountTypes
            // 
            cmbDiscountTypes.BackColor = SystemColors.ActiveBorder;
            cmbDiscountTypes.FlatStyle = FlatStyle.Popup;
            cmbDiscountTypes.FormattingEnabled = true;
            cmbDiscountTypes.Items.AddRange(new object[] { "None", "Senior Citizen 5%", "Senior Citizen 20%", "Person With Disability 5%", "Person With Disability 20%", "National Athletes and Coaches 20%" });
            cmbDiscountTypes.Location = new Point(12, 51);
            cmbDiscountTypes.Name = "cmbDiscountTypes";
            cmbDiscountTypes.Size = new Size(317, 23);
            cmbDiscountTypes.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.CornflowerBlue;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(137, 116);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(74, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.White;
            lblNote.ForeColor = Color.Black;
            lblNote.Location = new Point(44, 87);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(260, 15);
            lblNote.TabIndex = 2;
            lblNote.Text = "Note: You can ONLY choose ONE Discount Type";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(-16, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(408, 31);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // DiscountTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 151);
            Controls.Add(pictureBox2);
            Controls.Add(lblNote);
            Controls.Add(btnOk);
            Controls.Add(cmbDiscountTypes);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply Discount";
            Load += DiscountTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDiscountTypes;
        private Button btnOk;
        private Label lblNote;
        private PictureBox pictureBox2;
    }
}