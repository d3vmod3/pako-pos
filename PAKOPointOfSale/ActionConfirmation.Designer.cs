namespace PAKOPointOfSale
{
    partial class ActionConfirmation
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
            txtPassword = new TextBox();
            btnOk = new Button();
            label1 = new Label();
            label2 = new Label();
            lblMessage = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtUsername.Location = new Point(134, 44);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 25);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtPassword.Location = new Point(134, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(208, 25);
            txtPassword.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SeaGreen;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(148, 128);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Submit";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(57, 51);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(57, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblMessage.Location = new Point(172, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(89, 17);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Message Info";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(229, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActionConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(408, 174);
            Controls.Add(button1);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActionConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Credentials";
            Load += ActionConfirmation_Load;
            KeyDown += ActionConfirmation_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnOk;
        private Label label1;
        private Label label2;
        private Label lblMessage;
        private Button button1;
    }
}