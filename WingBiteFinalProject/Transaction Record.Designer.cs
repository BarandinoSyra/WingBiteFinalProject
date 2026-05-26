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
            this.lblChange.Location = new System.Drawing.Point(453, 289);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(84, 24);
            this.lblChange.TabIndex = 61;
            this.lblChange.Text = "Change:";
            // 
            // lblChangeResult
            // 
            this.lblChangeResult.AutoSize = true;
            this.lblChangeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeResult.Location = new System.Drawing.Point(560, 289);
            this.lblChangeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeResult.Name = "lblChangeResult";
            this.lblChangeResult.Size = new System.Drawing.Size(143, 24);
            this.lblChangeResult.TabIndex = 60;
            this.lblChangeResult.Text = "Change Result";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(358, 251);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(172, 24);
            this.lblPaymentMethod.TabIndex = 59;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentMethodUsed
            // 
            this.lblPaymentMethodUsed.AutoSize = true;
            this.lblPaymentMethodUsed.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethodUsed.Location = new System.Drawing.Point(560, 251);
            this.lblPaymentMethodUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethodUsed.Name = "lblPaymentMethodUsed";
            this.lblPaymentMethodUsed.Size = new System.Drawing.Size(219, 24);
            this.lblPaymentMethodUsed.TabIndex = 58;
            this.lblPaymentMethodUsed.Text = "Payment Method Used";
            // 
            // lblTotalAmountresult
            // 
            this.lblTotalAmountresult.AutoSize = true;
            this.lblTotalAmountresult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountresult.Location = new System.Drawing.Point(560, 212);
            this.lblTotalAmountresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountresult.Name = "lblTotalAmountresult";
            this.lblTotalAmountresult.Size = new System.Drawing.Size(217, 24);
            this.lblTotalAmountresult.TabIndex = 57;
            this.lblTotalAmountresult.Text = "Total Amount of order";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(388, 212);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(144, 24);
            this.lblTotalAmount.TabIndex = 56;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Location = new System.Drawing.Point(48, 409);
            this.dgvOrderSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersWidth = 62;
            this.dgvOrderSummary.Size = new System.Drawing.Size(1109, 322);
            this.dgvOrderSummary.TabIndex = 55;
            this.dgvOrderSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderSummary_CellContentClick);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(153, 380);
            this.lblOrderSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(238, 24);
            this.lblOrderSummary.TabIndex = 54;
            this.lblOrderSummary.Text = "Order Summary Record: ";
            // 
            // lblDateTimeResult
            // 
            this.lblDateTimeResult.AutoSize = true;
            this.lblDateTimeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeResult.Location = new System.Drawing.Point(562, 328);
            this.lblDateTimeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTimeResult.Name = "lblDateTimeResult";
            this.lblDateTimeResult.Size = new System.Drawing.Size(146, 24);
            this.lblDateTimeResult.TabIndex = 53;
            this.lblDateTimeResult.Text = "Date and Time";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(382, 328);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(156, 24);
            this.lblDateTime.TabIndex = 52;
            this.lblDateTime.Text = "Date and Time: ";
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(560, 174);
            this.lblOrderNumResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(127, 24);
            this.lblOrderNumResult.TabIndex = 51;
            this.lblOrderNumResult.Text = "Order # here";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(382, 174);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(157, 24);
            this.lblOrderNum.TabIndex = 50;
            this.lblOrderNum.Text = "Order Number: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(580, 763);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(226, 52);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(348, 763);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(224, 52);
            this.btnNewOrder.TabIndex = 48;
            this.btnNewOrder.Text = "NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // lblSalesTransactionForm
            // 
            this.lblSalesTransactionForm.AutoSize = true;
            this.lblSalesTransactionForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTransactionForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesTransactionForm.Location = new System.Drawing.Point(180, 51);
            this.lblSalesTransactionForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesTransactionForm.Name = "lblSalesTransactionForm";
            this.lblSalesTransactionForm.Size = new System.Drawing.Size(432, 46);
            this.lblSalesTransactionForm.TabIndex = 46;
            this.lblSalesTransactionForm.Text = "TRANSACTION RECORD";
            // 
            // picboxSalesTransactionForm
            // 
            this.picboxSalesTransactionForm.Image = global::WingBiteFinalProject.Properties.Resources.transac_removebg_preview;
            this.picboxSalesTransactionForm.Location = new System.Drawing.Point(18, 18);
            this.picboxSalesTransactionForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxSalesTransactionForm.Name = "picboxSalesTransactionForm";
            this.picboxSalesTransactionForm.Size = new System.Drawing.Size(153, 114);
            this.picboxSalesTransactionForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesTransactionForm.TabIndex = 47;
            this.picboxSalesTransactionForm.TabStop = false;
            // 
            // Transaction_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 846);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transaction_Record";
            this.Text = "Transaction_Record";
            this.Load += new System.EventHandler(this.Transaction_Record_Load);
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