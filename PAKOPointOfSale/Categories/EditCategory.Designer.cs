namespace PAKOPointOfSale.Categories
{
    partial class EditCategory
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
            btnSubmit = new Button();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            chkIsActive = new CheckBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(347, 200);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 86);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 42);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(140, 85);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(363, 84);
            txtDescription.TabIndex = 9;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(140, 36);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(363, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.ForeColor = Color.White;
            chkIsActive.Location = new Point(444, 175);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 27;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(428, 200);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(530, 250);
            Controls.Add(btnClose);
            Controls.Add(chkIsActive);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCategory";
            Text = "Edit Category";
            Load += EditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label3;
        private Label label2;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private CheckBox chkIsActive;
        private Button btnClose;
    }
}