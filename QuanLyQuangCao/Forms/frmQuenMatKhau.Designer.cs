namespace AuthForms.UI
{
    partial class frmQuenMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft           = new System.Windows.Forms.Panel();
            this.picLogo           = new System.Windows.Forms.PictureBox();
            this.lblAppName        = new System.Windows.Forms.Label();
            this.lblAppDesc        = new System.Windows.Forms.Label();
            this.pnlSteps          = new System.Windows.Forms.Panel();
            this.pnlBuoc1Chi       = new System.Windows.Forms.Panel();
            this.lblSoBuoc1        = new System.Windows.Forms.Label();
            this.lblBuoc1Chi       = new System.Windows.Forms.Label();
            this.pnlBuoc2Chi       = new System.Windows.Forms.Panel();
            this.lblSoBuoc2        = new System.Windows.Forms.Label();
            this.lblBuoc2Chi       = new System.Windows.Forms.Label();
            this.pnlRight          = new System.Windows.Forms.Panel();
            this.lblTitle          = new System.Windows.Forms.Label();
            this.lblSubTitle       = new System.Windows.Forms.Label();
            // Bước 1
            this.pnlBuoc1          = new System.Windows.Forms.Panel();
            this.lblTenDangNhap    = new System.Windows.Forms.Label();
            this.txtTenDangNhap    = new System.Windows.Forms.TextBox();
            this.lblEmail          = new System.Windows.Forms.Label();
            this.txtEmail          = new System.Windows.Forms.TextBox();
            this.btnXacMinh        = new System.Windows.Forms.Button();
            // Bước 2
            this.pnlBuoc2          = new System.Windows.Forms.Panel();
            this.lblMatKhauMoi     = new System.Windows.Forms.Label();
            this.txtMatKhauMoi     = new System.Windows.Forms.TextBox();
            this.lblXacNhan        = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhauMoi = new System.Windows.Forms.CheckBox();
            this.lblDoManhLabel    = new System.Windows.Forms.Label();
            this.pbDoManh          = new System.Windows.Forms.ProgressBar();
            this.lblDoManh         = new System.Windows.Forms.Label();
            this.btnDatLai         = new System.Windows.Forms.Button();
            this.btnQuayLai        = new System.Windows.Forms.Button();
            // Chung
            this.lblThongBao       = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlBuoc1.SuspendLayout();
            this.pnlBuoc2.SuspendLayout();
            this.SuspendLayout();

            // ── pnlLeft ─────────────────────────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.lblAppName);
            this.pnlLeft.Controls.Add(this.lblAppDesc);
            this.pnlLeft.Controls.Add(this.pnlSteps);
            this.pnlLeft.Dock     = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Size     = new System.Drawing.Size(300, 510);

            // ── picLogo ─────────────────────────────────────────────
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(40, 90, 160);
            this.picLogo.Location  = new System.Drawing.Point(113, 70);
            this.picLogo.Size      = new System.Drawing.Size(74, 74);
            this.picLogo.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabStop   = false;


            // ── lblAppName ───────────────────────────────────────────
            this.lblAppName.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location  = new System.Drawing.Point(10, 158);
            this.lblAppName.Size      = new System.Drawing.Size(280, 60);
            this.lblAppName.Text      = "QuangCao\nSystem";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblAppDesc ───────────────────────────────────────────
            this.lblAppDesc.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppDesc.ForeColor = System.Drawing.Color.FromArgb(170, 200, 240);
            this.lblAppDesc.Location  = new System.Drawing.Point(10, 228);
            this.lblAppDesc.Size      = new System.Drawing.Size(280, 40);
            this.lblAppDesc.Text      = "Hệ thống quản lý hợp đồng\nvà bài viết nội bộ";
            this.lblAppDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── pnlSteps (bộ chỉ báo bước) ──────────────────────────
            this.pnlSteps.Location = new System.Drawing.Point(50, 310);
            this.pnlSteps.Size     = new System.Drawing.Size(200, 100);
            this.pnlSteps.BackColor = System.Drawing.Color.Transparent;

            // Bước 1 chỉ báo
            this.pnlBuoc1Chi.Size      = new System.Drawing.Size(32, 32);
            this.pnlBuoc1Chi.Location  = new System.Drawing.Point(0, 10);
            this.pnlBuoc1Chi.BackColor = System.Drawing.Color.White;
            this.lblSoBuoc1.Text       = "1";
            this.lblSoBuoc1.Font       = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoBuoc1.ForeColor  = System.Drawing.Color.FromArgb(22, 55, 100);
            this.lblSoBuoc1.Size       = new System.Drawing.Size(32, 32);
            this.lblSoBuoc1.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlBuoc1Chi.Controls.Add(this.lblSoBuoc1);
            this.lblBuoc1Chi.Text      = "Xác minh danh tính";
            this.lblBuoc1Chi.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuoc1Chi.ForeColor = System.Drawing.Color.White;
            this.lblBuoc1Chi.Location  = new System.Drawing.Point(40, 14);
            this.lblBuoc1Chi.Size      = new System.Drawing.Size(160, 22);

            // Bước 2 chỉ báo
            this.pnlBuoc2Chi.Size      = new System.Drawing.Size(32, 32);
            this.pnlBuoc2Chi.Location  = new System.Drawing.Point(0, 56);
            this.pnlBuoc2Chi.BackColor = System.Drawing.Color.FromArgb(100, 130, 170);
            this.lblSoBuoc2.Text       = "2";
            this.lblSoBuoc2.Font       = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoBuoc2.ForeColor  = System.Drawing.Color.White;
            this.lblSoBuoc2.Size       = new System.Drawing.Size(32, 32);
            this.lblSoBuoc2.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlBuoc2Chi.Controls.Add(this.lblSoBuoc2);
            this.lblBuoc2Chi.Text      = "Đặt mật khẩu mới";
            this.lblBuoc2Chi.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuoc2Chi.ForeColor = System.Drawing.Color.FromArgb(150, 180, 220);
            this.lblBuoc2Chi.Location  = new System.Drawing.Point(40, 60);
            this.lblBuoc2Chi.Size      = new System.Drawing.Size(160, 22);

            this.pnlSteps.Controls.Add(this.pnlBuoc1Chi);
            this.pnlSteps.Controls.Add(this.pnlBuoc2Chi);
            this.pnlSteps.Controls.Add(this.lblBuoc1Chi);
            this.pnlSteps.Controls.Add(this.lblBuoc2Chi);

            // ── pnlRight ─────────────────────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Controls.Add(this.lblSubTitle);
            this.pnlRight.Controls.Add(this.pnlBuoc1);
            this.pnlRight.Controls.Add(this.pnlBuoc2);
            this.pnlRight.Controls.Add(this.lblThongBao);
            this.pnlRight.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Size     = new System.Drawing.Size(430, 510);

            // ── lblTitle ─────────────────────────────────────────────
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.lblTitle.Location  = new System.Drawing.Point(35, 45);
            this.lblTitle.Size      = new System.Drawing.Size(360, 34);
            this.lblTitle.Text      = "Quên mật khẩu";

            // ── lblSubTitle ───────────────────────────────────────────
            this.lblSubTitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location  = new System.Drawing.Point(37, 82);
            this.lblSubTitle.Size      = new System.Drawing.Size(360, 22);
            this.lblSubTitle.Text      = "Nhập thông tin tài khoản để xác minh.";

            // ── pnlBuoc1 ─────────────────────────────────────────────
            this.pnlBuoc1.Location  = new System.Drawing.Point(0, 110);
            this.pnlBuoc1.Size      = new System.Drawing.Size(430, 300);
            this.pnlBuoc1.BackColor = System.Drawing.Color.White;

            this.lblTenDangNhap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.Location  = new System.Drawing.Point(35, 20);
            this.lblTenDangNhap.Size      = new System.Drawing.Size(200, 20);
            this.lblTenDangNhap.Text      = "Tên đăng nhập";

            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font        = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenDangNhap.Location    = new System.Drawing.Point(35, 43);
            this.txtTenDangNhap.MaxLength   = 50;
            this.txtTenDangNhap.Size        = new System.Drawing.Size(358, 32);
            this.txtTenDangNhap.TabIndex    = 0;

            this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location  = new System.Drawing.Point(35, 90);
            this.lblEmail.Size      = new System.Drawing.Size(200, 20);
            this.lblEmail.Text      = "Email đăng ký";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font        = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location    = new System.Drawing.Point(35, 113);
            this.txtEmail.MaxLength   = 100;
            this.txtEmail.Size        = new System.Drawing.Size(358, 32);
            this.txtEmail.TabIndex    = 1;

            this.btnXacMinh.BackColor             = System.Drawing.Color.FromArgb(22, 55, 100);
            this.btnXacMinh.FlatAppearance.BorderSize = 0;
            this.btnXacMinh.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacMinh.Font                  = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacMinh.ForeColor             = System.Drawing.Color.White;
            this.btnXacMinh.Location              = new System.Drawing.Point(35, 165);
            this.btnXacMinh.Size                  = new System.Drawing.Size(358, 40);
            this.btnXacMinh.TabIndex              = 2;
            this.btnXacMinh.Text                  = "XÁC MINH DANH TÍNH";
            this.btnXacMinh.UseVisualStyleBackColor = false;
            this.btnXacMinh.Click += new System.EventHandler(this.btnXacMinh_Click);

            this.pnlBuoc1.Controls.Add(this.lblTenDangNhap);
            this.pnlBuoc1.Controls.Add(this.txtTenDangNhap);
            this.pnlBuoc1.Controls.Add(this.lblEmail);
            this.pnlBuoc1.Controls.Add(this.txtEmail);
            this.pnlBuoc1.Controls.Add(this.btnXacMinh);

            // ── pnlBuoc2 ─────────────────────────────────────────────
            this.pnlBuoc2.Location  = new System.Drawing.Point(0, 110);
            this.pnlBuoc2.Size      = new System.Drawing.Size(430, 330);
            this.pnlBuoc2.BackColor = System.Drawing.Color.White;
            this.pnlBuoc2.Visible   = false;

            this.lblMatKhauMoi.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauMoi.Location  = new System.Drawing.Point(35, 10);
            this.lblMatKhauMoi.Size      = new System.Drawing.Size(200, 20);
            this.lblMatKhauMoi.Text      = "Mật khẩu mới";

            this.txtMatKhauMoi.BorderStyle   = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauMoi.Font          = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhauMoi.Location      = new System.Drawing.Point(35, 33);
            this.txtMatKhauMoi.MaxLength     = 100;
            this.txtMatKhauMoi.PasswordChar  = '●';
            this.txtMatKhauMoi.Size          = new System.Drawing.Size(358, 32);
            this.txtMatKhauMoi.TabIndex      = 0;
            this.txtMatKhauMoi.TextChanged  += new System.EventHandler(this.txtMatKhauMoi_TextChanged);

            this.lblDoManhLabel.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDoManhLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lblDoManhLabel.Location  = new System.Drawing.Point(35, 70);
            this.lblDoManhLabel.Size      = new System.Drawing.Size(90, 16);
            this.lblDoManhLabel.Text      = "Độ mạnh:";

            this.pbDoManh.Location  = new System.Drawing.Point(35, 88);
            this.pbDoManh.Size      = new System.Drawing.Size(280, 8);
            this.pbDoManh.Maximum   = 100;
            this.pbDoManh.Value     = 0;
            this.pbDoManh.Style     = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.lblDoManh.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDoManh.Location  = new System.Drawing.Point(322, 83);
            this.lblDoManh.Size      = new System.Drawing.Size(70, 18);
            this.lblDoManh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblXacNhan.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblXacNhan.Location  = new System.Drawing.Point(35, 108);
            this.lblXacNhan.Size      = new System.Drawing.Size(200, 20);
            this.lblXacNhan.Text      = "Xác nhận mật khẩu";

            this.txtXacNhanMatKhau.BorderStyle   = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhanMatKhau.Font          = new System.Drawing.Font("Segoe UI", 11F);
            this.txtXacNhanMatKhau.Location      = new System.Drawing.Point(35, 131);
            this.txtXacNhanMatKhau.MaxLength     = 100;
            this.txtXacNhanMatKhau.PasswordChar  = '●';
            this.txtXacNhanMatKhau.Size          = new System.Drawing.Size(358, 32);
            this.txtXacNhanMatKhau.TabIndex      = 1;

            this.chkHienMatKhauMoi.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.chkHienMatKhauMoi.ForeColor = System.Drawing.Color.DimGray;
            this.chkHienMatKhauMoi.Location  = new System.Drawing.Point(35, 170);
            this.chkHienMatKhauMoi.Size      = new System.Drawing.Size(150, 22);
            this.chkHienMatKhauMoi.Text      = "Hiện mật khẩu";
            this.chkHienMatKhauMoi.TabIndex  = 2;
            this.chkHienMatKhauMoi.CheckedChanged += new System.EventHandler(this.chkHienMatKhauMoi_CheckedChanged);

            this.btnDatLai.BackColor             = System.Drawing.Color.FromArgb(22, 55, 100);
            this.btnDatLai.FlatAppearance.BorderSize = 0;
            this.btnDatLai.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.Font                  = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatLai.ForeColor             = System.Drawing.Color.White;
            this.btnDatLai.Location              = new System.Drawing.Point(35, 202);
            this.btnDatLai.Size                  = new System.Drawing.Size(358, 40);
            this.btnDatLai.TabIndex              = 3;
            this.btnDatLai.Text                  = "ĐẶT LẠI MẬT KHẨU";
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);

            this.btnQuayLai.BackColor             = System.Drawing.Color.White;
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.btnQuayLai.FlatAppearance.BorderSize  = 1;
            this.btnQuayLai.FlatStyle             = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font                  = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuayLai.ForeColor             = System.Drawing.Color.FromArgb(22, 55, 100);
            this.btnQuayLai.Location              = new System.Drawing.Point(35, 250);
            this.btnQuayLai.Size                  = new System.Drawing.Size(358, 32);
            this.btnQuayLai.TabIndex              = 4;
            this.btnQuayLai.Text                  = "← Quay lại bước trước";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            this.pnlBuoc2.Controls.Add(this.lblMatKhauMoi);
            this.pnlBuoc2.Controls.Add(this.txtMatKhauMoi);
            this.pnlBuoc2.Controls.Add(this.lblDoManhLabel);
            this.pnlBuoc2.Controls.Add(this.pbDoManh);
            this.pnlBuoc2.Controls.Add(this.lblDoManh);
            this.pnlBuoc2.Controls.Add(this.lblXacNhan);
            this.pnlBuoc2.Controls.Add(this.txtXacNhanMatKhau);
            this.pnlBuoc2.Controls.Add(this.chkHienMatKhauMoi);
            this.pnlBuoc2.Controls.Add(this.btnDatLai);
            this.pnlBuoc2.Controls.Add(this.btnQuayLai);

            // ── lblThongBao ───────────────────────────────────────────
            this.lblThongBao.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location  = new System.Drawing.Point(35, 440);
            this.lblThongBao.Size      = new System.Drawing.Size(358, 50);

            // ── frmQuenMatKhau ────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(730, 510);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "frmQuenMatKhau";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Đặt lại mật khẩu";

            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlBuoc1.ResumeLayout(false);
            this.pnlBuoc1.PerformLayout();
            this.pnlBuoc2.ResumeLayout(false);
            this.pnlBuoc2.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── Field declarations ─────────────────────────────────────
        private System.Windows.Forms.Panel       pnlLeft;
        private System.Windows.Forms.PictureBox  picLogo;
        private System.Windows.Forms.Label       lblAppName;
        private System.Windows.Forms.Label       lblAppDesc;
        private System.Windows.Forms.Panel       pnlSteps;
        private System.Windows.Forms.Panel       pnlBuoc1Chi;
        private System.Windows.Forms.Label       lblSoBuoc1;
        private System.Windows.Forms.Label       lblBuoc1Chi;
        private System.Windows.Forms.Panel       pnlBuoc2Chi;
        private System.Windows.Forms.Label       lblSoBuoc2;
        private System.Windows.Forms.Label       lblBuoc2Chi;
        private System.Windows.Forms.Panel       pnlRight;
        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.Label       lblSubTitle;
        // Bước 1
        private System.Windows.Forms.Panel       pnlBuoc1;
        private System.Windows.Forms.Label       lblTenDangNhap;
        private System.Windows.Forms.TextBox     txtTenDangNhap;
        private System.Windows.Forms.Label       lblEmail;
        private System.Windows.Forms.TextBox     txtEmail;
        private System.Windows.Forms.Button      btnXacMinh;
        // Bước 2
        private System.Windows.Forms.Panel       pnlBuoc2;
        private System.Windows.Forms.Label       lblMatKhauMoi;
        private System.Windows.Forms.TextBox     txtMatKhauMoi;
        private System.Windows.Forms.Label       lblDoManhLabel;
        private System.Windows.Forms.ProgressBar pbDoManh;
        private System.Windows.Forms.Label       lblDoManh;
        private System.Windows.Forms.Label       lblXacNhan;
        private System.Windows.Forms.TextBox     txtXacNhanMatKhau;
        private System.Windows.Forms.CheckBox    chkHienMatKhauMoi;
        private System.Windows.Forms.Button      btnDatLai;
        private System.Windows.Forms.Button      btnQuayLai;
        // Chung
        private System.Windows.Forms.Label       lblThongBao;
    }
}
