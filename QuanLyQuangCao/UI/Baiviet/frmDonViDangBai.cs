using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyQuangCao.BLL;

namespace QuanLyQuangCao.UI.Baiviet
{
    public partial class frmDonViDangBai : Form
    {
        DonViDangBaiBLL bll = new DonViDangBaiBLL();

        public frmDonViDangBai()
        {
            InitializeComponent();

            LoadDonVi();

            txtThanhTien.ReadOnly = true;
            txtTongGiaTri.ReadOnly = true;

            txtSoKy.TextChanged += TinhThanhTien;
            txtDonGia.TextChanged += TinhThanhTien;

            btnThemDV.Click += BtnThemDV_Click;
            btnXoaDV.Click += BtnXoaDV_Click;
            btnBoQua.Click += BtnBoQua_Click;
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        // =========================
        // LOAD ĐƠN VỊ
        // =========================
        private void LoadDonVi()
        {
            DataTable dt = bll.LayDanhSachDonVi();

            cboDonVi.DataSource = dt;
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.ValueMember = "MaDonViDangBai";

            cboDonVi.SelectedIndex = -1;
        }

        // =========================
        // TÍNH THÀNH TIỀN
        // =========================
        private void TinhThanhTien(object sender, EventArgs e)
        {
            int soKy = 0;
            decimal donGia = 0;

            int.TryParse(txtSoKy.Text, out soKy);
            decimal.TryParse(txtDonGia.Text, out donGia);

            decimal thanhTien = soKy * donGia;

            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        // =========================
        // THÊM
        // =========================
        private void BtnThemDV_Click(object sender, EventArgs e)
        {
            if (cboDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị");
                return;
            }

            dgvDonVi.Rows.Add(
                cboDonVi.Text,
                dtpNgayPhatHanh.Value.ToShortDateString(),
                txtSoKy.Text,
                txtDonGia.Text,
                txtThanhTien.Text,
                txtGhiChu.Text
            );

            TinhTongTien();

            LamMoi();
        }

        // =========================
        // XÓA
        // =========================
        private void BtnXoaDV_Click(object sender, EventArgs e)
        {
            if (dgvDonVi.CurrentRow != null)
            {
                dgvDonVi.Rows.Remove(dgvDonVi.CurrentRow);

                TinhTongTien();
            }
        }

        // =========================
        // TÍNH TỔNG
        // =========================
        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvDonVi.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal tien = 0;

                    decimal.TryParse(
                        row.Cells[4].Value.ToString(),
                        NumberStyles.AllowThousands,
                        CultureInfo.CurrentCulture,
                        out tien
                    );

                    tong += tien;
                }
            }

            txtTongGiaTri.Text = tong.ToString("N0");
        }

        // =========================
        // LÀM MỚI
        // =========================
        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            cboDonVi.SelectedIndex = -1;

            txtSoKy.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtGhiChu.Clear();
        }

        // =========================
        // LƯU
        // =========================
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công!");
        }

        // =========================
        // ĐÓNG
        // =========================
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}