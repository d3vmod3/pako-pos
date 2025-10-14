namespace PAKOPointOfSale.Users
{
    partial class DeactivatedUser
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
            btnYes = new Button();
            label9 = new Label();
            btnNo = new Button();
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
            userTypeBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new Point(300, 280);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 32;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 24);
            label9.Name = "label9";
            label9.Size = new Size(226, 15);
            label9.TabIndex = 33;
            label9.Text = "Are you sure you want to delete this user?";
            // 
            // btnNo
            // 
            btnNo.Location = new Point(381, 280);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 34;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 257);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 50;
            label8.Text = "User Role";
            // 
            // cmbRole
            // 
            cmbRole.DataSource = userTypeBindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.Enabled = false;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(107, 254);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 49;
            cmbRole.ValueMember = "id";
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 227);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 48;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 195);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 47;
            label6.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 169);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 46;
            label5.Text = "Suffix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 45;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 44;
            label3.Text = "Middle Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 43;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 42;
            label1.Text = "Username";
            // 
            // cmbGender
            // 
            cmbGender.Enabled = false;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(107, 224);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 41;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Enabled = false;
            dtpBirthdate.Location = new Point(107, 195);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 40;
            // 
            // txtSuffix
            // 
            txtSuffix.Enabled = false;
            txtSuffix.Location = new Point(107, 166);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(121, 23);
            txtSuffix.TabIndex = 39;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(107, 137);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 38;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Enabled = false;
            txtMiddleName.Location = new Point(107, 108);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(121, 23);
            txtMiddleName.TabIndex = 37;
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(107, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 36;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(107, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 35;
            // 
            // userTypeBindingSource1
            // 
            userTypeBindingSource1.DataSource = typeof(UserType);
            // 
            // DeactivatedUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 315);
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
            Controls.Add(btnNo);
            Controls.Add(label9);
            Controls.Add(btnYes);
            Name = "DeactivatedUser";
            Text = "Deactivate User";
            Load += DeleteUser_Load;
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnYes;
        private Label label9;
        private Button btnNo;
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
        private BindingSource userTypeBindingSource1;
    }
}