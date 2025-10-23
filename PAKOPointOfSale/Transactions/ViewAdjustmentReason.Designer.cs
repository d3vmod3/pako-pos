namespace PAKOPointOfSale.Transactions
{
    partial class ViewAdjustmentReason
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
            txtReason = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.Location = new Point(12, 12);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ReadOnly = true;
            txtReason.Size = new Size(513, 176);
            txtReason.TabIndex = 0;
            txtReason.TextChanged += txtReason_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SeaGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(450, 195);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewAdjustmentReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(537, 230);
            Controls.Add(btnBack);
            Controls.Add(txtReason);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAdjustmentReason";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reason";
            Load += ViewAdjustmentReason_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReason;
        private Button btnBack;
    }
}