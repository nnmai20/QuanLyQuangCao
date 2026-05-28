using System;
using System.Drawing;
using System.Windows.Forms;
using AuthForms.BLL;

namespace AuthForms.UI
{
    /// <summary>
    /// frmQuenMatKhau — Màn hình quên mật khẩu.
    ///   Bước 1: Nhập tên đăng nhập + email để xác minh danh tính.
    ///   Bước 2: Nhập mật khẩu mới (có kiểm tra độ mạnh).
    /// </summary>
    public partial class frmQuenMatKhau : Form
    {
        private int _maNguoiDung = -1;
        private bool _buoc2 = false;

        public frmQuenMatKhau()
        {
            InitializeComponent();
            VeIcon();
        }

        private void VeIcon()
        {
            var bmp = new System.Drawing.Bitmap(74, 74);
            using (var g = System.Drawing.Graphics.FromImage(bmp))
            {
                g.Clear(System.Drawing.Color.FromArgb(40, 90, 160));
                using (var f = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold))
                using (var b = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                {
                    var sf = new System.Drawing.StringFormat
                    {
                        Alignment = System.Drawing.StringAlignment.Center,
                        LineAlignment = System.Drawing.StringAlignment.Center
                    };
                    g.DrawString("QC", f, b, new System.Drawing.RectangleF(0, 0, 74, 74), sf);
                }
            }
            picLogo.Image = bmp;
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        // ============================================================
        //  Bước 1 — Xác minh tên đăng nhập + email
        // ============================================================
        private void btnXacMinh_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            string tenDN = txtTenDangNhap.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenDN))
            { HienThiLoi("Vui lòng nhập tên đăng nhập."); txtTenDangNhap.Focus(); return; }
            if (string.IsNullOrEmpty(email))
            { HienThiLoi("Vui lòng nhập địa chỉ email."); txtEmail.Focus(); return; }

