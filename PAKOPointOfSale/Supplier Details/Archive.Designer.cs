namespace PAKOPointOfSale.Supplier_Details
{
    partial class Archive
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
            txtPaymentGateway = new TextBox();
            txtAccountNumber = new TextBox();
            txtContactNumber = new TextBox();
            txtAddress = new TextBox();
            txtSupplierName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNo = new Button();
            btnYes = new Button();
            SuspendLayout();
            // 
            // txtPaymentGateway
            // 
            txtPaymentGateway.Font = new Font("Segoe Print", 9F);
            txtPaymentGateway.Location = new Point(151, 268);
            txtPaymentGateway.Name = "txtPaymentGateway";
            txtPaymentGateway.Size = new Size(209, 29);
            txtPaymentGateway.TabIndex = 24;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe Print", 9F);
            txtAccountNumber.Location = new Point(151, 218);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(209, 29);
            txtAccountNumber.TabIndex = 23;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe Print", 9F);
            txtContactNumber.Location = new Point(151, 169);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(209, 29);
            txtContactNumber.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe Print", 9F);
            txtAddress.Location = new Point(151, 118);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(209, 29);
            txtAddress.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe Print", 9F);
            txtSupplierName.Location = new Point(151, 58);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(209, 29);
            txtSupplierName.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F);
            label6.Location = new Point(22, 271);
            label6.Name = "label6";
            label6.Size = new Size(103, 14);
            label6.TabIndex = 19;
            label6.Text = "Payment Gateway";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F);
            label5.Location = new Point(22, 221);
            label5.Name = "label5";
            label5.Size = new Size(95, 14);
            label5.TabIndex = 18;
            label5.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F);
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(93, 14);
            label4.TabIndex = 17;
            label4.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F);
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(51, 14);
            label3.TabIndex = 16;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F);
            label2.Location = new Point(22, 66);
            label2.Name = "label2";
            label2.Size = new Size(88, 14);
            label2.TabIndex = 15;
            label2.Text = "Supplier Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 111;
            label1.Text = "Are you sure you want to archive this product?";
            // 
            // btnNo
            // 
            btnNo.Location = new Point(285, 325);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 113;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(195, 325);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 112;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // Arhive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 375);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Controls.Add(txtPaymentGateway);
            Controls.Add(txtAccountNumber);
            Controls.Add(txtContactNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Arhive";
            Text = "Archive";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPaymentGateway;
        private TextBox txtAccountNumber;
        private TextBox txtContactNumber;
        private TextBox txtAddress;
        private TextBox txtSupplierName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNo;
        private Button btnYes;
    }
}