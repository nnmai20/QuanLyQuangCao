namespace QuanLyQuangCao.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnBaiViet = new System.Windows.Forms.Button();
            this.btnDonViPhatHanh = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.lblNguoiDung);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(208, 14);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(571, 29);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ HỢP ĐỒNG QUẢNG CÁO";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Location = new System.Drawing.Point(38, 24);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(44, 16);
            this.lblNguoiDung.TabIndex = 1;
            this.lblNguoiDung.Text = "label1";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.btnDonViPhatHanh);
            this.pnlSidebar.Controls.Add(this.btnBaiViet);
            this.pnlSidebar.Controls.Add(this.btnHopDong);
            this.pnlSidebar.Controls.Add(this.btnKhachHang);
            this.pnlSidebar.Controls.Add(this.btnNguoiDung);
            this.pnlSidebar.Controls.Add(this.btnTongQuan);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 55);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 407);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 0);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(200, 45);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnNguoiDung.Location = new System.Drawing.Point(0, 290);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNguoiDung.Size = new System.Drawing.Size(200, 45);
            this.btnNguoiDung.TabIndex = 1;
            this.btnNguoiDung.Text = "Quản lý Người dùng";
            this.btnNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 84);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(200, 45);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Quản lý Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDong.Location = new System.Drawing.Point(0, 42);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHopDong.Size = new System.Drawing.Size(200, 45);
            this.btnHopDong.TabIndex = 3;
            this.btnHopDong.Text = "Quản lý Hợp đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.UseVisualStyleBackColor = true;
            // 
            // btnBaiViet
            // 
            this.btnBaiViet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaiViet.ForeColor = System.Drawing.Color.White;
            this.btnBaiViet.Location = new System.Drawing.Point(0, 124);
            this.btnBaiViet.Name = "btnBaiViet";
            this.btnBaiViet.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBaiViet.Size = new System.Drawing.Size(200, 45);
            this.btnBaiViet.TabIndex = 4;
            this.btnBaiViet.Text = "Quản lý Bài viết";
            this.btnBaiViet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaiViet.UseVisualStyleBackColor = true;
            // 
            // btnDonViPhatHanh
            // 
            this.btnDonViPhatHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonViPhatHanh.ForeColor = System.Drawing.Color.White;
            this.btnDonViPhatHanh.Location = new System.Drawing.Point(0, 166);
            this.btnDonViPhatHanh.Name = "btnDonViPhatHanh";
            this.btnDonViPhatHanh.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDonViPhatHanh.Size = new System.Drawing.Size(200, 45);
            this.btnDonViPhatHanh.TabIndex = 5;
            this.btnDonViPhatHanh.Text = "Đơn vị Phát hành";
            this.btnDonViPhatHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonViPhatHanh.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 248);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(200, 45);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo cáo và Thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 362);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(200, 45);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 407);
            this.pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDonViPhatHanh;
        private System.Windows.Forms.Button btnBaiViet;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Panel pnlContent;
    }
}