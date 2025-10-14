namespace PAKOPointOfSale.Supplier_Details
{
    partial class AddSupplierDetails
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSupplierName = new TextBox();
            txtAddress = new TextBox();
            txtContactNumber = new TextBox();
            txtAccountNumber = new TextBox();
            txtPaymentGateway = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F);
            label2.Location = new Point(16, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F);
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F);
            label4.Location = new Point(16, 126);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9F);
            label5.Location = new Point(16, 175);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 4;
            label5.Text = "Account Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9F);
            label6.Location = new Point(16, 225);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 5;
            label6.Text = "Payment Gateway";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe Print", 9F);
            txtSupplierName.Location = new Point(145, 12);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(209, 29);
            txtSupplierName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe Print", 9F);
            txtAddress.Location = new Point(145, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(209, 29);
            txtAddress.TabIndex = 9;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe Print", 9F);
            txtContactNumber.Location = new Point(145, 123);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(209, 29);
            txtContactNumber.TabIndex = 10;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe Print", 9F);
            txtAccountNumber.Location = new Point(145, 172);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(209, 29);
            txtAccountNumber.TabIndex = 11;
            // 
            // txtPaymentGateway
            // 
            txtPaymentGateway.Font = new Font("Segoe Print", 9F);
            txtPaymentGateway.Location = new Point(145, 222);
            txtPaymentGateway.Name = "txtPaymentGateway";
            txtPaymentGateway.Size = new Size(209, 29);
            txtPaymentGateway.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe Print", 9F);
            btnSubmit.Location = new Point(279, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // AddSupplierDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 337);
            Controls.Add(btnSubmit);
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
            Name = "AddSupplierDetails";
            Text = "AddSupplierDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSupplierName;
        private TextBox txtAddress;
        private TextBox txtContactNumber;
        private TextBox txtAccountNumber;
        private TextBox txtPaymentGateway;
        private Button btnSubmit;
    }
}