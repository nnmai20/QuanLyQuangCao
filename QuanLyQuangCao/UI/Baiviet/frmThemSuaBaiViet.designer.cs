using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuangCao.UI.Baiviet
{
    partial class frmThemSuaBaiViet
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblNgayNop = new System.Windows.Forms.Label();
            this.dtpNgayNop = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDuyet = new System.Windows.Forms.Label();
            this.dtpNgayDuyet = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDang = new System.Windows.Forms.Label();
            this.dtpNgayDang = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpNoiDung = new System.Windows.Forms.GroupBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.lblFileDinhKem = new System.Windows.Forms.Label();
            this.txtDuongDanFile = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblFileHienTai = new System.Windows.Forms.Label();
            this.lnkFileHienTai = new System.Windows.Forms.LinkLabel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpNoiDung.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1085, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM / SỬA BÀI VIẾT";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Location = new System.Drawing.Point(0, 55);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(950, 530);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpThongTin);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(430, 530);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblHopDong);
            this.grpThongTin.Controls.Add(this.cboHopDong);
            this.grpThongTin.Controls.Add(this.lblTieuDe);
            this.grpThongTin.Controls.Add(this.txtTieuDe);
            this.grpThongTin.Controls.Add(this.lblTheLoai);
            this.grpThongTin.Controls.Add(this.cboTheLoai);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.lblNgayNop);
            this.grpThongTin.Controls.Add(this.dtpNgayNop);
            this.grpThongTin.Controls.Add(this.lblNgayDuyet);
            this.grpThongTin.Controls.Add(this.dtpNgayDuyet);
            this.grpThongTin.Controls.Add(this.lblNgayDang);
            this.grpThongTin.Controls.Add(this.dtpNgayDang);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(410, 510);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "  Thông tin bài viết";
            // 
            // lblHopDong
            // 
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHopDong.ForeColor = System.Drawing.Color.Black;
            this.lblHopDong.Location = new System.Drawing.Point(15, 28);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.Size = new System.Drawing.Size(100, 20);
            this.lblHopDong.TabIndex = 0;
            this.lblHopDong.Text = "Hợp đồng: (*)";
            // 
            // cboHopDong
            // 
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHopDong.Items.AddRange(new object[] {
            "-- Chọn hợp đồng --",
            "HD001 - Khách hàng A",
            "HD002 - Khách hàng B"});
            this.cboHopDong.Location = new System.Drawing.Point(160, 25);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(230, 28);
            this.cboHopDong.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 66);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(81, 20);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Tiêu đề: (*)";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTieuDe.Location = new System.Drawing.Point(160, 63);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(230, 27);
            this.txtTieuDe.TabIndex = 3;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTheLoai.ForeColor = System.Drawing.Color.Black;
            this.lblTheLoai.Location = new System.Drawing.Point(15, 104);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(85, 20);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "Thể loại: (*)";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTheLoai.Items.AddRange(new object[] {
            "-- Chọn thể loại --",
            "Quảng cáo sản phẩm",
            "Thông báo",
            "Bài PR"});
            this.cboTheLoai.Location = new System.Drawing.Point(160, 101);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(230, 28);
            this.cboTheLoai.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblNhanVien.Location = new System.Drawing.Point(15, 142);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(78, 20);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVien.Items.AddRange(new object[] {
            "-- Chọn nhân viên --",
            "Nguyễn Văn A",
            "Trần Thị B"});
            this.cboNhanVien.Location = new System.Drawing.Point(160, 139);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(230, 28);
            this.cboNhanVien.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lblTrangThai.Location = new System.Drawing.Point(15, 180);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(98, 20);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái: (*)";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang viết",
            "Chờ duyệt",
            "Đã duyệt chờ đăng",
            "Đã đăng"});
            this.cboTrangThai.Location = new System.Drawing.Point(160, 177);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 28);
            this.cboTrangThai.TabIndex = 9;
            // 
            // lblNgayNop
            // 
            this.lblNgayNop.AutoSize = true;
            this.lblNgayNop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayNop.ForeColor = System.Drawing.Color.Black;
            this.lblNgayNop.Location = new System.Drawing.Point(15, 218);
            this.lblNgayNop.Name = "lblNgayNop";
            this.lblNgayNop.Size = new System.Drawing.Size(77, 20);
            this.lblNgayNop.TabIndex = 10;
            this.lblNgayNop.Text = "Ngày nộp:";
            // 
            // dtpNgayNop
            // 
            this.dtpNgayNop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNop.Location = new System.Drawing.Point(160, 215);
            this.dtpNgayNop.Name = "dtpNgayNop";
            this.dtpNgayNop.Size = new System.Drawing.Size(230, 27);
            this.dtpNgayNop.TabIndex = 11;
            // 
            // lblNgayDuyet
            // 
            this.lblNgayDuyet.AutoSize = true;
            this.lblNgayDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDuyet.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDuyet.Location = new System.Drawing.Point(15, 256);
            this.lblNgayDuyet.Name = "lblNgayDuyet";
            this.lblNgayDuyet.Size = new System.Drawing.Size(88, 20);
            this.lblNgayDuyet.TabIndex = 12;
            this.lblNgayDuyet.Text = "Ngày duyệt:";
            // 
            // dtpNgayDuyet
            // 
            this.dtpNgayDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDuyet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDuyet.Location = new System.Drawing.Point(160, 253);
            this.dtpNgayDuyet.Name = "dtpNgayDuyet";
            this.dtpNgayDuyet.Size = new System.Drawing.Size(230, 27);
            this.dtpNgayDuyet.TabIndex = 13;
            // 
            // lblNgayDang
            // 
            this.lblNgayDang.AutoSize = true;
            this.lblNgayDang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDang.ForeColor = System.Drawing.Color.Black;
            this.lblNgayDang.Location = new System.Drawing.Point(15, 294);
            this.lblNgayDang.Name = "lblNgayDang";
            this.lblNgayDang.Size = new System.Drawing.Size(85, 20);
            this.lblNgayDang.TabIndex = 14;
            this.lblNgayDang.Text = "Ngày đăng:";
            // 
            // dtpNgayDang
            // 
            this.dtpNgayDang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDang.Location = new System.Drawing.Point(160, 291);
            this.dtpNgayDang.Name = "dtpNgayDang";
            this.dtpNgayDang.Size = new System.Drawing.Size(230, 27);
            this.dtpNgayDang.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 332);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(61, 20);
            this.lblGhiChu.TabIndex = 16;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(160, 329);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(230, 60);
            this.txtGhiChu.TabIndex = 17;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.grpNoiDung);
            this.pnlRight.Controls.Add(this.grpFile);
            this.pnlRight.Location = new System.Drawing.Point(430, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(655, 530);
            this.pnlRight.TabIndex = 1;
            // 
            // grpNoiDung
            // 
            this.grpNoiDung.Controls.Add(this.lblNoiDung);
            this.grpNoiDung.Controls.Add(this.txtNoiDung);
            this.grpNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpNoiDung.Location = new System.Drawing.Point(10, 10);
            this.grpNoiDung.Name = "grpNoiDung";
            this.grpNoiDung.Size = new System.Drawing.Size(598, 350);
            this.grpNoiDung.TabIndex = 0;
            this.grpNoiDung.TabStop = false;
            this.grpNoiDung.Text = "  Nội dung bài viết";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoiDung.ForeColor = System.Drawing.Color.Black;
            this.lblNoiDung.Location = new System.Drawing.Point(10, 25);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(238, 20);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nhập nội dung bài viết quảng cáo:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoiDung.Location = new System.Drawing.Point(10, 48);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(478, 285);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.Text = "";
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.lblFileDinhKem);
            this.grpFile.Controls.Add(this.txtDuongDanFile);
            this.grpFile.Controls.Add(this.btnChonFile);
            this.grpFile.Controls.Add(this.lblFileHienTai);
            this.grpFile.Controls.Add(this.lnkFileHienTai);
            this.grpFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpFile.Location = new System.Drawing.Point(10, 370);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(614, 150);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "  File đính kèm";
            // 
            // lblFileDinhKem
            // 
            this.lblFileDinhKem.AutoSize = true;
            this.lblFileDinhKem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFileDinhKem.ForeColor = System.Drawing.Color.Black;
            this.lblFileDinhKem.Location = new System.Drawing.Point(10, 35);
            this.lblFileDinhKem.Name = "lblFileDinhKem";
            this.lblFileDinhKem.Size = new System.Drawing.Size(153, 20);
            this.lblFileDinhKem.TabIndex = 0;
            this.lblFileDinhKem.Text = "Chọn file (.docx, .pdf):";
            // 
            // txtDuongDanFile
            // 
            this.txtDuongDanFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuongDanFile.Location = new System.Drawing.Point(10, 58);
            this.txtDuongDanFile.Name = "txtDuongDanFile";
            this.txtDuongDanFile.ReadOnly = true;
            this.txtDuongDanFile.Size = new System.Drawing.Size(360, 27);
            this.txtDuongDanFile.TabIndex = 1;
            this.txtDuongDanFile.Text = "Chưa chọn file...";
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnChonFile.FlatAppearance.BorderSize = 0;
            this.btnChonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFile.ForeColor = System.Drawing.Color.White;
            this.btnChonFile.Location = new System.Drawing.Point(397, 58);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(113, 27);
            this.btnChonFile.TabIndex = 2;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = false;
            // 
            // lblFileHienTai
            // 
            this.lblFileHienTai.AutoSize = true;
            this.lblFileHienTai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFileHienTai.ForeColor = System.Drawing.Color.Black;
            this.lblFileHienTai.Location = new System.Drawing.Point(10, 95);
            this.lblFileHienTai.Name = "lblFileHienTai";
            this.lblFileHienTai.Size = new System.Drawing.Size(88, 20);
            this.lblFileHienTai.TabIndex = 3;
            this.lblFileHienTai.Text = "File hiện tại:";
            // 
            // lnkFileHienTai
            // 
            this.lnkFileHienTai.AutoSize = true;
            this.lnkFileHienTai.Location = new System.Drawing.Point(104, 95);
            this.lnkFileHienTai.Name = "lnkFileHienTai";
            this.lnkFileHienTai.Size = new System.Drawing.Size(103, 20);
            this.lnkFileHienTai.TabIndex = 4;
            this.lnkFileHienTai.TabStop = true;
            this.lnkFileHienTai.Text = "(Chưa có file)";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnBoQua);
            this.pnlFooter.Controls.Add(this.btnDong);
            this.pnlFooter.Location = new System.Drawing.Point(0, 585);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(950, 55);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(580, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 32);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(700, 12);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(110, 32);
            this.btnBoQua.TabIndex = 1;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(820, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 32);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmThemSuaBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemSuaBaiViet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm / Sửa Bài Viết";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.grpNoiDung.ResumeLayout(false);
            this.grpNoiDung.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlBody;

        private Panel pnlLeft;
        private GroupBox grpThongTin;

        private Label lblHopDong;
        private ComboBox cboHopDong;

        private Label lblTieuDe;
        private TextBox txtTieuDe;

        private Label lblTheLoai;
        private ComboBox cboTheLoai;

        private Label lblNhanVien;
        private ComboBox cboNhanVien;

        private Label lblTrangThai;
        private ComboBox cboTrangThai;

        private Label lblNgayNop;
        private DateTimePicker dtpNgayNop;

        private Label lblNgayDuyet;
        private DateTimePicker dtpNgayDuyet;

        private Label lblNgayDang;
        private DateTimePicker dtpNgayDang;

        private Label lblGhiChu;
        private TextBox txtGhiChu;

        private Panel pnlRight;

        private GroupBox grpNoiDung;
        private Label lblNoiDung;
        private RichTextBox txtNoiDung;

        private GroupBox grpFile;
        private Label lblFileDinhKem;
        private TextBox txtDuongDanFile;
        private Button btnChonFile;
        private Label lblFileHienTai;
        private LinkLabel lnkFileHienTai;

        private Panel pnlFooter;
        private Button btnLuu;
        private Button btnBoQua;
        private Button btnDong;
    }
}