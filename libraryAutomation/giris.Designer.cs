
namespace libraryAutomation
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklblRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picboxPassword = new System.Windows.Forms.PictureBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOperation.Controls.Add(this.pictureBox1);
            this.pnlOperation.Controls.Add(this.linklblRegister);
            this.pnlOperation.Controls.Add(this.btnLogin);
            this.pnlOperation.Controls.Add(this.picboxPassword);
            this.pnlOperation.Controls.Add(this.picboxUser);
            this.pnlOperation.Controls.Add(this.txtPassword);
            this.pnlOperation.Controls.Add(this.txtUserName);
            this.pnlOperation.Controls.Add(this.lblLine);
            this.pnlOperation.Controls.Add(this.lblLogin);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(593, 786);
            this.pnlOperation.TabIndex = 0;
            this.pnlOperation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOperation_Paint);
            this.pnlOperation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseDown);
            this.pnlOperation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseMove);
            this.pnlOperation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOperation_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // linklblRegister
            // 
            this.linklblRegister.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linklblRegister.AutoSize = true;
            this.linklblRegister.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.linklblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblRegister.LinkColor = System.Drawing.Color.Silver;
            this.linklblRegister.Location = new System.Drawing.Point(16, 756);
            this.linklblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblRegister.Name = "linklblRegister";
            this.linklblRegister.Size = new System.Drawing.Size(114, 20);
            this.linklblRegister.TabIndex = 7;
            this.linklblRegister.TabStop = true;
            this.linklblRegister.Text = "Hesap oluştur";
            this.linklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegister_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Giriş Yap";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Silver;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Black;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(180, 497);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(241, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picboxPassword
            // 
            this.picboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.picboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxPassword.BackgroundImage")));
            this.picboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPassword.Location = new System.Drawing.Point(73, 410);
            this.picboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPassword.Name = "picboxPassword";
            this.picboxPassword.Size = new System.Drawing.Size(43, 41);
            this.picboxPassword.TabIndex = 5;
            this.picboxPassword.TabStop = false;
            // 
            // picboxUser
            // 
            this.picboxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxUser.BackColor = System.Drawing.Color.Transparent;
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxUser.Location = new System.Drawing.Point(73, 324);
            this.picboxUser.Margin = new System.Windows.Forms.Padding(4);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(43, 41);
            this.picboxUser.TabIndex = 4;
            this.picboxUser.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(141, 410);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(383, 41);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUserName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(141, 324);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(383, 41);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "Kullanıcı adı";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Location = new System.Drawing.Point(67, 273);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(467, 1);
            this.lblLine.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLogin.Location = new System.Drawing.Point(67, 224);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(163, 32);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "OTURUM AÇ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(914, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(880, 13);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(670, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(670, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(614, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "İLERİ GÖRSEL PROGRAMLAMA\r\n               VİZE ÖDEVİ";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlOperation);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseUp);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.PictureBox picboxPassword;
        private System.Windows.Forms.PictureBox picboxUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLogin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.LinkLabel linklblRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}

