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
            this.btnServing.Location = new System.Drawing.Point(343, 441);
            this.btnServing.Name = "btnServing";
            this.btnServing.Size = new System.Drawing.Size(119, 48);
            this.btnServing.TabIndex = 49;
            this.btnServing.Text = "MARK AS SERVING";
            this.btnServing.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Green;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(468, 441);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(119, 48);
            this.btnCompleted.TabIndex = 48;
            this.btnCompleted.Text = "MARK AS COMPLETED";
            this.btnCompleted.UseVisualStyleBackColor = false;
            // 
            // btnPreparing
            // 
            this.btnPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPreparing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparing.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparing.Location = new System.Drawing.Point(220, 441);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(117, 48);
            this.btnPreparing.TabIndex = 47;
            this.btnPreparing.Text = "MARK AS PREPARING";
            this.btnPreparing.UseVisualStyleBackColor = false;
            // 
            // dgvReadyToServe
            // 
            this.dgvReadyToServe.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReadyToServe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadyToServe.Location = new System.Drawing.Point(531, 144);
            this.dgvReadyToServe.Name = "dgvReadyToServe";
            this.dgvReadyToServe.Size = new System.Drawing.Size(240, 278);
            this.dgvReadyToServe.TabIndex = 46;
            // 
            // dgvPreparingOrders
            // 
            this.dgvPreparingOrders.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvPreparingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreparingOrders.Location = new System.Drawing.Point(285, 144);
            this.dgvPreparingOrders.Name = "dgvPreparingOrders";
            this.dgvPreparingOrders.Size = new System.Drawing.Size(240, 278);
            this.dgvPreparingOrders.TabIndex = 45;
            // 
            // lblPreparingOrders
            // 
            this.lblPreparingOrders.AutoSize = true;
            this.lblPreparingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparingOrders.Location = new System.Drawing.Point(281, 122);
            this.lblPreparingOrders.Name = "lblPreparingOrders";
            this.lblPreparingOrders.Size = new System.Drawing.Size(128, 19);
            this.lblPreparingOrders.TabIndex = 44;
            this.lblPreparingOrders.Text = "Preparing Orders: ";
            // 
            // lblReadyToServe
            // 
            this.lblReadyToServe.AutoSize = true;
            this.lblReadyToServe.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToServe.Location = new System.Drawing.Point(527, 122);
            this.lblReadyToServe.Name = "lblReadyToServe";
            this.lblReadyToServe.Size = new System.Drawing.Size(115, 19);
            this.lblReadyToServe.TabIndex = 43;
            this.lblReadyToServe.Text = "Ready to Serve: ";
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(35, 122);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(121, 19);
            this.lblPendingOrders.TabIndex = 42;
            this.lblPendingOrders.Text = "Pending Orders: ";
            // 
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Location = new System.Drawing.Point(39, 144);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.Size = new System.Drawing.Size(240, 278);
            this.dgvPendingOrders.TabIndex = 41;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 498);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblKitchenQueue
            // 
            this.lblKitchenQueue.AutoSize = true;
            this.lblKitchenQueue.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblKitchenQueue.Location = new System.Drawing.Point(120, 33);
            this.lblKitchenQueue.Name = "lblKitchenQueue";
            this.lblKitchenQueue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenQueue.Size = new System.Drawing.Size(243, 31);
            this.lblKitchenQueue.TabIndex = 38;
            this.lblKitchenQueue.Text = "KITCHEN PROCESS";
            // 
            // picboxKitchenQueue
            // 
            this.picboxKitchenQueue.Image = global::WingBiteFinalProject.Properties.Resources.kitsen_removebg_preview;
            this.picboxKitchenQueue.Location = new System.Drawing.Point(12, 12);
            this.picboxKitchenQueue.Name = "picboxKitchenQueue";
            this.picboxKitchenQueue.Size = new System.Drawing.Size(102, 74);
            this.picboxKitchenQueue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxKitchenQueue.TabIndex = 39;
            this.picboxKitchenQueue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(224, 77);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "KITCHEN QUEUE DISPLAY";
            // 
            // Kitchen_Queue_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
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
    }
}