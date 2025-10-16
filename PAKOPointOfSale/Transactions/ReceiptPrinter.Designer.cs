namespace PAKOPointOfSale.Transactions
{
    partial class ReceiptPrinter
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
            printSalesInvoice = new System.Drawing.Printing.PrintDocument();
            printSalesInvoiceDialog = new PrintDialog();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // printSalesInvoice
            // 
            printSalesInvoice.PrintPage += printSalesInvoice_PrintPage;
            // 
            // printSalesInvoiceDialog
            // 
            printSalesInvoiceDialog.UseEXDialog = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(463, 231);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(126, 39);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // ReceiptPrinter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 283);
            Controls.Add(btnPrint);
            Name = "ReceiptPrinter";
            Text = "ReceiptPrinter";
            Load += ReceiptPrinter_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printSalesInvoice;
        private PrintDialog printSalesInvoiceDialog;
        private Button btnPrint;
    }
}