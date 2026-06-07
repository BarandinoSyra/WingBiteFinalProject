namespace WingBiteFinalProject
{
    partial class PaymentForm
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
            this.lblSalesPaymentForm = new System.Windows.Forms.Label();
            this.picboxSalesPaymentForm = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.rbDiscount = new System.Windows.Forms.RadioButton();
            this.lblOrderNumResult = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblFinalTotalResult = new System.Windows.Forms.Label();
            this.lblChangeResult = new System.Windows.Forms.Label();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmountTendered = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnConfirmPay = new System.Windows.Forms.Button();
            this.btnCancelPay = new System.Windows.Forms.Button();
            this.lblTotalAmountResult = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesPaymentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesPaymentForm
            // 
            this.lblSalesPaymentForm.AutoSize = true;
            this.lblSalesPaymentForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPaymentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesPaymentForm.Location = new System.Drawing.Point(180, 51);
            this.lblSalesPaymentForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesPaymentForm.Name = "lblSalesPaymentForm";
            this.lblSalesPaymentForm.Size = new System.Drawing.Size(578, 46);
            this.lblSalesPaymentForm.TabIndex = 13;
            this.lblSalesPaymentForm.Text = "SALES ORDER - PAYMENT FORM";
            // 
            // picboxSalesPaymentForm
            // 
            this.picboxSalesPaymentForm.Image = global::WingBiteFinalProject.Properties.Resources.asdfdg_removebg_preview1;
            this.picboxSalesPaymentForm.Location = new System.Drawing.Point(18, 18);
            this.picboxSalesPaymentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxSalesPaymentForm.Name = "picboxSalesPaymentForm";
            this.picboxSalesPaymentForm.Size = new System.Drawing.Size(153, 114);
            this.picboxSalesPaymentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesPaymentForm.TabIndex = 14;
            this.picboxSalesPaymentForm.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Teal;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(585, 375);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(111, 40);
            this.btnEnter.TabIndex = 55;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(222, 246);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(99, 24);
            this.lblDiscount.TabIndex = 54;
            this.lblDiscount.Text = "Discount:";
            // 
            // rbDiscount
            // 
            this.rbDiscount.AutoSize = true;
            this.rbDiscount.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiscount.Location = new System.Drawing.Point(344, 243);
            this.rbDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDiscount.Name = "rbDiscount";
            this.rbDiscount.Size = new System.Drawing.Size(229, 26);
            this.rbDiscount.TabIndex = 53;
            this.rbDiscount.TabStop = true;
            this.rbDiscount.Text = "PWD/Senior (15% OFF)";
            this.rbDiscount.UseVisualStyleBackColor = true;
            this.rbDiscount.CheckedChanged += new System.EventHandler(this.rbDiscount_CheckedChanged);
            // 
            // lblOrderNumResult
            // 
            this.lblOrderNumResult.AutoSize = true;
            this.lblOrderNumResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumResult.Location = new System.Drawing.Point(302, 182);
            this.lblOrderNumResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumResult.Name = "lblOrderNumResult";
            this.lblOrderNumResult.Size = new System.Drawing.Size(185, 24);
            this.lblOrderNumResult.TabIndex = 52;
            this.lblOrderNumResult.Text = "Order # result here";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(214, 531);
            this.lblFinalTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(120, 24);
            this.lblFinalTotal.TabIndex = 51;
            this.lblFinalTotal.Text = "Final Total: ";
            // 
            // lblFinalTotalResult
            // 
            this.lblFinalTotalResult.AutoSize = true;
            this.lblFinalTotalResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotalResult.Location = new System.Drawing.Point(418, 531);
            this.lblFinalTotalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalTotalResult.Name = "lblFinalTotalResult";
            this.lblFinalTotalResult.Size = new System.Drawing.Size(174, 24);
            this.lblFinalTotalResult.TabIndex = 50;
            this.lblFinalTotalResult.Text = "Final Total Result";
            // 
            // lblChangeResult
            // 
            this.lblChangeResult.AutoSize = true;
            this.lblChangeResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeResult.Location = new System.Drawing.Point(418, 438);
            this.lblChangeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeResult.Name = "lblChangeResult";
            this.lblChangeResult.Size = new System.Drawing.Size(143, 24);
            this.lblChangeResult.TabIndex = 49;
            this.lblChangeResult.Text = "Change Result";
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Location = new System.Drawing.Point(424, 334);
            this.txtAmountTendered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(270, 26);
            this.txtAmountTendered.TabIndex = 48;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Gcash",
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(424, 288);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(270, 28);
            this.cmbPaymentMethod.TabIndex = 47;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(220, 291);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(177, 24);
            this.lblPaymentMethod.TabIndex = 46;
            this.lblPaymentMethod.Text = "Payment Method: ";
            // 
            // lblAmountTendered
            // 
            this.lblAmountTendered.AutoSize = true;
            this.lblAmountTendered.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTendered.Location = new System.Drawing.Point(214, 335);
            this.lblAmountTendered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountTendered.Name = "lblAmountTendered";
            this.lblAmountTendered.Size = new System.Drawing.Size(188, 24);
            this.lblAmountTendered.TabIndex = 45;
            this.lblAmountTendered.Text = "Amount Tendered: ";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(214, 438);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(89, 24);
            this.lblChange.TabIndex = 44;
            this.lblChange.Text = "Change: ";
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPay.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPay.Location = new System.Drawing.Point(648, 612);
            this.btnConfirmPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.Size = new System.Drawing.Size(266, 54);
            this.btnConfirmPay.TabIndex = 43;
            this.btnConfirmPay.Text = "CONFIRM PAYMENT";
            this.btnConfirmPay.UseVisualStyleBackColor = false;
            this.btnConfirmPay.Click += new System.EventHandler(this.btnConfirmPay_Click);
            // 
            // btnCancelPay
            // 
            this.btnCancelPay.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPay.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPay.Location = new System.Drawing.Point(340, 612);
            this.btnCancelPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelPay.Name = "btnCancelPay";
            this.btnCancelPay.Size = new System.Drawing.Size(266, 54);
            this.btnCancelPay.TabIndex = 42;
            this.btnCancelPay.Text = "CANCEL PAYMENT";
            this.btnCancelPay.UseVisualStyleBackColor = false;
            this.btnCancelPay.Click += new System.EventHandler(this.btnCancelPay_Click);
            // 
            // lblTotalAmountResult
            // 
            this.lblTotalAmountResult.AutoSize = true;
            this.lblTotalAmountResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountResult.Location = new System.Drawing.Point(746, 182);
            this.lblTotalAmountResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountResult.Name = "lblTotalAmountResult";
            this.lblTotalAmountResult.Size = new System.Drawing.Size(223, 24);
            this.lblTotalAmountResult.TabIndex = 41;
            this.lblTotalAmountResult.Text = "Total Amount of Order";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(582, 182);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(149, 24);
            this.lblTotalAmount.TabIndex = 40;
            this.lblTotalAmount.Text = "Total Amount: ";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(214, 182);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(92, 24);
            this.lblOrderNum.TabIndex = 39;
            this.lblOrderNum.Text = "Order #: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(18, 774);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 846);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.rbDiscount);
            this.Controls.Add(this.lblOrderNumResult);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblFinalTotalResult);
            this.Controls.Add(this.lblChangeResult);
            this.Controls.Add(this.txtAmountTendered);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnConfirmPay);
            this.Controls.Add(this.btnCancelPay);
            this.Controls.Add(this.lblTotalAmountResult);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.picboxSalesPaymentForm);
            this.Controls.Add(this.lblSalesPaymentForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesPaymentForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSalesPaymentForm;
        private System.Windows.Forms.Label lblSalesPaymentForm;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.RadioButton rbDiscount;
        private System.Windows.Forms.Label lblOrderNumResult;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblFinalTotalResult;
        private System.Windows.Forms.Label lblChangeResult;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmountTendered;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnConfirmPay;
        private System.Windows.Forms.Button btnCancelPay;
        private System.Windows.Forms.Label lblTotalAmountResult;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Button btnBack;
    }
}