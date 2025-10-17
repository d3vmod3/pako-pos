namespace PAKOPointOfSale.Transactions
{
    partial class ViewTransaction
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
            components = new System.ComponentModel.Container();
            btnVoid = new Button();
            dgvItems = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productCode = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            transactionidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitpriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatamountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatablesalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vatexemptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discounttypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalamountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitofmeasurementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesInvoiceItemBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTransactionId = new Label();
            lblInvoiceNumber = new Label();
            lblTransactionDate = new Label();
            lblSubTotal = new Label();
            lblVatableSales = new Label();
            lblVatAmount = new Label();
            lblVatExempt = new Label();
            lblGrandTotal = new Label();
            lblPaymentMethod = new Label();
            label10 = new Label();
            lblCashReceived = new Label();
            label11 = new Label();
            lblChange = new Label();
            label12 = new Label();
            btnReturn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVoid
            // 
            btnVoid.Location = new Point(632, 12);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(75, 23);
            btnVoid.TabIndex = 0;
            btnVoid.Text = "Void";
            btnVoid.UseVisualStyleBackColor = true;
            btnVoid.Click += btnVoid_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productCode, productName, transactionidDataGridViewTextBoxColumn, productidDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitpriceDataGridViewTextBoxColumn, vatamountDataGridViewTextBoxColumn, vatablesalesDataGridViewTextBoxColumn, vatexemptDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, discounttypeDataGridViewTextBoxColumn, totalamountDataGridViewTextBoxColumn, unitofmeasurementDataGridViewTextBoxColumn, transactionDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            dgvItems.DataSource = salesInvoiceItemBindingSource;
            dgvItems.Location = new Point(12, 219);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.Size = new Size(776, 290);
            dgvItems.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productCode
            // 
            productCode.DataPropertyName = "id";
            productCode.HeaderText = "Prodcut Code";
            productCode.Name = "productCode";
            productCode.ReadOnly = true;
            // 
            // productName
            // 
            productName.DataPropertyName = "id";
            productName.HeaderText = "Product";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            transactionidDataGridViewTextBoxColumn.DataPropertyName = "transaction_id";
            transactionidDataGridViewTextBoxColumn.HeaderText = "transaction_id";
            transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            transactionidDataGridViewTextBoxColumn.ReadOnly = true;
            transactionidDataGridViewTextBoxColumn.Visible = false;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            productidDataGridViewTextBoxColumn.ReadOnly = true;
            productidDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Applied Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatamountDataGridViewTextBoxColumn
            // 
            vatamountDataGridViewTextBoxColumn.DataPropertyName = "vat_amount";
            vatamountDataGridViewTextBoxColumn.HeaderText = "VAT Amount";
            vatamountDataGridViewTextBoxColumn.Name = "vatamountDataGridViewTextBoxColumn";
            vatamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatablesalesDataGridViewTextBoxColumn
            // 
            vatablesalesDataGridViewTextBoxColumn.DataPropertyName = "vatable_sales";
            vatablesalesDataGridViewTextBoxColumn.HeaderText = "VATable Sales";
            vatablesalesDataGridViewTextBoxColumn.Name = "vatablesalesDataGridViewTextBoxColumn";
            vatablesalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatexemptDataGridViewTextBoxColumn
            // 
            vatexemptDataGridViewTextBoxColumn.DataPropertyName = "vat_exempt";
            vatexemptDataGridViewTextBoxColumn.HeaderText = "VAT Exempt";
            vatexemptDataGridViewTextBoxColumn.Name = "vatexemptDataGridViewTextBoxColumn";
            vatexemptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount Amount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discounttypeDataGridViewTextBoxColumn
            // 
            discounttypeDataGridViewTextBoxColumn.DataPropertyName = "discount_type";
            discounttypeDataGridViewTextBoxColumn.HeaderText = "Discount Type";
            discounttypeDataGridViewTextBoxColumn.Name = "discounttypeDataGridViewTextBoxColumn";
            discounttypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            totalamountDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            totalamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitofmeasurementDataGridViewTextBoxColumn
            // 
            unitofmeasurementDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement";
            unitofmeasurementDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitofmeasurementDataGridViewTextBoxColumn.Name = "unitofmeasurementDataGridViewTextBoxColumn";
            unitofmeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDataGridViewTextBoxColumn
            // 
            transactionDataGridViewTextBoxColumn.DataPropertyName = "transaction";
            transactionDataGridViewTextBoxColumn.HeaderText = "transaction";
            transactionDataGridViewTextBoxColumn.Name = "transactionDataGridViewTextBoxColumn";
            transactionDataGridViewTextBoxColumn.ReadOnly = true;
            transactionDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "product";
            productDataGridViewTextBoxColumn.HeaderText = "product";
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            productDataGridViewTextBoxColumn.Visible = false;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 4;
            label3.Text = "Transaction Date and Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 123);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "VATable Sales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 177);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 7;
            label6.Text = "VAT Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 201);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 8;
            label7.Text = "VAT Exempt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 29);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 9;
            label8.Text = "Grand Total:";
            // 
            // lblTransactionId
            // 
            lblTransactionId.AutoSize = true;
            lblTransactionId.Location = new Point(113, 29);
            lblTransactionId.Name = "lblTransactionId";
            lblTransactionId.Size = new Size(43, 15);
            lblTransactionId.TabIndex = 10;
            lblTransactionId.Text = "000000";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(113, 63);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(43, 15);
            lblInvoiceNumber.TabIndex = 11;
            lblInvoiceNumber.Text = "000000";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new Point(166, 90);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(67, 15);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "mmddyyyy";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(106, 123);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(28, 15);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "0.00";
            // 
            // lblVatableSales
            // 
            lblVatableSales.AutoSize = true;
            lblVatableSales.Location = new Point(106, 150);
            lblVatableSales.Name = "lblVatableSales";
            lblVatableSales.Size = new Size(28, 15);
            lblVatableSales.TabIndex = 14;
            lblVatableSales.Text = "0.00";
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.Location = new Point(106, 177);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(28, 15);
            lblVatAmount.TabIndex = 15;
            lblVatAmount.Text = "0.00";
            // 
            // lblVatExempt
            // 
            lblVatExempt.AutoSize = true;
            lblVatExempt.Location = new Point(106, 201);
            lblVatExempt.Name = "lblVatExempt";
            lblVatExempt.Size = new Size(28, 15);
            lblVatExempt.TabIndex = 16;
            lblVatExempt.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(383, 29);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(28, 15);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "0.00";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(394, 56);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(31, 15);
            lblPaymentMethod.TabIndex = 19;
            lblPaymentMethod.Text = "cash";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 56);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 18;
            label10.Text = "Payment Method:";
            // 
            // lblCashReceived
            // 
            lblCashReceived.AutoSize = true;
            lblCashReceived.Location = new Point(394, 84);
            lblCashReceived.Name = "lblCashReceived";
            lblCashReceived.Size = new Size(28, 15);
            lblCashReceived.TabIndex = 21;
            lblCashReceived.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 84);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 20;
            label11.Text = "Cash Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(394, 99);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(28, 15);
            lblChange.TabIndex = 23;
            lblChange.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(289, 99);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 22;
            label12.Text = "Change";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(713, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(506, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 25;
            button1.Text = "View Receipt";
            button1.UseVisualStyleBackColor = true;
            // 
            // ViewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(button1);
            Controls.Add(btnReturn);
            Controls.Add(lblChange);
            Controls.Add(label12);
            Controls.Add(lblCashReceived);
            Controls.Add(label11);
            Controls.Add(lblPaymentMethod);
            Controls.Add(label10);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblVatExempt);
            Controls.Add(lblVatAmount);
            Controls.Add(lblVatableSales);
            Controls.Add(lblSubTotal);
            Controls.Add(lblTransactionDate);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(lblTransactionId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvItems);
            Controls.Add(btnVoid);
            Name = "ViewTransaction";
            Text = "View Transaction";
            Load += ViewTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoid;
        private DataGridView dgvItems;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTransactionId;
        private Label lblInvoiceNumber;
        private Label lblTransactionDate;
        private Label lblSubTotal;
        private Label lblVatableSales;
        private Label lblVatAmount;
        private Label lblVatExempt;
        private Label lblGrandTotal;
        private Label lblPaymentMethod;
        private Label label10;
        private Label lblCashReceived;
        private Label label11;
        private Label lblChange;
        private Label label12;
        private BindingSource salesInvoiceItemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatamountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatablesalesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatexemptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discounttypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitofmeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private Button btnReturn;
        private Button button1;
    }
}