using System.ComponentModel;

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
            components = new Container();
            btnProceed = new Button();
            dgvItems = new DataGridView();
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
            btnViewReceipt = new Button();
            cmbInvoiceAction = new ComboBox();
            label9 = new Label();
            lblTransactionType = new Label();
            label14 = new Label();
            lblAdjustmentNumber = new Label();
            lblReturnNote = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label13 = new Label();
            id = new DataGridViewTextBoxColumn();
            selectReturn = new DataGridViewCheckBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            transaction = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)dgvItems).BeginInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(713, 515);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 23);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = SystemColors.ScrollBar;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { id, selectReturn, product_id, transaction_id, dataGridViewTextBoxColumn1, quantity, unit_price, vat_amount, vatable_sales, vat_exempt, discount, discount_type, total_amount, unit_of_measurement, transaction, product });
            dgvItems.DataSource = salesInvoiceItemBindingSource;
            dgvItems.Location = new Point(12, 270);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(776, 239);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 133);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 3;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 4;
            label3.Text = "Transaction Date and Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 29);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 56);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 6;
            label5.Text = "VATable Sales:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 83);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 7;
            label6.Text = "VAT Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 107);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 8;
            label7.Text = "VAT Exempt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 133);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 9;
            label8.Text = "Grand Total:";
            // 
            // lblTransactionId
            // 
            lblTransactionId.AutoSize = true;
            lblTransactionId.BackColor = Color.Silver;
            lblTransactionId.FlatStyle = FlatStyle.Popup;
            lblTransactionId.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblTransactionId.ForeColor = Color.Black;
            lblTransactionId.Location = new Point(113, 26);
            lblTransactionId.Name = "lblTransactionId";
            lblTransactionId.Size = new Size(62, 18);
            lblTransactionId.TabIndex = 10;
            lblTransactionId.Text = "000000";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(113, 107);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(43, 15);
            lblInvoiceNumber.TabIndex = 11;
            lblInvoiceNumber.Text = "000000";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new Point(166, 133);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(67, 15);
            lblTransactionDate.TabIndex = 12;
            lblTransactionDate.Text = "mmddyyyy";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(383, 29);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(28, 15);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "0.00";
            // 
            // lblVatableSales
            // 
            lblVatableSales.AutoSize = true;
            lblVatableSales.Location = new Point(383, 56);
            lblVatableSales.Name = "lblVatableSales";
            lblVatableSales.Size = new Size(28, 15);
            lblVatableSales.TabIndex = 14;
            lblVatableSales.Text = "0.00";
            // 
            // lblVatAmount
            // 
            lblVatAmount.AutoSize = true;
            lblVatAmount.Location = new Point(383, 83);
            lblVatAmount.Name = "lblVatAmount";
            lblVatAmount.Size = new Size(28, 15);
            lblVatAmount.TabIndex = 15;
            lblVatAmount.Text = "0.00";
            // 
            // lblVatExempt
            // 
            lblVatExempt.AutoSize = true;
            lblVatExempt.Location = new Point(383, 107);
            lblVatExempt.Name = "lblVatExempt";
            lblVatExempt.Size = new Size(28, 15);
            lblVatExempt.TabIndex = 16;
            lblVatExempt.Text = "0.00";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(383, 133);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(28, 15);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "0.00";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(394, 160);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(31, 15);
            lblPaymentMethod.TabIndex = 19;
            lblPaymentMethod.Text = "cash";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 160);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 18;
            label10.Text = "Payment Method:";
            // 
            // lblCashReceived
            // 
            lblCashReceived.AutoSize = true;
            lblCashReceived.Location = new Point(394, 188);
            lblCashReceived.Name = "lblCashReceived";
            lblCashReceived.Size = new Size(28, 15);
            lblCashReceived.TabIndex = 21;
            lblCashReceived.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 188);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 20;
            label11.Text = "Cash Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(394, 203);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(28, 15);
            lblChange.TabIndex = 23;
            lblChange.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(289, 203);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 22;
            label12.Text = "Change";
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.Location = new Point(668, 12);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(120, 23);
            btnViewReceipt.TabIndex = 25;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = true;
            btnViewReceipt.Click += button1_Click;
            // 
            // cmbInvoiceAction
            // 
            cmbInvoiceAction.FormattingEnabled = true;
            cmbInvoiceAction.Items.AddRange(new object[] { "", "Void", "Return" });
            cmbInvoiceAction.Location = new Point(586, 516);
            cmbInvoiceAction.Name = "cmbInvoiceAction";
            cmbInvoiceAction.Size = new Size(121, 23);
            cmbInvoiceAction.TabIndex = 26;
            cmbInvoiceAction.SelectedIndexChanged += cmbInvoiceAction_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 519);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 27;
            label9.Text = "Invoice Action:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(113, 56);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(96, 15);
            lblTransactionType.TabIndex = 29;
            lblTransactionType.Text = "Transaction Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 56);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 28;
            label14.Text = "Transaction Type:";
            // 
            // lblAdjustmentNumber
            // 
            lblAdjustmentNumber.AutoSize = true;
            lblAdjustmentNumber.Location = new Point(12, 83);
            lblAdjustmentNumber.Name = "lblAdjustmentNumber";
            lblAdjustmentNumber.Size = new Size(141, 15);
            lblAdjustmentNumber.TabIndex = 30;
            lblAdjustmentNumber.Text = "adjustment series: 000000";
            // 
            // lblReturnNote
            // 
            lblReturnNote.AutoSize = true;
            lblReturnNote.Location = new Point(12, 252);
            lblReturnNote.Name = "lblReturnNote";
            lblReturnNote.Size = new Size(277, 15);
            lblReturnNote.TabIndex = 31;
            lblReturnNote.Text = "Note: Gray items indicate they are already returned.";
            lblReturnNote.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 29);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 32;
            label13.Text = "Transaction No:";
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // selectReturn
            // 
            selectReturn.DataPropertyName = "selectReturn";
            selectReturn.FalseValue = "0";
            selectReturn.HeaderText = "Select an Item(s) to Return";
            selectReturn.Name = "selectReturn";
            selectReturn.Resizable = DataGridViewTriState.True;
            selectReturn.SortMode = DataGridViewColumnSortMode.Automatic;
            selectReturn.TrueValue = "1";
            selectReturn.Visible = false;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "product_id";
            product_id.Name = "product_id";
            product_id.Visible = false;
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            transaction_id.HeaderText = "transaction_id";
            transaction_id.Name = "transaction_id";
            transaction_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            dataGridViewTextBoxColumn1.HeaderText = "product_id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Applied Quantity";
            quantity.Name = "quantity";
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Subtotal";
            total_amount.Name = "total_amount";
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.DataPropertyName = "unit_of_measurement";
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            // 
            // transaction
            // 
            transaction.DataPropertyName = "transaction";
            transaction.HeaderText = "transaction";
            transaction.Name = "transaction";
            transaction.Visible = false;
            // 
            // product
            // 
            product.DataPropertyName = "product";
            product.HeaderText = "product";
            product.Name = "product";
            product.Visible = false;
            // 
            // ViewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(label13);
            Controls.Add(lblReturnNote);
            Controls.Add(lblAdjustmentNumber);
            Controls.Add(lblTransactionType);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(cmbInvoiceAction);
            Controls.Add(btnViewReceipt);
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
            Controls.Add(btnProceed);
            Name = "ViewTransaction";
            Text = "View Transaction";
            Load += ViewTransaction_Load;
            ((ISupportInitialize)dgvItems).EndInit();
            ((ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProceed;
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
        private Button btnViewReceipt;
        private ComboBox cmbInvoiceAction;
        private Label label9;
        private Label lblTransactionType;
        private Label label14;
        private Label lblAdjustmentSeries;
        private Label lblAdjustmentNumber;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewCheckBoxColumn select;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private Label lblReturnNote;
        private Label label13;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewCheckBoxColumn selectReturn;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn transaction;
        private DataGridViewTextBoxColumn product;
    }
}