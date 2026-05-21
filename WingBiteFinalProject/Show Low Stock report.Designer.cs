namespace WingBiteFinalProject
{
    partial class Show_Low_Stock_report
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
            this.dgvLowStockReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLowStockReport = new System.Windows.Forms.Label();
            this.lblInventoryTracking = new System.Windows.Forms.Label();
            this.picboxInventoryTracking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLowStockReport
            // 
            this.dgvLowStockReport.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvLowStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStockReport.Location = new System.Drawing.Point(60, 134);
            this.dgvLowStockReport.Name = "dgvLowStockReport";
            this.dgvLowStockReport.RowHeadersWidth = 62;
            this.dgvLowStockReport.Size = new System.Drawing.Size(680, 284);
            this.dgvLowStockReport.TabIndex = 50;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblLowStockReport
            // 
            this.lblLowStockReport.AutoSize = true;
            this.lblLowStockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.lblLowStockReport.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblLowStockReport.Location = new System.Drawing.Point(58, 107);
            this.lblLowStockReport.Name = "lblLowStockReport";
            this.lblLowStockReport.Size = new System.Drawing.Size(217, 24);
            this.lblLowStockReport.TabIndex = 48;
            this.lblLowStockReport.Text = "LOW STOCK REPORT";
            // 
            // lblInventoryTracking
            // 
            this.lblInventoryTracking.AutoSize = true;
            this.lblInventoryTracking.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblInventoryTracking.Location = new System.Drawing.Point(120, 33);
            this.lblInventoryTracking.Name = "lblInventoryTracking";
            this.lblInventoryTracking.Size = new System.Drawing.Size(287, 31);
            this.lblInventoryTracking.TabIndex = 46;
            this.lblInventoryTracking.Text = "INVENTORY TRACKING";
            // 
            // picboxInventoryTracking
            // 
            this.picboxInventoryTracking.Image = global::WingBiteFinalProject.Properties.Resources.inventoryy_removebg_preview1;
            this.picboxInventoryTracking.Location = new System.Drawing.Point(12, 12);
            this.picboxInventoryTracking.Name = "picboxInventoryTracking";
            this.picboxInventoryTracking.Size = new System.Drawing.Size(102, 74);
            this.picboxInventoryTracking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxInventoryTracking.TabIndex = 47;
            this.picboxInventoryTracking.TabStop = false;
            // 
            // Show_Low_Stock_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.dgvLowStockReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLowStockReport);
            this.Controls.Add(this.picboxInventoryTracking);
            this.Controls.Add(this.lblInventoryTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Low_Stock_report";
            this.Text = "Show_Low_Stock_report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLowStockReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLowStockReport;
        private System.Windows.Forms.PictureBox picboxInventoryTracking;
        private System.Windows.Forms.Label lblInventoryTracking;
    }
}