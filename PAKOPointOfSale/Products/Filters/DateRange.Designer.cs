namespace PAKOPointOfSale.Products.Filters
{
    partial class DateRange
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
            dtFrom = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtTo = new DateTimePicker();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(80, 29);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(200, 23);
            dtFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Date From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Date To:";
            // 
            // dtTo
            // 
            dtTo.Location = new Point(80, 68);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(200, 23);
            dtTo.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(205, 97);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // DateRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 140);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(dtTo);
            Controls.Add(label1);
            Controls.Add(dtFrom);
            Name = "DateRange";
            Text = "Filter by";
            Load += DateRange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFrom;
        private Label label1;
        private Label label2;
        private DateTimePicker dtTo;
        private Button btnFilter;
    }
}