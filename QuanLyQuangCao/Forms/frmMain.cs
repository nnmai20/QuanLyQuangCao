using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AuthForms.BLL;
using AuthForms.DAL;

namespace AuthForms.UI
{
    public partial class frmMain : Form
    {
        // ── State ──────────────────────────────────────────────────────
        private string _currentModule   = "HopDong";
        private Button _activeNavBtn    = null;
        private bool   _isEditMode      = false;
        private int    _selectedHopDongId = -1;
        private string _reportMode        = ""; // "DoanhThu" | "HopDong"

        // ── Child Report Forms ──
        private frmBaoCaoDoanhThu _frmBaoCaoDoanhThu;
        private frmThongKeHopDong _frmThongKeHopDong;

        // ── BLL ────────────────────────────────────────────────────────
        private readonly HopDongBLL  _hopDongBLL  = new HopDongBLL();
        private readonly KhachHangBLL _khachHangBLL = new KhachHangBLL();

        // ──────────────────────────────────────────────────────────────
        public frmMain(string roleTieuDe = "", bool showAdmin = false)
        {
            InitializeComponent();
            SetupDgv();
            ApplyNhanVienInfo();
            SetActiveNav(btnHopDong);
            LoadHopDong();
            SetEditMode(false);

            if (!showAdmin)
            {
                btnNguoiDung.Visible = false;
                lblHeThongHeader.Visible = false;
            }
        }

        // ── User info ─────────────────────────────────────────────────
        private void ApplyNhanVienInfo()
        {
            lblHoTen.Text  = Session.NguoiDungHienTai?.HoTen  ?? "Khách";
            lblVaiTro.Text = Session.NguoiDungHienTai?.VaiTro ?? "Nhân viên";
        }

        // ── DataGridView setup ────────────────────────────────────────
        private void SetupDgv()
        {
            dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor  = Color.FromArgb(22, 44, 88);
            dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor  = Color.White;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Font       = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDanhSach.DefaultCellStyle.Font                    = new Font("Segoe UI", 9F);
            dgvDanhSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 255);
            dgvDanhSach.RowTemplate.Height                        = 26;
            dgvDanhSach.EnableHeadersVisualStyles                 = false;
        }

