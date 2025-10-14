namespace PAKOPointOfSale.Users
{
    partial class AddUser
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
            txtUsername = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtSuffix = new TextBox();
            dtpBirthdate = new DateTimePicker();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbRole = new ComboBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(107, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(107, 41);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(107, 70);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(121, 23);
            txtMiddleName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(107, 128);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(121, 23);
            txtSuffix.TabIndex = 4;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(107, 157);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 5;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(107, 186);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Suffix";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Birthdate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 189);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 219);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "User Role";
            label8.Click += label8_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(107, 216);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(499, 244);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 271);
            Controls.Add(btnSubmit);
            Controls.Add(label8);
            Controls.Add(cmbRole);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtSuffix);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtUsername);
            Name = "AddUser";
            Text = "Add User";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtSuffix;
        private DateTimePicker dtpBirthdate;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbRole;
        private Button btnSubmit;
    }
}