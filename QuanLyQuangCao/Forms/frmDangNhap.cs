using System;
using System.Drawing;
using System.Windows.Forms;
using AuthForms.BLL;
using AuthForms.Functions;

namespace AuthForms.UI
{
    /// <summary>
    /// frmDangNhap — Màn hình đăng nhập.
    ///   Mức cơ bản : xác thực tên + mật khẩu qua DB QuangCao.
    ///   Mức khá    : phân quyền, mở form theo vai trò.
    ///   Mức tốt    : PBKDF2 hash/salt; hỗ trợ tài khoản cũ legacy;
    ///                khoá 30 giây sau 5 lần sai; hiện/ẩn mật khẩu;
    ///                hiển thị banner màu theo vai trò sau đăng nhập.
    /// </summary>
    public partial class frmDangNhap : Form
    {
        private int _soLanSai = 0;
        private const int MAX_SAI = 5;
        private System.Windows.Forms.Timer _timerKhoa;
        private int _giayKhoa = 30;

        public frmDangNhap()
        {
            InitializeComponent();
            SetupEnterKey();
            SetupKhoaTimer();
            VeIcon();
        }

        // ============================================================
        //  Đăng nhập
        // ============================================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";

            string tenDN   = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tenDN))
            { HienThiLoi("Vui lòng nhập tên đăng nhập."); txtTenDangNhap.Focus(); return; }
            if (string.IsNullOrEmpty(matKhau))
            { HienThiLoi("Vui lòng nhập mật khẩu."); txtMatKhau.Focus(); return; }

            SetLoading(true);
            try
            {
                var (result, nd) = NguoiDungBLL.DangNhap(tenDN, matKhau);

                switch (result)
                {
                    case LoginResult.WrongCredentials:
                        _soLanSai++;
                        if (_soLanSai >= MAX_SAI) { KhoaTamThoi(); return; }
                        HienThiLoi($"Tên đăng nhập hoặc mật khẩu không đúng.\n(Còn {MAX_SAI - _soLanSai} lần thử)");
                        txtMatKhau.Clear(); txtMatKhau.Focus();
                        return;

                    case LoginResult.AccountDisabled:
                        HienThiLoi("Tài khoản đã bị vô hiệu hoá. Liên hệ quản trị viên.");
                        return;

                    case LoginResult.LegacyMustReset:
                        _soLanSai = 0;
                        Session.NguoiDungHienTai = nd;
                        MessageBox.Show(
                            "Tài khoản của bạn chưa được bảo mật.\n" +
                            "Vui lòng đặt lại mật khẩu mới ngay bây giờ.\n\n" +
                            "Mật khẩu mới phải có ít nhất 8 ký tự,\n" +
                            "bao gồm chữ hoa, chữ thường và số/ký tự đặc biệt.",
                            "Yêu cầu đổi mật khẩu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BatBuocDoiMatKhau();
                        return;

                    case LoginResult.Success:
                        _soLanSai = 0;
                        Session.NguoiDungHienTai = nd;
                        // [Mức tốt] Hiển thị thông báo role trước khi mở form
                        HienThiBannerRole(nd);
                        MoFormTheoVaiTro(nd);
                        this.Hide();
                        return;
                }
            }
            catch (Exception ex)
            {
                HienThiLoi("Lỗi kết nối CSDL:\n" + ex.Message);
            }
            finally
            {
                SetLoading(false);
            }
        }

        // ============================================================
        //  [Mức tốt] Hiển thị banner vai trò sau khi đăng nhập thành công
        // ============================================================
        private void HienThiBannerRole(NguoiDungInfo nd)
        {
            string roleHienThi;
            Color  mauRole;

            switch (nd.VaiTro?.ToLower())
            {
                case "admin":
                    roleHienThi = "Quản Trị Viên";
                    mauRole     = Color.FromArgb(180, 30, 30);
                    break;
                case "quanly":
                    roleHienThi = "Quản Lý";
                    mauRole     = Color.FromArgb(30, 120, 60);
                    break;
                default:
                    roleHienThi = "Nhân Viên";
                    mauRole     = Color.FromArgb(50, 100, 170);
                    break;
            }

            lblThongBao.ForeColor = mauRole;
            lblThongBao.Text      = $"✔ Đăng nhập thành công — {roleHienThi}: {nd.HoTen}";
        }

        // ============================================================
        //  [Mức khá + Tốt] Mở form theo vai trò — UI riêng từng role
        // ============================================================
        private void MoFormTheoVaiTro(NguoiDungInfo nd)
        {
            bool isAdmin = Session.CoQuyen("Admin");
            bool isQL    = Session.CoQuyen("QuanLy");

            // [Mức tốt] Tiêu đề & màu sắc khác nhau theo từng vai trò
            string tieuDe = isAdmin ? "Quản Trị Viên"
                          : isQL    ? "Quản Lý"
                                    : "Nhân Viên";

            var frm = new frmMain(roleTieuDe: tieuDe, showAdmin: isAdmin);
            frm.FormClosed += (s, ev) => this.Close();
            frm.Show();
        }

        // ============================================================
        //  Bắt buộc đổi mật khẩu (tài khoản legacy)
        // ============================================================
        private void BatBuocDoiMatKhau()
        {
            using (var frm = new frmDoiMatKhau(batBuoc: true))
            {
                frm.ShowDialog(this);

                if (!Session.DaDangNhap)
                {
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                    return;
                }

                MoFormTheoVaiTro(Session.NguoiDungHienTai);
                this.Hide();
            }
        }

        // ============================================================
        //  Khoá tạm thời
        // ============================================================
        private void KhoaTamThoi()
        {
            _giayKhoa = 30;
            btnDangNhap.Enabled    = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled     = false;
            _timerKhoa.Start();
            lblThongBao.ForeColor = Color.DarkOrange;
            lblThongBao.Text = $"Quá nhiều lần sai. Chờ {_giayKhoa}s.";
        }

        private void _timerKhoa_Tick(object sender, EventArgs e)
        {
            _giayKhoa--;
            lblThongBao.Text = $"Quá nhiều lần sai. Chờ {_giayKhoa}s.";
            if (_giayKhoa <= 0)
            {
                _timerKhoa.Stop();
                _soLanSai = 0;
                btnDangNhap.Enabled    = true;
                txtTenDangNhap.Enabled = true;
                txtMatKhau.Enabled     = true;
                lblThongBao.ForeColor  = Color.Crimson;
                lblThongBao.Text = "";
                txtTenDangNhap.Focus();
            }
        }

        // ============================================================
        //  Helpers
        // ============================================================
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
            => txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '●';

        // ============================================================
        //  Quên mật khẩu
        // ============================================================
        private void lnkQuenMatKhau_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new frmQuenMatKhau())
                frm.ShowDialog(this);
        }

        private void HienThiLoi(string msg)
        { lblThongBao.ForeColor = Color.Crimson; lblThongBao.Text = msg; }

        private void SetLoading(bool on)
        {
            pbLoading.Visible   = on;
            btnDangNhap.Enabled = !on;
            btnDangNhap.Text    = on ? "Đang xác thực..." : "ĐĂNG NHẬP";
        }

        private void SetupEnterKey()   => this.AcceptButton = btnDangNhap;

        private void SetupKhoaTimer()
        {
            _timerKhoa      = new System.Windows.Forms.Timer { Interval = 1000 };
            _timerKhoa.Tick += _timerKhoa_Tick;
        }

        private void VeIcon()
        {
            var bmp = new System.Drawing.Bitmap(70, 70);
            using (var g = System.Drawing.Graphics.FromImage(bmp))
            {
                g.Clear(System.Drawing.Color.FromArgb(40, 90, 160));
                using (var f = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold))
                using (var b = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                {
                    var sf = new System.Drawing.StringFormat
                    { Alignment = System.Drawing.StringAlignment.Center,
                      LineAlignment = System.Drawing.StringAlignment.Center };
                    g.DrawString("QC", f, b, new System.Drawing.RectangleF(0,0,70,70), sf);
                }
            }
            picLogo.Image    = bmp;
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
