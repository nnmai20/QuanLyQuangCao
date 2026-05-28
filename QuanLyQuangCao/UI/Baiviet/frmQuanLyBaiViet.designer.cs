using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuangCao.UI.Baiviet
{
    partial class frmQuanLyBaiViet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();

            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();

            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();

            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.dgvBaiViet = new System.Windows.Forms.DataGridView();

            this.colMaBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlAction = new System.Windows.Forms.Panel();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGanNhanVien = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.btnDonViDang = new System.Windows.Forms.Button();

            this.pnlGanNhanVien = new System.Windows.Forms.Panel();
            this.lblGanNV = new System.Windows.Forms.Label();
            this.cboNhanVienGan = new System.Windows.Forms.ComboBox();
            this.btnXacNhanGan = new System.Windows.Forms.Button();

            this.pnlCapNhatTT = new System.Windows.Forms.Panel();
            this.lblCapNhatTT = new System.Windows.Forms.Label();
            this.cboTrangThaiMoi = new System.Windows.Forms.ComboBox();
            this.btnXacNhanTT = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiViet)).BeginInit();
            this.pnlAction.SuspendLayout();
            this.pnlGanNhanVien.SuspendLayout();
            this.pnlCapNhatTT.SuspendLayout();

            this.SuspendLayout();

            // ==================================================
            // pnlHeader
            // ==================================================
            this.pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(1158, 60);

            // ==================================================
            // lblTitle
            // ==================================================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(20, 12);
            this.lblTitle.Text = "QUẢN LÝ BÀI VIẾT";

            // ==================================================
            // pnlFilter
            // ==================================================
            this.pnlFilter.BackColor = Color.FromArgb(236, 240, 241);
            this.pnlFilter.Location = new Point(0, 60);
            this.pnlFilter.Size = new Size(1146, 70);

            this.pnlFilter.Controls.Add(this.lblHopDong);
            this.pnlFilter.Controls.Add(this.cboHopDong);

            this.pnlFilter.Controls.Add(this.lblTrangThai);
            this.pnlFilter.Controls.Add(this.cboTrangThai);

            this.pnlFilter.Controls.Add(this.lblNhanVien);
            this.pnlFilter.Controls.Add(this.cboNhanVien);

            this.pnlFilter.Controls.Add(this.txtTimKiem);
            this.pnlFilter.Controls.Add(this.btnTimKiem);
            this.pnlFilter.Controls.Add(this.btnLamMoi);

            // ==================================================
            // lblHopDong
            // ==================================================
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblHopDong.Location = new Point(10, 25);
            this.lblHopDong.Text = "Hợp đồng:";

            // ==================================================
            // cboHopDong
            // ==================================================
            this.cboHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboHopDong.Font = new Font("Segoe UI", 9F);
            this.cboHopDong.Location = new Point(98, 21);
            this.cboHopDong.Size = new Size(171, 28);

            // ==================================================
            // lblTrangThai
            // ==================================================
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTrangThai.Location = new Point(280, 25);
            this.lblTrangThai.Text = "Trạng thái:";

            // ==================================================
            // cboTrangThai
            // ==================================================
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new Font("Segoe UI", 9F);
            this.cboTrangThai.Location = new Point(370, 22);
            this.cboTrangThai.Size = new Size(170, 28);

            // ==================================================
            // lblNhanVien
            // ==================================================
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNhanVien.Location = new Point(545, 25);
            this.lblNhanVien.Text = "Nhân viên:";

            // ==================================================
            // cboNhanVien
            // ==================================================
            this.cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new Font("Segoe UI", 9F);
            this.cboNhanVien.Location = new Point(635, 22);
            this.cboNhanVien.Size = new Size(160, 28);

            // ==================================================
            // txtTimKiem
            // ==================================================
            this.txtTimKiem.Font = new Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = Color.Gray;
            this.txtTimKiem.Location = new Point(801, 22);
            this.txtTimKiem.Size = new Size(188, 27);
            this.txtTimKiem.Text = "Tìm theo tiêu đề...";

            // ==================================================
            // btnTimKiem
            // ==================================================
            this.btnTimKiem.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.Location = new Point(995, 22);
            this.btnTimKiem.Size = new Size(68, 29);
            this.btnTimKiem.Text = "Tìm";

            // ==================================================
            // btnLamMoi
            // ==================================================
            this.btnLamMoi.BackColor = Color.FromArgb(149, 165, 166);
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Location = new Point(1078, 21);
            this.btnLamMoi.Size = new Size(65, 29);
            this.btnLamMoi.Text = "Reset";

            // ==================================================
            // dgvBaiViet
            // ==================================================
            this.dgvBaiViet.AllowUserToAddRows = false;
            this.dgvBaiViet.AllowUserToDeleteRows = false;

            dataGridViewCellStyle1.BackColor =
                Color.FromArgb(245, 249, 253);

            this.dgvBaiViet.AlternatingRowsDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvBaiViet.AutoGenerateColumns = false;

            this.dgvBaiViet.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvBaiViet.BackgroundColor = Color.White;
            this.dgvBaiViet.BorderStyle = BorderStyle.None;

            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                Color.FromArgb(41, 128, 185);

            dataGridViewCellStyle2.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dataGridViewCellStyle2.ForeColor = Color.White;

            this.dgvBaiViet.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle2;

            this.dgvBaiViet.EnableHeadersVisualStyles = false;

            this.dgvBaiViet.Location = new Point(0, 130);
            this.dgvBaiViet.MultiSelect = false;
            this.dgvBaiViet.ReadOnly = true;
            this.dgvBaiViet.RowHeadersVisible = false;
            this.dgvBaiViet.RowTemplate.Height = 30;
            this.dgvBaiViet.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvBaiViet.Size = new Size(1146, 412);

            // ==================================================
            // COLUMN MAP
            // ==================================================

            this.colMaBaiViet.DataPropertyName = "MaBaiViet";
            this.colMaBaiViet.HeaderText = "Mã BV";

            this.colTieuDe.DataPropertyName = "TieuDe";
            this.colTieuDe.HeaderText = "Tiêu đề bài viết";

            this.colTheLoai.DataPropertyName = "TheLoai";
            this.colTheLoai.HeaderText = "Thể loại";

            this.colNhanVien.DataPropertyName = "TenNhanVien";
            this.colNhanVien.HeaderText = "Nhân viên";

            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";

            this.colNgayNop.DataPropertyName = "NgayNop";
            this.colNgayNop.HeaderText = "Ngày nộp";

            this.colNgayDuyet.DataPropertyName = "NgayDuyet";
            this.colNgayDuyet.HeaderText = "Ngày duyệt";

            this.dgvBaiViet.Columns.AddRange(new DataGridViewColumn[]
            {
                this.colMaBaiViet,
                this.colTieuDe,
                this.colTheLoai,
                this.colNhanVien,
                this.colTrangThai,
                this.colNgayNop,
                this.colNgayDuyet
            });

            // ==================================================
            // pnlAction
            // ==================================================
            this.pnlAction.BackColor = Color.FromArgb(248, 249, 250);
            this.pnlAction.Location = new Point(0, 560);
            this.pnlAction.Size = new Size(1146, 55);

            this.pnlAction.Controls.Add(this.btnThem);
            this.pnlAction.Controls.Add(this.btnSua);
            this.pnlAction.Controls.Add(this.btnXoa);
            this.pnlAction.Controls.Add(this.btnGanNhanVien);
            this.pnlAction.Controls.Add(this.btnCapNhatTrangThai);
            this.pnlAction.Controls.Add(this.btnDonViDang);

            // ==================================================
            // BUTTONS
            // ==================================================
            this.btnThem.BackColor = Color.FromArgb(39, 174, 96);
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Location = new Point(15, 12);
            this.btnThem.Size = new Size(137, 32);
            this.btnThem.Text = "+ Thêm bài viết";

            this.btnSua.BackColor = Color.FromArgb(243, 156, 18);
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Location = new Point(196, 12);
            this.btnSua.Size = new Size(120, 32);
            this.btnSua.Text = "Sửa";

            this.btnXoa.BackColor = Color.FromArgb(192, 57, 43);
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Location = new Point(369, 12);
            this.btnXoa.Size = new Size(109, 32);
            this.btnXoa.Text = "Xóa";

            this.btnGanNhanVien.BackColor = Color.FromArgb(142, 68, 173);
            this.btnGanNhanVien.FlatStyle = FlatStyle.Flat;
            this.btnGanNhanVien.FlatAppearance.BorderSize = 0;
            this.btnGanNhanVien.ForeColor = Color.White;
            this.btnGanNhanVien.Location = new Point(516, 12);
            this.btnGanNhanVien.Size = new Size(161, 32);
            this.btnGanNhanVien.Text = "Gán nhân viên";

            this.btnCapNhatTrangThai.BackColor =
                Color.FromArgb(22, 160, 133);

            this.btnCapNhatTrangThai.FlatStyle = FlatStyle.Flat;
            this.btnCapNhatTrangThai.FlatAppearance.BorderSize = 0;
            this.btnCapNhatTrangThai.ForeColor = Color.White;
            this.btnCapNhatTrangThai.Location = new Point(722, 12);
            this.btnCapNhatTrangThai.Size = new Size(190, 32);
            this.btnCapNhatTrangThai.Text = "Cập nhật trạng thái";

            this.btnDonViDang.BackColor =
                Color.FromArgb(41, 128, 185);

            this.btnDonViDang.FlatStyle = FlatStyle.Flat;
            this.btnDonViDang.FlatAppearance.BorderSize = 0;
            this.btnDonViDang.ForeColor = Color.White;
            this.btnDonViDang.Location = new Point(955, 12);
            this.btnDonViDang.Size = new Size(160, 32);
            this.btnDonViDang.Text = "Đơn vị đăng bài";

            // ==================================================
            // pnlGanNhanVien
            // ==================================================
            this.pnlGanNhanVien.BackColor =
                Color.FromArgb(245, 245, 250);

            this.pnlGanNhanVien.BorderStyle =
                BorderStyle.FixedSingle;

            this.pnlGanNhanVien.Location = new Point(210, 615);
            this.pnlGanNhanVien.Size = new Size(520, 45);

            this.pnlGanNhanVien.Controls.Add(this.lblGanNV);
            this.pnlGanNhanVien.Controls.Add(this.cboNhanVienGan);
            this.pnlGanNhanVien.Controls.Add(this.btnXacNhanGan);

            this.lblGanNV.AutoSize = true;
            this.lblGanNV.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblGanNV.Location = new Point(3, 14);
            this.lblGanNV.Text = "Gán nhân viên:";

            this.cboNhanVienGan.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cboNhanVienGan.Location = new Point(135, 8);
            this.cboNhanVienGan.Size = new Size(160, 28);

            this.btnXacNhanGan.BackColor =
                Color.FromArgb(142, 68, 173);

            this.btnXacNhanGan.FlatStyle = FlatStyle.Flat;
            this.btnXacNhanGan.FlatAppearance.BorderSize = 0;
            this.btnXacNhanGan.ForeColor = Color.White;
            this.btnXacNhanGan.Location = new Point(328, 7);
            this.btnXacNhanGan.Size = new Size(138, 31);
            this.btnXacNhanGan.Text = "Xác nhận";

            // ==================================================
            // pnlCapNhatTT
            // ==================================================
            this.pnlCapNhatTT.BackColor =
                Color.FromArgb(240, 250, 245);

            this.pnlCapNhatTT.BorderStyle =
                BorderStyle.FixedSingle;

            this.pnlCapNhatTT.Location = new Point(740, 615);
            this.pnlCapNhatTT.Size = new Size(403, 45);

            this.pnlCapNhatTT.Controls.Add(this.lblCapNhatTT);
            this.pnlCapNhatTT.Controls.Add(this.cboTrangThaiMoi);
            this.pnlCapNhatTT.Controls.Add(this.btnXacNhanTT);

            this.lblCapNhatTT.AutoSize = true;
            this.lblCapNhatTT.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblCapNhatTT.Location = new Point(8, 13);
            this.lblCapNhatTT.Text = "Cập nhật trạng thái:";

            this.cboTrangThaiMoi.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cboTrangThaiMoi.Location = new Point(162, 9);
            this.cboTrangThaiMoi.Size = new Size(140, 28);

            this.btnXacNhanTT.BackColor =
                Color.FromArgb(22, 160, 133);

            this.btnXacNhanTT.FlatStyle = FlatStyle.Flat;
            this.btnXacNhanTT.FlatAppearance.BorderSize = 0;
            this.btnXacNhanTT.ForeColor = Color.White;
            this.btnXacNhanTT.Location = new Point(313, 6);
            this.btnXacNhanTT.Size = new Size(74, 31);
            this.btnXacNhanTT.Text = "Lưu";

            // ==================================================
            // FORM
            // ==================================================
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;

            this.BackColor = Color.White;

            this.ClientSize = new Size(1158, 670);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvBaiViet);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlGanNhanVien);
            this.Controls.Add(this.pnlCapNhatTT);

            this.Font = new Font("Segoe UI", 9F);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Name = "frmQuanLyBaiViet";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text = "Quản Lý Bài Viết";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvBaiViet)).EndInit();

            this.pnlAction.ResumeLayout(false);

            this.pnlGanNhanVien.ResumeLayout(false);
            this.pnlGanNhanVien.PerformLayout();

            this.pnlCapNhatTT.ResumeLayout(false);
            this.pnlCapNhatTT.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlFilter;

        private Label lblHopDong;
        private ComboBox cboHopDong;

        private Label lblTrangThai;
        private ComboBox cboTrangThai;

        private Label lblNhanVien;
        private ComboBox cboNhanVien;

        private TextBox txtTimKiem;

        private Button btnTimKiem;
        private Button btnLamMoi;

        private DataGridView dgvBaiViet;

        private DataGridViewTextBoxColumn colMaBaiViet;
        private DataGridViewTextBoxColumn colTieuDe;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colNgayNop;
        private DataGridViewTextBoxColumn colNgayDuyet;

        private Panel pnlAction;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnGanNhanVien;
        private Button btnCapNhatTrangThai;
        private Button btnDonViDang;

        private Panel pnlGanNhanVien;

        private Label lblGanNV;
        private ComboBox cboNhanVienGan;
        private Button btnXacNhanGan;

        private Panel pnlCapNhatTT;

        private Label lblCapNhatTT;
        private ComboBox cboTrangThaiMoi;
        private Button btnXacNhanTT;
    }
}