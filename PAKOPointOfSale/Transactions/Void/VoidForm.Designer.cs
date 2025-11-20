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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidForm));
            btnViewReceipt = new Button();
            label1 = new Label();
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            lblInvoiceNumber = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.ForestGreen;
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.ForeColor = Color.White;
            btnViewReceipt.Location = new Point(341, 169);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(88, 28);
            btnViewReceipt.TabIndex = 0;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            btnViewReceipt.Click += btnViewReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 127);
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
            btnConfirm.Location = new Point(445, 170);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(88, 27);
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
            label2.Location = new Point(189, 72);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to void this invoice?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(243, 99);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 4;
            label3.Text = "Invoice Number:";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.Transparent;
            lblInvoiceNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(372, 99);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(57, 20);
            lblInvoiceNumber.TabIndex = 5;
            lblInvoiceNumber.Text = "000000";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(-5, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(709, 57);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(548, 170);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 114;
            pictureBox1.TabStop = false;
            // 
            // VoidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(671, 211);
            Controls.Add(pictureBox1);
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
            KeyDown += VoidForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}