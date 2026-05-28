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
    public partial class frmLogin : Form
    {
        private readonly NguoiDungBLL _bll = new NguoiDungBLL();

        // Thuộc tính để frmMain đọc thông tin người dùng sau khi đăng nhập thành công
        public NguoiDungModel NguoiDungHienTai { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
            ThietLapGiaoDien();
        }
        private void ThietLapGiaoDien()
        {
            // Thiết lập màu sắc chủ đạo
            Color mauChu = Color.FromArgb(26, 58, 92);
            pnlHeader.BackColor = mauChu;
            btnDangNhap.BackColor = mauChu;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.FlatAppearance.BorderSize = 0;

            // Cho phép nhấn Enter để đăng nhập
            this.AcceptButton = btnDangNhap;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongBao;
            NguoiDungModel nd = _bll.DangNhap(
                txtTenDangNhap.Text.Trim(),
                txtMatKhau.Text,
                out thongBao);

            if (nd == null)
            {
                MessageBox.Show(thongBao, "Đăng nhập thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            // Lưu thông tin người dùng và đóng form đăng nhập
            NguoiDungHienTai = nd;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
