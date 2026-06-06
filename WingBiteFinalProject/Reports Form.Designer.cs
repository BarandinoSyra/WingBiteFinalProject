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
            this.btnView.Location = new System.Drawing.Point(924, 698);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 46);
            this.btnView.TabIndex = 63;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1038, 774);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 54);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvReportData
            // 
            this.dgvReportData.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(134, 402);
            this.dgvReportData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.RowHeadersWidth = 51;
            this.dgvReportData.Size = new System.Drawing.Size(899, 285);
            this.dgvReportData.TabIndex = 61;
            this.dgvReportData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportData_CellContentClick);
            // 
            // lblReportData
            // 
            this.lblReportData.AutoSize = true;
            this.lblReportData.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportData.Location = new System.Drawing.Point(127, 371);
            this.lblReportData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportData.Name = "lblReportData";
            this.lblReportData.Size = new System.Drawing.Size(126, 24);
            this.lblReportData.TabIndex = 60;
            this.lblReportData.Text = "Report Data:";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(683, 314);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(298, 26);
            this.dateTimeTo.TabIndex = 59;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(638, 320);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(34, 24);
            this.lblDateTo.TabIndex = 58;
            this.lblDateTo.Text = "To";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(261, 319);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(58, 24);
            this.lblDateFrom.TabIndex = 57;
            this.lblDateFrom.Text = "From";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(328, 315);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(298, 26);
            this.dateTimeFrom.TabIndex = 56;
            // 
            // lblReportTitleResult
            // 
            this.lblReportTitleResult.AutoSize = true;
            this.lblReportTitleResult.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitleResult.Location = new System.Drawing.Point(261, 282);
            this.lblReportTitleResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTitleResult.Name = "lblReportTitleResult";
            this.lblReportTitleResult.Size = new System.Drawing.Size(166, 24);
            this.lblReportTitleResult.TabIndex = 55;
            this.lblReportTitleResult.Text = "Report Title here";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(129, 282);
            this.lblReportTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(126, 24);
            this.lblReportTitle.TabIndex = 54;
            this.lblReportTitle.Text = "Report Title:";
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.Location = new System.Drawing.Point(129, 319);
            this.lblDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(121, 24);
            this.lblDateRange.TabIndex = 53;
            this.lblDateRange.Text = "Date Range:";
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.Location = new System.Drawing.Point(678, 192);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(172, 65);
            this.btnTransactionHistory.TabIndex = 52;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSelling.Location = new System.Drawing.Point(860, 192);
            this.btnTopSelling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(172, 65);
            this.btnTopSelling.TabIndex = 51;
            this.btnTopSelling.Text = "Top Selling";
            this.btnTopSelling.UseVisualStyleBackColor = false;
            this.btnTopSelling.Click += new System.EventHandler(this.btnTopSelling_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(315, 192);
            this.btnWeekly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(172, 65);
            this.btnWeekly.TabIndex = 50;
            this.btnWeekly.Text = "Weekly Summay";
            this.btnWeekly.UseVisualStyleBackColor = false;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(496, 192);
            this.btnMonthly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(172, 65);
            this.btnMonthly.TabIndex = 49;
            this.btnMonthly.Text = "Monthly Summay";
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(134, 192);
            this.btnDaily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(172, 65);
            this.btnDaily.TabIndex = 48;
            this.btnDaily.Text = "Daily Summay";
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(129, 155);
            this.lblReportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(128, 24);
            this.lblReportType.TabIndex = 47;
            this.lblReportType.Text = "Report Type:";
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
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReportsForm
            // 
            this.lblReportsForm.AutoSize = true;
            this.lblReportsForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblReportsForm.Location = new System.Drawing.Point(180, 51);
            this.lblReportsForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportsForm.Name = "lblReportsForm";
            this.lblReportsForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportsForm.Size = new System.Drawing.Size(285, 46);
            this.lblReportsForm.TabIndex = 44;
            this.lblReportsForm.Text = "SALES REPORT";
            // 
            // picboxReportsForm
            // 
            this.picboxReportsForm.Image = global::WingBiteFinalProject.Properties.Resources.salesss_removebg_preview;
            this.picboxReportsForm.Location = new System.Drawing.Point(18, 19);
            this.picboxReportsForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxReportsForm.Name = "picboxReportsForm";
            this.picboxReportsForm.Size = new System.Drawing.Size(153, 114);
            this.picboxReportsForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxReportsForm.TabIndex = 45;
            this.picboxReportsForm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(422, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 64;
            this.label1.Text = "REPORTS FORM";
            // 
            // Reports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 846);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports_Form";
            this.Text = "Reports_Form";
            this.Load += new System.EventHandler(this.Reports_Form_Load);
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