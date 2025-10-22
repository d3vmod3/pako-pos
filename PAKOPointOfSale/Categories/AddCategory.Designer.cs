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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbladdcategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(134, 82);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(332, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(134, 133);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(332, 87);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 131);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(308, 233);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(76, 24);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(390, 234);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(76, 24);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 65);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // lbladdcategory
            // 
            lbladdcategory.AutoSize = true;
            lbladdcategory.BackColor = SystemColors.ControlDarkDark;
            lbladdcategory.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbladdcategory.Location = new Point(204, 19);
            lbladdcategory.Name = "lbladdcategory";
            lbladdcategory.Size = new Size(134, 26);
            lbladdcategory.TabIndex = 21;
            lbladdcategory.Text = "ADD CATEGORY";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(498, 270);
            Controls.Add(lbladdcategory);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbladdcategory;
    }
}