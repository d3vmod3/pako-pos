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
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            lblInvoiceNumber = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.ForestGreen;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnViewReceipt.ForeColor = Color.Black;
            btnViewReceipt.Location = new Point(58, 127);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(92, 32);
            btnViewReceipt.TabIndex = 0;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            btnViewReceipt.Click += btnViewReceipt_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(167, 127);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(117, 33);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Void";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnProceed_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 26);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to void this invoice?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(119, 59);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 4;
            label3.Text = "Invoice Number:";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.Transparent;
            lblInvoiceNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(263, 59);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(64, 21);
            lblInvoiceNumber.TabIndex = 5;
            lblInvoiceNumber.Text = "000000";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(300, 127);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 90);
            label1.Name = "label1";
            label1.Size = new Size(391, 21);
            label1.TabIndex = 1;
            label1.Text = "Please review the receipt before voiding this receipt";
            // 
            // VoidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(457, 190);
            Controls.Add(button1);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(btnViewReceipt);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VoidForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Void";
            Load += VoidForm_Load;
            KeyDown += VoidForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewReceipt;
        private Button btnConfirm;
        private Label label2;
        private Label label3;
        private Label lblInvoiceNumber;
        private Button button1;
        private Label label1;
    }
}