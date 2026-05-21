namespace WingBiteFinalProject
{
    partial class Reports_Form
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.lblReportData = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblReportTitleResult = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnTopSelling = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.lblReportType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReportsForm = new System.Windows.Forms.Label();
            this.picboxReportsForm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReportsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Maroon;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(616, 453);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 30);
            this.btnView.TabIndex = 63;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(692, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 35);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvReportData
            // 
            this.dgvReportData.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(89, 262);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.Size = new System.Drawing.Size(599, 185);
            this.dgvReportData.TabIndex = 61;
            // 
            // lblReportData
            // 
            this.lblReportData.AutoSize = true;
            this.lblReportData.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportData.Location = new System.Drawing.Point(85, 241);
            this.lblReportData.Name = "lblReportData";
            this.lblReportData.Size = new System.Drawing.Size(83, 18);
            this.lblReportData.TabIndex = 60;
            this.lblReportData.Text = "Report Data:";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(455, 204);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 59;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(425, 208);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(24, 18);
            this.lblDateTo.TabIndex = 58;
            this.lblDateTo.Text = "To";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(174, 207);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(39, 18);
            this.lblDateFrom.TabIndex = 57;
            this.lblDateFrom.Text = "From";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(219, 205);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 56;
            // 
            // lblReportTitleResult
            // 
            this.lblReportTitleResult.AutoSize = true;
            this.lblReportTitleResult.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitleResult.Location = new System.Drawing.Point(174, 184);
            this.lblReportTitleResult.Name = "lblReportTitleResult";
            this.lblReportTitleResult.Size = new System.Drawing.Size(109, 18);
            this.lblReportTitleResult.TabIndex = 55;
            this.lblReportTitleResult.Text = "Report Title here";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(86, 184);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(82, 18);
            this.lblReportTitle.TabIndex = 54;
            this.lblReportTitle.Text = "Report Title:";
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.Location = new System.Drawing.Point(86, 207);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(81, 18);
            this.lblDateRange.TabIndex = 53;
            this.lblDateRange.Text = "Date Range:";
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.Location = new System.Drawing.Point(452, 125);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(115, 42);
            this.btnTransactionHistory.TabIndex = 52;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSelling.Location = new System.Drawing.Point(573, 125);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(115, 42);
            this.btnTopSelling.TabIndex = 51;
            this.btnTopSelling.Text = "Top Selling";
            this.btnTopSelling.UseVisualStyleBackColor = false;
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(210, 125);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(115, 42);
            this.btnWeekly.TabIndex = 50;
            this.btnWeekly.Text = "Weekly Summay";
            this.btnWeekly.UseVisualStyleBackColor = false;
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(331, 125);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(115, 42);
            this.btnMonthly.TabIndex = 49;
            this.btnMonthly.Text = "Monthly Summay";
            this.btnMonthly.UseVisualStyleBackColor = false;
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(89, 125);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(115, 42);
            this.btnDaily.TabIndex = 48;
            this.btnDaily.Text = "Daily Summay";
            this.btnDaily.UseVisualStyleBackColor = false;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(86, 101);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(85, 18);
            this.lblReportType.TabIndex = 47;
            this.lblReportType.Text = "Report Type:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblReportsForm
            // 
            this.lblReportsForm.AutoSize = true;
            this.lblReportsForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblReportsForm.Location = new System.Drawing.Point(120, 33);
            this.lblReportsForm.Name = "lblReportsForm";
            this.lblReportsForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportsForm.Size = new System.Drawing.Size(195, 31);
            this.lblReportsForm.TabIndex = 44;
            this.lblReportsForm.Text = "SALES REPORT";
            // 
            // picboxReportsForm
            // 
            this.picboxReportsForm.Image = global::WingBiteFinalProject.Properties.Resources.salesss_removebg_preview;
            this.picboxReportsForm.Location = new System.Drawing.Point(12, 12);
            this.picboxReportsForm.Name = "picboxReportsForm";
            this.picboxReportsForm.Size = new System.Drawing.Size(102, 74);
            this.picboxReportsForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxReportsForm.TabIndex = 45;
            this.picboxReportsForm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(281, 75);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "REPORTS FORM";
            // 
            // Reports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.lblReportData);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.lblReportTitleResult);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnTopSelling);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxReportsForm);
            this.Controls.Add(this.lblReportsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports_Form";
            this.Text = "Reports_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReportsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.Label lblReportData;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label lblReportTitleResult;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnTopSelling;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picboxReportsForm;
        private System.Windows.Forms.Label lblReportsForm;
        private System.Windows.Forms.Label label1;
    }
}