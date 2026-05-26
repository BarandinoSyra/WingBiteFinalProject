namespace WingBiteFinalProject
{
    partial class Edit_Product_Search
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnFindID = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this.lblMenuProductManagement = new System.Windows.Forms.Label();
            this.picboxMenuProductManagement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(702, 515);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 45);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "EDIT";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(64, 275);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.Size = new System.Drawing.Size(782, 231);
            this.dgvProducts.TabIndex = 67;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(246, 217);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(290, 37);
            this.txtProductName.TabIndex = 66;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.lblProductID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(58, 226);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(175, 28);
            this.lblProductID.TabIndex = 65;
            this.lblProductID.Text = "Product Name:";
            // 
            // btnFindID
            // 
            this.btnFindID.BackColor = System.Drawing.Color.Green;
            this.btnFindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindID.ForeColor = System.Drawing.Color.White;
            this.btnFindID.Location = new System.Drawing.Point(549, 215);
            this.btnFindID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(120, 39);
            this.btnFindID.TabIndex = 64;
            this.btnFindID.Text = "Find Name";
            this.btnFindID.UseVisualStyleBackColor = false;
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(22, 595);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 54);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.lblUpdateProduct.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUpdateProduct.Location = new System.Drawing.Point(335, 153);
            this.lblUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(271, 39);
            this.lblUpdateProduct.TabIndex = 62;
            this.lblUpdateProduct.Text = "EDIT PRODUCT";
            // 
            // lblMenuProductManagement
            // 
            this.lblMenuProductManagement.AutoSize = true;
            this.lblMenuProductManagement.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProductManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblMenuProductManagement.Location = new System.Drawing.Point(272, 57);
            this.lblMenuProductManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuProductManagement.Name = "lblMenuProductManagement";
            this.lblMenuProductManagement.Size = new System.Drawing.Size(569, 46);
            this.lblMenuProductManagement.TabIndex = 60;
            this.lblMenuProductManagement.Text = "MENU/PRODUCT MANAGEMENT";
            // 
            // picboxMenuProductManagement
            // 
            this.picboxMenuProductManagement.Image = global::WingBiteFinalProject.Properties.Resources.kitchen_que_removebg_preview2;
            this.picboxMenuProductManagement.Location = new System.Drawing.Point(110, 18);
            this.picboxMenuProductManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxMenuProductManagement.Name = "picboxMenuProductManagement";
            this.picboxMenuProductManagement.Size = new System.Drawing.Size(153, 122);
            this.picboxMenuProductManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenuProductManagement.TabIndex = 61;
            this.picboxMenuProductManagement.TabStop = false;
            // 
            // Edit_Product_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(951, 668);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnFindID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUpdateProduct);
            this.Controls.Add(this.picboxMenuProductManagement);
            this.Controls.Add(this.lblMenuProductManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit_Product_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Products";
            this.Load += new System.EventHandler(this.Edit_Product_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenuProductManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnFindID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.PictureBox picboxMenuProductManagement;
        private System.Windows.Forms.Label lblMenuProductManagement;
    }
}