        // ── Load dữ liệu hợp đồng ────────────────────────────────────
        private void LoadHopDong()
        {
            try
            {
                DataTable dt = _hopDongBLL.GetAll();
                dgvDanhSach.DataSource = dt;

                // Hide technical ID column from user
                if (dgvDanhSach.Columns.Contains("Id"))
                    dgvDanhSach.Columns["Id"].Visible = false;

                // Set headers to accented Vietnamese
                if (dgvDanhSach.Columns.Contains("MaHopDong")) dgvDanhSach.Columns["MaHopDong"].HeaderText = "Mã Hợp Đồng";
                if (dgvDanhSach.Columns.Contains("TenKhachHang")) dgvDanhSach.Columns["TenKhachHang"].HeaderText = "Khách Hàng";
                if (dgvDanhSach.Columns.Contains("GhiChu")) dgvDanhSach.Columns["GhiChu"].HeaderText = "Ghi Chú";
                if (dgvDanhSach.Columns.Contains("NgayKy")) dgvDanhSach.Columns["NgayKy"].HeaderText = "Ngày Ký";
                if (dgvDanhSach.Columns.Contains("NgayBatDau")) dgvDanhSach.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                if (dgvDanhSach.Columns.Contains("NgayKetThuc")) dgvDanhSach.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                if (dgvDanhSach.Columns.Contains("TongGiaTri")) dgvDanhSach.Columns["TongGiaTri"].HeaderText = "Tổng Giá Trị";
                if (dgvDanhSach.Columns.Contains("DaThanhToan")) dgvDanhSach.Columns["DaThanhToan"].HeaderText = "Đã Thanh Toán";
                if (dgvDanhSach.Columns.Contains("TrangThai")) dgvDanhSach.Columns["TrangThai"].HeaderText = "Trạng Thái";
                if (dgvDanhSach.Columns.Contains("LoaiHopDong")) dgvDanhSach.Columns["LoaiHopDong"].HeaderText = "Loại Hợp Đồng";

                lblStatusBar.Text = $"Tổng: {dt.Rows.Count} hợp đồng    Đã chọn:";

                // Populate search combobox
                cboTimKiem.Items.Clear();
                cboTimKiem.Items.AddRange(new object[] { "Mã HĐ", "Khách hàng", "Nhân viên", "Loại HĐ", "Trạng thái" });
                if (cboTimKiem.Items.Count > 0) cboTimKiem.SelectedIndex = 0;

                // Populate form combos
                LoadCboKhachHang();
                LoadCboLoaiHopDong();
                LoadCboTrangThai();
                LoadCboNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCboKhachHang()
        {
            try
            {
                DataTable dt = _khachHangBLL.GetAll();
                cboKhachHang.DataSource    = dt;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember   = "MaKhachHang";
            }
            catch { }
        }

        private void LoadCboLoaiHopDong()
        {
            cboLoaiHopDong.Items.Clear();
            cboLoaiHopDong.Items.AddRange(new object[] {
                "Quảng cáo Banner", "Quảng cáo Video", "Tài trợ sự kiện", "Quảng cáo Báo chí"
            });
            if (cboLoaiHopDong.Items.Count > 0) cboLoaiHopDong.SelectedIndex = 0;
        }

        private void LoadCboTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] {
                "Đang hiệu lực", "Hết hiệu lực", "Đã hủy", "Chờ duyệt"
            });
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
        }

        private void LoadCboNhanVien()
        {
            try
            {
                DataTable dt = new NguoiDungDAL().GetAll();
                cboNhanVien.DataSource    = dt;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember   = "MaNguoiDung";
            }
            catch { }
        }

        // ── Edit mode ─────────────────────────────────────────────────
        private void SetEditMode(bool editing)
        {
            _isEditMode = editing;

            txtMaHopDong.ReadOnly    = !editing;
            cboLoaiHopDong.Enabled   = editing;
            cboTrangThai.Enabled     = editing;
            cboKhachHang.Enabled     = editing;
            cboNhanVien.Enabled      = editing;
            dtpNgayKy.Enabled        = editing;
            dtpNgayBatDau.Enabled    = editing;
            dtpNgayKetThuc.Enabled   = editing;
            txtTongGiaTri.ReadOnly   = !editing;
            txtDaThanhToan.ReadOnly  = !editing;
            txtGhiChu.ReadOnly       = !editing;

            btnLuu.Enabled   = editing;
            btnHuy.Enabled   = editing;
            btnThemMoi.Enabled  = !editing;
            btnSua.Enabled      = !editing;
            btnXoa.Enabled      = !editing;

            if (!editing) ClearFields();
        }

        private void ClearFields()
        {
            txtMaHopDong.Text    = "";
            txtTongGiaTri.Text   = "";
            txtDaThanhToan.Text  = "";
            txtGhiChu.Text       = "Nhập ghi chú...";
            txtGhiChu.ForeColor  = Color.Gray;
            txtConLai.Text       = "";
            dtpNgayKy.Value      = DateTime.Today;
            dtpNgayBatDau.Value  = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddMonths(1);
            _selectedHopDongId   = -1;
        }

        private void FillFieldsFromRow(DataGridViewRow row)
        {
            if (row == null) return;
            txtMaHopDong.Text   = row.Cells["MaHopDong"]?.Value?.ToString()   ?? "";
            txtTongGiaTri.Text  = row.Cells["TongGiaTri"]?.Value?.ToString()  ?? "";
            txtDaThanhToan.Text = row.Cells["DaThanhToan"]?.Value?.ToString() ?? "";
            
            string gc = row.Cells["GhiChu"]?.Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(gc))
            {
                txtGhiChu.Text = "Nhập ghi chú...";
                txtGhiChu.ForeColor = Color.Gray;
            }
            else
            {
                txtGhiChu.Text = gc;
                txtGhiChu.ForeColor = Color.Black;
            }

            CalculateConLai();

            if (row.Cells["NgayKy"]?.Value is DateTime ngayKy)        dtpNgayKy.Value      = ngayKy;
            if (row.Cells["NgayBatDau"]?.Value is DateTime ngayBD)    dtpNgayBatDau.Value  = ngayBD;
            if (row.Cells["NgayKetThuc"]?.Value is DateTime ngayKT)   dtpNgayKetThuc.Value = ngayKT;

            string loai = row.Cells["LoaiHopDong"]?.Value?.ToString() ?? "";
            if (cboLoaiHopDong.Items.Contains(loai)) cboLoaiHopDong.SelectedItem = loai;

            string tt = row.Cells["TrangThai"]?.Value?.ToString() ?? "";
            if (cboTrangThai.Items.Contains(tt)) cboTrangThai.SelectedItem = tt;

            if (row.Cells["MaKhachHang"]?.Value != null)
                cboKhachHang.SelectedValue = row.Cells["MaKhachHang"].Value;

            if (row.Cells["MaNguoiDung"]?.Value != null)
                cboNhanVien.SelectedValue = row.Cells["MaNguoiDung"].Value;

            if (row.Cells["Id"]?.Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int id))
                _selectedHopDongId = id;
        }

        private void CalculateConLai()
        {
            decimal tong  = 0, da = 0;
            decimal.TryParse(txtTongGiaTri.Text.Replace(",", ""), out tong);
            decimal.TryParse(txtDaThanhToan.Text.Replace(",", ""), out da);
            txtConLai.Text = (tong - da).ToString("N0");
        }

        // ── Sidebar navigation ────────────────────────────────────────
        private void SetActiveNav(Button btn)
        {
            if (_activeNavBtn != null)
            {
                _activeNavBtn.BackColor = Color.Transparent;
                _activeNavBtn.ForeColor = Color.FromArgb(200, 218, 250);
            }
            _activeNavBtn           = btn;
            btn.BackColor           = Color.FromArgb(40, 70, 130);
            btn.ForeColor           = Color.White;
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            HideReportPanel();
            SetActiveNav(btnHopDong);
            lblModuleTitle.Text  = "Quản lý Hợp Đồng Quảng Cáo";
            lblThongTinTitle.Text = "Thông Tin Hợp Đồng";
            _currentModule       = "HopDong";
            LoadHopDong();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            HideReportPanel();
            SetActiveNav(btnKhachHang);
            lblModuleTitle.Text  = "Quản lý Khách Hàng";
            lblThongTinTitle.Text = "Thông Tin Khách Hàng";
            _currentModule       = "KhachHang";
            dgvDanhSach.DataSource = _khachHangBLL.GetAll();

            // Set grid headers for customer list
            if (dgvDanhSach.Columns.Contains("MaKhachHang")) dgvDanhSach.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
            if (dgvDanhSach.Columns.Contains("TenKhachHang")) dgvDanhSach.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
        }

        private void btnBaiViet_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            HideReportPanel();
            SetActiveNav(btnBaiViet);
            lblModuleTitle.Text  = "Quản lý Bài Viết";
            lblThongTinTitle.Text = "Thông Tin Bài Viết";
            _currentModule       = "BaiViet";
            dgvDanhSach.DataSource = null;
        }

        private void btnDonViPhatHanh_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            HideReportPanel();
            SetActiveNav(btnDonViPhatHanh);
            lblModuleTitle.Text  = "Đơn Vị Phát Hành";
            lblThongTinTitle.Text = "Thông Tin Đơn Vị";
            _currentModule       = "DonVi";
            dgvDanhSach.DataSource = null;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnBaoCao);
            _currentModule = "BaoCao";

            // Toggle popup menu
            if (pnlBaoCaoPopup.Visible)
            {
                pnlBaoCaoPopup.Visible = false;
                return;
            }

            // Position popup to the right of the sidebar button
            Point btnScreen = btnBaoCao.PointToScreen(new Point(btnBaoCao.Width, 0));
            Point formPos   = this.PointToClient(btnScreen);
            pnlBaoCaoPopup.Location = formPos;
            pnlBaoCaoPopup.Visible  = true;
            pnlBaoCaoPopup.BringToFront();
        }

        private void btnPopupDoanhThu_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            _reportMode = "DoanhThu";
            ShowReportPanel();
            lblModuleTitle.Text = "Thống kê Doanh Thu theo Ngày / Tháng / Năm";
            _frmBaoCaoDoanhThu?.LoadDuLieu();
        }

        private void btnPopupHopDong_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            _reportMode = "HopDong";
            ShowReportPanel();
            lblModuleTitle.Text = "Thống kê Số Lượng Hợp Đồng theo Ngày / Tháng / Trạng Thái";
            _frmThongKeHopDong?.LoadDuLieu();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            pnlBaoCaoPopup.Visible = false;
            HideReportPanel();
            SetActiveNav(btnNguoiDung);
            lblModuleTitle.Text  = "Quản lý Người Dùng";
            _currentModule       = "NguoiDung";
            dgvDanhSach.DataSource = null;
        }

        // ── Toolbar events ────────────────────────────────────────────
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetEditMode(true);
            txtMaHopDong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SetEditMode(true);
            FillFieldsFromRow(dgvDanhSach.CurrentRow);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _hopDongBLL.Delete(_selectedHopDongId);
                    LoadHopDong();
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHopDong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHopDong.Focus();
                return;
            }

            try
            {
                var row = new HopDongRow
                {
                    MaHopDong    = txtMaHopDong.Text.Trim(),
                    LoaiHopDong  = cboLoaiHopDong.SelectedItem?.ToString() ?? "",
                    TrangThai    = cboTrangThai.SelectedItem?.ToString()   ?? "",
                    MaKhachHang  = (int)(cboKhachHang.SelectedValue ?? 0),
                    MaNguoiDung  = (int)(cboNhanVien.SelectedValue  ?? 0),
                    NgayKy       = dtpNgayKy.Value,
                    NgayBatDau   = dtpNgayBatDau.Value,
                    NgayKetThuc  = dtpNgayKetThuc.Value,
                    TongGiaTri   = decimal.TryParse(txtTongGiaTri.Text, out decimal tg) ? tg : 0,
                    DaThanhToan  = decimal.TryParse(txtDaThanhToan.Text, out decimal dt2) ? dt2 : 0,
                    GhiChu       = txtGhiChu.Text == "Nhập ghi chú..." ? "" : txtGhiChu.Text.Trim()
                };

                if (_selectedHopDongId < 0)
                    _hopDongBLL.Insert(row);
                else
                {
                    row.Id = _selectedHopDongId;
                    _hopDongBLL.Update(row);
                }

                SetEditMode(false);
                LoadHopDong();
                MessageBox.Show("Lưu thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
        }

        private void btnXuatHon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất dữ liệu đang được phát triển.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Search ────────────────────────────────────────────────────
        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (keyword == "Nhập từ khóa..." || string.IsNullOrEmpty(keyword))
            {
                LoadHopDong(); return;
            }
            try
            {
                DataTable dt = _hopDongBLL.Search(keyword);
                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns.Contains("Id"))
                    dgvDanhSach.Columns["Id"].Visible = false;

                lblStatusBar.Text = $"Tổng: {dt.Rows.Count} kết quả    Từ khóa: {keyword}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text      = "Nhập từ khóa...";
            txtTimKiem.ForeColor = Color.Gray;
            LoadHopDong();
        }

        // ── Grid selection ────────────────────────────────────────────
        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && !_isEditMode)
            {
                FillFieldsFromRow(dgvDanhSach.CurrentRow);
                int count = dgvDanhSach.SelectedRows.Count;
                lblStatusBar.Text = $"Tổng: {dgvDanhSach.Rows.Count} hợp đồng    Đã chọn: {count}";
            }
        }

        // ── Timer ─────────────────────────────────────────────────────
        private void timerClock_Tick(object sender, EventArgs e)
        {
            // Could update a clock label here if needed
        }

        // ── Form MouseClick — đóng popup khi click ngoài ──────────────────────
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlBaoCaoPopup.Visible && !pnlBaoCaoPopup.Bounds.Contains(e.Location))
                pnlBaoCaoPopup.Visible = false;
        }

        private void ShowReportPanel()
        {
            pnlToolbar.Visible   = false;
            dgvDanhSach.Visible  = false;
            pnlThongTin.Visible  = false;

            if (_reportMode == "DoanhThu")
            {
                if (_frmThongKeHopDong != null) _frmThongKeHopDong.Visible = false;

                if (_frmBaoCaoDoanhThu == null || _frmBaoCaoDoanhThu.IsDisposed)
                {
                    _frmBaoCaoDoanhThu = new frmBaoCaoDoanhThu();
                    _frmBaoCaoDoanhThu.TopLevel = false;
                    _frmBaoCaoDoanhThu.FormBorderStyle = FormBorderStyle.None;
                    _frmBaoCaoDoanhThu.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(_frmBaoCaoDoanhThu);
                }
                _frmBaoCaoDoanhThu.Visible = true;
                _frmBaoCaoDoanhThu.BringToFront();
            }
            else
            {
                if (_frmBaoCaoDoanhThu != null) _frmBaoCaoDoanhThu.Visible = false;

                if (_frmThongKeHopDong == null || _frmThongKeHopDong.IsDisposed)
                {
                    _frmThongKeHopDong = new frmThongKeHopDong();
                    _frmThongKeHopDong.TopLevel = false;
                    _frmThongKeHopDong.FormBorderStyle = FormBorderStyle.None;
                    _frmThongKeHopDong.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(_frmThongKeHopDong);
                }
                _frmThongKeHopDong.Visible = true;
                _frmThongKeHopDong.BringToFront();
            }
        }

        private void HideReportPanel()
        {
            if (_frmBaoCaoDoanhThu != null) _frmBaoCaoDoanhThu.Visible = false;
            if (_frmThongKeHopDong != null) _frmThongKeHopDong.Visible = false;
            
            pnlToolbar.Visible   = true;
            dgvDanhSach.Visible  = true;
            pnlThongTin.Visible  = true;
        }

        // Compatibility event handlers for old frmMain.Designer.cs elements
        private void cboFilterLoai_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnLoadReport_Click(object sender, EventArgs e) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtTongGiaTri.TextChanged  += (s, _) => CalculateConLai();
            txtDaThanhToan.TextChanged += (s, _) => CalculateConLai();

            // Placeholder behaviour for Search
            txtTimKiem.GotFocus  += (s, _) => {
                if (txtTimKiem.Text == "Nhập từ khóa...") {
                    txtTimKiem.Text = ""; txtTimKiem.ForeColor = Color.Black; }
            };
            txtTimKiem.LostFocus += (s, _) => {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) {
                    txtTimKiem.Text = "Nhập từ khóa..."; txtTimKiem.ForeColor = Color.Gray; }
            };

            // Placeholder behaviour for Ghi Chu
            txtGhiChu.GotFocus  += (s, _) => {
                if (txtGhiChu.Text == "Nhập ghi chú...") {
                    txtGhiChu.Text = ""; txtGhiChu.ForeColor = Color.Black; }
            };
            txtGhiChu.LostFocus += (s, _) => {
                if (string.IsNullOrWhiteSpace(txtGhiChu.Text) || txtGhiChu.Text == "Nhập ghi chú...") {
                    txtGhiChu.Text = "Nhập ghi chú..."; txtGhiChu.ForeColor = Color.Gray; }
            };
        }
    }
}
