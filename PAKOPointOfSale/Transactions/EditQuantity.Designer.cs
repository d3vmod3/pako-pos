namespace PAKOPointOfSale.Transactions
{
    partial class EditQuantity
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
            lblProductName = new Label();
            btnOk = new Button();
            lblProductBrand = new Label();
            lblUOM = new Label();
            label4 = new Label();
            num_AppliedQty = new NumericUpDown();
            lblCurrentQty = new Label();
            lblCurrentQtyValue = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            lblUnitPrice = new Label();
            lblCategory = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_AppliedQty).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(70, 9);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(49, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(252, 228);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Location = new Point(70, 33);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(38, 15);
            lblProductBrand.TabIndex = 2;
            lblProductBrand.Text = "Brand";
            // 
            // lblUOM
            // 
            lblUOM.AutoSize = true;
            lblUOM.Location = new Point(74, 57);
            lblUOM.Name = "lblUOM";
            lblUOM.Size = new Size(29, 15);
            lblUOM.TabIndex = 3;
            lblUOM.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 119);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // num_AppliedQty
            // 
            num_AppliedQty.Location = new Point(70, 117);
            num_AppliedQty.Name = "num_AppliedQty";
            num_AppliedQty.Size = new Size(257, 23);
            num_AppliedQty.TabIndex = 5;
            num_AppliedQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCurrentQty
            // 
            lblCurrentQty.AutoSize = true;
            lblCurrentQty.Location = new Point(9, 85);
            lblCurrentQty.Name = "lblCurrentQty";
            lblCurrentQty.Size = new Size(99, 15);
            lblCurrentQty.TabIndex = 6;
            lblCurrentQty.Text = "Current Quantity:";
            // 
            // lblCurrentQtyValue
            // 
            lblCurrentQtyValue.AutoSize = true;
            lblCurrentQtyValue.Location = new Point(114, 85);
            lblCurrentQtyValue.Name = "lblCurrentQtyValue";
            lblCurrentQtyValue.Size = new Size(13, 15);
            lblCurrentQtyValue.TabIndex = 7;
            lblCurrentQtyValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 57);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 10;
            label3.Text = "Unit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 177);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 11;
            label5.Text = "Current Quantity:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(109, 177);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(13, 15);
            lblUnitPrice.TabIndex = 12;
            lblUnitPrice.Text = "0";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(67, 152);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 152);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Category:";
            // 
            // EditQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 263);
            Controls.Add(lblCategory);
            Controls.Add(label7);
            Controls.Add(lblUnitPrice);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCurrentQtyValue);
            Controls.Add(lblCurrentQty);
            Controls.Add(num_AppliedQty);
            Controls.Add(label4);
            Controls.Add(lblUOM);
            Controls.Add(lblProductBrand);
            Controls.Add(btnOk);
            Controls.Add(lblProductName);
            Name = "EditQuantity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Quantity";
            Load += EditQuantity_Load;
            ((System.ComponentModel.ISupportInitialize)num_AppliedQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Button btnOk;
        private Label lblProductBrand;
        private Label lblUOM;
        private Label label4;
        private NumericUpDown num_AppliedQty;
        private Label lblCurrentQty;
        private Label lblCurrentQtyValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label lblUnitPrice;
        private Label lblCategory;
        private Label label7;
    }
}