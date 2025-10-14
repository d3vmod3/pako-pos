namespace PAKOPointOfSale.Categories
{
    partial class Archive
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
            label1 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            btnNo = new Button();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new Point(336, 210);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 13;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 147);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 106);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 63);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 10;
            label1.Text = "CategoryID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(176, 143);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(197, 23);
            txtDescription.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(176, 102);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(197, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(176, 55);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(197, 23);
            txtCategoryID.TabIndex = 7;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(426, 210);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 14;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 273);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Name = "Archive";
            Text = "Archive";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Button btnNo;
    }
}