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
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.Forms
{
    public partial class frmThemSuaNguoiDung : Form
    {
        private readonly NguoiDungBLL _bll = new NguoiDungBLL();
        private readonly int? _maNguoiDung; // null = thêm mới, có giá trị = sửa
        public frmThemSuaNguoiDung(int? maNguoiDung)
        {
            InitializeComponent();
            _maNguoiDung = maNguoiDung;
            ThietLapGiaoDien();
        }

        private void frmThemSuaNguoiDung_Load(object sender, EventArgs e)
        {
            // Nạp danh sách Vai trò vào ComboBox
            cboVaiTro.Items.AddRange(new[] { "Admin", "Marketing", "VietBai", "QuanLy" });
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_maNguoiDung.HasValue)
            {
                // Chế độ SỬA: tải dữ liệu lên form
                this.Text = "Sửa thông tin tài khoản";
                NapDuLieuLenForm();
                lblMatKhau.Text = "Mật khẩu mới (bỏ trống = không đổi):";
            }
            else
            {
                // Chế độ THÊM
                this.Text = "Thêm tài khoản mới";
            }
        }
        private void NapDuLieuLenForm()
        {
            // Lấy dữ liệu từ DB thông qua BLL (dùng GetDanhSach lọc theo mã)
            var dt = _bll.GetDanhSach("");
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["MaNguoiDung"]) == _maNguoiDung.Value)
                {
                    txtTenDangNhap.Text = row["TenDangNhap"].ToString();
                    txtTenDangNhap.ReadOnly = true; // Không cho sửa tên đăng nhập
                    txtHoTen.Text = row["HoTen"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtSoDienThoai.Text = row["SoDienThoai"].ToString();
                    cboVaiTro.SelectedItem = row["VaiTro"].ToString();
                    break;
                }
            }
        }

        // ── Nút Lưu ──────────────────────────────────────────────────────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDungModel nd = new NguoiDungModel
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                VaiTro = cboVaiTro.SelectedItem?.ToString() ?? ""
            };

            bool ok;
            string thongBao;

            if (!_maNguoiDung.HasValue)
            {
                // Thêm mới
                nd.MatKhau = txtMatKhau.Text;
                ok = _bll.ThemNguoiDung(nd, out thongBao);
            }
            else
            {
                // Sửa
                nd.MaNguoiDung = _maNguoiDung.Value;
                ok = _bll.SuaNguoiDung(nd, txtMatKhau.Text, out thongBao);
            }

            if (!ok)
            {
                MessageBox.Show(thongBao, "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Lưu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Báo cho form cha biết để tải lại DGV
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void ThietLapGiaoDien()
        {
            Color mauChu = Color.FromArgb(26, 58, 92);

            pnlHeader.BackColor = mauChu;
            btnLuu.BackColor = mauChu;
            btnLuu.ForeColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;

            btnHuy.BackColor = Color.FromArgb(189, 195, 199);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.FlatAppearance.BorderSize = 0;

            this.AcceptButton = btnLuu;
            this.CancelButton = btnHuy;
        }
    }
}
