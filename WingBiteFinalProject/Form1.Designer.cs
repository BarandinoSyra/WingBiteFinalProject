namespace WingBiteFinalProject
{
    partial class LoginForm
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
            this.panelWallpaper = new System.Windows.Forms.Panel();
            this.picboxWallpaper = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblWingBitePOS = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.Controls.Add(this.picboxWallpaper);
            this.panelWallpaper.Location = new System.Drawing.Point(537, -38);
            this.panelWallpaper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(662, 848);
            this.panelWallpaper.TabIndex = 1;
            // 
            // picboxWallpaper
            // 
            this.picboxWallpaper.Image = global::WingBiteFinalProject.Properties.Resources._123456_removebg_preview;
            this.picboxWallpaper.Location = new System.Drawing.Point(4, 111);
            this.picboxWallpaper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxWallpaper.Name = "picboxWallpaper";
            this.picboxWallpaper.Size = new System.Drawing.Size(660, 643);
            this.picboxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxWallpaper.TabIndex = 0;
            this.picboxWallpaper.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 774);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lblWingBitePOS);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.picboxUser);
            this.panel2.Controls.Add(this.lblUserLogin);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(34, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 755);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(259, 560);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(54, 520);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 32);
            this.txtPassword.TabIndex = 29;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(54, 422);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(354, 32);
            this.txtUsername.TabIndex = 28;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblWingBitePOS
            // 
            this.lblWingBitePOS.AutoSize = true;
            this.lblWingBitePOS.Font = new System.Drawing.Font("Stencil", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingBitePOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblWingBitePOS.Location = new System.Drawing.Point(68, 49);
            this.lblWingBitePOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWingBitePOS.Name = "lblWingBitePOS";
            this.lblWingBitePOS.Size = new System.Drawing.Size(339, 55);
            this.lblWingBitePOS.TabIndex = 22;
            this.lblWingBitePOS.Text = "WingBite POS";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(146, 612);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 55);
            this.btnLogin.TabIndex = 27;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picboxUser
            // 
            this.picboxUser.Image = global::WingBiteFinalProject.Properties.Resources.user__1_;
            this.picboxUser.Location = new System.Drawing.Point(136, 122);
            this.picboxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(190, 169);
            this.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUser.TabIndex = 21;
            this.picboxUser.TabStop = false;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserLogin.Location = new System.Drawing.Point(130, 320);
            this.lblUserLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(202, 35);
            this.lblUserLogin.TabIndex = 23;
            this.lblUserLogin.Text = "- User Login -";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(50, 488);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 24);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password*";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(50, 389);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Username*";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelWallpaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWallpaper;
        private System.Windows.Forms.PictureBox picboxWallpaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblWingBitePOS;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

