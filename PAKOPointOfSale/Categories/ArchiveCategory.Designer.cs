namespace PAKOPointOfSale.Categories
{
    partial class ArchiveCategory
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
            btnYes = new Button();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            btnNo = new Button();
            btnArchive = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.Green;
            btnYes.FlatStyle = FlatStyle.Popup;
            btnYes.ForeColor = Color.Black;
            btnYes.Location = new Point(307, 222);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 13;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(126, 92);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(337, 117);
            txtDescription.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Enabled = false;
            txtCategoryName.Location = new Point(126, 51);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(337, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Red;
            btnNo.FlatStyle = FlatStyle.Popup;
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(388, 221);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 14;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.Orange;
            btnArchive.FlatStyle = FlatStyle.Popup;
            btnArchive.Location = new Point(226, 222);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(75, 23);
            btnArchive.TabIndex = 15;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(256, 15);
            label1.TabIndex = 16;
            label1.Text = "Are you sure you want to archive this category?";
            // 
            // ArchiveCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(533, 273);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnArchive);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Name = "ArchiveCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            Load += Archive_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Label label3;
        private Label label2;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private Button btnNo;
        private Button btnArchive;
        private Label label1;
    }
}