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
            btnCancel = new Button();
            panel1 = new Panel();
            num_customDiscount = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_customDiscount).BeginInit();
            SuspendLayout();
            // 
            // cmbDiscountTypes
            // 
            cmbDiscountTypes.BackColor = SystemColors.ActiveBorder;
            cmbDiscountTypes.FlatStyle = FlatStyle.Popup;
            cmbDiscountTypes.FormattingEnabled = true;
            cmbDiscountTypes.Items.AddRange(new object[] { "None", "Senior Citizen 5%", "Senior Citizen 20%", "Person With Disability 5%", "Person With Disability 20%", "National Athletes and Coaches 20%", "Regular Discount" });
            cmbDiscountTypes.Location = new Point(12, 51);
            cmbDiscountTypes.Name = "cmbDiscountTypes";
            cmbDiscountTypes.Size = new Size(317, 23);
            cmbDiscountTypes.TabIndex = 0;
            cmbDiscountTypes.SelectedIndexChanged += cmbDiscountTypes_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.CornflowerBlue;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(75, 41);
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
            lblNote.Location = new Point(29, 12);
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(155, 41);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(74, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOk);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 76);
            panel1.TabIndex = 15;
            // 
            // num_customDiscount
            // 
            num_customDiscount.DecimalPlaces = 2;
            num_customDiscount.Location = new Point(117, 78);
            num_customDiscount.Name = "num_customDiscount";
            num_customDiscount.Size = new Size(212, 23);
            num_customDiscount.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 17;
            label1.Text = "Custom Discount:";
            // 
            // DiscountTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 166);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(num_customDiscount);
            Controls.Add(pictureBox2);
            Controls.Add(cmbDiscountTypes);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply Discount";
            Load += DiscountTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_customDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDiscountTypes;
        private Button btnOk;
        private Label lblNote;
        private PictureBox pictureBox2;
        private Button btnCancel;
        private Panel panel1;
        private NumericUpDown num_customDiscount;
        private Label label1;
    }
}