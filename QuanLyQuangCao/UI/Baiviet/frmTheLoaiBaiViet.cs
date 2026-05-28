
using System;
using System.Windows.Forms;
using QuanLyQuangCao.BLL;
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.UI.Baiviet
{
    public partial class frmTheLoaiBaiViet : Form
    {
        TheLoaiBLL bll = new TheLoaiBLL();

        public frmTheLoaiBaiViet()
        {
            InitializeComponent();
        }

        private void frmTheLoaiBaiViet_Load(
            object sender,
            EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dgvTheLoai.DataSource = bll.GetAll();
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            TheLoaiBaiViet tl =
                new TheLoaiBaiViet();

            tl.TenTheLoai =
                txtTenTheLoai.Text;

            // THÊM MÔ TẢ
            tl.MoTa =
                txtMoTa.Text;

            bool kq = bll.Insert(tl);

            if (kq)
            {
                MessageBox.Show(
                    "Thêm thành công");

                LoadData();

                txtTenTheLoai.Clear();
                txtMoTa.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Dữ liệu không hợp lệ");
            }
        }

        private void dgvTheLoai_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaTheLoai.Text =
                    dgvTheLoai.Rows[e.RowIndex]
                    .Cells["MaTheLoai"]
                    .Value.ToString();

                txtTenTheLoai.Text =
                    dgvTheLoai.Rows[e.RowIndex]
                    .Cells["TenTheLoai"]
                    .Value.ToString();

                // HIỆN MÔ TẢ
                txtMoTa.Text =
                    dgvTheLoai.Rows[e.RowIndex]
                    .Cells["MoTa"]
                    .Value.ToString();
            }
        }

        private void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null)
            {
                MessageBox.Show(
                    "Chọn dữ liệu");

                return;
            }

            TheLoaiBaiViet tl =
                new TheLoaiBaiViet();

            tl.MaTheLoai =
                Convert.ToInt32(
                    dgvTheLoai.CurrentRow
                    .Cells["MaTheLoai"]
                    .Value);

            tl.TenTheLoai =
                txtTenTheLoai.Text;

            // THÊM MÔ TẢ
            tl.MoTa =
                txtMoTa.Text;

            bool kq = bll.Update(tl);

            if (kq)
            {
                MessageBox.Show(
                    "Sửa thành công");

                LoadData();
            }
            else
            {
                MessageBox.Show(
                    "Sửa thất bại");
            }
        }

        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null)
            {
                MessageBox.Show(
                    "Chọn dữ liệu");

                return;
            }

            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                int ma =
                    Convert.ToInt32(
                        dgvTheLoai.CurrentRow
                        .Cells["MaTheLoai"]
                        .Value);

                bool kq = bll.Delete(ma);

                if (kq)
                {
                    MessageBox.Show(
                        "Xóa thành công");

                    LoadData();
                }
                else
                {
                    MessageBox.Show(
                        "Xóa thất bại");
                }
            }
        }

        private void btnTimKiem_Click(
            object sender,
            EventArgs e)
        {
            dgvTheLoai.DataSource =
                bll.Search(txtTimKiem.Text);
        }

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            txtMaTheLoai.Text = "(Tự sinh)";

            txtTenTheLoai.Clear();

            txtMoTa.Clear();

            txtTimKiem.Clear();

            LoadData();
        }

        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}

