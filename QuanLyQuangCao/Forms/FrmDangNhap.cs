using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QLQC.Class;

namespace QLQC.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            // Thiết lập bo góc tròn cho Form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Kết nối DB lúc load
            try
            {
                Functions.Ketnot();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Lỗi kết nối CSDL: " + ex.Message;
            }

            // Custom border styles và effects cho TextBox lúc focus
            SetupTextBoxEffects(txtTenDangNhap);
            SetupTextBoxEffects(txtMatKhau);

            // Nút Thoát viền nhạt nhẽo cao cấp
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnThoat.FlatAppearance.BorderSize = 1;
            btnThoat.MouseEnter += (s, ev) => { btnThoat.BackColor = Color.FromArgb(243, 244, 246); btnThoat.ForeColor = Color.FromArgb(17, 24, 39); };
            btnThoat.MouseLeave += (s, ev) => { btnThoat.BackColor = Color.White; btnThoat.ForeColor = Color.FromArgb(107, 114, 128); };

            // Nút Đăng nhập hover
            btnDangNhap.MouseEnter += (s, ev) => btnDangNhap.BackColor = Color.FromArgb(21, 101, 192);
            btnDangNhap.MouseLeave += (s, ev) => btnDangNhap.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void SetupTextBoxEffects(TextBox tb)
        {
            tb.GotFocus += (s, ev) =>
            {
                tb.BackColor = Color.FromArgb(239, 246, 255); // Xanh dương cực nhạt lúc chọn
            };
            tb.LostFocus += (s, ev) =>
            {
                tb.BackColor = Color.FromArgb(249, 250, 251);
            };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblMessage.Text = "Vui lòng nhập tên đăng nhập!";
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Vui lòng nhập mật khẩu!";
                txtMatKhau.Focus();
                return;
            }

            try
            {
                string sql = $"SELECT TenDangNhap, MatKhau, HoTen, VaiTro, TrangThaiHoatDong FROM NGUOI_DUNG WHERE TenDangNhap = '{username.Replace("'", "''")}'";
                DataTable dt = Functions.GetDataToTable(sql);

                if (dt.Rows.Count == 0)
                {
                    lblMessage.Text = "Tài khoản không tồn tại!";
                    txtTenDangNhap.Focus();
                    return;
                }

                DataRow row = dt.Rows[0];
                string dbPass = row["MatKhau"].ToString();
                bool active = Convert.ToBoolean(row["TrangThaiHoatDong"] == DBNull.Value ? true : row["TrangThaiHoatDong"]);

                if (dbPass != password)
                {
                    lblMessage.Text = "Mật khẩu không chính xác!";
                    txtMatKhau.Focus();
                    return;
                }

                if (!active)
                {
                    lblMessage.Text = "Tài khoản của bạn đã bị khóa!";
                    return;
                }

                // Lưu Session thành công
                Session.TenDangNhap = row["TenDangNhap"].ToString();
                Session.HoTen = row["HoTen"].ToString();
                Session.VaiTro = row["VaiTro"].ToString();

                lblMessage.ForeColor = Color.FromArgb(22, 163, 74);
                lblMessage.Text = "Đăng nhập thành công! Đang chuyển hướng...";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Lỗi xác thực: " + ex.Message;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Vẽ viền cho form bo góc
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.FromArgb(13, 71, 161), 2f))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // Vẽ viền quanh form bo tròn góc
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
