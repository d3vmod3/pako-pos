namespace PAKOPointOfSale.Transactions.Void
{
    partial class VoidForm
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
            btnViewReceipt = new Button();
            label1 = new Label();
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            lblInvoiceNumber = new Label();
            SuspendLayout();
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.Location = new Point(564, 80);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(116, 23);
            btnViewReceipt.TabIndex = 0;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(546, 32);
            label1.TabIndex = 1;
            label1.Text = "Please review the receipt before voiding this receipt";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(564, 153);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(111, 40);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Void";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnProceed_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(233, 15);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to void this invoice?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Invoice Number:";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(113, 56);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(43, 15);
            lblInvoiceNumber.TabIndex = 5;
            lblInvoiceNumber.Text = "000000";
            // 
            // VoidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 205);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(btnViewReceipt);
            Name = "VoidForm";
            Text = "Void";
            Load += VoidForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewReceipt;
        private Label label1;
        private Button btnConfirm;
        private Label label2;
        private Label label3;
        private Label lblInvoiceNumber;
    }
}