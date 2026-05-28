using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuangCao.UI.Baiviet
{
    partial class frmDonViDangBai
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpThemDV = new System.Windows.Forms.GroupBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.lblNgayPhatHanh = new System.Windows.Forms.Label();
            this.dtpNgayPhatHanh = new System.Windows.Forms.DateTimePicker();
            this.lblSoKy = new System.Windows.Forms.Label();
            this.txtSoKy = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.grpDanhSachDV = new System.Windows.Forms.GroupBox();
            this.dgvDonVi = new System.Windows.Forms.DataGridView();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChuDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.txtTongGiaTri = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpThemDV.SuspendLayout();
            this.grpDanhSachDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1042, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ ĐƠN VỊ ĐĂNG BÀI";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpThemDV);
            this.pnlMain.Controls.Add(this.grpDanhSachDV);
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1030, 560);
            this.pnlMain.TabIndex = 1;
            // 
            // grpThemDV
            // 
            this.grpThemDV.Controls.Add(this.lblDonVi);
            this.grpThemDV.Controls.Add(this.cboDonVi);
            this.grpThemDV.Controls.Add(this.lblNgayPhatHanh);
            this.grpThemDV.Controls.Add(this.dtpNgayPhatHanh);
            this.grpThemDV.Controls.Add(this.lblSoKy);
            this.grpThemDV.Controls.Add(this.txtSoKy);
            this.grpThemDV.Controls.Add(this.lblDonGia);
            this.grpThemDV.Controls.Add(this.txtDonGia);
            this.grpThemDV.Controls.Add(this.lblThanhTien);
            this.grpThemDV.Controls.Add(this.txtThanhTien);
            this.grpThemDV.Controls.Add(this.lblGhiChu);
            this.grpThemDV.Controls.Add(this.txtGhiChu);
            this.grpThemDV.Controls.Add(this.btnThemDV);
            this.grpThemDV.Controls.Add(this.btnBoQua);
            this.grpThemDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThemDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpThemDV.Location = new System.Drawing.Point(10, 10);
            this.grpThemDV.Name = "grpThemDV";
            this.grpThemDV.Size = new System.Drawing.Size(350, 520);
            this.grpThemDV.TabIndex = 0;
            this.grpThemDV.TabStop = false;
            this.grpThemDV.Text = "Thêm đơn vị phát hành";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.ForeColor = System.Drawing.Color.Black;
            this.lblDonVi.Location = new System.Drawing.Point(10, 35);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(133, 20);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị phát hành:";
            // 
            // cboDonVi
            // 
            this.cboDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonVi.Items.AddRange(new object[] {
            "-- Chọn đơn vị --",
            "Báo Tiền Phong",
            "Báo Lao Động",
            "Báo Nhân Dân"});
            this.cboDonVi.Location = new System.Drawing.Point(140, 32);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Size = new System.Drawing.Size(180, 28);
            this.cboDonVi.TabIndex = 1;
            // 
            // lblNgayPhatHanh
            // 
            this.lblNgayPhatHanh.AutoSize = true;
            this.lblNgayPhatHanh.ForeColor = System.Drawing.Color.Black;
            this.lblNgayPhatHanh.Location = new System.Drawing.Point(10, 80);
            this.lblNgayPhatHanh.Name = "lblNgayPhatHanh";
            this.lblNgayPhatHanh.Size = new System.Drawing.Size(125, 20);
            this.lblNgayPhatHanh.TabIndex = 2;
            this.lblNgayPhatHanh.Text = "Ngày phát hành:";
            // 
            // dtpNgayPhatHanh
            // 
            this.dtpNgayPhatHanh.Location = new System.Drawing.Point(140, 77);
            this.dtpNgayPhatHanh.Name = "dtpNgayPhatHanh";
            this.dtpNgayPhatHanh.Size = new System.Drawing.Size(180, 27);
            this.dtpNgayPhatHanh.TabIndex = 3;
            // 
            // lblSoKy
            // 
            this.lblSoKy.AutoSize = true;
            this.lblSoKy.ForeColor = System.Drawing.Color.Black;
            this.lblSoKy.Location = new System.Drawing.Point(10, 125);
            this.lblSoKy.Name = "lblSoKy";
            this.lblSoKy.Size = new System.Drawing.Size(89, 20);
            this.lblSoKy.TabIndex = 4;
            this.lblSoKy.Text = "Số kỳ đăng:";
            // 
            // txtSoKy
            // 
            this.txtSoKy.Location = new System.Drawing.Point(140, 122);
            this.txtSoKy.Name = "txtSoKy";
            this.txtSoKy.Size = new System.Drawing.Size(180, 27);
            this.txtSoKy.TabIndex = 5;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblDonGia.Location = new System.Drawing.Point(10, 170);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(67, 20);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(140, 167);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(180, 27);
            this.txtDonGia.TabIndex = 7;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.ForeColor = System.Drawing.Color.Green;
            this.lblThanhTien.Location = new System.Drawing.Point(10, 215);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(88, 20);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(140, 212);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(180, 27);
            this.txtThanhTien.TabIndex = 9;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;
            this.lblGhiChu.Location = new System.Drawing.Point(10, 260);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(66, 20);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(140, 257);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(180, 70);
            this.txtGhiChu.TabIndex = 11;
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(10, 360);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(150, 35);
            this.btnThemDV.TabIndex = 12;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.Gray;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(170, 360);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(150, 35);
            this.btnBoQua.TabIndex = 13;
            this.btnBoQua.Text = "Làm mới";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // grpDanhSachDV
            // 
            this.grpDanhSachDV.Controls.Add(this.dgvDonVi);
            this.grpDanhSachDV.Controls.Add(this.btnXoaDV);
            this.grpDanhSachDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDanhSachDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpDanhSachDV.Location = new System.Drawing.Point(380, 10);
            this.grpDanhSachDV.Name = "grpDanhSachDV";
            this.grpDanhSachDV.Size = new System.Drawing.Size(650, 520);
            this.grpDanhSachDV.TabIndex = 1;
            this.grpDanhSachDV.TabStop = false;
            this.grpDanhSachDV.Text = "Danh sách đơn vị";
            // 
            // dgvDonVi
            // 
            this.dgvDonVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonVi.ColumnHeadersHeight = 29;
            this.dgvDonVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDonVi,
            this.colNgayPH,
            this.colSoKy,
            this.colDonGia,
            this.colThanhTien,
            this.colGhiChuDV});
            this.dgvDonVi.Location = new System.Drawing.Point(10, 30);
            this.dgvDonVi.Name = "dgvDonVi";
            this.dgvDonVi.RowHeadersWidth = 51;
            this.dgvDonVi.Size = new System.Drawing.Size(637, 408);
            this.dgvDonVi.TabIndex = 0;
            // 
            // colDonVi
            // 
            this.colDonVi.HeaderText = "Đơn vị";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            // 
            // colNgayPH
            // 
            this.colNgayPH.HeaderText = "Ngày";
            this.colNgayPH.MinimumWidth = 6;
            this.colNgayPH.Name = "colNgayPH";
            // 
            // colSoKy
            // 
            this.colSoKy.HeaderText = "Số kỳ";
            this.colSoKy.MinimumWidth = 6;
            this.colSoKy.Name = "colSoKy";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // colGhiChuDV
            // 
            this.colGhiChuDV.HeaderText = "Ghi chú";
            this.colGhiChuDV.MinimumWidth = 6;
            this.colGhiChuDV.Name = "colGhiChuDV";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(10, 470);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(150, 35);
            this.btnXoaDV.TabIndex = 1;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFooter.Controls.Add(this.lblTongGiaTri);
            this.pnlFooter.Controls.Add(this.txtTongGiaTri);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnDong);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 615);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1042, 55);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblTongGiaTri
            // 
            this.lblTongGiaTri.AutoSize = true;
            this.lblTongGiaTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTri.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongGiaTri.Location = new System.Drawing.Point(10, 18);
            this.lblTongGiaTri.Name = "lblTongGiaTri";
            this.lblTongGiaTri.Size = new System.Drawing.Size(110, 23);
            this.lblTongGiaTri.TabIndex = 0;
            this.lblTongGiaTri.Text = "Tổng giá trị:";
            // 
            // txtTongGiaTri
            // 
            this.txtTongGiaTri.Location = new System.Drawing.Point(120, 16);
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.Size = new System.Drawing.Size(180, 22);
            this.txtTongGiaTri.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(730, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Firebrick;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(850, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmDonViDangBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 670);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Name = "frmDonViDangBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn vị đăng bài";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpThemDV.ResumeLayout(false);
            this.grpThemDV.PerformLayout();
            this.grpDanhSachDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonVi)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlMain;

        private GroupBox grpThemDV;

        private Label lblDonVi;
        private ComboBox cboDonVi;

        private Label lblNgayPhatHanh;
        private DateTimePicker dtpNgayPhatHanh;

        private Label lblSoKy;
        private TextBox txtSoKy;

        private Label lblDonGia;
        private TextBox txtDonGia;

        private Label lblThanhTien;
        private TextBox txtThanhTien;

        private Label lblGhiChu;
        private TextBox txtGhiChu;

        private Button btnThemDV;
        private Button btnBoQua;

        private GroupBox grpDanhSachDV;

        private DataGridView dgvDonVi;

        private DataGridViewTextBoxColumn colDonVi;
        private DataGridViewTextBoxColumn colNgayPH;
        private DataGridViewTextBoxColumn colSoKy;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridViewTextBoxColumn colGhiChuDV;

        private Button btnXoaDV;

        private Panel pnlFooter;

        private Label lblTongGiaTri;
        private TextBox txtTongGiaTri;

        private Button btnLuu;
        private Button btnDong;
    }
}