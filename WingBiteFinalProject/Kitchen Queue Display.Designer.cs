namespace WingBiteFinalProject
{
    partial class Kitchen_Queue_Display
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
            this.btnServing = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnPreparing = new System.Windows.Forms.Button();
            this.dgvReadyToServe = new System.Windows.Forms.DataGridView();
            this.dgvPreparingOrders = new System.Windows.Forms.DataGridView();
            this.lblPreparingOrders = new System.Windows.Forms.Label();
            this.lblReadyToServe = new System.Windows.Forms.Label();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.dgvPendingOrders = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblKitchenQueue = new System.Windows.Forms.Label();
            this.picboxKitchenQueue = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyToServe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServing
            // 
            this.btnServing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnServing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServing.Location = new System.Drawing.Point(514, 679);
            this.btnServing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServing.Name = "btnServing";
            this.btnServing.Size = new System.Drawing.Size(179, 74);
            this.btnServing.TabIndex = 49;
            this.btnServing.Text = "MARK AS SERVING";
            this.btnServing.UseVisualStyleBackColor = false;
            this.btnServing.Click += new System.EventHandler(this.btnServing_Click_1);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Green;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(702, 679);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(179, 74);
            this.btnCompleted.TabIndex = 48;
            this.btnCompleted.Text = "MARK AS COMPLETED";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnPreparing
            // 
            this.btnPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparing.Location = new System.Drawing.Point(330, 679);
            this.btnPreparing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(176, 74);
            this.btnPreparing.TabIndex = 47;
            this.btnPreparing.Text = "MARK AS PREPARING";
            this.btnPreparing.UseVisualStyleBackColor = false;
            this.btnPreparing.Click += new System.EventHandler(this.btnPreparing_Click);
            // 
            // dgvReadyToServe
            // 
            this.dgvReadyToServe.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReadyToServe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadyToServe.Location = new System.Drawing.Point(796, 221);
            this.dgvReadyToServe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReadyToServe.Name = "dgvReadyToServe";
            this.dgvReadyToServe.ReadOnly = true;
            this.dgvReadyToServe.RowHeadersWidth = 51;
            this.dgvReadyToServe.Size = new System.Drawing.Size(400, 428);
            this.dgvReadyToServe.TabIndex = 46;
            // 
            // dgvPreparingOrders
            // 
            this.dgvPreparingOrders.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvPreparingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreparingOrders.Location = new System.Drawing.Point(426, 221);
            this.dgvPreparingOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPreparingOrders.Name = "dgvPreparingOrders";
            this.dgvPreparingOrders.ReadOnly = true;
            this.dgvPreparingOrders.RowHeadersWidth = 51;
            this.dgvPreparingOrders.Size = new System.Drawing.Size(362, 428);
            this.dgvPreparingOrders.TabIndex = 45;
            // 
            // lblPreparingOrders
            // 
            this.lblPreparingOrders.AutoSize = true;
            this.lblPreparingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparingOrders.Location = new System.Drawing.Point(422, 188);
            this.lblPreparingOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreparingOrders.Name = "lblPreparingOrders";
            this.lblPreparingOrders.Size = new System.Drawing.Size(179, 24);
            this.lblPreparingOrders.TabIndex = 44;
            this.lblPreparingOrders.Text = "Preparing Orders: ";
            // 
            // lblReadyToServe
            // 
            this.lblReadyToServe.AutoSize = true;
            this.lblReadyToServe.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToServe.Location = new System.Drawing.Point(791, 188);
            this.lblReadyToServe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadyToServe.Name = "lblReadyToServe";
            this.lblReadyToServe.Size = new System.Drawing.Size(156, 24);
            this.lblReadyToServe.TabIndex = 43;
            this.lblReadyToServe.Text = "Ready to Serve: ";
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(53, 188);
            this.lblPendingOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(165, 24);
            this.lblPendingOrders.TabIndex = 42;
            this.lblPendingOrders.Text = "Pending Orders: ";
            // 
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Location = new System.Drawing.Point(5, 221);
            this.dgvPendingOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.ReadOnly = true;
            this.dgvPendingOrders.RowHeadersWidth = 51;
            this.dgvPendingOrders.Size = new System.Drawing.Size(413, 428);
            this.dgvPendingOrders.TabIndex = 41;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 778);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblKitchenQueue
            // 
            this.lblKitchenQueue.AutoSize = true;
            this.lblKitchenQueue.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblKitchenQueue.Location = new System.Drawing.Point(180, 51);
            this.lblKitchenQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitchenQueue.Name = "lblKitchenQueue";
            this.lblKitchenQueue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenQueue.Size = new System.Drawing.Size(356, 46);
            this.lblKitchenQueue.TabIndex = 38;
            this.lblKitchenQueue.Text = "KITCHEN PROCESS";
            // 
            // picboxKitchenQueue
            // 
            this.picboxKitchenQueue.Image = global::WingBiteFinalProject.Properties.Resources.kitsen_removebg_preview;
            this.picboxKitchenQueue.Location = new System.Drawing.Point(18, 19);
            this.picboxKitchenQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxKitchenQueue.Name = "picboxKitchenQueue";
            this.picboxKitchenQueue.Size = new System.Drawing.Size(153, 114);
            this.picboxKitchenQueue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxKitchenQueue.TabIndex = 39;
            this.picboxKitchenQueue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(336, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(477, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "KITCHEN QUEUE DISPLAY";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.YellowGreen;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(1015, 778);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(172, 54);
            this.btnViewDetails.TabIndex = 51;
            this.btnViewDetails.Text = "VIEW DETAILS";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // Kitchen_Queue_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 961);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServing);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnPreparing);
            this.Controls.Add(this.dgvReadyToServe);
            this.Controls.Add(this.dgvPreparingOrders);
            this.Controls.Add(this.lblPreparingOrders);
            this.Controls.Add(this.lblReadyToServe);
            this.Controls.Add(this.lblPendingOrders);
            this.Controls.Add(this.dgvPendingOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxKitchenQueue);
            this.Controls.Add(this.lblKitchenQueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kitchen_Queue_Display";
            this.Text = "Kitchen_Queue_Display";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyToServe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKitchenQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServing;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnPreparing;
        private System.Windows.Forms.DataGridView dgvReadyToServe;
        private System.Windows.Forms.DataGridView dgvPreparingOrders;
        private System.Windows.Forms.Label lblPreparingOrders;
        private System.Windows.Forms.Label lblReadyToServe;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.DataGridView dgvPendingOrders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picboxKitchenQueue;
        private System.Windows.Forms.Label lblKitchenQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDetails;
    }
}