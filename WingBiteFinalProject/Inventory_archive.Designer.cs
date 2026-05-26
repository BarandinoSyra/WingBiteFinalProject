namespace WingBiteFinalProject
{
    partial class Inventory_archive
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMenuProductManagement = new System.Windows.Forms.Label();
            this.picboxMenuProductManagement = new System.Windows.Forms.PictureBox();
            this.dgvarchive = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDeletePermanent = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndisplay1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(848, 529);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 54);
            this.btnSubmit.TabIndex = 75;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 529);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblMenuProductManagement
            // 
            this.lblMenuProductManagement.AutoSize = true;
            this.lblMenuProductManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProductManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblMenuProductManagement.Location = new System.Drawing.Point(170, 53);
            this.lblMenuProductManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuProductManagement.Name = "lblMenuProductManagement";
            this.lblMenuProductManagement.Size = new System.Drawing.Size(401, 46);
            this.lblMenuProductManagement.TabIndex = 64;
            this.lblMenuProductManagement.Text = "INVENTORY ARCHIVE";
            // 
            // picboxMenuProductManagement
            // 
            this.picboxMenuProductManagement.Image = global::WingBiteFinalProject.Properties.Resources.kitchen_que_removebg_preview1;
            this.picboxMenuProductManagement.Location = new System.Drawing.Point(13, 14);
            this.picboxMenuProductManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxMenuProductManagement.Name = "picboxMenuProductManagement";
            this.picboxMenuProductManagement.Size = new System.Drawing.Size(153, 122);
            this.picboxMenuProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenuProductManagement.TabIndex = 65;
            this.picboxMenuProductManagement.TabStop = false;
            // 
            // dgvarchive
            // 
            this.dgvarchive.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvarchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarchive.Location = new System.Drawing.Point(38, 161);
            this.dgvarchive.Name = "dgvarchive";
            this.dgvarchive.ReadOnly = true;
            this.dgvarchive.RowHeadersWidth = 62;
            this.dgvarchive.RowTemplate.Height = 28;
            this.dgvarchive.Size = new System.Drawing.Size(911, 277);
            this.dgvarchive.TabIndex = 76;
            this.dgvarchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarchive_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(249, 456);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(231, 55);
            this.btnDisplay.TabIndex = 77;
            this.btnDisplay.Text = "Display Product";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click_1);
            // 
            // btnDeletePermanent
            // 
            this.btnDeletePermanent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletePermanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePermanent.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePermanent.Location = new System.Drawing.Point(498, 456);
            this.btnDeletePermanent.Name = "btnDeletePermanent";
            this.btnDeletePermanent.Size = new System.Drawing.Size(231, 55);
            this.btnDeletePermanent.TabIndex = 78;
            this.btnDeletePermanent.Text = "Delete Product";
            this.btnDeletePermanent.UseVisualStyleBackColor = false;
            this.btnDeletePermanent.Click += new System.EventHandler(this.btnDeletePermanent_Click_1);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.LightGreen;
            this.panelDisplay.Controls.Add(this.groupBox1);
            this.panelDisplay.Location = new System.Drawing.Point(249, 102);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(461, 305);
            this.panelDisplay.TabIndex = 79;
            this.panelDisplay.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndisplay1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.lblInventoryID);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 251);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT DISPLAY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "InventoryID:";
            // 
            // btndisplay1
            // 
            this.btndisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplay1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay1.Location = new System.Drawing.Point(132, 187);
            this.btndisplay1.Name = "btndisplay1";
            this.btndisplay1.Size = new System.Drawing.Size(154, 46);
            this.btndisplay1.TabIndex = 10;
            this.btndisplay1.Text = "Display";
            this.btndisplay1.UseVisualStyleBackColor = false;
            this.btndisplay1.Click += new System.EventHandler(this.btndisplay1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Update Stock:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(227, 135);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(148, 36);
            this.txtStock.TabIndex = 9;
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryID.Location = new System.Drawing.Point(222, 48);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(79, 28);
            this.lblInventoryID.TabIndex = 5;
            this.lblInventoryID.Text = "label6";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(222, 91);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 28);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "label6";
            // 
            // Inventory_archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1005, 597);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.btnDeletePermanent);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dgvarchive);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxMenuProductManagement);
            this.Controls.Add(this.lblMenuProductManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_archive";
            this.Text = "Products_Archieves";
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picboxMenuProductManagement;
        private System.Windows.Forms.Label lblMenuProductManagement;
        private System.Windows.Forms.DataGridView dgvarchive;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDeletePermanent;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Button btndisplay1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}