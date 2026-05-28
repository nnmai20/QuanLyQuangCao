
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuangCao.UI.Baiviet
{
    partial class frmTheLoaiBaiViet
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();

            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();

            this.dgvTheLoai = new System.Windows.Forms.DataGridView();

            this.colMaTheLoai =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTenTheLoai =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMoTa =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlRight = new System.Windows.Forms.Panel();

            this.grpNhapLieu = new System.Windows.Forms.GroupBox();

            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();

            this.lblTenTheLoai = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();

            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.grpDanhSach.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTheLoai)).BeginInit();

            this.pnlRight.SuspendLayout();
            this.grpNhapLieu.SuspendLayout();
            this.pnlButtons.SuspendLayout();

            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor =
                Color.FromArgb(41, 128, 185);

            this.pnlHeader.Controls.Add(this.lblTitle);

            this.pnlHeader.Dock = DockStyle.Top;

            this.pnlHeader.Size =
                new Size(820, 55);

            // lblTitle
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor = Color.White;

            this.lblTitle.Location =
                new Point(20, 12);

            this.lblTitle.Text =
                "QUẢN LÝ THỂ LOẠI BÀI VIẾT";

            // pnlLeft
            this.pnlLeft.Location =
                new Point(0, 55);

            this.pnlLeft.Size =
                new Size(490, 490);

            this.pnlLeft.Controls.Add(
                this.grpDanhSach);

            // grpDanhSach
            this.grpDanhSach.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.grpDanhSach.ForeColor =
                Color.FromArgb(41, 128, 185);

            this.grpDanhSach.Location =
                new Point(10, 10);

            this.grpDanhSach.Size =
                new Size(470, 470);

            this.grpDanhSach.Text =
                "Danh sách thể loại";

            // txtTimKiem
            this.txtTimKiem.Font =
                new Font("Segoe UI", 9F);

            this.txtTimKiem.Location =
                new Point(10, 28);

            this.txtTimKiem.Size =
                new Size(330, 23);

            // btnTimKiem
            this.btnTimKiem.BackColor =
                Color.FromArgb(41, 128, 185);

            this.btnTimKiem.FlatStyle =
                FlatStyle.Flat;

            this.btnTimKiem.ForeColor =
                Color.White;

            this.btnTimKiem.Location =
                new Point(348, 27);

            this.btnTimKiem.Size =
                new Size(110, 25);

            this.btnTimKiem.Text =
                "Tìm kiếm";

            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.btnTimKiem.Click +=
                new EventHandler(
                    this.btnTimKiem_Click);

            // dgvTheLoai
            this.dgvTheLoai.AllowUserToAddRows = false;

            this.dgvTheLoai.AllowUserToDeleteRows = false;

            // QUAN TRỌNG
            this.dgvTheLoai.AutoGenerateColumns = false;

            this.dgvTheLoai.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvTheLoai.BackgroundColor =
                Color.White;

            this.dgvTheLoai.BorderStyle =
                BorderStyle.None;

            this.dgvTheLoai.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(41, 128, 185);

            this.dgvTheLoai.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            this.dgvTheLoai.EnableHeadersVisualStyles = false;

            this.dgvTheLoai.Location =
                new Point(10, 62);

            this.dgvTheLoai.Size =
                new Size(448, 395);

            this.dgvTheLoai.ReadOnly = true;

            this.dgvTheLoai.RowHeadersVisible = false;

            this.dgvTheLoai.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvTheLoai.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    this.colMaTheLoai,
                    this.colTenTheLoai,
                    this.colMoTa
                });

            this.dgvTheLoai.CellClick +=
                new DataGridViewCellEventHandler(
                    this.dgvTheLoai_CellClick);

            // =========================
            // COLUMNS
            // =========================

            // colMaTheLoai
            this.colMaTheLoai.HeaderText = "Mã TL";

            this.colMaTheLoai.Name =
                "MaTheLoai";

            this.colMaTheLoai.DataPropertyName =
                "MaTheLoai";

            // colTenTheLoai
            this.colTenTheLoai.HeaderText =
                "Tên thể loại";

            this.colTenTheLoai.Name =
                "TenTheLoai";

            this.colTenTheLoai.DataPropertyName =
                "TenTheLoai";

            // colMoTa
            this.colMoTa.HeaderText =
                "Mô tả";

            this.colMoTa.Name =
                "MoTa";

            this.colMoTa.DataPropertyName =
                "MoTa";

            // add controls
            this.grpDanhSach.Controls.Add(
                this.txtTimKiem);

            this.grpDanhSach.Controls.Add(
                this.btnTimKiem);

            this.grpDanhSach.Controls.Add(
                this.dgvTheLoai);

            // pnlRight
            this.pnlRight.Location =
                new Point(490, 55);

            this.pnlRight.Size =
                new Size(330, 490);

            // grpNhapLieu
            this.grpNhapLieu.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.grpNhapLieu.ForeColor =
                Color.FromArgb(41, 128, 185);

            this.grpNhapLieu.Location =
                new Point(10, 10);

            this.grpNhapLieu.Size =
                new Size(310, 360);

            this.grpNhapLieu.Text =
                "Nhập thông tin";

            // lblMaTheLoai
            this.lblMaTheLoai.AutoSize = true;

            this.lblMaTheLoai.Font =
                new Font("Segoe UI", 9F);

            this.lblMaTheLoai.ForeColor =
                Color.Black;

            this.lblMaTheLoai.Location =
                new Point(12, 30);

            this.lblMaTheLoai.Text =
                "Mã thể loại:";

            // txtMaTheLoai
            this.txtMaTheLoai.Location =
                new Point(100, 27);

            this.txtMaTheLoai.Size =
                new Size(195, 23);

            this.txtMaTheLoai.ReadOnly = true;

            this.txtMaTheLoai.Text =
                "(Tự sinh)";

            // lblTenTheLoai
            this.lblTenTheLoai.AutoSize = true;

            this.lblTenTheLoai.Location =
                new Point(12, 75);

            this.lblTenTheLoai.Text =
                "Tên thể loại:";

            // txtTenTheLoai
            this.txtTenTheLoai.Location =
                new Point(100, 72);

            this.txtTenTheLoai.Size =
                new Size(195, 23);

            // lblMoTa
            this.lblMoTa.AutoSize = true;

            this.lblMoTa.Location =
                new Point(12, 120);

            this.lblMoTa.Text =
                "Mô tả:";

            // txtMoTa
            this.txtMoTa.Location =
                new Point(100, 117);

            this.txtMoTa.Multiline = true;

            this.txtMoTa.ScrollBars =
                ScrollBars.Vertical;

            this.txtMoTa.Size =
                new Size(195, 200);

            // add input controls
            this.grpNhapLieu.Controls.Add(
                this.lblMaTheLoai);

            this.grpNhapLieu.Controls.Add(
                this.txtMaTheLoai);

            this.grpNhapLieu.Controls.Add(
                this.lblTenTheLoai);

            this.grpNhapLieu.Controls.Add(
                this.txtTenTheLoai);

            this.grpNhapLieu.Controls.Add(
                this.lblMoTa);

            this.grpNhapLieu.Controls.Add(
                this.txtMoTa);

            // pnlButtons
            this.pnlButtons.BackColor =
                Color.FromArgb(248, 249, 250);

            this.pnlButtons.Location =
                new Point(10, 380);

            this.pnlButtons.Size =
                new Size(310, 100);

            // btnThem
            this.btnThem.BackColor =
                Color.FromArgb(39, 174, 96);

            this.btnThem.FlatStyle =
                FlatStyle.Flat;

            this.btnThem.ForeColor =
                Color.White;

            this.btnThem.Location =
                new Point(5, 10);

            this.btnThem.Size =
                new Size(90, 32);

            this.btnThem.Text =
                "+ Thêm";

            this.btnThem.Click +=
                new EventHandler(
                    this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor =
                Color.FromArgb(243, 156, 18);

            this.btnSua.FlatStyle =
                FlatStyle.Flat;

            this.btnSua.ForeColor =
                Color.White;

            this.btnSua.Location =
                new Point(100, 10);

            this.btnSua.Size =
                new Size(90, 32);

            this.btnSua.Text =
                "Sửa";

            this.btnSua.Click +=
                new EventHandler(
                    this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor =
                Color.FromArgb(192, 57, 43);

            this.btnXoa.FlatStyle =
                FlatStyle.Flat;

            this.btnXoa.ForeColor =
                Color.White;

            this.btnXoa.Location =
                new Point(195, 10);

            this.btnXoa.Size =
                new Size(90, 32);

            this.btnXoa.Text =
                "Xóa";

            this.btnXoa.Click +=
                new EventHandler(
                    this.btnXoa_Click);

            // btnBoQua
            this.btnBoQua.BackColor =
                Color.Gray;

            this.btnBoQua.FlatStyle =
                FlatStyle.Flat;

            this.btnBoQua.ForeColor =
                Color.White;

            this.btnBoQua.Location =
                new Point(5, 52);

            this.btnBoQua.Size =
                new Size(135, 32);

            this.btnBoQua.Text =
                "Bỏ qua";

            this.btnBoQua.Click +=
                new EventHandler(
                    this.btnLamMoi_Click);

            // btnDong
            this.btnDong.BackColor =
                Color.FromArgb(52, 73, 94);

            this.btnDong.FlatStyle =
                FlatStyle.Flat;

            this.btnDong.ForeColor =
                Color.White;

            this.btnDong.Location =
                new Point(150, 52);

            this.btnDong.Size =
                new Size(135, 32);

            this.btnDong.Text =
                "Đóng";

            this.btnDong.Click +=
                new EventHandler(
                    this.btnThoat_Click);

            // add buttons
            this.pnlButtons.Controls.Add(
                this.btnThem);

            this.pnlButtons.Controls.Add(
                this.btnSua);

            this.pnlButtons.Controls.Add(
                this.btnXoa);

            this.pnlButtons.Controls.Add(
                this.btnBoQua);

            this.pnlButtons.Controls.Add(
                this.btnDong);

            // add right controls
            this.pnlRight.Controls.Add(
                this.grpNhapLieu);

            this.pnlRight.Controls.Add(
                this.pnlButtons);

            // form
            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.BackColor =
                Color.White;

            this.ClientSize =
                new Size(820, 545);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Quản Lý Thể Loại Bài Viết";

            this.Load +=
                new EventHandler(
                    this.frmTheLoaiBaiViet_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlLeft.ResumeLayout(false);

            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTheLoai)).EndInit();

            this.pnlRight.ResumeLayout(false);

            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();

            this.pnlButtons.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlLeft;
        private GroupBox grpDanhSach;

        private TextBox txtTimKiem;
        private Button btnTimKiem;

        private DataGridView dgvTheLoai;

        private DataGridViewTextBoxColumn colMaTheLoai;
        private DataGridViewTextBoxColumn colTenTheLoai;
        private DataGridViewTextBoxColumn colMoTa;

        private Panel pnlRight;
        private GroupBox grpNhapLieu;

        private Label lblMaTheLoai;
        private TextBox txtMaTheLoai;

        private Label lblTenTheLoai;
        private TextBox txtTenTheLoai;

        private Label lblMoTa;
        private TextBox txtMoTa;

        private Panel pnlButtons;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBoQua;
        private Button btnDong;
    }
}

