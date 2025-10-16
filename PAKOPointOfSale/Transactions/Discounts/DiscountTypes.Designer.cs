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
            SuspendLayout();
            // 
            // cmbDiscountTypes
            // 
            cmbDiscountTypes.FormattingEnabled = true;
            cmbDiscountTypes.Items.AddRange(new object[] { "None", "Senior Citizen 5%", "Senior Citizen 20%", "Person With Disability 5%", "Person With Disability 20%", "National Athletes and Coaches 20%" });
            cmbDiscountTypes.Location = new Point(12, 12);
            cmbDiscountTypes.Name = "cmbDiscountTypes";
            cmbDiscountTypes.Size = new Size(317, 23);
            cmbDiscountTypes.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 116);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(317, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(12, 72);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(260, 15);
            lblNote.TabIndex = 2;
            lblNote.Text = "Note: You can ONLY choose ONE Discount Type";
            // 
            // DiscountTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 151);
            Controls.Add(lblNote);
            Controls.Add(btnOk);
            Controls.Add(cmbDiscountTypes);
            Name = "DiscountTypes";
            Text = "Apply Discount";
            Load += DiscountTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDiscountTypes;
        private Button btnOk;
        private Label lblNote;
    }
}