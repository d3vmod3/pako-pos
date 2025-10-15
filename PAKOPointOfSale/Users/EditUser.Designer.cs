namespace PAKOPointOfSale.Users
{
    partial class EditUser
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
            components = new System.ComponentModel.Container();
            btnSubmit = new Button();
            label8 = new Label();
            cmbRole = new ComboBox();
            userTypeBindingSource = new BindingSource(components);
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbGender = new ComboBox();
            dtpBirthdate = new DateTimePicker();
            txtSuffix = new TextBox();
            txtLastName = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            txtUsername = new TextBox();
            chkIsActive = new CheckBox();
            lblCreatedAt = new Label();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(403, 288);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 33;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 230);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 32;
            label8.Text = "User Role";
            // 
            // cmbRole
            // 
            cmbRole.DataSource = userTypeBindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(120, 227);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 31;
            cmbRole.ValueMember = "id";
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 200);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 30;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 168);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 29;
            label6.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 142);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 28;
            label5.Text = "Suffix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 113);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 27;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 26;
            label3.Text = "Middle Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 25;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(120, 197);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 23;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(120, 168);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 22;
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(120, 139);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(121, 23);
            txtSuffix.TabIndex = 21;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 20;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(120, 81);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(121, 23);
            txtMiddleName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 17;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(182, 292);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 34;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(25, 260);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(81, 15);
            lblCreatedAt.TabIndex = 35;
            lblCreatedAt.Text = "Date Created: ";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 334);
            Controls.Add(lblCreatedAt);
            Controls.Add(chkIsActive);
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
            Name = "EditUser";
            Text = "Edit User";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label8;
        private ComboBox cmbRole;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbGender;
        private DateTimePicker dtpBirthdate;
        private TextBox txtSuffix;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private TextBox txtUsername;
        private BindingSource userTypeBindingSource;
        private CheckBox chkIsActive;
        private Label lblCreatedAt;
    }
}