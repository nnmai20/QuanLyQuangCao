namespace AuthForms.UI
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.lblTieuDe          = new System.Windows.Forms.Label();
            this.lblMoTa            = new System.Windows.Forms.Label();
            this.pnlBody            = new System.Windows.Forms.Panel();
            this.lblNguoiDung       = new System.Windows.Forms.Label();
            this.lblNguoiDungGiaTri = new System.Windows.Forms.Label();
            this.pnlSepAcc          = new System.Windows.Forms.Panel();
            this.lblMatKhauCu       = new System.Windows.Forms.Label();
            this.txtMatKhauCu       = new System.Windows.Forms.TextBox();
            this.chkHienCu          = new System.Windows.Forms.CheckBox();
            this.lblMatKhauMoi      = new System.Windows.Forms.Label();
            this.txtMatKhauMoi      = new System.Windows.Forms.TextBox();
            this.chkHienMoi         = new System.Windows.Forms.CheckBox();
            this.lblDoBenTitle      = new System.Windows.Forms.Label();
            this.pbDoBen            = new System.Windows.Forms.ProgressBar();
            this.lblDoBenText       = new System.Windows.Forms.Label();
            this.lblXacNhan         = new System.Windows.Forms.Label();
            this.txtXacNhan         = new System.Windows.Forms.TextBox();
            this.chkHienXacNhan     = new System.Windows.Forms.CheckBox();
            this.pnlYeuCau          = new System.Windows.Forms.Panel();
            this.lblYeuCau          = new System.Windows.Forms.Label();
            this.lblThongBao        = new System.Windows.Forms.Label();
            this.btnLuu             = new System.Windows.Forms.Button();
            this.btnHuy             = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlYeuCau.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.pnlHeader.Controls.Add(this.lblMoTa);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location  = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name      = "pnlHeader";
            this.pnlHeader.Size      = new System.Drawing.Size(480, 72);
            this.pnlHeader.TabIndex  = 0;

            this.lblTieuDe.AutoSize  = false;
            this.lblTieuDe.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location  = new System.Drawing.Point(16, 12);
            this.lblTieuDe.Name      = "lblTieuDe";
            this.lblTieuDe.Size      = new System.Drawing.Size(450, 28);
            this.lblTieuDe.TabIndex  = 0;
            this.lblTieuDe.Text      = "Doi Mat Khau";

            this.lblMoTa.AutoSize  = false;
            this.lblMoTa.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(180, 210, 250);
            this.lblMoTa.Location  = new System.Drawing.Point(18, 44);
            this.lblMoTa.Name      = "lblMoTa";
            this.lblMoTa.Size      = new System.Drawing.Size(450, 20);
            this.lblMoTa.TabIndex  = 1;
            this.lblMoTa.Text      = "Thay doi mat khau tai khoan dang dang nhap";

            // ── pnlBody ──────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.btnHuy);
            this.pnlBody.Controls.Add(this.btnLuu);
            this.pnlBody.Controls.Add(this.lblThongBao);
            this.pnlBody.Controls.Add(this.pnlYeuCau);
            this.pnlBody.Controls.Add(this.chkHienXacNhan);
            this.pnlBody.Controls.Add(this.txtXacNhan);
            this.pnlBody.Controls.Add(this.lblXacNhan);
            this.pnlBody.Controls.Add(this.lblDoBenText);
            this.pnlBody.Controls.Add(this.pbDoBen);
            this.pnlBody.Controls.Add(this.lblDoBenTitle);
            this.pnlBody.Controls.Add(this.chkHienMoi);
            this.pnlBody.Controls.Add(this.txtMatKhauMoi);
            this.pnlBody.Controls.Add(this.lblMatKhauMoi);
            this.pnlBody.Controls.Add(this.chkHienCu);
            this.pnlBody.Controls.Add(this.txtMatKhauCu);
            this.pnlBody.Controls.Add(this.lblMatKhauCu);
            this.pnlBody.Controls.Add(this.pnlSepAcc);
            this.pnlBody.Controls.Add(this.lblNguoiDungGiaTri);
            this.pnlBody.Controls.Add(this.lblNguoiDung);
            this.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location  = new System.Drawing.Point(0, 72);
            this.pnlBody.Name      = "pnlBody";
            this.pnlBody.Size      = new System.Drawing.Size(480, 528);
            this.pnlBody.TabIndex  = 1;

            // lblNguoiDung
            this.lblNguoiDung.AutoSize  = false;
            this.lblNguoiDung.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.Location  = new System.Drawing.Point(24, 18);
            this.lblNguoiDung.Name      = "lblNguoiDung";
            this.lblNguoiDung.Size      = new System.Drawing.Size(80, 22);
            this.lblNguoiDung.TabIndex  = 0;
            this.lblNguoiDung.Text      = "Tai khoan:";

            // lblNguoiDungGiaTri
            this.lblNguoiDungGiaTri.AutoSize  = false;
            this.lblNguoiDungGiaTri.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDungGiaTri.ForeColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.lblNguoiDungGiaTri.Location  = new System.Drawing.Point(110, 18);
            this.lblNguoiDungGiaTri.Name      = "lblNguoiDungGiaTri";
            this.lblNguoiDungGiaTri.Size      = new System.Drawing.Size(340, 22);
            this.lblNguoiDungGiaTri.TabIndex  = 1;
            this.lblNguoiDungGiaTri.Text      = "";

            // pnlSepAcc
            this.pnlSepAcc.BackColor = System.Drawing.Color.FromArgb(220, 228, 240);
            this.pnlSepAcc.Location  = new System.Drawing.Point(24, 48);
            this.pnlSepAcc.Name      = "pnlSepAcc";
            this.pnlSepAcc.Size      = new System.Drawing.Size(430, 1);
            this.pnlSepAcc.TabIndex  = 2;

            // ── Mat khau cu ───────────────────────────────────────
            this.lblMatKhauCu.AutoSize  = false;
            this.lblMatKhauCu.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauCu.Location  = new System.Drawing.Point(24, 60);
            this.lblMatKhauCu.Name      = "lblMatKhauCu";
            this.lblMatKhauCu.Size      = new System.Drawing.Size(200, 20);
            this.lblMatKhauCu.TabIndex  = 3;
            this.lblMatKhauCu.Text      = "Mat khau hien tai";

            this.txtMatKhauCu.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauCu.Font         = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMatKhauCu.Location     = new System.Drawing.Point(24, 83);
            this.txtMatKhauCu.Name         = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size         = new System.Drawing.Size(330, 28);
            this.txtMatKhauCu.TabIndex     = 0;

            this.chkHienCu.AutoSize  = false;
            this.chkHienCu.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkHienCu.ForeColor = System.Drawing.Color.Gray;
            this.chkHienCu.Location  = new System.Drawing.Point(362, 87);
            this.chkHienCu.Name      = "chkHienCu";
            this.chkHienCu.Size      = new System.Drawing.Size(72, 20);
            this.chkHienCu.TabIndex  = 1;
            this.chkHienCu.Text      = "Hien";
            this.chkHienCu.UseVisualStyleBackColor = true;
            this.chkHienCu.CheckedChanged += new System.EventHandler(this.chkHienCu_CheckedChanged);

            // ── Mat khau moi ──────────────────────────────────────
            this.lblMatKhauMoi.AutoSize  = false;
            this.lblMatKhauMoi.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauMoi.Location  = new System.Drawing.Point(24, 126);
            this.lblMatKhauMoi.Name      = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size      = new System.Drawing.Size(200, 20);
            this.lblMatKhauMoi.TabIndex  = 6;
            this.lblMatKhauMoi.Text      = "Mat khau moi";

            this.txtMatKhauMoi.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauMoi.Font         = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMatKhauMoi.Location     = new System.Drawing.Point(24, 149);
            this.txtMatKhauMoi.Name         = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size         = new System.Drawing.Size(330, 28);
            this.txtMatKhauMoi.TabIndex     = 2;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);

            this.chkHienMoi.AutoSize  = false;
            this.chkHienMoi.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkHienMoi.ForeColor = System.Drawing.Color.Gray;
            this.chkHienMoi.Location  = new System.Drawing.Point(362, 153);
            this.chkHienMoi.Name      = "chkHienMoi";
            this.chkHienMoi.Size      = new System.Drawing.Size(72, 20);
            this.chkHienMoi.TabIndex  = 3;
            this.chkHienMoi.Text      = "Hien";
            this.chkHienMoi.UseVisualStyleBackColor = true;
            this.chkHienMoi.CheckedChanged += new System.EventHandler(this.chkHienMoi_CheckedChanged);

            // ── Thanh do ben ──────────────────────────────────────
            this.lblDoBenTitle.AutoSize  = false;
            this.lblDoBenTitle.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDoBenTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblDoBenTitle.Location  = new System.Drawing.Point(24, 186);
            this.lblDoBenTitle.Name      = "lblDoBenTitle";
            this.lblDoBenTitle.Size      = new System.Drawing.Size(130, 18);
            this.lblDoBenTitle.TabIndex  = 9;
            this.lblDoBenTitle.Text      = "Do manh mat khau:";

            this.lblDoBenText.AutoSize   = false;
            this.lblDoBenText.Font       = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDoBenText.ForeColor  = System.Drawing.Color.Gray;
            this.lblDoBenText.Location   = new System.Drawing.Point(160, 186);
            this.lblDoBenText.Name       = "lblDoBenText";
            this.lblDoBenText.Size       = new System.Drawing.Size(80, 18);
            this.lblDoBenText.TabIndex   = 10;
            this.lblDoBenText.Text       = "";

            this.pbDoBen.Location   = new System.Drawing.Point(24, 207);
            this.pbDoBen.Maximum    = 100;
            this.pbDoBen.Name       = "pbDoBen";
            this.pbDoBen.Size       = new System.Drawing.Size(330, 10);
            this.pbDoBen.TabIndex   = 11;
            this.pbDoBen.Value      = 0;

            // ── Xac nhan ──────────────────────────────────────────
            this.lblXacNhan.AutoSize  = false;
            this.lblXacNhan.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblXacNhan.Location  = new System.Drawing.Point(24, 228);
            this.lblXacNhan.Name      = "lblXacNhan";
            this.lblXacNhan.Size      = new System.Drawing.Size(220, 20);
            this.lblXacNhan.TabIndex  = 12;
            this.lblXacNhan.Text      = "Xac nhan mat khau moi";

            this.txtXacNhan.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhan.Font         = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtXacNhan.Location     = new System.Drawing.Point(24, 251);
            this.txtXacNhan.Name         = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size         = new System.Drawing.Size(330, 28);
            this.txtXacNhan.TabIndex     = 4;

            this.chkHienXacNhan.AutoSize  = false;
            this.chkHienXacNhan.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkHienXacNhan.ForeColor = System.Drawing.Color.Gray;
            this.chkHienXacNhan.Location  = new System.Drawing.Point(362, 255);
            this.chkHienXacNhan.Name      = "chkHienXacNhan";
            this.chkHienXacNhan.Size      = new System.Drawing.Size(72, 20);
            this.chkHienXacNhan.TabIndex  = 5;
            this.chkHienXacNhan.Text      = "Hien";
            this.chkHienXacNhan.UseVisualStyleBackColor = true;
            this.chkHienXacNhan.CheckedChanged += new System.EventHandler(this.chkHienXacNhan_CheckedChanged);

            // ── pnlYeuCau ─────────────────────────────────────────
            this.pnlYeuCau.BackColor   = System.Drawing.Color.FromArgb(236, 242, 255);
            this.pnlYeuCau.Controls.Add(this.lblYeuCau);
            this.pnlYeuCau.Location    = new System.Drawing.Point(24, 292);
            this.pnlYeuCau.Name        = "pnlYeuCau";
            this.pnlYeuCau.Size        = new System.Drawing.Size(430, 58);
            this.pnlYeuCau.TabIndex    = 16;

            this.lblYeuCau.AutoSize  = false;
            this.lblYeuCau.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblYeuCau.ForeColor = System.Drawing.Color.FromArgb(60, 100, 180);
            this.lblYeuCau.Location  = new System.Drawing.Point(8, 6);
            this.lblYeuCau.Name      = "lblYeuCau";
            this.lblYeuCau.Size      = new System.Drawing.Size(414, 46);
            this.lblYeuCau.TabIndex  = 0;
            this.lblYeuCau.Text      = "* Toi thieu 8 ky tu\r\n* Co chu hoa, chu thuong va so hoac ky tu dac biet";

            // lblThongBao
            this.lblThongBao.AutoSize  = false;
            this.lblThongBao.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location  = new System.Drawing.Point(24, 358);
            this.lblThongBao.Name      = "lblThongBao";
            this.lblThongBao.Size      = new System.Drawing.Size(430, 38);
            this.lblThongBao.TabIndex  = 17;
            this.lblThongBao.Text      = "";

            // btnLuu
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(22, 55, 100);
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location  = new System.Drawing.Point(24, 404);
            this.btnLuu.Name      = "btnLuu";
            this.btnLuu.Size      = new System.Drawing.Size(200, 36);
            this.btnLuu.TabIndex  = 6;
            this.btnLuu.Text      = "Luu Mat Khau Moi";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click    += new System.EventHandler(this.btnLuu_Click);

            // btnHuy
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnHuy.Location  = new System.Drawing.Point(234, 404);
            this.btnHuy.Name      = "btnHuy";
            this.btnHuy.Size      = new System.Drawing.Size(110, 36);
            this.btnHuy.TabIndex  = 7;
            this.btnHuy.Text      = "Huy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click    += new System.EventHandler(this.btnHuy_Click);

            // ── frmDoiMatKhau ─────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "frmDoiMatKhau";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Doi Mat Khau";

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlYeuCau.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel        pnlHeader;
        private System.Windows.Forms.Label        lblTieuDe;
        private System.Windows.Forms.Label        lblMoTa;
        private System.Windows.Forms.Panel        pnlBody;
        private System.Windows.Forms.Label        lblNguoiDung;
        private System.Windows.Forms.Label        lblNguoiDungGiaTri;
        private System.Windows.Forms.Panel        pnlSepAcc;
        private System.Windows.Forms.Label        lblMatKhauCu;
        private System.Windows.Forms.TextBox      txtMatKhauCu;
        private System.Windows.Forms.CheckBox     chkHienCu;
        private System.Windows.Forms.Label        lblMatKhauMoi;
        private System.Windows.Forms.TextBox      txtMatKhauMoi;
        private System.Windows.Forms.CheckBox     chkHienMoi;
        private System.Windows.Forms.Label        lblDoBenTitle;
        private System.Windows.Forms.ProgressBar  pbDoBen;
        private System.Windows.Forms.Label        lblDoBenText;
        private System.Windows.Forms.Label        lblXacNhan;
        private System.Windows.Forms.TextBox      txtXacNhan;
        private System.Windows.Forms.CheckBox     chkHienXacNhan;
        private System.Windows.Forms.Panel        pnlYeuCau;
        private System.Windows.Forms.Label        lblYeuCau;
        private System.Windows.Forms.Label        lblThongBao;
        private System.Windows.Forms.Button       btnLuu;
        private System.Windows.Forms.Button       btnHuy;
    }
}
