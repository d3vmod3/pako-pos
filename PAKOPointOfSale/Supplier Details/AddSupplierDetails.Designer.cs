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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierDetails));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSupplierName = new TextBox();
            txtAddress = new TextBox();
            txtContactNumber = new TextBox();
            txtAccountNumber = new TextBox();
            txtGateway = new TextBox();
            lblAddUser = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSubmit = new Button();
            btnClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 138);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 178);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 3;
            label4.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 221);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 4;
            label5.Text = "Account Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 262);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 5;
            label6.Text = "Gateway:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtSupplierName.Location = new Point(138, 96);
            txtSupplierName.MaxLength = 50;
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(219, 20);
            txtSupplierName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtAddress.Location = new Point(141, 135);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(219, 20);
            txtAddress.TabIndex = 9;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtContactNumber.Location = new Point(176, 178);
            txtContactNumber.MaxLength = 10;
            txtContactNumber.Multiline = true;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(184, 20);
            txtContactNumber.TabIndex = 10;
            txtContactNumber.TextChanged += txtContactNumber_TextChanged;
            txtContactNumber.KeyPress += txtContactNumber_KeyPress;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtAccountNumber.Location = new Point(141, 218);
            txtAccountNumber.MaxLength = 18;
            txtAccountNumber.Multiline = true;
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(219, 20);
            txtAccountNumber.TabIndex = 11;
            // 
            // txtGateway
            // 
            txtGateway.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtGateway.Location = new Point(141, 259);
            txtGateway.MaxLength = 12;
            txtGateway.Multiline = true;
            txtGateway.Name = "txtGateway";
            txtGateway.Size = new Size(219, 20);
            txtGateway.TabIndex = 12;
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.BackColor = Color.DimGray;
            lblAddUser.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddUser.ForeColor = Color.White;
            lblAddUser.Location = new Point(165, 13);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(174, 36);
            lblAddUser.TabIndex = 33;
            lblAddUser.Text = "ADD SUPPLIER";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(-1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(390, 66);
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(118, 311);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(69, 24);
            btnSubmit.TabIndex = 35;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(201, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(67, 24);
            btnClose.TabIndex = 150;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 178);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 151;
            label1.Text = "+63";
            // 
            // AddSupplierDetails
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(387, 360);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(lblAddUser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(txtGateway);
            Controls.Add(txtAccountNumber);
            Controls.Add(txtContactNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Calibri", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSupplierDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplierDetails";
            Load += AddSupplierDetails_Load;
            KeyDown += AddSupplierDetails_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox txtGateway;
        private Label lblAddUser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSubmit;
        private Button btnClose;
        private Label label1;
    }
}