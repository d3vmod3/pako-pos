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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategory));
            btnSubmit = new Button();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            chkIsActive = new CheckBox();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbleditcategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(315, 243);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 28);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 128);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(342, 84);
            txtDescription.TabIndex = 9;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(129, 79);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(342, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.ForeColor = Color.Black;
            chkIsActive.Location = new Point(412, 218);
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
            btnClose.Location = new Point(396, 243);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 28);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 65);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // lbleditcategory
            // 
            lbleditcategory.AutoSize = true;
            lbleditcategory.BackColor = SystemColors.ControlDarkDark;
            lbleditcategory.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbleditcategory.ForeColor = Color.White;
            lbleditcategory.Location = new Point(193, 19);
            lbleditcategory.Name = "lbleditcategory";
            lbleditcategory.Size = new Size(137, 26);
            lbleditcategory.TabIndex = 31;
            lbleditcategory.Text = "EDIT CATEGORY";
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(502, 283);
            Controls.Add(lbleditcategory);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbleditcategory;
    }
}