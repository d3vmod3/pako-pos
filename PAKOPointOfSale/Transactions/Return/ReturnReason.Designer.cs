namespace PAKOPointOfSale.Transactions.Return
{
    partial class ReturnReason
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
            label1 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.Location = new Point(12, 27);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(408, 172);
            txtReason.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 15);
            label1.TabIndex = 1;
            label1.Text = "Please indicate the reason why you want to return the item(s).";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(345, 205);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ReturnReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 238);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtReason);
            Name = "ReturnReason";
            Text = "Return Reason";
            Load += ReturnReason_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReason;
        private Label label1;
        private Button btnSubmit;
    }
}