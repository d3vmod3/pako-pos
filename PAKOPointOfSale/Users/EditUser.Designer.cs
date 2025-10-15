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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
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
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbledituser = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(577, 354);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(78, 23);
            btnSubmit.TabIndex = 33;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(412, 248);
            label8.Name = "label8";
            label8.Size = new Size(75, 18);
            label8.TabIndex = 32;
            label8.Text = "User Role";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.DimGray;
            cmbRole.DataSource = userTypeBindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.FlatStyle = FlatStyle.Popup;
            cmbRole.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbRole.ForeColor = Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(514, 240);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(225, 26);
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
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(412, 208);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 30;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(412, 165);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 29;
            label6.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(412, 115);
            label5.Name = "label5";
            label5.Size = new Size(44, 18);
            label5.TabIndex = 28;
            label5.Text = "Suffix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 287);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 27;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 233);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 26;
            label3.Text = "Middle Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 170);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 25;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 109);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.DimGray;
            cmbGender.FlatStyle = FlatStyle.Popup;
            cmbGender.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbGender.ForeColor = Color.White;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(514, 200);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(225, 26);
            cmbGender.TabIndex = 23;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthdate.Location = new Point(514, 157);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(225, 22);
            dtpBirthdate.TabIndex = 22;
            // 
            // txtSuffix
            // 
            txtSuffix.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtSuffix.Location = new Point(514, 110);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(225, 24);
            txtSuffix.TabIndex = 21;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtLastName.Location = new Point(153, 290);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(226, 24);
            txtLastName.TabIndex = 20;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtMiddleName.Location = new Point(156, 228);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(223, 24);
            txtMiddleName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtFirstName.Location = new Point(156, 165);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(223, 24);
            txtFirstName.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtUsername.Location = new Point(156, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 24);
            txtUsername.TabIndex = 17;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(680, 319);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 34;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblCreatedAt.ForeColor = Color.Black;
            lblCreatedAt.Location = new Point(412, 287);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(95, 18);
            lblCreatedAt.TabIndex = 35;
            lblCreatedAt.Text = "Date Created";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(514, 283);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 22);
            dateTimePicker1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(874, 80);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // lbledituser
            // 
            lbledituser.AutoSize = true;
            lbledituser.BackColor = Color.DimGray;
            lbledituser.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbledituser.ForeColor = Color.White;
            lbledituser.Location = new Point(371, 24);
            lbledituser.Name = "lbledituser";
            lbledituser.Size = new Size(143, 39);
            lbledituser.TabIndex = 39;
            lbledituser.Text = "EDIT USER";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(661, 354);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 23);
            btnClose.TabIndex = 40;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(815, 398);
            Controls.Add(btnClose);
            Controls.Add(lbledituser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimePicker1);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit User";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbledituser;
        private Button btnClose;
    }
}