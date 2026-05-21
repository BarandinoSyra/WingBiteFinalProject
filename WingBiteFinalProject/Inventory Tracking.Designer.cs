namespace WingBiteFinalProject
{
    partial class Inventory_Tracking
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtAdjustProduct = new System.Windows.Forms.TextBox();
            this.txtCurentStock = new System.Windows.Forms.TextBox();
            this.lblProductNameHere = new System.Windows.Forms.Label();
            this.lblAdjustProduct = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.btnLowStockReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInventoryTracking = new System.Windows.Forms.Label();
            this.picboxInventoryTracking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Teal;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(329, 460);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(157, 31);
            this.btnAddProduct.TabIndex = 64;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStock.Location = new System.Drawing.Point(496, 412);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(109, 30);
            this.btnUpdateStock.TabIndex = 63;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            // 
            // txtAdjustProduct
            // 
            this.txtAdjustProduct.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustProduct.Location = new System.Drawing.Point(335, 421);
            this.txtAdjustProduct.Name = "txtAdjustProduct";
            this.txtAdjustProduct.Size = new System.Drawing.Size(141, 21);
            this.txtAdjustProduct.TabIndex = 62;
            // 
            // txtCurentStock
            // 
            this.txtCurentStock.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurentStock.Location = new System.Drawing.Point(335, 395);
            this.txtCurentStock.Name = "txtCurentStock";
            this.txtCurentStock.Size = new System.Drawing.Size(141, 21);
            this.txtCurentStock.TabIndex = 61;
            // 
            // lblProductNameHere
            // 
            this.lblProductNameHere.AutoSize = true;
            this.lblProductNameHere.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameHere.Location = new System.Drawing.Point(332, 370);
            this.lblProductNameHere.Name = "lblProductNameHere";
            this.lblProductNameHere.Size = new System.Drawing.Size(97, 18);
            this.lblProductNameHere.TabIndex = 60;
            this.lblProductNameHere.Text = "Product Name:";
            // 
            // lblAdjustProduct
            // 
            this.lblAdjustProduct.AutoSize = true;
            this.lblAdjustProduct.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjustProduct.Location = new System.Drawing.Point(202, 424);
            this.lblAdjustProduct.Name = "lblAdjustProduct";
            this.lblAdjustProduct.Size = new System.Drawing.Size(87, 18);
            this.lblAdjustProduct.TabIndex = 59;
            this.lblAdjustProduct.Text = "Adjust Stock:";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.Location = new System.Drawing.Point(202, 397);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(93, 18);
            this.lblCurrentStock.TabIndex = 58;
            this.lblCurrentStock.Text = "Current Stock:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(202, 370);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(97, 18);
            this.lblProductName.TabIndex = 57;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUpdateStock.Location = new System.Drawing.Point(202, 344);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(114, 18);
            this.lblUpdateStock.TabIndex = 56;
            this.lblUpdateStock.Text = "UPDATE STOCK";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(69, 159);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.Size = new System.Drawing.Size(680, 175);
            this.dgvInventory.TabIndex = 55;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblProductStock.Location = new System.Drawing.Point(66, 138);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(128, 18);
            this.lblProductStock.TabIndex = 54;
            this.lblProductStock.Text = "PRODUCT STOCK:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(592, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(157, 31);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(127, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 24);
            this.txtSearch.TabIndex = 52;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(66, 108);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 18);
            this.lblSearch.TabIndex = 51;
            this.lblSearch.Text = "Search: ";
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAll.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAll.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshAll.Location = new System.Drawing.Point(166, 460);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(157, 31);
            this.btnRefreshAll.TabIndex = 50;
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = false;
            // 
            // btnLowStockReport
            // 
            this.btnLowStockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLowStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStockReport.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowStockReport.ForeColor = System.Drawing.Color.Black;
            this.btnLowStockReport.Location = new System.Drawing.Point(492, 460);
            this.btnLowStockReport.Name = "btnLowStockReport";
            this.btnLowStockReport.Size = new System.Drawing.Size(157, 31);
            this.btnLowStockReport.TabIndex = 49;
            this.btnLowStockReport.Text = "Low Stock Report";
            this.btnLowStockReport.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(17, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
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
            this.picboxInventoryTracking.Image = global::WingBiteFinalProject.Properties.Resources.inventoryy_removebg_preview;
            this.picboxInventoryTracking.Location = new System.Drawing.Point(12, 12);
            this.picboxInventoryTracking.Name = "picboxInventoryTracking";
            this.picboxInventoryTracking.Size = new System.Drawing.Size(102, 74);
            this.picboxInventoryTracking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxInventoryTracking.TabIndex = 47;
            this.picboxInventoryTracking.TabStop = false;
            // 
            // Inventory_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.txtAdjustProduct);
            this.Controls.Add(this.txtCurentStock);
            this.Controls.Add(this.lblProductNameHere);
            this.Controls.Add(this.lblAdjustProduct);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.btnLowStockReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picboxInventoryTracking);
            this.Controls.Add(this.lblInventoryTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Tracking";
            this.Text = "Inventory_Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInventoryTracking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtAdjustProduct;
        private System.Windows.Forms.TextBox txtCurentStock;
        private System.Windows.Forms.Label lblProductNameHere;
        private System.Windows.Forms.Label lblAdjustProduct;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.Button btnLowStockReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picboxInventoryTracking;
        private System.Windows.Forms.Label lblInventoryTracking;
    }
}