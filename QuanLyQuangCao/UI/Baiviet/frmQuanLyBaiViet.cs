using System;
using System.Data;
using System.Windows.Forms;
using QuanLyQuangCao.BLL;

namespace QuanLyQuangCao.UI.Baiviet
{
    public partial class frmQuanLyBaiViet : Form
    {
        BaiVietBLL bll = new BaiVietBLL();

        public frmQuanLyBaiViet()
        {
            InitializeComponent();
        }

        // =========================
        // LOAD FORM
        // =========================
        private void frmQuanLyBaiViet_Load(object sender, EventArgs e)
        {
            LoadDanhSachBaiViet();
        }

        // =========================
        // LOAD DANH SÁCH BÀI VIẾT
        // =========================
        private void LoadDanhSachBaiViet()
        {
            dgvBaiViet.AutoGenerateColumns = false;

            dgvBaiViet.DataSource =
                bll.LayDanhSachBaiViet();
        }
    }
}