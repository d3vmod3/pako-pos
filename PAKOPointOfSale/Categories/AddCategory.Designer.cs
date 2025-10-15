namespace PAKOPointOfSale.Categories
{
    partial class AddCategory
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
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(140, 28);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(332, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(140, 79);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(332, 87);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 34);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 79);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(314, 183);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(76, 24);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(396, 183);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(76, 24);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(498, 232);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += AddCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private Button btnClose;
    }
}