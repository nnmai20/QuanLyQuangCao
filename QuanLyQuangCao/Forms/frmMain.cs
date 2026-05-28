using QuanLyQuangCao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuangCao.Forms
{
    public partial class frmMain : Form
    {
        // Thông tin người dùng đang đăng nhập (truyền vào từ Program.cs)
        public NguoiDungModel NguoiDungHienTai { get; set; }

        private Form _formConHienTai; // Giữ tham chiếu form con đang nhúng
        public frmMain()
        {
            InitializeComponent();
            ThietLapGiaoDien();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            // Hiển thị tên và chức vụ
            lblNguoiDung.Text = $"{NguoiDungHienTai.HoTen}  |  {NguoiDungHienTai.VaiTro}";

            // Phân quyền: ẩn/hiện menu theo vai trò
            PhanQuyenMenu();

            // Mở dashboard mặc định
            MoFormCon(new frmDashboard());
        }

        // ── Phân quyền hiển thị menu ─────────────────────────────────────────
        private void PhanQuyenMenu()
        {
            bool laAdmin = NguoiDungHienTai.VaiTro == "Admin";
            bool laMarketing = NguoiDungHienTai.VaiTro == "Marketing";

            // Quản lý người dùng: chỉ Admin
            btnNguoiDung.Visible = laAdmin;

            // Báo cáo thống kê: chỉ Admin
            btnBaoCao.Visible = laAdmin;

            // Hợp đồng & bài viết: Admin + Marketing + QuanLy
            btnHopDong.Visible = laAdmin || laMarketing || NguoiDungHienTai.VaiTro == "QuanLy";
            btnBaiViet.Visible = true; // Tất cả xem được
            btnKhachHang.Visible = laAdmin || laMarketing;
            btnDonViPhatHanh.Visible = laAdmin || laMarketing;
        }

        // ── Nhúng form con vào pnlContent ────────────────────────────────────
        /// <summary>
        /// Đây là hàm cốt lõi: Dispose form cũ → gán form mới → Fill vào panel.
        /// </summary>
        private void MoFormCon(Form formMoi)
        {
            // 1. Giải phóng form con cũ để tránh rò bộ nhớ
            if (_formConHienTai != null && !_formConHienTai.IsDisposed)
            {
                _formConHienTai.Close();
                _formConHienTai.Dispose();
            }

            // 2. Cấu hình form mới để nhúng vào panel
            formMoi.TopLevel = false;   // Không cho là cửa sổ độc lập
            formMoi.FormBorderStyle = FormBorderStyle.None; // Ẩn border
            formMoi.Dock = DockStyle.Fill;       // Lấp đầy panel

            // 3. Truyền thông tin người dùng vào form con (nếu form con cần)
            if (formMoi is IFormCon formCon)
                formCon.NhanThongTinNguoiDung(NguoiDungHienTai);

            // 4. Thêm vào panel và hiển thị
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(formMoi);
            formMoi.Show();
            formMoi.BringToFront();

            _formConHienTai = formMoi;
        }

        // ── Sự kiện các nút Sidebar ───────────────────────────────────────────
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmDashboard());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNguoiDung());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Đóng frmMain, quay lại Program.cs để mở lại frmLogin
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        // ── Thiết lập giao diện ───────────────────────────────────────────────
        private void ThietLapGiaoDien()
        {
            Color mauHeader = Color.FromArgb(26, 58, 92);
            Color mauSidebar = Color.FromArgb(20, 45, 72);

            pnlHeader.BackColor = mauHeader;
            pnlSidebar.BackColor = mauSidebar;

            // Thiết lập style chung cho tất cả nút sidebar
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = mauSidebar;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 82, 128);
                    btn.Cursor = Cursors.Hand;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(15, 0, 0, 0);
                    btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                    btn.Height = 45;
                }
            }
        }
    }
    // Interface để frmMain truyền thông tin người dùng vào form con (nếu cần)
    public interface IFormCon
    {
        void NhanThongTinNguoiDung(NguoiDungModel nd);
    }
}
