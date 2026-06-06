namespace WingBiteFinalProject
{
    partial class Sales_Order_Module
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
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.rbDrinks = new System.Windows.Forms.RadioButton();
            this.rbRicePlatter = new System.Windows.Forms.RadioButton();
            this.rbWings = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.lblMenuItems = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSubtotalResult = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxSalesOrderForm = new System.Windows.Forms.PictureBox();
            this.lblSalesOrderForm = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesOrderForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(258, 160);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(251, 22);
            this.txtOrderNumber.TabIndex = 43;
            // 
            // rbDrinks
            // 
            this.rbDrinks.AutoSize = true;
            this.rbDrinks.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrinks.Location = new System.Drawing.Point(649, 210);
            this.rbDrinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDrinks.Name = "rbDrinks";
            this.rbDrinks.Size = new System.Drawing.Size(86, 26);
            this.rbDrinks.TabIndex = 42;
            this.rbDrinks.TabStop = true;
            this.rbDrinks.Text = "Drinks";
            this.rbDrinks.UseVisualStyleBackColor = true;
            this.rbDrinks.CheckedChanged += new System.EventHandler(this.rbDrinks_CheckedChanged_1);
            // 
            // rbRicePlatter
            // 
            this.rbRicePlatter.AutoSize = true;
            this.rbRicePlatter.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRicePlatter.Location = new System.Drawing.Point(491, 210);
            this.rbRicePlatter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRicePlatter.Name = "rbRicePlatter";
            this.rbRicePlatter.Size = new System.Drawing.Size(123, 26);
            this.rbRicePlatter.TabIndex = 41;
            this.rbRicePlatter.TabStop = true;
            this.rbRicePlatter.Text = "Rice Platter";
            this.rbRicePlatter.UseVisualStyleBackColor = true;
            this.rbRicePlatter.CheckedChanged += new System.EventHandler(this.rbRicePlatter_CheckedChanged_1);
            // 
            // rbWings
            // 
            this.rbWings.AutoSize = true;
            this.rbWings.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWings.Location = new System.Drawing.Point(379, 208);
            this.rbWings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbWings.Name = "rbWings";
            this.rbWings.Size = new System.Drawing.Size(81, 26);
            this.rbWings.TabIndex = 40;
            this.rbWings.TabStop = true;
            this.rbWings.Text = "Wings";
            this.rbWings.UseVisualStyleBackColor = true;
            this.rbWings.CheckedChanged += new System.EventHandler(this.rbWings_CheckedChanged_1);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(172, 212);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 22);
            this.lblCategory.TabIndex = 39;
            this.lblCategory.Text = "Category: ";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Dine In",
            "Take Out"});
            this.cmbOrderType.Location = new System.Drawing.Point(653, 158);
            this.cmbOrderType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(221, 24);
            this.cmbOrderType.TabIndex = 38;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(533, 158);
            this.lblOrderType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(108, 22);
            this.lblOrderType.TabIndex = 37;
            this.lblOrderType.Text = "Order Type: ";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(160, 158);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(79, 22);
            this.lblOrderNum.TabIndex = 36;
            this.lblOrderNum.Text = "Order #: ";
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(515, 278);
            this.dgvCurrentOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.ReadOnly = true;
            this.dgvCurrentOrder.RowHeadersVisible = false;
            this.dgvCurrentOrder.RowHeadersWidth = 62;
            this.dgvCurrentOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCurrentOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(524, 375);
            this.dgvCurrentOrder.TabIndex = 47;
            this.dgvCurrentOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentOrder_CellContentClick_1);
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(30, 278);
            this.dgvMenuItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.ReadOnly = true;
            this.dgvMenuItems.RowHeadersVisible = false;
            this.dgvMenuItems.RowHeadersWidth = 62;
            this.dgvMenuItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(477, 375);
            this.dgvMenuItems.TabIndex = 46;
            this.dgvMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellContentClick_1);
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrder.Location = new System.Drawing.Point(547, 251);
            this.lblCurrentOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(130, 22);
            this.lblCurrentOrder.TabIndex = 45;
            this.lblCurrentOrder.Text = "Current Order: ";
            // 
            // lblMenuItems
            // 
            this.lblMenuItems.AutoSize = true;
            this.lblMenuItems.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItems.Location = new System.Drawing.Point(78, 251);
            this.lblMenuItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuItems.Name = "lblMenuItems";
            this.lblMenuItems.Size = new System.Drawing.Size(113, 22);
            this.lblMenuItems.TabIndex = 44;
            this.lblMenuItems.Text = "Menu Items: ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(189, 676);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 55;
            // 
            // lblSubtotalResult
            // 
            this.lblSubtotalResult.AutoSize = true;
            this.lblSubtotalResult.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalResult.Location = new System.Drawing.Point(548, 676);
            this.lblSubtotalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalResult.Name = "lblSubtotalResult";
            this.lblSubtotalResult.Size = new System.Drawing.Size(80, 22);
            this.lblSubtotalResult.TabIndex = 54;
            this.lblSubtotalResult.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(649, 676);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(126, 22);
            this.lblSubtotal.TabIndex = 53;
            this.lblSubtotal.Text = "Subtotal result";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(78, 676);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 22);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(365, 666);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(144, 34);
            this.btnAddToOrder.TabIndex = 51;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.Location = new System.Drawing.Point(424, 732);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(211, 38);
            this.btnClearOrder.TabIndex = 50;
            this.btnClearOrder.Text = "CLEAR ORDER";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(205, 732);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(211, 38);
            this.btnRemoveItem.TabIndex = 49;
            this.btnRemoveItem.Text = "REMOVE ITEM";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(643, 732);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(211, 38);
            this.btnCheckout.TabIndex = 48;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 804);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 43);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(357, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 57;
            this.label1.Text = "ORDER ENTRY FORM";
            // 
            // picboxSalesOrderForm
            // 
            this.picboxSalesOrderForm.Image = global::WingBiteFinalProject.Properties.Resources.asdfdg_removebg_preview;
            this.picboxSalesOrderForm.Location = new System.Drawing.Point(16, 14);
            this.picboxSalesOrderForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxSalesOrderForm.Name = "picboxSalesOrderForm";
            this.picboxSalesOrderForm.Size = new System.Drawing.Size(136, 91);
            this.picboxSalesOrderForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSalesOrderForm.TabIndex = 12;
            this.picboxSalesOrderForm.TabStop = false;
            // 
            // lblSalesOrderForm
            // 
            this.lblSalesOrderForm.AutoSize = true;
            this.lblSalesOrderForm.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblSalesOrderForm.Location = new System.Drawing.Point(160, 42);
            this.lblSalesOrderForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOrderForm.Name = "lblSalesOrderForm";
            this.lblSalesOrderForm.Size = new System.Drawing.Size(221, 38);
            this.lblSalesOrderForm.TabIndex = 11;
            this.lblSalesOrderForm.Text = "SALES ORDER";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(286, 210);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 26);
            this.rbAll.TabIndex = 58;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged_1);
            // 
            // Sales_Order_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1067, 862);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSubtotalResult);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.lblMenuItems);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.rbDrinks);
            this.Controls.Add(this.rbRicePlatter);
            this.Controls.Add(this.rbWings);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.picboxSalesOrderForm);
            this.Controls.Add(this.lblSalesOrderForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sales_Order_Module";
            this.Text = "Sales_Order_Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Order_Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalesOrderForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSalesOrderForm;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.RadioButton rbDrinks;
        private System.Windows.Forms.RadioButton rbRicePlatter;
        private System.Windows.Forms.RadioButton rbWings;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.Label lblMenuItems;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSubtotalResult;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalesOrderForm;
        private System.Windows.Forms.RadioButton rbAll;
    }
}