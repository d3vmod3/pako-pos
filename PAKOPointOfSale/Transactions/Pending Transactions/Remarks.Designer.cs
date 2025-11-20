namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    partial class Remarks
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
            txtRemarks = new TextBox();
            label1 = new Label();
            btnProceed = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(12, 55);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(400, 97);
            txtRemarks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(408, 30);
            label1.TabIndex = 1;
            label1.Text = "Kindly provide remarks. This helps prevent mix-ups when retrieving pending\r\ntransactions with your customer.";
            label1.Click += label1_Click;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.OrangeRed;
            btnProceed.FlatStyle = FlatStyle.Popup;
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(252, 162);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 23);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Pending";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(335, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Remarks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(422, 197);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(label1);
            Controls.Add(txtRemarks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Remarks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remarks";
            Load += Remarks_Load;
            KeyDown += Remarks_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRemarks;
        private Label label1;
        private Button btnProceed;
        private Button btnCancel;
    }
}