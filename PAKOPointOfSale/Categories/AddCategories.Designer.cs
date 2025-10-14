namespace PAKOPointOfSale.Categories
{
    partial class AddCategories
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
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(179, 27);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(197, 23);
            txtCategoryID.TabIndex = 0;
            txtCategoryID.TextChanged += textBox1_TextChanged;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(179, 74);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(197, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(179, 115);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(197, 23);
            txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "CategoryID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 78);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 119);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(413, 167);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 214);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Name = "Categories";
            Text = "Categories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
    }
}