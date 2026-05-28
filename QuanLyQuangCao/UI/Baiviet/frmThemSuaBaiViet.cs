// =========================== frmThemSuaBaiViet.cs ===========================
using System;
using System.Windows.Forms;
using QuanLyQuangCao.BLL;

namespace QuanLyQuangCao.UI.Baiviet
{
    public partial class frmThemSuaBaiViet : Form
    {
        BaiVietBLL bll = new BaiVietBLL();

        public frmThemSuaBaiViet()
        {
            InitializeComponent();
        }

        private void frmThemSuaBaiViet_Load(object sender, EventArgs e)
        {
            LoadHopDong();
            LoadTheLoai();
            LoadNhanVien();

            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadHopDong()
        {
            cboHopDong.DataSource = bll.LayHopDong();
            cboHopDong.DisplayMember = "TenHopDong";
            cboHopDong.ValueMember = "MaHopDong";
        }

        private void LoadTheLoai()
        {
            cboTheLoai.DataSource = bll.LayTheLoai();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }

        private void LoadNhanVien()
        {
            cboNhanVien.DataSource = bll.LayNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNguoiDung";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTieuDe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề!");
                txtTieuDe.Focus();
                return;
            }

            bool result = bll.ThemBaiViet(
                txtTieuDe.Text.Trim(),
                cboTrangThai.Text,
                txtNoiDung.Text,
                txtGhiChu.Text,
                dtpNgayNop.Value,
                dtpNgayDuyet.Value,
                dtpNgayDang.Value,
                Convert.ToInt32(cboTheLoai.SelectedValue),
                Convert.ToInt32(cboHopDong.SelectedValue),
                Convert.ToInt32(cboNhanVien.SelectedValue)
            );

            if (result)
            {
                MessageBox.Show("Thêm bài viết thành công!");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void ClearForm()
        {
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            txtGhiChu.Clear();

            cboTrangThai.SelectedIndex = 0;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Word|*.docx|PDF|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanFile.Text = ofd.FileName;
                lnkFileHienTai.Text = ofd.SafeFileName;
            }
        }
    }
}