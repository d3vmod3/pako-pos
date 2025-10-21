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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.ForestGreen;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.ForeColor = Color.White;
            btnViewReceipt.Location = new Point(176, 156);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(88, 32);
            btnViewReceipt.TabIndex = 0;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            btnViewReceipt.Click += btnViewReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 110);
            label1.Name = "label1";
            label1.Size = new Size(579, 32);
            label1.TabIndex = 1;
            label1.Text = "Please review the receipt before voiding this receipt";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(309, 156);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(88, 31);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Void";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnProceed_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(189, 37);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to void this invoice?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(243, 76);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 4;
            label3.Text = "Invoice Number:";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.White;
            lblInvoiceNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(372, 76);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(57, 20);
            lblInvoiceNumber.TabIndex = 5;
            lblInvoiceNumber.Text = "000000";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(-5, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(709, 31);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 156);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VoidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(671, 211);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Button button1;
    }
}