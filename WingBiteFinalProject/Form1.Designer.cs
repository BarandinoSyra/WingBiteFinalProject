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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblWingBitePOS = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.picboxWallpaper = new System.Windows.Forms.PictureBox();
            this.panelWallpaper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.Controls.Add(this.picboxWallpaper);
            this.panelWallpaper.Location = new System.Drawing.Point(358, -25);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(441, 551);
            this.panelWallpaper.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 512);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lblWingBitePOS);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.picboxUser);
            this.panel2.Controls.Add(this.lblUserLogin);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(23, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 463);
            this.panel2.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(36, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(237, 24);
            this.txtPassword.TabIndex = 29;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(36, 274);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 24);
            this.txtUsername.TabIndex = 28;
            // 
            // lblWingBitePOS
            // 
            this.lblWingBitePOS.AutoSize = true;
            this.lblWingBitePOS.Font = new System.Drawing.Font("Stencil", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingBitePOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblWingBitePOS.Location = new System.Drawing.Point(45, 32);
            this.lblWingBitePOS.Name = "lblWingBitePOS";
            this.lblWingBitePOS.Size = new System.Drawing.Size(228, 37);
            this.lblWingBitePOS.TabIndex = 22;
            this.lblWingBitePOS.Text = "WingBite POS";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(161, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 36);
            this.btnLogin.TabIndex = 27;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblUserLogin.Location = new System.Drawing.Point(87, 208);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(135, 24);
            this.lblUserLogin.TabIndex = 23;
            this.lblUserLogin.Text = "- User Login -";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(33, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 18);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password*";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(33, 253);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 18);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Username*";
            // 
            // picboxUser
            // 
            this.picboxUser.Image = global::WingBiteFinalProject.Properties.Resources.user__1_;
            this.picboxUser.Location = new System.Drawing.Point(91, 79);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(127, 110);
            this.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUser.TabIndex = 21;
            this.picboxUser.TabStop = false;
            // 
            // picboxWallpaper
            // 
            this.picboxWallpaper.Image = global::WingBiteFinalProject.Properties.Resources._123456_removebg_preview;
            this.picboxWallpaper.Location = new System.Drawing.Point(3, 72);
            this.picboxWallpaper.Name = "picboxWallpaper";
            this.picboxWallpaper.Size = new System.Drawing.Size(440, 418);
            this.picboxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxWallpaper.TabIndex = 0;
            this.picboxWallpaper.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.panelWallpaper.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxWallpaper)).EndInit();
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
    }
}

