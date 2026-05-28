namespace AuthForms.UI
{
    partial class frmDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppDesc = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lnkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.lblAppName);
            this.pnlLeft.Controls.Add(this.lblAppDesc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 460);
            this.pnlLeft.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.picLogo.Location = new System.Drawing.Point(113, 110);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(74, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(10, 200);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(280, 80);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "QuangCao\nSystem";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.lblAppDesc.Location = new System.Drawing.Point(10, 290);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(280, 50);
            this.lblAppDesc.TabIndex = 2;
            this.lblAppDesc.Text = "Hệ thống quản lý hợp đồng\nvà bài viết nội bộ";
            this.lblAppDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Controls.Add(this.lblSubTitle);
            this.pnlRight.Controls.Add(this.lblTenDangNhap);
            this.pnlRight.Controls.Add(this.txtTenDangNhap);
            this.pnlRight.Controls.Add(this.lblMatKhau);
            this.pnlRight.Controls.Add(this.txtMatKhau);
            this.pnlRight.Controls.Add(this.chkHienMatKhau);
            this.pnlRight.Controls.Add(this.btnDangNhap);
            this.pnlRight.Controls.Add(this.pbLoading);
            this.pnlRight.Controls.Add(this.lblThongBao);
            this.pnlRight.Controls.Add(this.lnkQuenMatKhau);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(430, 460);
            this.pnlRight.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chào mừng trở lại!";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(37, 92);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(360, 22);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Vui lòng đăng nhập để tiếp tục";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.Location = new System.Drawing.Point(35, 140);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(200, 20);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(35, 163);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(358, 32);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.Location = new System.Drawing.Point(35, 210);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(200, 20);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(35, 233);
            this.txtMatKhau.MaxLength = 100;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(358, 32);
            this.txtMatKhau.TabIndex = 1;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkHienMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.chkHienMatKhau.Location = new System.Drawing.Point(35, 272);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(130, 22);
            this.chkHienMatKhau.TabIndex = 2;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(35, 308);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(358, 40);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(35, 357);
            this.pbLoading.MarqueeAnimationSpeed = 30;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(358, 6);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoading.TabIndex = 8;
            this.pbLoading.Visible = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location = new System.Drawing.Point(35, 366);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(358, 50);
            this.lblThongBao.TabIndex = 9;
            // 
            // lnkQuenMatKhau
            // 
            this.lnkQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkQuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lnkQuenMatKhau.Location = new System.Drawing.Point(205, 272);
            this.lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            this.lnkQuenMatKhau.Size = new System.Drawing.Size(188, 22);
            this.lnkQuenMatKhau.TabIndex = 10;
            this.lnkQuenMatKhau.TabStop = true;
            this.lnkQuenMatKhau.Text = "Quên mật khẩu?";
            this.lnkQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQuenMatKhau_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 460);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel      pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label      lblAppName;
        private System.Windows.Forms.Label      lblAppDesc;
        private System.Windows.Forms.Panel      pnlRight;
        private System.Windows.Forms.Label      lblTitle;
        private System.Windows.Forms.Label      lblSubTitle;
        private System.Windows.Forms.Label      lblTenDangNhap;
        private System.Windows.Forms.TextBox    txtTenDangNhap;
        private System.Windows.Forms.Label      lblMatKhau;
        private System.Windows.Forms.TextBox    txtMatKhau;
        private System.Windows.Forms.CheckBox   chkHienMatKhau;
        private System.Windows.Forms.Button     btnDangNhap;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label      lblThongBao;
        private System.Windows.Forms.LinkLabel  lnkQuenMatKhau;
    }
}
