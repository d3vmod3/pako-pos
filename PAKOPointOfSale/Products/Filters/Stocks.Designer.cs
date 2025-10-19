namespace PAKOPointOfSale.Products.Filters
{
    partial class Stocks
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
            label1 = new Label();
            btnFilter = new Button();
            num_quantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(359, 15);
            label1.TabIndex = 0;
            label1.Text = "Please input the minimum quantity you want to apply for this filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(296, 73);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // num_quantity
            // 
            num_quantity.DecimalPlaces = 2;
            num_quantity.Location = new Point(12, 44);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(359, 23);
            num_quantity.TabIndex = 3;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 118);
            Controls.Add(num_quantity);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Name = "Stocks";
            Text = "Filter Stocks";
            Load += Stocks_Load;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFilter;
        private NumericUpDown num_quantity;
    }
}