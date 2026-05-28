using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AuthForms.BLL;

namespace AuthForms.UI
{
    /// <summary>
    /// frmDoiMatKhau — Đổi mật khẩu.
    ///   Mức tốt: sinh salt mới (PBKDF2), kiểm tra độ bền mật khẩu,
    ///            thanh đo độ bền, hiện/ẩn mật khẩu.
    ///            Hỗ trợ chế độ bắt buộc (tài khoản legacy).
    /// </summary>
    public partial class frmDoiMatKhau : Form
    {
        private readonly bool _batBuoc;

        public frmDoiMatKhau() : this(false) { }

        public frmDoiMatKhau(bool batBuoc)
        {
            _batBuoc = batBuoc;
            InitializeComponent();
            HienThiThongTinNguoiDung();

            if (_batBuoc)
            {
                btnHuy.Text     = "Đăng Xuất";
                this.Text       = "Yêu Cầu Đổi Mật Khẩu";
                lblMoTa.Text    = "Tài khoản cũ — vui lòng đặt mật khẩu mới có bảo mật cao hơn";
                this.ControlBox = false;
            }
        }

        private void HienThiThongTinNguoiDung()
        {
            if (Session.DaDangNhap)
                lblNguoiDungGiaTri.Text =
                    $"{Session.NguoiDungHienTai.HoTen}  ({Session.NguoiDungHienTai.TenDangNhap})  —  {Session.NguoiDungHienTai.VaiTro}";
        }

        // ── Hiện/ẩn mật khẩu ─────────────────────────────────────
        private void chkHienCu_CheckedChanged(object sender, EventArgs e)
            => txtMatKhauCu.PasswordChar = chkHienCu.Checked ? '\0' : '*';

        private void chkHienMoi_CheckedChanged(object sender, EventArgs e)
            => txtMatKhauMoi.PasswordChar = chkHienMoi.Checked ? '\0' : '*';

        private void chkHienXacNhan_CheckedChanged(object sender, EventArgs e)
            => txtXacNhan.PasswordChar = chkHienXacNhan.Checked ? '\0' : '*';

        // ── Thanh đo độ bền mật khẩu ─────────────────────────────
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            string mk   = txtMatKhauMoi.Text;
            int    diem = TinhDiem(mk);
            pbDoBen.Value = Math.Min(diem, 100);

            if (diem == 0)
            {
                lblDoBenText.Text      = "";
                lblDoBenText.ForeColor = Color.Gray;
            }
            else if (diem < 40)
            {
                lblDoBenText.Text      = "Yếu";
                lblDoBenText.ForeColor = Color.Crimson;
            }
            else if (diem < 70)
            {
                lblDoBenText.Text      = "Trung bình";
                lblDoBenText.ForeColor = Color.Orange;
            }
            else if (diem < 90)
            {
                lblDoBenText.Text      = "Mạnh";
                lblDoBenText.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblDoBenText.Text      = "Rất mạnh";
                lblDoBenText.ForeColor = Color.FromArgb(0, 120, 60);
            }
        }

        private static int TinhDiem(string mk)
        {
            if (string.IsNullOrEmpty(mk)) return 0;
            int d = 0;
            if (mk.Length >= 8)  d += 20;
            if (mk.Length >= 12) d += 10;
            if (mk.Length >= 16) d += 10;
            if (Regex.IsMatch(mk, "[A-Z]")) d += 15;
            if (Regex.IsMatch(mk, "[a-z]")) d += 15;
            if (Regex.IsMatch(mk, "[0-9]")) d += 15;
            if (Regex.IsMatch(mk, @"[^a-zA-Z0-9]")) d += 15;
            return d;
        }

        private static string KiemTraDoBen(string mk)
        {
            if (mk.Length < 8) return "Mật khẩu phải có ít nhất 8 ký tự.";
            if (!Regex.IsMatch(mk, "[A-Z]") || !Regex.IsMatch(mk, "[a-z]"))
                return "Phải có cả chữ hoa và chữ thường.";
            if (!Regex.IsMatch(mk, "[0-9]") && !Regex.IsMatch(mk, @"[^a-zA-Z0-9]"))
                return "Phải có ít nhất 1 chữ số hoặc ký tự đặc biệt.";
            return null;
        }

        // ── Lưu mật khẩu ─────────────────────────────────────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";

            if (!Session.DaDangNhap)
            { HienLoi("Phiên đăng nhập đã hết hạn."); return; }

            string cu      = txtMatKhauCu.Text;
            string moi     = txtMatKhauMoi.Text;
            string xacNhan = txtXacNhan.Text;

            if (string.IsNullOrEmpty(cu))      { HienLoi("Nhập mật khẩu hiện tại."); txtMatKhauCu.Focus(); return; }
            if (string.IsNullOrEmpty(moi))     { HienLoi("Nhập mật khẩu mới."); txtMatKhauMoi.Focus(); return; }

            string err = KiemTraDoBen(moi);
            if (err != null)                   { HienLoi(err); txtMatKhauMoi.Focus(); return; }
            if (moi != xacNhan)                { HienLoi("Mật khẩu xác nhận không khớp."); txtXacNhan.Focus(); return; }
            if (cu == moi)                     { HienLoi("Mật khẩu mới phải khác mật khẩu cũ."); txtMatKhauMoi.Focus(); return; }

            try
            {
                var (ok, error) = NguoiDungBLL.DoiMatKhau(
                    Session.NguoiDungHienTai.MaNguoiDung, cu, moi);

                if (!ok) { HienLoi(error); return; }

                MessageBox.Show(
                    "Mật khẩu đã được cập nhật thành công!\n" +
                    (_batBuoc ? "Bạn sẽ được chuyển vào hệ thống." : "Vui lòng đăng nhập lại."),
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!_batBuoc) Session.DangXuat();
                this.Close();
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (_batBuoc)
            {
                if (MessageBox.Show("Bạn chưa đổi mật khẩu. Nhấn OK để đăng xuất.",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Session.DangXuat();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void HienLoi(string msg)
        {
            lblThongBao.ForeColor = Color.Crimson;
            lblThongBao.Text = msg;
        }
    }
}
