namespace WingBiteFinalProject
{
    partial class Transaction_Record
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
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeResult = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentMethodUsed = new System.Windows.Forms.Label();
            this.lblTotalAmountresult = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.ColOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountTendered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblDateTimeResult = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblOrderNumResult = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblSalesTransactionForm = new System.Windows.Forms.Label();
            this.picboxSalesTransactionForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesTransactionForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(302, 188);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(63, 19);
            this.lblChange.TabIndex = 61;
            this.lblChange.Text = "Change:";
            // 
            // lblChangeResult
            // 
            this.lblChangeResult.AutoSize = true;
            this.lblChangeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeResult.Location = new System.Drawing.Point(373, 188);
            this.lblChangeResult.Name = "lblChangeResult";
            this.lblChangeResult.Size = new System.Drawing.Size(105, 19);
            this.lblChangeResult.TabIndex = 60;
            this.lblChangeResult.Text = "Change Result";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(239, 163);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(126, 19);
            this.lblPaymentMethod.TabIndex = 59;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentMethodUsed
            // 
            this.lblPaymentMethodUsed.AutoSize = true;
            this.lblPaymentMethodUsed.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethodUsed.Location = new System.Drawing.Point(373, 163);
            this.lblPaymentMethodUsed.Name = "lblPaymentMethodUsed";
            this.lblPaymentMethodUsed.Size = new System.Drawing.Size(159, 19);
            this.lblPaymentMethodUsed.TabIndex = 58;
            this.lblPaymentMethodUsed.Text = "Payment Method Used";
            // 
            // lblTotalAmountresult
            // 
            this.lblTotalAmountresult.AutoSize = true;
            this.lblTotalAmountresult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountresult.Location = new System.Drawing.Point(373, 138);
            this.lblTotalAmountresult.Name = "lblTotalAmountresult";
            this.lblTotalAmountresult.Size = new System.Drawing.Size(156, 19);
            this.lblTotalAmountresult.TabIndex = 57;
            this.lblTotalAmountresult.Text = "Total Amount of order";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(259, 138);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(105, 19);
            this.lblTotalAmount.TabIndex = 56;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderNum,
            this.colOrderType,
            this.colTotal,
            this.colDiscount,
            this.colFinalTotal,
            this.colPaymentMethod,
            this.colAmountTendered,
            this.colChange,
            this.colDateTime});
            this.dgvOrderSummary.Location = new System.Drawing.Point(106, 269);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.Size = new System.Drawing.Size(593, 209);
            this.dgvOrderSummary.TabIndex = 55;
            // 
            // ColOrderNum
            // 
            this.ColOrderNum.HeaderText = "Order Number";
            this.ColOrderNum.Name = "ColOrderNum";
            // 
            // colOrderType
            // 
            this.colOrderType.HeaderText = "Order Type";
            this.colOrderType.Name = "colOrderType";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total Amount";
            this.colTotal.Name = "colTotal";
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount Deduct";
            this.colDiscount.Name = "colDiscount";
            // 
            // colFinalTotal
            // 
            this.colFinalTotal.HeaderText = "Final Total";
            this.colFinalTotal.Name = "colFinalTotal";
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.Name = "colPaymentMethod";
            // 
            // colAmountTendered
            // 
            this.colAmountTendered.HeaderText = "Amount Tendered";
            this.colAmountTendered.Name = "colAmountTendered";
            // 
            // colChange
            // 
            this.colChange.HeaderText = "Change";
            this.colChange.Name = "colChange";
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date&Time";
            this.colDateTime.Name = "colDateTime";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(102, 247);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(170, 19);
            this.lblOrderSummary.TabIndex = 54;
            this.lblOrderSummary.Text = "Order Summary Record: ";
            // 
            // lblDateTimeResult
            // 
            this.lblDateTimeResult.AutoSize = true;
            this.lblDateTimeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeResult.Location = new System.Drawing.Point(375, 213);
            this.lblDateTimeResult.Name = "lblDateTimeResult";
            this.lblDateTimeResult.Size = new System.Drawing.Size(106, 19);
            this.lblDateTimeResult.TabIndex = 53;
            this.lblDateTimeResult.Text = "Date and Time";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(255, 213);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(114, 19);
            this.lblDateTime.TabIndex = 52;
            this.lblDateTime.Text = "Date and Time: ";
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(373, 113);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(91, 19);
            this.lblOrderNumResult.TabIndex = 51;
            this.lblOrderNumResult.Text = "Order # here";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(255, 113);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(112, 19);
            this.lblOrderNum.TabIndex = 50;
            this.lblOrderNum.Text = "Order Number: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(387, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 34);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(232, 496);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(149, 34);
            this.btnNewOrder.TabIndex = 48;
            this.btnNewOrder.Text = "NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // lblSalesTransactionForm
            // 
            this.lblSalesTransactionForm.AutoSize = true;
            this.lblSalesTransactionForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTransactionForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesTransactionForm.Location = new System.Drawing.Point(120, 33);
            this.lblSalesTransactionForm.Name = "lblSalesTransactionForm";
            this.lblSalesTransactionForm.Size = new System.Drawing.Size(290, 31);
            this.lblSalesTransactionForm.TabIndex = 46;
            this.lblSalesTransactionForm.Text = "TRANSACTION RECORD";
            // 
            // picboxSalesTransactionForm
            // 
            this.picboxSalesTransactionForm.Image = global::WingBiteFinalProject.Properties.Resources.transac_removebg_preview;
            this.picboxSalesTransactionForm.Location = new System.Drawing.Point(12, 12);
            this.picboxSalesTransactionForm.Name = "picboxSalesTransactionForm";
            this.picboxSalesTransactionForm.Size = new System.Drawing.Size(102, 74);
            this.picboxSalesTransactionForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesTransactionForm.TabIndex = 47;
            this.picboxSalesTransactionForm.TabStop = false;
            // 
            // Transaction_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblChangeResult);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPaymentMethodUsed);
            this.Controls.Add(this.lblTotalAmountresult);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvOrderSummary);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblDateTimeResult);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblOrderNumResult);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.picboxSalesTransactionForm);
            this.Controls.Add(this.lblSalesTransactionForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Record";
            this.Text = "Transaction_Record";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesTransactionForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeResult;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethodUsed;
        private System.Windows.Forms.Label lblTotalAmountresult;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountTendered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblDateTimeResult;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblOrderNumResult;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.PictureBox picboxSalesTransactionForm;
        private System.Windows.Forms.Label lblSalesTransactionForm;
    }
}