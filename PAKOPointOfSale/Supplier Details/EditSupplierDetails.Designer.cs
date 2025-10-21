namespace PAKOPointOfSale.Supplier_Details
{
    partial class EditSupplierDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSupplierDetails));
            btnSubmit = new Button();
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
            chkIsActive = new CheckBox();
            lblCreatedAt = new Label();
            lblAddUser = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(650, 281);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPaymentGateway
            // 
            txtPaymentGateway.Font = new Font("Segoe Print", 9F);
            txtPaymentGateway.Location = new Point(516, 163);
            txtPaymentGateway.Multiline = true;
            txtPaymentGateway.Name = "txtPaymentGateway";
            txtPaymentGateway.Size = new Size(209, 23);
            txtPaymentGateway.TabIndex = 24;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe Print", 9F);
            txtAccountNumber.Location = new Point(516, 111);
            txtAccountNumber.Multiline = true;
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(209, 23);
            txtAccountNumber.TabIndex = 23;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe Print", 9F);
            txtContactNumber.Location = new Point(184, 213);
            txtContactNumber.Multiline = true;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(176, 23);
            txtContactNumber.TabIndex = 22;
            txtContactNumber.KeyPress += txtContactNumber_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe Print", 9F);
            txtAddress.Location = new Point(151, 164);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(209, 23);
            txtAddress.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe Print", 9F);
            txtSupplierName.Location = new Point(151, 112);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(209, 23);
            txtSupplierName.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 11.25F);
            label6.Location = new Point(393, 168);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 19;
            label6.Text = "Payment Gateway";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11.25F);
            label5.Location = new Point(393, 116);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 18;
            label5.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F);
            label4.Location = new Point(32, 222);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 17;
            label4.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F);
            label3.Location = new Point(32, 167);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 16;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F);
            label2.Location = new Point(32, 116);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 15;
            label2.Text = "Supplier Name";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(666, 254);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 26;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Calibri", 11.25F);
            lblCreatedAt.Location = new Point(393, 217);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(89, 18);
            lblCreatedAt.TabIndex = 27;
            lblCreatedAt.Text = "Date Created";
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.BackColor = Color.DimGray;
            lblAddUser.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddUser.ForeColor = Color.White;
            lblAddUser.Location = new Point(298, 21);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(215, 43);
            lblAddUser.TabIndex = 30;
            lblAddUser.Text = "EDIT SUPPLIER";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(771, 76);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(516, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 217);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 152;
            label1.Text = "+63";
            // 
            // EditSupplierDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(768, 336);
            Controls.Add(label1);
            Controls.Add(lblAddUser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblCreatedAt);
            Controls.Add(chkIsActive);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditSupplierDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditSupplierDetails";
            Load += EditSupplierDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
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
        private CheckBox chkIsActive;
        private Label lblCreatedAt;
        private Label lblAddUser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}