            try
            {
                var (ok, maNguoiDung) = NguoiDungBLL.XacMinhNguoiDung(tenDN, email);
                if (!ok)
                {
                    HienThiLoi("Tên đăng nhập hoặc email không khớp.\nVui lòng kiểm tra lại.");
                    return;
                }

                _maNguoiDung = maNguoiDung;
                ChuyenSangBuoc2();
            }
            catch (Exception ex)
            {
                HienThiLoi("Lỗi kết nối CSDL:\n" + ex.Message);
            }
        }

        // ============================================================
        //  Bước 2 — Đặt mật khẩu mới
        // ============================================================
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhan   = txtXacNhanMatKhau.Text;

            if (string.IsNullOrEmpty(matKhauMoi))
            { HienThiLoi("Vui lòng nhập mật khẩu mới."); txtMatKhauMoi.Focus(); return; }

            string loi = KiemTraDoManhMatKhau(matKhauMoi);
            if (loi != null) { HienThiLoi(loi); txtMatKhauMoi.Focus(); return; }

            if (matKhauMoi != xacNhan)
            { HienThiLoi("Mật khẩu xác nhận không khớp."); txtXacNhanMatKhau.Focus(); return; }

            try
            {
                NguoiDungBLL.DatLaiMatKhau(_maNguoiDung, matKhauMoi);
                MessageBox.Show(
                    "Mật khẩu đã được đặt lại thành công!\nVui lòng đăng nhập với mật khẩu mới.",
                    "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                HienThiLoi("Lỗi khi cập nhật mật khẩu:\n" + ex.Message);
            }
        }

        // ============================================================
        //  Chuyển giao diện sang bước 2
        // ============================================================
        private void ChuyenSangBuoc2()
        {
            _buoc2 = true;

            // Ẩn bước 1
            pnlBuoc1.Visible = false;

            // Hiện bước 2
            pnlBuoc2.Visible = true;

            // Cập nhật tiêu đề
            lblTitle.Text    = "Đặt mật khẩu mới";
            lblSubTitle.Text = "Tài khoản đã xác minh. Nhập mật khẩu mới.";
            lblSubTitle.ForeColor = Color.SeaGreen;

            // Cập nhật bước chỉ báo
            lblBuoc1Chi.ForeColor = Color.LightGray;
            lblBuoc2Chi.ForeColor = Color.White;
            pnlBuoc1Chi.BackColor = Color.FromArgb(100, 130, 170);
            pnlBuoc2Chi.BackColor = Color.White;
            lblSoBuoc2.ForeColor  = Color.FromArgb(22, 55, 100);

            txtMatKhauMoi.Focus();
        }

        // ============================================================
        //  Kiểm tra độ mạnh mật khẩu
        // ============================================================
        private string KiemTraDoManhMatKhau(string mk)
        {
            if (mk.Length < 8)
                return "Mật khẩu phải có ít nhất 8 ký tự.";
            bool coHoa   = false, coThuong = false, coSo = false, coDacBiet = false;
            foreach (char c in mk)
            {
                if (char.IsUpper(c))   coHoa = true;
                if (char.IsLower(c))   coThuong = true;
                if (char.IsDigit(c))   coSo = true;
                if (!char.IsLetterOrDigit(c)) coDacBiet = true;
            }
            if (!coHoa)     return "Mật khẩu phải có ít nhất 1 chữ hoa.";
            if (!coThuong)  return "Mật khẩu phải có ít nhất 1 chữ thường.";
            if (!coSo && !coDacBiet) return "Mật khẩu phải có ít nhất 1 số hoặc ký tự đặc biệt.";
            return null;
        }

        // ============================================================
        //  Cập nhật thanh độ mạnh mật khẩu
        // ============================================================
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            string mk = txtMatKhauMoi.Text;
            int diem = 0;
            if (mk.Length >= 8) diem++;
            foreach (char c in mk)
            {
                if (char.IsUpper(c))           { diem++; break; }
            }
            foreach (char c in mk)
            {
                if (char.IsLower(c))           { diem++; break; }
            }
            foreach (char c in mk)
            {
                if (char.IsDigit(c))           { diem++; break; }
            }
            foreach (char c in mk)
            {
                if (!char.IsLetterOrDigit(c))  { diem++; break; }
            }

            pbDoManh.Value = Math.Min(diem * 20, 100);
            if (diem <= 2)      { pbDoManh.ForeColor = Color.Crimson;  lblDoManh.Text = "Yếu";   lblDoManh.ForeColor = Color.Crimson; }
            else if (diem <= 3) { pbDoManh.ForeColor = Color.Orange;   lblDoManh.Text = "Trung bình"; lblDoManh.ForeColor = Color.Orange; }
            else if (diem <= 4) { pbDoManh.ForeColor = Color.SteelBlue;lblDoManh.Text = "Khá";   lblDoManh.ForeColor = Color.SteelBlue; }
            else                { pbDoManh.ForeColor = Color.SeaGreen; lblDoManh.Text = "Mạnh";  lblDoManh.ForeColor = Color.SeaGreen; }
        }

        // ============================================================
        //  Hiện / ẩn mật khẩu
        // ============================================================
        private void chkHienMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            char c = chkHienMatKhauMoi.Checked ? '\0' : '●';
            txtMatKhauMoi.PasswordChar     = c;
            txtXacNhanMatKhau.PasswordChar = c;
        }

        // ============================================================
        //  Nút quay lại bước 1
        // ============================================================
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            _buoc2 = false;
            _maNguoiDung = -1;

            pnlBuoc2.Visible = false;
            pnlBuoc1.Visible = true;

            lblTitle.Text    = "Quên mật khẩu";
            lblSubTitle.Text = "Nhập thông tin tài khoản để xác minh.";
            lblSubTitle.ForeColor = Color.Gray;

            lblBuoc1Chi.ForeColor = Color.White;
            lblBuoc2Chi.ForeColor = Color.LightGray;
            pnlBuoc1Chi.BackColor = Color.White;
            pnlBuoc2Chi.BackColor = Color.FromArgb(100, 130, 170);
            lblSoBuoc1.ForeColor  = Color.FromArgb(22, 55, 100);
            lblSoBuoc2.ForeColor  = Color.White;

            lblThongBao.Text = "";
            txtMatKhauMoi.Clear();
            txtXacNhanMatKhau.Clear();
            pbDoManh.Value   = 0;
            lblDoManh.Text   = "";
        }

        // ============================================================
        //  Helper
        // ============================================================
        private void HienThiLoi(string msg)
        { lblThongBao.ForeColor = Color.Crimson; lblThongBao.Text = msg; }
    }
}
