namespace WingBiteFinalProject
{
    partial class Main_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.lblOrdersToday = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.lblTodaysSales = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.lblSalesManagement = new System.Windows.Forms.Label();
            this.lblWingsandRice = new System.Windows.Forms.Label();
            this.lbl1POS = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.panelDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.panelDashboard.Controls.Add(this.label1);
            this.panelDashboard.Controls.Add(this.lblRecentOrders);
            this.panelDashboard.Controls.Add(this.panel2);
            this.panelDashboard.Controls.Add(this.dgvRecentOrders);
            this.panelDashboard.Controls.Add(this.panel1);
            this.panelDashboard.Location = new System.Drawing.Point(309, 160);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(757, 517);
            this.panelDashboard.TabIndex = 3;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 12;
            this.label1.Tag = "";
            this.label1.Text = "WELCOME, ADMIN";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(30, 206);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(155, 22);
            this.lblRecentOrders.TabIndex = 21;
            this.lblRecentOrders.Text = "RECENT ORDERS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblOrdersValue);
            this.panel2.Controls.Add(this.lblOrdersToday);
            this.panel2.Location = new System.Drawing.Point(393, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 126);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "items below threshold";
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.AutoSize = true;
            this.lblOrdersValue.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersValue.ForeColor = System.Drawing.Color.Crimson;
            this.lblOrdersValue.Location = new System.Drawing.Point(25, 50);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(29, 35);
            this.lblOrdersValue.TabIndex = 2;
            this.lblOrdersValue.Text = "0";
            // 
            // lblOrdersToday
            // 
            this.lblOrdersToday.AutoSize = true;
            this.lblOrdersToday.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersToday.Location = new System.Drawing.Point(28, 21);
            this.lblOrdersToday.Name = "lblOrdersToday";
            this.lblOrdersToday.Size = new System.Drawing.Size(175, 22);
            this.lblOrdersToday.TabIndex = 1;
            this.lblOrdersToday.Text = "LOW STOCK ALERT";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Location = new System.Drawing.Point(35, 233);
            this.dgvRecentOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.RowHeadersWidth = 51;
            this.dgvRecentOrders.RowTemplate.Height = 24;
            this.dgvRecentOrders.Size = new System.Drawing.Size(691, 238);
            this.dgvRecentOrders.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSalesPrice);
            this.panel1.Controls.Add(this.lblTodaysSales);
            this.panel1.Location = new System.Drawing.Point(35, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 126);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "total sales today";
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPrice.Location = new System.Drawing.Point(21, 50);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(84, 35);
            this.lblSalesPrice.TabIndex = 2;
            this.lblSalesPrice.Text = "₱0.00";
            // 
            // lblTodaysSales
            // 
            this.lblTodaysSales.AutoSize = true;
            this.lblTodaysSales.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysSales.Location = new System.Drawing.Point(23, 21);
            this.lblTodaysSales.Name = "lblTodaysSales";
            this.lblTodaysSales.Size = new System.Drawing.Size(235, 22);
            this.lblTodaysSales.TabIndex = 1;
            this.lblTodaysSales.Text = "DAILY REPORT SUMMARY";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.panelSidebar.Controls.Add(this.btnLogOut);
            this.panelSidebar.Controls.Add(this.btnSales);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnInventory);
            this.panelSidebar.Controls.Add(this.btnUser);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnKitchen);
            this.panelSidebar.Location = new System.Drawing.Point(-2, 160);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(312, 517);
            this.panelSidebar.TabIndex = 22;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(41, 320);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(229, 41);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(41, 32);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(229, 41);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "SALES ORDER";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(41, 80);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(229, 41);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "MENU/PRODUCT";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(41, 128);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(229, 41);
            this.btnInventory.TabIndex = 4;
            this.btnInventory.Text = "INVETORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(41, 272);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(229, 41);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "MANAGE USER";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(41, 224);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(229, 41);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = " SALES REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(41, 176);
            this.btnKitchen.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(229, 41);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "KITCHEN";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // lblSalesManagement
            // 
            this.lblSalesManagement.AutoSize = true;
            this.lblSalesManagement.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesManagement.Location = new System.Drawing.Point(315, 85);
            this.lblSalesManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesManagement.Name = "lblSalesManagement";
            this.lblSalesManagement.Size = new System.Drawing.Size(601, 30);
            this.lblSalesManagement.TabIndex = 26;
            this.lblSalesManagement.Text = "Sales Management System and Kitchen Operation";
            // 
            // lblWingsandRice
            // 
            this.lblWingsandRice.AutoSize = true;
            this.lblWingsandRice.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingsandRice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblWingsandRice.Location = new System.Drawing.Point(516, 50);
            this.lblWingsandRice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWingsandRice.Name = "lblWingsandRice";
            this.lblWingsandRice.Size = new System.Drawing.Size(373, 30);
            this.lblWingsandRice.TabIndex = 25;
            this.lblWingsandRice.Text = "Wings and Rice Meal Products";
            // 
            // lbl1POS
            // 
            this.lbl1POS.AutoSize = true;
            this.lbl1POS.Font = new System.Drawing.Font("Bernard MT Condensed", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1POS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lbl1POS.Location = new System.Drawing.Point(339, 48);
            this.lbl1POS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1POS.Name = "lbl1POS";
            this.lbl1POS.Size = new System.Drawing.Size(180, 34);
            this.lbl1POS.TabIndex = 24;
            this.lbl1POS.Text = "WingBite POS: ";
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(130, 10);
            this.picboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(173, 142);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 23;
            this.picboxLogo.TabStop = false;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 677);
            this.Controls.Add(this.lblSalesManagement);
            this.Controls.Add(this.lblWingsandRice);
            this.Controls.Add(this.lbl1POS);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Page";
            this.Text = "Main_Page";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Label lblOrdersToday;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label lblTodaysSales;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Label lblSalesManagement;
        private System.Windows.Forms.Label lblWingsandRice;
        private System.Windows.Forms.Label lbl1POS;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}