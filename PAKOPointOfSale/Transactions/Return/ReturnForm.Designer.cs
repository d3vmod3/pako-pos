namespace PAKOPointOfSale.Transactions.Return
{
    partial class ReturnForm
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
            lblInvoiceNumber = new Label();
            label3 = new Label();
            dgvItems = new DataGridView();
            productCode = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(113, 9);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(43, 15);
            lblInvoiceNumber.TabIndex = 7;
            lblInvoiceNumber.Text = "000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Invoice Number:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { productCode, productName });
            dgvItems.Location = new Point(12, 80);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.Size = new Size(776, 290);
            dgvItems.TabIndex = 8;
            // 
            // productCode
            // 
            productCode.DataPropertyName = "product_code";
            productCode.HeaderText = "Prodcut Code";
            productCode.Name = "productCode";
            productCode.ReadOnly = true;
            // 
            // productName
            // 
            productName.DataPropertyName = "product_name";
            productName.HeaderText = "Product";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvItems);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            Name = "ReturnForm";
            Text = "ReturnForm";
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumber;
        private Label label3;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
    }
}