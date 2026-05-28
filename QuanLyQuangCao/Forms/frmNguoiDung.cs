using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuangCao.BLL;

namespace QuanLyQuangCao.Forms
{
    public partial class frmNguoiDung : Form
    {
        private readonly NguoiDungBLL _bll = new NguoiDungBLL();
        public frmNguoiDung()
        {
            InitializeComponent();
            ThietLapGiaoDien();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            TaiDanhSach();
        }
        // ── Tải danh sách ─────────────────────────────────────────────────────
        private void TaiDanhSach()
        {
            DataTable dt = _bll.GetDanhSach(txtTimKiem.Text.Trim());
            dgvDanhSach.DataSource = dt;

            // Đặt tiêu đề cột tiếng Việt
            if (dgvDanhSach.Columns.Count > 0)
            {
                dgvDanhSach.Columns["MaNguoiDung"].HeaderText = "Mã";
                dgvDanhSach.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvDanhSach.Columns["HoTen"].HeaderText = "Họ tên";
                dgvDanhSach.Columns["Email"].HeaderText = "Email";
                dgvDanhSach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgvDanhSach.Columns["VaiTro"].HeaderText = "Vai trò";
                dgvDanhSach.Columns["TrangThaiHoatDong"].HeaderText = "Trạng thái";

                // Điều chỉnh độ rộng cột
                dgvDanhSach.Columns["MaNguoiDung"].Width = 50;
                dgvDanhSach.Columns["TenDangNhap"].Width = 130;
                dgvDanhSach.Columns["HoTen"].Width = 180;
                dgvDanhSach.Columns["Email"].Width = 180;
                dgvDanhSach.Columns["SoDienThoai"].Width = 110;
                dgvDanhSach.Columns["VaiTro"].Width = 110;
                dgvDanhSach.Columns["TrangThaiHoatDong"].Width = 90;
            }
        }

        // ── Tìm kiếm (tìm ngay khi gõ) ───────────────────────────────────────
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        // ── Nút Thêm ─────────────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemSuaNguoiDung frm = new frmThemSuaNguoiDung(null))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    TaiDanhSach(); // Tải lại DGV sau khi thêm thành công
            }
        }


        // ── Nút Sửa ──────────────────────────────────────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null) return;

            int ma = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaNguoiDung"].Value);

            using (frmThemSuaNguoiDung frm = new frmThemSuaNguoiDung(ma))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    TaiDanhSach();
            }
        }

        // ── Nút Khóa / Mở ────────────────────────────────────────────────────
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null) return;

            int ma = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaNguoiDung"].Value);
            int trangThai = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["TrangThaiHoatDong"].Value);
            string hanh = trangThai == 1 ? "khóa" : "mở";

            if (MessageBox.Show($"Bạn có chắc muốn {hanh} tài khoản này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string thongBao;
            bool ok = _bll.DoiTrangThai(ma, trangThai, out thongBao);

            if (ok)
            {
                MessageBox.Show($"Đã {hanh} tài khoản thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSach();
            }
            else
            {
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Nút Làm mới ──────────────────────────────────────────────────────
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDanhSach();
        }
        // ── Thiết lập giao diện ───────────────────────────────────────────────
        private void ThietLapGiaoDien()
        {
            Color mauChu = Color.FromArgb(26, 58, 92);

            pnlTop.BackColor = Color.White;

            // Style các nút hành động
            foreach (Control ctrl in pnlTop.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = mauChu;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Height = 34;
                }
            }

            // DataGridView style
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.BorderStyle = BorderStyle.None;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor = mauChu;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvDanhSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.Dock = DockStyle.Fill; // Responsive
        }
    }
}
