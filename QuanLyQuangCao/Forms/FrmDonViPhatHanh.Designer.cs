using System.Drawing;
using System.Windows.Forms;

namespace QLQC.Forms
{
    partial class FrmDonViPhatHanh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblSearchTen = new System.Windows.Forms.Label();
            this.lblSearchTT = new System.Windows.Forms.Label();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.cboTimKiemTT = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaLoc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgridDonVi = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNguoiLH = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDonVi)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ ĐƠN VỊ PHÁT HÀNH";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblSubtitle.Location = new System.Drawing.Point(80, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(303, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Thêm, sửa, xóa và tìm kiếm đơn vị phát hành";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblSearchTen);
            this.pnlToolbar.Controls.Add(this.lblSearchTT);
            this.pnlToolbar.Controls.Add(this.txtTimKiemTen);
            this.pnlToolbar.Controls.Add(this.cboTimKiemTT);
            this.pnlToolbar.Controls.Add(this.btnTimKiem);
            this.pnlToolbar.Controls.Add(this.btnXoaLoc);
            this.pnlToolbar.Controls.Add(this.btnThem);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 72);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1280, 76);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblSearchTen
            // 
            this.lblSearchTen.AutoSize = true;
            this.lblSearchTen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSearchTen.Location = new System.Drawing.Point(16, 10);
            this.lblSearchTen.Name = "lblSearchTen";
            this.lblSearchTen.Size = new System.Drawing.Size(72, 19);
            this.lblSearchTen.TabIndex = 0;
            this.lblSearchTen.Text = "Tên đơn vị";
            // 
            // lblSearchTT
            // 
            this.lblSearchTT.AutoSize = true;
            this.lblSearchTT.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSearchTT.Location = new System.Drawing.Point(228, 10);
            this.lblSearchTT.Name = "lblSearchTT";
            this.lblSearchTT.Size = new System.Drawing.Size(70, 19);
            this.lblSearchTT.TabIndex = 2;
            this.lblSearchTT.Text = "Trạng thái";
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtTimKiemTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiemTen.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemTen.Location = new System.Drawing.Point(16, 30);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(200, 29);
            this.txtTimKiemTen.TabIndex = 1;
            this.txtTimKiemTen.Text = "Tìm theo tên...";
            // 
            // cboTimKiemTT
            // 
            this.cboTimKiemTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.cboTimKiemTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTimKiemTT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTimKiemTT.FormattingEnabled = true;
            this.cboTimKiemTT.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Đang hợp tác",
            "Tạm dừng"});
            this.cboTimKiemTT.Location = new System.Drawing.Point(228, 30);
            this.cboTimKiemTT.Name = "cboTimKiemTT";
            this.cboTimKiemTT.Size = new System.Drawing.Size(155, 29);
            this.cboTimKiemTT.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(395, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 28);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "🔍  Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaLoc
            // 
            this.btnXoaLoc.BackColor = System.Drawing.Color.White;
            this.btnXoaLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnXoaLoc.Location = new System.Drawing.Point(520, 30);
            this.btnXoaLoc.Name = "btnXoaLoc";
            this.btnXoaLoc.Size = new System.Drawing.Size(100, 28);
            this.btnXoaLoc.TabIndex = 5;
            this.btnXoaLoc.Text = "✕  Xóa lọc";
            this.btnXoaLoc.UseVisualStyleBackColor = false;
            this.btnXoaLoc.Click += new System.EventHandler(this.btnXoaLoc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1109, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 28);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "➕  Thêm đơn vị";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dgridDonVi);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 148);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlContent.Size = new System.Drawing.Size(1280, 596);
            this.pnlContent.TabIndex = 2;
            // 
            // dgridDonVi
            // 
            this.dgridDonVi.AllowUserToAddRows = false;
            this.dgridDonVi.BackgroundColor = System.Drawing.Color.White;
            this.dgridDonVi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridDonVi.Location = new System.Drawing.Point(16, 12);
            this.dgridDonVi.Name = "dgridDonVi";
            this.dgridDonVi.RowHeadersVisible = false;
            this.dgridDonVi.RowHeadersWidth = 51;
            this.dgridDonVi.RowTemplate.Height = 24;
            this.dgridDonVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridDonVi.Size = new System.Drawing.Size(1248, 572);
            this.dgridDonVi.TabIndex = 0;
            this.dgridDonVi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridDonVi_CellContentClick);
            this.dgridDonVi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgridDonVi_CellFormatting);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 744);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1280, 36);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFooter.Location = new System.Drawing.Point(16, 9);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(205, 20);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "ℹ  (*) Trường bắt buộc nhập";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.Location = new System.Drawing.Point(0, 0);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Size = new System.Drawing.Size(1, 29);
            this.txtMaDonVi.TabIndex = 99;
            this.txtMaDonVi.Visible = false;
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(0, 0);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(1, 29);
            this.txtTenDonVi.TabIndex = 99;
            this.txtTenDonVi.Visible = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(0, 0);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(1, 29);
            this.txtDiaChi.TabIndex = 99;
            this.txtDiaChi.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(1, 29);
            this.txtEmail.TabIndex = 99;
            this.txtEmail.Visible = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(0, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(1, 29);
            this.txtSDT.TabIndex = 99;
            this.txtSDT.Visible = false;
            // 
            // txtNguoiLH
            // 
            this.txtNguoiLH.Location = new System.Drawing.Point(0, 0);
            this.txtNguoiLH.Name = "txtNguoiLH";
            this.txtNguoiLH.Size = new System.Drawing.Size(1, 29);
            this.txtNguoiLH.TabIndex = 99;
            this.txtNguoiLH.Visible = false;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Location = new System.Drawing.Point(0, 0);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(1, 29);
            this.cboTrangThai.TabIndex = 99;
            this.cboTrangThai.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(1, 1);
            this.btnSua.TabIndex = 99;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(1, 1);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(0, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(1, 1);
            this.btnLuu.TabIndex = 99;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(0, 0);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(1, 1);
            this.btnBoqua.TabIndex = 99;
            this.btnBoqua.Visible = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(0, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(1, 1);
            this.btnDong.TabIndex = 99;
            this.btnDong.Visible = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDonViPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.txtMaDonVi);
            this.Controls.Add(this.txtTenDonVi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNguoiLH);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmDonViPhatHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn vị phát hành";
            this.Load += new System.EventHandler(this.FrmDonViPhatHanh_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDonVi)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearchTen;
        private System.Windows.Forms.Label lblSearchTT;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.ComboBox cboTimKiemTT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaLoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgridDonVi;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;

        // Hidden stubs
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNguoiLH;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
    }
}