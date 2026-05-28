namespace AuthForms.UI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Sidebar ──────────────────────────────────────────────
            this.pnlSidebar           = new System.Windows.Forms.Panel();
            this.pnlUserInfo          = new System.Windows.Forms.Panel();
            this.lblHoTen             = new System.Windows.Forms.Label();
            this.lblVaiTro            = new System.Windows.Forms.Label();

            this.lblDanhMucHeader     = new System.Windows.Forms.Label();
            this.btnHopDong           = new System.Windows.Forms.Button();
            this.btnKhachHang         = new System.Windows.Forms.Button();
            this.btnBaiViet           = new System.Windows.Forms.Button();
            this.btnDonViPhatHanh     = new System.Windows.Forms.Button();

            this.lblHeThongHeader     = new System.Windows.Forms.Label();
            this.btnBaoCao            = new System.Windows.Forms.Button();
            this.btnNguoiDung         = new System.Windows.Forms.Button();

            // ── BaoCao Popup Menu ─────────────────────────────────────
            this.pnlBaoCaoPopup       = new System.Windows.Forms.Panel();
            this.btnPopupDoanhThu     = new System.Windows.Forms.Button();
            this.btnPopupHopDong      = new System.Windows.Forms.Button();

            // ── Main area ─────────────────────────────────────────────
            this.pnlMain              = new System.Windows.Forms.Panel();

            // Title
            this.lblModuleTitle       = new System.Windows.Forms.Label();

            // Toolbar
            this.pnlToolbar           = new System.Windows.Forms.Panel();
            this.btnThemMoi           = new System.Windows.Forms.Button();
            this.btnSua               = new System.Windows.Forms.Button();
            this.btnXoa               = new System.Windows.Forms.Button();
            this.btnLuu               = new System.Windows.Forms.Button();
            this.btnHuy               = new System.Windows.Forms.Button();
            this.btnXuatHon           = new System.Windows.Forms.Button();
            this.cboTimKiem           = new System.Windows.Forms.ComboBox();
            this.txtTimKiem           = new System.Windows.Forms.TextBox();
            this.btnTim               = new System.Windows.Forms.Button();
            this.btnReset             = new System.Windows.Forms.Button();

            // DataGridView
            this.dgvDanhSach          = new System.Windows.Forms.DataGridView();

            // Panel thông tin
            this.pnlThongTin          = new System.Windows.Forms.Panel();
            this.lblThongTinTitle     = new System.Windows.Forms.Label();
            this.pnlThongTinFields    = new System.Windows.Forms.Panel();

            // Fields
            this.lblMaHopDong         = new System.Windows.Forms.Label();
            this.txtMaHopDong         = new System.Windows.Forms.TextBox();
            this.lblLoaiHopDong       = new System.Windows.Forms.Label();
            this.cboLoaiHopDong       = new System.Windows.Forms.ComboBox();
            this.lblTrangThai         = new System.Windows.Forms.Label();
            this.cboTrangThai         = new System.Windows.Forms.ComboBox();

            this.lblKhachHang         = new System.Windows.Forms.Label();
            this.cboKhachHang         = new System.Windows.Forms.ComboBox();
            this.lblNhanVienPhuTrach   = new System.Windows.Forms.Label();
            this.cboNhanVien          = new System.Windows.Forms.ComboBox();
            this.lblNgayKy            = new System.Windows.Forms.Label();
            this.dtpNgayKy            = new System.Windows.Forms.DateTimePicker();

            this.lblNgayBatDau        = new System.Windows.Forms.Label();
            this.dtpNgayBatDau        = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc       = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc       = new System.Windows.Forms.DateTimePicker();
            this.lblTongGiaTri        = new System.Windows.Forms.Label();
            this.txtTongGiaTri        = new System.Windows.Forms.TextBox();

            this.lblDaThanhToan       = new System.Windows.Forms.Label();
            this.txtDaThanhToan       = new System.Windows.Forms.TextBox();
            this.lblGhiChu            = new System.Windows.Forms.Label();
            this.txtGhiChu            = new System.Windows.Forms.TextBox();
            this.lblConLai            = new System.Windows.Forms.Label();
            this.txtConLai            = new System.Windows.Forms.TextBox();

            // ── Report Panel (inline) ─────────────────────────────────
            this.pnlReport            = new System.Windows.Forms.Panel();
            this.pnlReportFilter      = new System.Windows.Forms.Panel();
            this.lblFilterLoai        = new System.Windows.Forms.Label();
            this.cboFilterLoai        = new System.Windows.Forms.ComboBox();
            this.lblFilterNam         = new System.Windows.Forms.Label();
            this.nudFilterNam         = new System.Windows.Forms.NumericUpDown();
            this.lblFilterThang       = new System.Windows.Forms.Label();
            this.cboFilterThang       = new System.Windows.Forms.ComboBox();
            this.lblFilterTuNgay      = new System.Windows.Forms.Label();
            this.dtpFilterTuNgay      = new System.Windows.Forms.DateTimePicker();
            this.lblFilterDenNgay     = new System.Windows.Forms.Label();
            this.dtpFilterDenNgay     = new System.Windows.Forms.DateTimePicker();
            this.btnLoadReport        = new System.Windows.Forms.Button();
            this.pnlKpiBar            = new System.Windows.Forms.Panel();
            this.lblKpi1              = new System.Windows.Forms.Label();
            this.lblKpi2              = new System.Windows.Forms.Label();
            this.lblKpi3              = new System.Windows.Forms.Label();
            this.lblKpi4              = new System.Windows.Forms.Label();
            this.dgvReport            = new System.Windows.Forms.DataGridView();

            // Status bar
            this.lblStatusBar         = new System.Windows.Forms.Label();

            // Timer
            this.timerClock           = new System.Windows.Forms.Timer(this.components);

            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterNam)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.pnlThongTinFields.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlReportFilter.SuspendLayout();
            this.pnlKpiBar.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════
            //  SIDEBAR
            // ════════════════════════════════════════════
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(32, 53, 82);
            this.pnlSidebar.Controls.Add(this.btnNguoiDung);
            this.pnlSidebar.Controls.Add(this.lblHeThongHeader);
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.btnDonViPhatHanh);
            this.pnlSidebar.Controls.Add(this.btnBaiViet);
            this.pnlSidebar.Controls.Add(this.btnKhachHang);
            this.pnlSidebar.Controls.Add(this.btnHopDong);
            this.pnlSidebar.Controls.Add(this.lblDanhMucHeader);
            this.pnlSidebar.Controls.Add(this.pnlUserInfo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 680);
            this.pnlSidebar.TabIndex = 0;

            // User info panel
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(24, 40, 62);
            this.pnlUserInfo.Controls.Add(this.lblHoTen);
            this.pnlUserInfo.Controls.Add(this.lblVaiTro);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Size = new System.Drawing.Size(200, 64);

            this.lblHoTen.AutoSize  = false;
            this.lblHoTen.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.White;
            this.lblHoTen.Location  = new System.Drawing.Point(14, 12);
            this.lblHoTen.Size      = new System.Drawing.Size(180, 20);
            this.lblHoTen.Text      = "Nguyễn Văn An";
            this.lblHoTen.Name      = "lblHoTen";

            this.lblVaiTro.AutoSize  = false;
            this.lblVaiTro.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(160, 185, 230);
            this.lblVaiTro.Location  = new System.Drawing.Point(14, 34);
            this.lblVaiTro.Size      = new System.Drawing.Size(180, 18);
            this.lblVaiTro.Text      = "Nhân viên marketing";
            this.lblVaiTro.Name      = "lblVaiTro";

            // DANH MUC header
            this.lblDanhMucHeader.AutoSize  = false;
            this.lblDanhMucHeader.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMucHeader.ForeColor = System.Drawing.Color.FromArgb(90, 130, 195);
            this.lblDanhMucHeader.Location  = new System.Drawing.Point(14, 76);
            this.lblDanhMucHeader.Size      = new System.Drawing.Size(176, 18);
            this.lblDanhMucHeader.Text      = "DANH MỤC";
            this.lblDanhMucHeader.Name      = "lblDanhMucHeader";

            // btnHopDong
            this.btnHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnHopDong.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnHopDong.Location  = new System.Drawing.Point(0, 96);
            this.btnHopDong.Size      = new System.Drawing.Size(200, 38);
            this.btnHopDong.Text      = "  Quản lý Hợp Đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click    += new System.EventHandler(this.btnHopDong_Click);

            // btnKhachHang
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnKhachHang.Location  = new System.Drawing.Point(0, 136);
            this.btnKhachHang.Size      = new System.Drawing.Size(200, 38);
            this.btnKhachHang.Text      = "  Quản lý Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click    += new System.EventHandler(this.btnKhachHang_Click);

            // btnBaiViet
            this.btnBaiViet.BackColor = System.Drawing.Color.Transparent;
            this.btnBaiViet.FlatAppearance.BorderSize = 0;
            this.btnBaiViet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnBaiViet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaiViet.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBaiViet.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnBaiViet.Location  = new System.Drawing.Point(0, 176);
            this.btnBaiViet.Size      = new System.Drawing.Size(200, 38);
            this.btnBaiViet.Text      = "  Quản lý Bài Viết";
            this.btnBaiViet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaiViet.UseVisualStyleBackColor = false;
            this.btnBaiViet.Click    += new System.EventHandler(this.btnBaiViet_Click);

            // btnDonViPhatHanh
            this.btnDonViPhatHanh.BackColor = System.Drawing.Color.Transparent;
            this.btnDonViPhatHanh.FlatAppearance.BorderSize = 0;
            this.btnDonViPhatHanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnDonViPhatHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonViPhatHanh.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDonViPhatHanh.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnDonViPhatHanh.Location  = new System.Drawing.Point(0, 216);
            this.btnDonViPhatHanh.Size      = new System.Drawing.Size(200, 38);
            this.btnDonViPhatHanh.Text      = "  Đơn vị Phát hành";
            this.btnDonViPhatHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonViPhatHanh.UseVisualStyleBackColor = false;
            this.btnDonViPhatHanh.Click    += new System.EventHandler(this.btnDonViPhatHanh_Click);

            // lblHeThongHeader
            this.lblHeThongHeader.AutoSize  = false;
            this.lblHeThongHeader.Font      = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblHeThongHeader.ForeColor = System.Drawing.Color.FromArgb(90, 130, 195);
            this.lblHeThongHeader.Location  = new System.Drawing.Point(14, 268);
            this.lblHeThongHeader.Size      = new System.Drawing.Size(176, 18);
            this.lblHeThongHeader.Text      = "HỆ THỐNG";
            this.lblHeThongHeader.Name      = "lblHeThongHeader";

            // btnBaoCao
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnBaoCao.Location  = new System.Drawing.Point(0, 288);
            this.btnBaoCao.Size      = new System.Drawing.Size(200, 38);
            this.btnBaoCao.Text      = "  Báo cáo và Thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Name      = "btnBaoCao";
            this.btnBaoCao.Click    += new System.EventHandler(this.btnBaoCao_Click);

            // btnNguoiDung
            this.btnNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnNguoiDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 70, 130);
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNguoiDung.ForeColor = System.Drawing.Color.FromArgb(200, 218, 250);
            this.btnNguoiDung.Location  = new System.Drawing.Point(0, 328);
            this.btnNguoiDung.Size      = new System.Drawing.Size(200, 38);
            this.btnNguoiDung.Text      = "  Quản lý Người Dùng";
            this.btnNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiDung.UseVisualStyleBackColor = false;
            this.btnNguoiDung.Name      = "btnNguoiDung";
            this.btnNguoiDung.Click    += new System.EventHandler(this.btnNguoiDung_Click);

            // ════════════════════════════════════════════
            //  MAIN PANEL
            // ════════════════════════════════════════════
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(255, 253, 240);
            this.pnlMain.Controls.Add(this.lblStatusBar);
            this.pnlMain.Controls.Add(this.pnlThongTin);
            this.pnlMain.Controls.Add(this.dgvDanhSach);
            this.pnlMain.Controls.Add(this.pnlToolbar);
            this.pnlMain.Controls.Add(this.lblModuleTitle);
            this.pnlMain.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Name     = "pnlMain";
            this.pnlMain.Padding  = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.pnlMain.TabIndex = 1;

            // Module title
            this.lblModuleTitle.AutoSize  = false;
            this.lblModuleTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblModuleTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblModuleTitle.ForeColor = System.Drawing.Color.Black;
            this.lblModuleTitle.Name      = "lblModuleTitle";
            this.lblModuleTitle.Size      = new System.Drawing.Size(940, 36);
            this.lblModuleTitle.Text      = "Quản lý Hợp Đồng Quảng Cáo";
            this.lblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── Toolbar ───────────────────────────────────────────────
            this.pnlToolbar.BackColor = System.Drawing.Color.Transparent;
            this.pnlToolbar.Controls.Add(this.btnReset);
            this.pnlToolbar.Controls.Add(this.btnTim);
            this.pnlToolbar.Controls.Add(this.txtTimKiem);
            this.pnlToolbar.Controls.Add(this.cboTimKiem);
            this.pnlToolbar.Controls.Add(this.btnXuatHon);
            this.pnlToolbar.Controls.Add(this.btnHuy);
            this.pnlToolbar.Controls.Add(this.btnLuu);
            this.pnlToolbar.Controls.Add(this.btnXoa);
            this.pnlToolbar.Controls.Add(this.btnSua);
            this.pnlToolbar.Controls.Add(this.btnThemMoi);
            this.pnlToolbar.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Name     = "pnlToolbar";
            this.pnlToolbar.Size     = new System.Drawing.Size(940, 38);

            // btnThemMoi
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location  = new System.Drawing.Point(4, 4);
            this.btnThemMoi.Size      = new System.Drawing.Size(80, 28);
            this.btnThemMoi.Text      = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click    += new System.EventHandler(this.btnThemMoi_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSua.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location  = new System.Drawing.Point(88, 4);
            this.btnSua.Size      = new System.Drawing.Size(52, 28);
            this.btnSua.Text      = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click    += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location  = new System.Drawing.Point(144, 4);
            this.btnXoa.Size      = new System.Drawing.Size(52, 28);
            this.btnXoa.Text      = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click    += new System.EventHandler(this.btnXoa_Click);

            // btnLuu
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 1;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLuu.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location  = new System.Drawing.Point(200, 4);
            this.btnLuu.Size      = new System.Drawing.Size(52, 28);
            this.btnLuu.Text      = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click    += new System.EventHandler(this.btnLuu_Click);

            // btnHuy
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 1;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHuy.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location  = new System.Drawing.Point(256, 4);
            this.btnHuy.Size      = new System.Drawing.Size(52, 28);
            this.btnHuy.Text      = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click    += new System.EventHandler(this.btnHuy_Click);

            // btnXuatHon
            this.btnXuatHon.BackColor = System.Drawing.Color.White;
            this.btnXuatHon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHon.FlatAppearance.BorderSize = 1;
            this.btnXuatHon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnXuatHon.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnXuatHon.ForeColor = System.Drawing.Color.Black;
            this.btnXuatHon.Location  = new System.Drawing.Point(312, 4);
            this.btnXuatHon.Size      = new System.Drawing.Size(90, 28);
            this.btnXuatHon.Text      = "Xuất hơn";
            this.btnXuatHon.UseVisualStyleBackColor = false;
            this.btnXuatHon.Click    += new System.EventHandler(this.btnXuatHon_Click);

            // Search controls
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTimKiem.Location      = new System.Drawing.Point(420, 7);
            this.cboTimKiem.Name          = "cboTimKiem";
            this.cboTimKiem.Size          = new System.Drawing.Size(130, 24);

            this.txtTimKiem.BorderStyle    = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font           = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor      = System.Drawing.Color.Gray;
            this.txtTimKiem.Location       = new System.Drawing.Point(556, 7);
            this.txtTimKiem.Name           = "txtTimKiem";
            this.txtTimKiem.Size           = new System.Drawing.Size(170, 24);
            this.txtTimKiem.Text           = "Nhập từ khóa...";

            // btnTim
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.FlatAppearance.BorderSize = 1;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTim.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location  = new System.Drawing.Point(732, 4);
            this.btnTim.Size      = new System.Drawing.Size(50, 28);
            this.btnTim.Text      = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click    += new System.EventHandler(this.btnTim_Click);

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderSize = 1;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location  = new System.Drawing.Point(786, 4);
            this.btnReset.Size      = new System.Drawing.Size(60, 28);
            this.btnReset.Text      = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click    += new System.EventHandler(this.btnReset_Click);

            // ── DataGridView ──────────────────────────────────────────
            this.dgvDanhSach.AllowUserToAddRows      = false;
            this.dgvDanhSach.AllowUserToDeleteRows   = false;
            this.dgvDanhSach.AutoSizeColumnsMode     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor         = System.Drawing.Color.FromArgb(220, 225, 235);
            this.dgvDanhSach.BorderStyle             = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock     = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSach.Name     = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 26;
            this.dgvDanhSach.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size            = new System.Drawing.Size(940, 240);
            this.dgvDanhSach.TabIndex        = 2;
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);

            // ── pnlThongTin ───────────────────────────────────────────
            this.pnlThongTin.BackColor = System.Drawing.Color.FromArgb(255, 253, 240);
            this.pnlThongTin.Controls.Add(this.pnlThongTinFields);
            this.pnlThongTin.Controls.Add(this.lblThongTinTitle);
            this.pnlThongTin.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Name     = "pnlThongTin";
            this.pnlThongTin.TabIndex = 3;

            this.lblThongTinTitle.AutoSize  = false;
            this.lblThongTinTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinTitle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTinTitle.ForeColor = System.Drawing.Color.FromArgb(0, 80, 180);
            this.lblThongTinTitle.Name      = "lblThongTinTitle";
            this.lblThongTinTitle.Padding   = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.lblThongTinTitle.Size      = new System.Drawing.Size(940, 28);
            this.lblThongTinTitle.Text      = "Thông Tin Hợp Đồng";

            this.pnlThongTinFields.BackColor = System.Drawing.Color.Transparent;
            this.pnlThongTinFields.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinFields.Name      = "pnlThongTinFields";

            // ── Row 1: Mã HĐ | Loại HĐ | Trạng thái
            // lblMaHopDong
            this.lblMaHopDong.AutoSize  = false;
            this.lblMaHopDong.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMaHopDong.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblMaHopDong.Location  = new System.Drawing.Point(20, 6);
            this.lblMaHopDong.Size      = new System.Drawing.Size(280, 16);
            this.lblMaHopDong.Text      = "Mã hợp đồng *";
            this.pnlThongTinFields.Controls.Add(this.lblMaHopDong);

            // txtMaHopDong
            this.txtMaHopDong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHopDong.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHopDong.Location    = new System.Drawing.Point(20, 22);
            this.txtMaHopDong.ReadOnly    = false;
            this.txtMaHopDong.BackColor   = System.Drawing.Color.White;
            this.txtMaHopDong.Size        = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.txtMaHopDong);

            // lblLoaiHopDong
            this.lblLoaiHopDong.AutoSize  = false;
            this.lblLoaiHopDong.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLoaiHopDong.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblLoaiHopDong.Location  = new System.Drawing.Point(320, 6);
            this.lblLoaiHopDong.Size      = new System.Drawing.Size(280, 16);
            this.lblLoaiHopDong.Text      = "Loại hợp đồng *";
            this.pnlThongTinFields.Controls.Add(this.lblLoaiHopDong);

            // cboLoaiHopDong
            this.cboLoaiHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHopDong.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiHopDong.Location      = new System.Drawing.Point(320, 22);
            this.cboLoaiHopDong.Size          = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.cboLoaiHopDong);

            // lblTrangThai
            this.lblTrangThai.AutoSize  = false;
            this.lblTrangThai.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblTrangThai.Location  = new System.Drawing.Point(620, 6);
            this.lblTrangThai.Size      = new System.Drawing.Size(280, 16);
            this.lblTrangThai.Text      = "Trạng thái *";
            this.pnlThongTinFields.Controls.Add(this.lblTrangThai);

            // cboTrangThai
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.Location      = new System.Drawing.Point(620, 22);
            this.cboTrangThai.Size          = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.cboTrangThai);

            // ── Row 2: Khách hàng | Nhân viên phụ trách | Ngày ký
            // lblKhachHang
            this.lblKhachHang.AutoSize  = false;
            this.lblKhachHang.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblKhachHang.Location  = new System.Drawing.Point(20, 56);
            this.lblKhachHang.Size      = new System.Drawing.Size(280, 16);
            this.lblKhachHang.Text      = "Khách hàng *";
            this.pnlThongTinFields.Controls.Add(this.lblKhachHang);

            // cboKhachHang
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhachHang.Location      = new System.Drawing.Point(20, 72);
            this.cboKhachHang.Size          = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.cboKhachHang);

            // lblNhanVienPhuTrach
            this.lblNhanVienPhuTrach.AutoSize  = false;
            this.lblNhanVienPhuTrach.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNhanVienPhuTrach.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblNhanVienPhuTrach.Location  = new System.Drawing.Point(320, 56);
            this.lblNhanVienPhuTrach.Size      = new System.Drawing.Size(280, 16);
            this.lblNhanVienPhuTrach.Text      = "Nhân viên phụ trách *";
            this.pnlThongTinFields.Controls.Add(this.lblNhanVienPhuTrach);

            // cboNhanVien
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVien.Location      = new System.Drawing.Point(320, 72);
            this.cboNhanVien.Size          = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.cboNhanVien);

            // lblNgayKy
            this.lblNgayKy.AutoSize  = false;
            this.lblNgayKy.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgayKy.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblNgayKy.Location  = new System.Drawing.Point(620, 56);
            this.lblNgayKy.Size      = new System.Drawing.Size(280, 16);
            this.lblNgayKy.Text      = "Ngày ký";
            this.pnlThongTinFields.Controls.Add(this.lblNgayKy);

            // dtpNgayKy
            this.dtpNgayKy.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKy.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKy.Location = new System.Drawing.Point(620, 72);
            this.dtpNgayKy.Size     = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.dtpNgayKy);

            // ── Row 3: Ngày bắt đầu | Ngày kết thúc | Tổng giá trị
            // lblNgayBatDau
            this.lblNgayBatDau.AutoSize  = false;
            this.lblNgayBatDau.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblNgayBatDau.Location  = new System.Drawing.Point(20, 106);
            this.lblNgayBatDau.Size      = new System.Drawing.Size(280, 16);
            this.lblNgayBatDau.Text      = "Ngày bắt đầu";
            this.pnlThongTinFields.Controls.Add(this.lblNgayBatDau);

            // dtpNgayBatDau
            this.dtpNgayBatDau.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(20, 122);
            this.dtpNgayBatDau.Size     = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.dtpNgayBatDau);

            // lblNgayKetThuc
            this.lblNgayKetThuc.AutoSize  = false;
            this.lblNgayKetThuc.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblNgayKetThuc.Location  = new System.Drawing.Point(320, 106);
            this.lblNgayKetThuc.Size      = new System.Drawing.Size(280, 16);
            this.lblNgayKetThuc.Text      = "Ngày kết thúc";
            this.pnlThongTinFields.Controls.Add(this.lblNgayKetThuc);

            // dtpNgayKetThuc
            this.dtpNgayKetThuc.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(320, 122);
            this.dtpNgayKetThuc.Size     = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.dtpNgayKetThuc);

            // lblTongGiaTri
            this.lblTongGiaTri.AutoSize  = false;
            this.lblTongGiaTri.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTongGiaTri.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblTongGiaTri.Location  = new System.Drawing.Point(620, 106);
            this.lblTongGiaTri.Size      = new System.Drawing.Size(280, 16);
            this.lblTongGiaTri.Text      = "Tổng giá trị (VNĐ)";
            this.pnlThongTinFields.Controls.Add(this.lblTongGiaTri);

            // txtTongGiaTri
            this.txtTongGiaTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongGiaTri.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongGiaTri.Location    = new System.Drawing.Point(620, 122);
            this.txtTongGiaTri.ReadOnly    = false;
            this.txtTongGiaTri.BackColor   = System.Drawing.Color.White;
            this.txtTongGiaTri.Size        = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.txtTongGiaTri);

            // ── Row 4: Đã thanh toán | Ghi chú | Còn lại
            // lblDaThanhToan
            this.lblDaThanhToan.AutoSize  = false;
            this.lblDaThanhToan.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblDaThanhToan.Location  = new System.Drawing.Point(20, 156);
            this.lblDaThanhToan.Size      = new System.Drawing.Size(280, 16);
            this.lblDaThanhToan.Text      = "Đã thanh toán (VNĐ)";
            this.pnlThongTinFields.Controls.Add(this.lblDaThanhToan);

            // txtDaThanhToan
            this.txtDaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaThanhToan.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDaThanhToan.Location    = new System.Drawing.Point(20, 172);
            this.txtDaThanhToan.ReadOnly    = false;
            this.txtDaThanhToan.BackColor   = System.Drawing.Color.White;
            this.txtDaThanhToan.Size        = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.txtDaThanhToan);

            // lblGhiChu
            this.lblGhiChu.AutoSize  = false;
            this.lblGhiChu.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblGhiChu.Location  = new System.Drawing.Point(320, 156);
            this.lblGhiChu.Size      = new System.Drawing.Size(280, 16);
            this.lblGhiChu.Text      = "Ghi chú";
            this.pnlThongTinFields.Controls.Add(this.lblGhiChu);

            // txtGhiChu
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location    = new System.Drawing.Point(320, 172);
            this.txtGhiChu.ReadOnly    = false;
            this.txtGhiChu.BackColor   = System.Drawing.Color.White;
            this.txtGhiChu.Size        = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.txtGhiChu);

            // lblConLai
            this.lblConLai.AutoSize  = false;
            this.lblConLai.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblConLai.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblConLai.Location  = new System.Drawing.Point(620, 156);
            this.lblConLai.Size      = new System.Drawing.Size(280, 16);
            this.lblConLai.Text      = "Còn lại (VNĐ)";
            this.pnlThongTinFields.Controls.Add(this.lblConLai);

            // txtConLai
            this.txtConLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConLai.Font        = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConLai.Location    = new System.Drawing.Point(620, 172);
            this.txtConLai.ReadOnly    = true;
            this.txtConLai.BackColor   = System.Drawing.Color.FromArgb(235, 237, 242);
            this.txtConLai.Size        = new System.Drawing.Size(280, 24);
            this.pnlThongTinFields.Controls.Add(this.txtConLai);

            // ── Status bar ────────────────────────────────────────────
            this.lblStatusBar.AutoSize  = false;
            this.lblStatusBar.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.lblStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatusBar.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
            this.lblStatusBar.Name      = "lblStatusBar";
            this.lblStatusBar.Padding   = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblStatusBar.Size      = new System.Drawing.Size(940, 22);
            this.lblStatusBar.Text      = "Tổng: 0 hợp đồng    Đã chọn:";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Timer
            this.timerClock.Interval = 1000;
            this.timerClock.Tick    += new System.EventHandler(this.timerClock_Tick);
            this.timerClock.Start();

            // ════════════════════════════════════════════
            //  POPUP MENU BÁO CÁO
            // ════════════════════════════════════════════
            this.pnlBaoCaoPopup.BackColor   = System.Drawing.Color.FromArgb(22, 38, 68);
            this.pnlBaoCaoPopup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBaoCaoPopup.Controls.Add(this.btnPopupHopDong);
            this.pnlBaoCaoPopup.Controls.Add(this.btnPopupDoanhThu);
            this.pnlBaoCaoPopup.Size        = new System.Drawing.Size(270, 100);
            this.pnlBaoCaoPopup.Visible     = false;
            this.pnlBaoCaoPopup.Name        = "pnlBaoCaoPopup";

            // btnPopupDoanhThu
            this.btnPopupDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.btnPopupDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnPopupDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 90, 170);
            this.btnPopupDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopupDoanhThu.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPopupDoanhThu.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.btnPopupDoanhThu.Location  = new System.Drawing.Point(0, 2);
            this.btnPopupDoanhThu.Size      = new System.Drawing.Size(268, 46);
            this.btnPopupDoanhThu.Text      = "  📊  Thống kê doanh thu theo ngày/tháng/năm";
            this.btnPopupDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopupDoanhThu.Name      = "btnPopupDoanhThu";
            this.btnPopupDoanhThu.Click    += new System.EventHandler(this.btnPopupDoanhThu_Click);

            // btnPopupHopDong
            this.btnPopupHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btnPopupHopDong.FlatAppearance.BorderSize = 0;
            this.btnPopupHopDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 90, 170);
            this.btnPopupHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopupHopDong.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPopupHopDong.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.btnPopupHopDong.Location  = new System.Drawing.Point(0, 50);
            this.btnPopupHopDong.Size      = new System.Drawing.Size(268, 46);
            this.btnPopupHopDong.Text      = "  📋  Thống kê số lượng hợp đồng theo trạng thái";
            this.btnPopupHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopupHopDong.Name      = "btnPopupHopDong";
            this.btnPopupHopDong.Click    += new System.EventHandler(this.btnPopupHopDong_Click);

            // ════════════════════════════════════════════
            //  PANEL BÁO CÁO INLINE
            // ════════════════════════════════════════════

            // pnlReportFilter
            this.pnlReportFilter.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.pnlReportFilter.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlReportFilter.Size      = new System.Drawing.Size(940, 50);
            this.pnlReportFilter.Name      = "pnlReportFilter";
            this.pnlReportFilter.Padding   = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlReportFilter.Controls.Add(this.btnLoadReport);
            this.pnlReportFilter.Controls.Add(this.dtpFilterDenNgay);
            this.pnlReportFilter.Controls.Add(this.lblFilterDenNgay);
            this.pnlReportFilter.Controls.Add(this.dtpFilterTuNgay);
            this.pnlReportFilter.Controls.Add(this.lblFilterTuNgay);
            this.pnlReportFilter.Controls.Add(this.cboFilterThang);
            this.pnlReportFilter.Controls.Add(this.lblFilterThang);
            this.pnlReportFilter.Controls.Add(this.nudFilterNam);
            this.pnlReportFilter.Controls.Add(this.lblFilterNam);
            this.pnlReportFilter.Controls.Add(this.cboFilterLoai);
            this.pnlReportFilter.Controls.Add(this.lblFilterLoai);

            // lblFilterLoai
            this.lblFilterLoai.AutoSize  = false;
            this.lblFilterLoai.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterLoai.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFilterLoai.Location  = new System.Drawing.Point(6, 14);
            this.lblFilterLoai.Size      = new System.Drawing.Size(42, 18);
            this.lblFilterLoai.Text      = "Loại:";
            this.lblFilterLoai.Name      = "lblFilterLoai";

            // cboFilterLoai
            this.cboFilterLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLoai.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterLoai.Location      = new System.Drawing.Point(50, 11);
            this.cboFilterLoai.Size          = new System.Drawing.Size(110, 24);
            this.cboFilterLoai.Name          = "cboFilterLoai";
            this.cboFilterLoai.Items.AddRange(new object[] { "Theo ngày", "Theo tháng", "Theo năm", "Khoảng ngày" });
            this.cboFilterLoai.SelectedIndex = 1;
            this.cboFilterLoai.SelectedIndexChanged += new System.EventHandler(this.cboFilterLoai_SelectedIndexChanged);

            // lblFilterNam
            this.lblFilterNam.AutoSize  = false;
            this.lblFilterNam.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterNam.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFilterNam.Location  = new System.Drawing.Point(172, 14);
            this.lblFilterNam.Size      = new System.Drawing.Size(36, 18);
            this.lblFilterNam.Text      = "Năm:";
            this.lblFilterNam.Name      = "lblFilterNam";

            // nudFilterNam
            this.nudFilterNam.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.nudFilterNam.Location = new System.Drawing.Point(210, 11);
            this.nudFilterNam.Size     = new System.Drawing.Size(68, 24);
            this.nudFilterNam.Minimum  = 2000;
            this.nudFilterNam.Maximum  = 2100;
            this.nudFilterNam.Value    = System.DateTime.Now.Year;
            this.nudFilterNam.Name     = "nudFilterNam";

            // lblFilterThang
            this.lblFilterThang.AutoSize  = false;
            this.lblFilterThang.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterThang.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFilterThang.Location  = new System.Drawing.Point(286, 14);
            this.lblFilterThang.Size      = new System.Drawing.Size(46, 18);
            this.lblFilterThang.Text      = "Tháng:";
            this.lblFilterThang.Name      = "lblFilterThang";

            // cboFilterThang
            this.cboFilterThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterThang.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterThang.Location      = new System.Drawing.Point(334, 11);
            this.cboFilterThang.Size          = new System.Drawing.Size(70, 24);
            this.cboFilterThang.Name          = "cboFilterThang";
            this.cboFilterThang.Items.AddRange(new object[] {
                "Tất cả","01","02","03","04","05","06",
                "07","08","09","10","11","12" });
            this.cboFilterThang.SelectedIndex = 0;

            // lblFilterTuNgay
            this.lblFilterTuNgay.AutoSize  = false;
            this.lblFilterTuNgay.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterTuNgay.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFilterTuNgay.Location  = new System.Drawing.Point(416, 14);
            this.lblFilterTuNgay.Size      = new System.Drawing.Size(52, 18);
            this.lblFilterTuNgay.Text      = "Từ ngày:";
            this.lblFilterTuNgay.Name      = "lblFilterTuNgay";
            this.lblFilterTuNgay.Visible   = false;

            // dtpFilterTuNgay
            this.dtpFilterTuNgay.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterTuNgay.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterTuNgay.Location = new System.Drawing.Point(470, 11);
            this.dtpFilterTuNgay.Size     = new System.Drawing.Size(110, 24);
            this.dtpFilterTuNgay.Value    = System.DateTime.Today.AddMonths(-1);
            this.dtpFilterTuNgay.Name     = "dtpFilterTuNgay";
            this.dtpFilterTuNgay.Visible  = false;

            // lblFilterDenNgay
            this.lblFilterDenNgay.AutoSize  = false;
            this.lblFilterDenNgay.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterDenNgay.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblFilterDenNgay.Location  = new System.Drawing.Point(586, 14);
            this.lblFilterDenNgay.Size      = new System.Drawing.Size(56, 18);
            this.lblFilterDenNgay.Text      = "Đến ngày:";
            this.lblFilterDenNgay.Name      = "lblFilterDenNgay";
            this.lblFilterDenNgay.Visible   = false;

            // dtpFilterDenNgay
            this.dtpFilterDenNgay.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterDenNgay.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDenNgay.Location = new System.Drawing.Point(644, 11);
            this.dtpFilterDenNgay.Size     = new System.Drawing.Size(110, 24);
            this.dtpFilterDenNgay.Value    = System.DateTime.Today;
            this.dtpFilterDenNgay.Name     = "dtpFilterDenNgay";
            this.dtpFilterDenNgay.Visible  = false;

            // btnLoadReport
            this.btnLoadReport.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.FlatAppearance.BorderSize = 0;
            this.btnLoadReport.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Location  = new System.Drawing.Point(762, 11);
            this.btnLoadReport.Size      = new System.Drawing.Size(100, 28);
            this.btnLoadReport.Text      = "▶  Xem báo cáo";
            this.btnLoadReport.Name      = "btnLoadReport";
            this.btnLoadReport.UseVisualStyleBackColor = false;
            this.btnLoadReport.Click    += new System.EventHandler(this.btnLoadReport_Click);

            // pnlKpiBar
            this.pnlKpiBar.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlKpiBar.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiBar.Size      = new System.Drawing.Size(940, 68);
            this.pnlKpiBar.Name      = "pnlKpiBar";
            this.pnlKpiBar.Controls.Add(this.lblKpi4);
            this.pnlKpiBar.Controls.Add(this.lblKpi3);
            this.pnlKpiBar.Controls.Add(this.lblKpi2);
            this.pnlKpiBar.Controls.Add(this.lblKpi1);

            this.lblKpi1.AutoSize  = false;
            this.lblKpi1.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi1.ForeColor = System.Drawing.Color.FromArgb(22, 44, 88);
            this.lblKpi1.Location  = new System.Drawing.Point(12, 8);
            this.lblKpi1.Size      = new System.Drawing.Size(200, 50);
            this.lblKpi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKpi1.Name      = "lblKpi1";
            this.lblKpi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKpi1.BackColor = System.Drawing.Color.White;

            this.lblKpi2.AutoSize  = false;
            this.lblKpi2.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi2.ForeColor = System.Drawing.Color.FromArgb(22, 44, 88);
            this.lblKpi2.Location  = new System.Drawing.Point(224, 8);
            this.lblKpi2.Size      = new System.Drawing.Size(200, 50);
            this.lblKpi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKpi2.Name      = "lblKpi2";
            this.lblKpi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKpi2.BackColor = System.Drawing.Color.White;

            this.lblKpi3.AutoSize  = false;
            this.lblKpi3.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi3.ForeColor = System.Drawing.Color.FromArgb(22, 44, 88);
            this.lblKpi3.Location  = new System.Drawing.Point(436, 8);
            this.lblKpi3.Size      = new System.Drawing.Size(200, 50);
            this.lblKpi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKpi3.Name      = "lblKpi3";
            this.lblKpi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKpi3.BackColor = System.Drawing.Color.White;

            this.lblKpi4.AutoSize  = false;
            this.lblKpi4.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi4.ForeColor = System.Drawing.Color.FromArgb(22, 44, 88);
            this.lblKpi4.Location  = new System.Drawing.Point(648, 8);
            this.lblKpi4.Size      = new System.Drawing.Size(200, 50);
            this.lblKpi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKpi4.Name      = "lblKpi4";
            this.lblKpi4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKpi4.BackColor = System.Drawing.Color.White;

            // dgvReport
            this.dgvReport.AllowUserToAddRows    = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor       = System.Drawing.Color.White;
            this.dgvReport.BorderStyle           = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Name      = "dgvReport";
            this.dgvReport.ReadOnly  = true;
            this.dgvReport.RowHeadersWidth = 26;
            this.dgvReport.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.TabIndex  = 0;

            // pnlReport
            this.pnlReport.BackColor = System.Drawing.Color.White;
            this.pnlReport.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Name      = "pnlReport";
            this.pnlReport.Visible   = false;
            this.pnlReport.Controls.Add(this.dgvReport);
            this.pnlReport.Controls.Add(this.pnlKpiBar);
            this.pnlReport.Controls.Add(this.pnlReportFilter);

            // ════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlBaoCaoPopup);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize     = new System.Drawing.Size(960, 600);
            this.Name            = "frmMain";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Hệ Thống Quản Lý Hợp Đồng Quảng Cáo";
            this.MouseClick     += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterNam)).EndInit();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTinFields.ResumeLayout(false);
            this.pnlThongTinFields.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlReportFilter.ResumeLayout(false);
            this.pnlKpiBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Fields ────────────────────────────────────────────────
        private System.Windows.Forms.Panel       pnlSidebar;
        private System.Windows.Forms.Panel       pnlUserInfo;
        private System.Windows.Forms.Label       lblHoTen;
        private System.Windows.Forms.Label       lblVaiTro;
        private System.Windows.Forms.Label       lblDanhMucHeader;
        private System.Windows.Forms.Button      btnHopDong;
        private System.Windows.Forms.Button      btnKhachHang;
        private System.Windows.Forms.Button      btnBaiViet;
        private System.Windows.Forms.Button      btnDonViPhatHanh;
        private System.Windows.Forms.Label       lblHeThongHeader;
        private System.Windows.Forms.Button      btnBaoCao;
        private System.Windows.Forms.Button      btnNguoiDung;

        // Popup báo cáo
        private System.Windows.Forms.Panel       pnlBaoCaoPopup;
        private System.Windows.Forms.Button      btnPopupDoanhThu;
        private System.Windows.Forms.Button      btnPopupHopDong;

        private System.Windows.Forms.Panel       pnlMain;
        private System.Windows.Forms.Label       lblModuleTitle;
        private System.Windows.Forms.Panel       pnlToolbar;
        private System.Windows.Forms.Button      btnThemMoi;
        private System.Windows.Forms.Button      btnSua;
        private System.Windows.Forms.Button      btnXoa;
        private System.Windows.Forms.Button      btnLuu;
        private System.Windows.Forms.Button      btnHuy;
        private System.Windows.Forms.Button      btnXuatHon;
        private System.Windows.Forms.ComboBox    cboTimKiem;
        private System.Windows.Forms.TextBox     txtTimKiem;
        private System.Windows.Forms.Button      btnTim;
        private System.Windows.Forms.Button      btnReset;
        private System.Windows.Forms.DataGridView dgvDanhSach;

        private System.Windows.Forms.Panel       pnlThongTin;
        private System.Windows.Forms.Label       lblThongTinTitle;
        private System.Windows.Forms.Panel       pnlThongTinFields;

        private System.Windows.Forms.Label       lblMaHopDong;
        private System.Windows.Forms.TextBox     txtMaHopDong;
        private System.Windows.Forms.Label       lblLoaiHopDong;
        private System.Windows.Forms.ComboBox    cboLoaiHopDong;
        private System.Windows.Forms.Label       lblTrangThai;
        private System.Windows.Forms.ComboBox    cboTrangThai;

        private System.Windows.Forms.Label       lblKhachHang;
        private System.Windows.Forms.ComboBox    cboKhachHang;
        private System.Windows.Forms.Label       lblNhanVienPhuTrach;
        private System.Windows.Forms.ComboBox    cboNhanVien;
        private System.Windows.Forms.Label       lblNgayKy;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;

        private System.Windows.Forms.Label       lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label       lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label       lblTongGiaTri;
        private System.Windows.Forms.TextBox     txtTongGiaTri;

        private System.Windows.Forms.Label       lblDaThanhToan;
        private System.Windows.Forms.TextBox     txtDaThanhToan;
        private System.Windows.Forms.Label       lblGhiChu;
        private System.Windows.Forms.TextBox     txtGhiChu;
        private System.Windows.Forms.Label       lblConLai;
        private System.Windows.Forms.TextBox     txtConLai;

        private System.Windows.Forms.Label       lblStatusBar;
        private System.Windows.Forms.Timer       timerClock;

        // Report panel inline
        private System.Windows.Forms.Panel            pnlReport;
        private System.Windows.Forms.Panel            pnlReportFilter;
        private System.Windows.Forms.Label            lblFilterLoai;
        private System.Windows.Forms.ComboBox         cboFilterLoai;
        private System.Windows.Forms.Label            lblFilterNam;
        private System.Windows.Forms.NumericUpDown    nudFilterNam;
        private System.Windows.Forms.Label            lblFilterThang;
        private System.Windows.Forms.ComboBox         cboFilterThang;
        private System.Windows.Forms.Label            lblFilterTuNgay;
        private System.Windows.Forms.DateTimePicker   dtpFilterTuNgay;
        private System.Windows.Forms.Label            lblFilterDenNgay;
        private System.Windows.Forms.DateTimePicker   dtpFilterDenNgay;
        private System.Windows.Forms.Button           btnLoadReport;
        private System.Windows.Forms.Panel            pnlKpiBar;
        private System.Windows.Forms.Label            lblKpi1;
        private System.Windows.Forms.Label            lblKpi2;
        private System.Windows.Forms.Label            lblKpi3;
        private System.Windows.Forms.Label            lblKpi4;
        private System.Windows.Forms.DataGridView     dgvReport;
    }
}
