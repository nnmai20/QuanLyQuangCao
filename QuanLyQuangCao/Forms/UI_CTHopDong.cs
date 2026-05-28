using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QlyHopDong.BLL;
using QlyHopDong.DTO;

namespace QlyHopDong.UI
{
    /// <summary>
    /// UserControl dùng chung cho Thêm mới và Sửa hợp đồng.
    /// MaHopDong là INT IDENTITY — không cần sinh mã thủ công.
    /// </summary>
    public partial class UI_CTHopDong : UserControl
    {
        private readonly HopDongBLL _bll = new HopDongBLL();
        private readonly HopDongDTO _dtoGoc;       // null = Thêm mới
        private bool IsEditMode => _dtoGoc != null;

        // Callback để UI_HopDong reload danh sách sau khi lưu
        public Action OnLuuThanhCong { get; set; }

        // ──────────────────────────────────────────────
        // Constructors
        // ──────────────────────────────────────────────
        public UI_CTHopDong()
        {
            InitializeComponent();
            _dtoGoc = null;
            this.Load += UI_CTHopDong_Load;
        }

        public UI_CTHopDong(HopDongDTO dto)
        {
            InitializeComponent();
            _dtoGoc = dto ?? throw new ArgumentNullException(nameof(dto));
            this.Load += UI_CTHopDong_Load;
        }

        // ──────────────────────────────────────────────
        // Load
        // ──────────────────────────────────────────────
        private void UI_CTHopDong_Load(object sender, EventArgs e)
        {
            WireButtonEvents();
            ApDungStyle();

            NapDanhSachKhachHang();
            NapDanhSachNhanVien();
            NapLoaiHopDong();
            NapTrangThai();

            txtTGT.TextChanged += TinhConLai;
            txtDTT.TextChanged += TinhConLai;
            cboKhachHang.SelectedIndexChanged += CboKhachHang_Changed;

            if (IsEditMode)
                DienDuLieuVaoForm();
            else
                HienThiModeThem();

            CapNhatTieuDe();
        }

        // ──────────────────────────────────────────────
        // Gắn sự kiện nút (Designer khai báo biến cục bộ)
        // ──────────────────────────────────────────────
        private void WireButtonEvents()
        {
            foreach (Control c in panelThaoTac.Controls)
            {
                if (c is Button btn)
                    switch (btn.Name)
                    {
                        case "btnLuu": btn.Click += BtnLuu_Click; break;
                        case "btnHuy": btn.Click += BtnHuy_Click; break;
                    }
            }
        }

        // ──────────────────────────────────────────────
        // Style các control
        // ──────────────────────────────────────────────
        private void ApDungStyle()
        {
            foreach (Control c in panelThaoTac.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10f);
                    btn.Cursor = Cursors.Hand;
                    btn.Size = new Size(btn.Name == "btnLuu" ? 140 : 110, 40);

                    if (btn.Name == "btnLuu")
                    {
                        btn.BackColor = Color.FromArgb(22, 163, 74);
                        btn.ForeColor = Color.White;
                    }
                    else if (btn.Name == "btnHuy")
                    {
                        btn.BackColor = Color.FromArgb(245, 246, 248);
                        btn.ForeColor = Color.FromArgb(60, 70, 90);
                        btn.FlatAppearance.BorderSize = 1;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 210);
                        btn.Text = "✕  Hủy";
                    }
                }
            }

            panelHeader.BackColor = Color.FromArgb(46, 74, 122);
            lblHeader.ForeColor = Color.White;

            // txtMaHD — hiển thị số tự động, readonly
            txtMaHD.ReadOnly = true;
            txtMaHD.BackColor = Color.FromArgb(245, 246, 248);
            txtMaHD.Text = "(Tự động)";

            // txtCL — tự tính, readonly
            txtCL.ReadOnly = true;
            txtCL.BackColor = Color.FromArgb(245, 246, 248);
            txtCL.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            // txtSDT, txtDiaChi — tự điền từ DB
            txtSDT.ReadOnly = true;
            txtSDT.BackColor = Color.FromArgb(245, 246, 248);
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.FromArgb(245, 246, 248);
        }

        // ──────────────────────────────────────────────
        // Nạp ComboBox
        // ──────────────────────────────────────────────
        private void NapDanhSachKhachHang()
        {
            try
            {
                DataTable dt = _bll.GetDanhSachKhachHang();
                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember = "MaKhachHang";   // int
                cboKhachHang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khách hàng:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NapDanhSachNhanVien()
        {
            try
            {
                DataTable dt = _bll.GetDanhSachNhanVien();
                cboNhanVien.DataSource = dt;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNguoiDung";    // int
                cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NapLoaiHopDong()
        {
            // Lấy các loại HĐ thực tế từ dữ liệu mẫu trong DB
            cboLHD.Items.Clear();
            cboLHD.Items.Add("Hợp đồng quảng cáo trang bìa");
            cboLHD.Items.Add("Hợp đồng quảng cáo nửa trang");
            cboLHD.Items.Add("Hợp đồng quảng cáo 1/4 trang");
            cboLHD.Items.Add("Hợp đồng quảng cáo cả trang");
            cboLHD.Items.Add("Hợp đồng quảng cáo tuyển sinh");
            cboLHD.Items.Add("Hợp đồng quảng cáo dự án BĐS");
            cboLHD.Items.Add("Hợp đồng quảng cáo sản phẩm");
            cboLHD.Items.Add("Hợp đồng quảng cáo du lịch");
            cboLHD.Items.Add("Hợp đồng quảng cáo chuyên trang");
            cboLHD.Items.Add("Hợp đồng quảng cáo 1/2 trang");
            cboLHD.Items.Add("Hợp đồng quảng cáo tạp chí cao cấp");
            cboLHD.Items.Add("Khác");
            cboLHD.SelectedIndex = -1;
        }

        private void NapTrangThai()
        {
            // Khớp đúng CONSTRAINT CK_HD_TrangThai trong DB
            cboTrangThai.Items.Clear();
            foreach (var tt in HopDongBLL.GetDanhSachTrangThai())
                cboTrangThai.Items.Add(tt);
            cboTrangThai.SelectedIndex = 0;   // mặc định "Đang chờ xử lý"
        }

        // ──────────────────────────────────────────────
        // Mode Thêm mới
        // ──────────────────────────────────────────────
        private void HienThiModeThem()
        {
            txtMaHD.Text = "(Tự động sau khi lưu)";
            mskNK.Text = DateTime.Today.ToString("ddMMyyyy");
        }

        // ──────────────────────────────────────────────
        // Mode Sửa — điền dữ liệu gốc vào form
        // ──────────────────────────────────────────────
        private void DienDuLieuVaoForm()
        {
            // MaHopDong là INT — hiển thị số
            txtMaHD.Text = _dtoGoc.MaHopDong.ToString();

            // Chọn đúng giá trị INT trong ComboBox
            try { cboKhachHang.SelectedValue = _dtoGoc.MaKhachHang; } catch { }
            try { cboNhanVien.SelectedValue = _dtoGoc.MaNguoiDung; } catch { }

            // Loại HĐ — tìm theo text
            for (int i = 0; i < cboLHD.Items.Count; i++)
                if (cboLHD.Items[i].ToString() == _dtoGoc.LoaiHopDong)
                { cboLHD.SelectedIndex = i; break; }
            if (cboLHD.SelectedIndex < 0) // nếu không có sẵn → thêm tạm
            {
                cboLHD.Items.Add(_dtoGoc.LoaiHopDong);
                cboLHD.SelectedItem = _dtoGoc.LoaiHopDong;
            }

            // Trạng thái
            cboTrangThai.SelectedItem = _dtoGoc.TrangThaiHopDong;

            // Ngày (MaskedTextBox định dạng dd/MM/yyyy)
            mskNK.Text = _dtoGoc.NgayKy.HasValue
                ? _dtoGoc.NgayKy.Value.ToString("ddMMyyyy") : "";
            mskNBD.Text = _dtoGoc.NgayBatDau.HasValue
                ? _dtoGoc.NgayBatDau.Value.ToString("ddMMyyyy") : "";
            mskNKT.Text = _dtoGoc.NgayKetThuc.HasValue
                ? _dtoGoc.NgayKetThuc.Value.ToString("ddMMyyyy") : "";

            // Tài chính
            txtTGT.Text = _dtoGoc.TongGiaTri.ToString("N0");
            txtDTT.Text = _dtoGoc.SoTienDaThanhToan.ToString("N0");
            CapNhatConLai(_dtoGoc.SoTienConLai);

            txtGhiChu.Text = _dtoGoc.GhiChu ?? "";
        }

        // ──────────────────────────────────────────────
        // Khi chọn khách hàng → tự điền SĐT & Địa chỉ
        // ──────────────────────────────────────────────
        private void CboKhachHang_Changed(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex < 0) return;
            try
            {
                if (cboKhachHang.DataSource is DataTable dt
                    && cboKhachHang.SelectedItem is DataRowView drv)
                {
                    txtSDT.Text = dt.Columns.Contains("SoDienThoai")
                        ? drv["SoDienThoai"]?.ToString() ?? "" : "";
                    txtDiaChi.Text = dt.Columns.Contains("DiaChi")
                        ? drv["DiaChi"]?.ToString() ?? "" : "";
                }
            }
            catch { /* ignore nếu DataTable chưa đủ cột */ }
        }

        // ──────────────────────────────────────────────
        // Tính Còn lại tự động
        // ──────────────────────────────────────────────
        private void TinhConLai(object sender, EventArgs e)
        {
            decimal tgt = ParseDecimal(txtTGT.Text);
            decimal dtt = ParseDecimal(txtDTT.Text);
            decimal cl = Math.Max(0, tgt - dtt);
            CapNhatConLai(cl);
        }

        private void CapNhatConLai(decimal cl)
        {
            txtCL.Text = cl.ToString("N0");
            txtCL.ForeColor = cl > 0
                ? Color.FromArgb(220, 80, 30)
                : Color.FromArgb(40, 167, 69);
        }

        // ──────────────────────────────────────────────
        // Tiêu đề header
        // ──────────────────────────────────────────────
        private void CapNhatTieuDe()
        {
            lblHeader.Text = IsEditMode
                ? $"✏  Chỉnh sửa hợp đồng #{_dtoGoc.MaHopDong}"
                : "➕  Thêm hợp đồng mới";

            foreach (Control c in panelThaoTac.Controls)
                if (c is Button btn && btn.Name == "btnLuu")
                    btn.Text = IsEditMode ? "💾  Cập nhật" : "💾  Lưu";
        }

        // ══════════════════════════════════════════════
        //  NÚT LƯU
        // ══════════════════════════════════════════════
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                HopDongDTO dto = DocDuLieuForm();

                if (IsEditMode)
                {
                    dto.MaHopDong = _dtoGoc.MaHopDong;   // giữ nguyên khóa chính INT
                    _bll.Update(dto);
                    MessageBox.Show(
                        $"Cập nhật hợp đồng #{dto.MaHopDong} thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int maMoi = _bll.Add(dto);    // DB trả về IDENTITY mới
                    MessageBox.Show(
                        $"Thêm hợp đồng #{maMoi} thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OnLuuThanhCong?.Invoke();
                QuayLaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════════
        //  NÚT HỦY
        // ══════════════════════════════════════════════
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (CoThayDoi())
            {
                var kq = MessageBox.Show(
                    "Bạn có thay đổi chưa lưu. Có muốn hủy và quay lại không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq != DialogResult.Yes) return;
            }
            QuayLaiDanhSach();
        }

        // ──────────────────────────────────────────────
        // Quay về danh sách
        // ──────────────────────────────────────────────
        private void QuayLaiDanhSach()
        {
            Panel parent = TimPanelCha();
            if (parent != null)
                Class.Function.LoadModule(parent, new UI_HopDong());
        }

        private Panel TimPanelCha()
        {
            Control p = this.Parent;
            while (p != null)
            {
                if (p is Panel && !(p is UserControl)) return (Panel)p;
                p = p.Parent;
            }
            return null;
        }

        // ──────────────────────────────────────────────
        // Đọc dữ liệu form → HopDongDTO
        // ──────────────────────────────────────────────
        private HopDongDTO DocDuLieuForm()
        {
            // MaKhachHang / MaNguoiDung là INT từ ValueMember
            int maKH = cboKhachHang.SelectedValue != null
                ? Convert.ToInt32(cboKhachHang.SelectedValue) : 0;
            int maND = cboNhanVien.SelectedValue != null
                ? Convert.ToInt32(cboNhanVien.SelectedValue) : 0;

            return new HopDongDTO(
                loaiHopDong: cboLHD.SelectedItem?.ToString() ?? cboLHD.Text.Trim(),
                trangThaiHopDong: cboTrangThai.SelectedItem?.ToString() ?? "",
                ngayKy: ParseDate(mskNK.Text),
                ngayBatDau: ParseDate(mskNBD.Text),
                ngayKetThuc: ParseDate(mskNKT.Text),
                tongGiaTri: ParseDecimal(txtTGT.Text),
                soTienDaThanhToan: ParseDecimal(txtDTT.Text),
                maKhachHang: maKH,
                maNguoiDung: maND,
                ghiChu: txtGhiChu.Text.Trim()
            );
        }

        // ──────────────────────────────────────────────
        // Validate trước khi gửi BLL
        // ──────────────────────────────────────────────
        private bool ValidateForm()
        {
            if (cboKhachHang.SelectedIndex < 0)
            { ShowWarn("Vui lòng chọn khách hàng.", cboKhachHang); return false; }

            if (cboNhanVien.SelectedIndex < 0)
            { ShowWarn("Vui lòng chọn nhân viên phụ trách.", cboNhanVien); return false; }

            if (cboLHD.SelectedIndex < 0 && string.IsNullOrWhiteSpace(cboLHD.Text))
            { ShowWarn("Vui lòng chọn hoặc nhập loại hợp đồng.", cboLHD); return false; }

            // Ngày ký không bắt buộc theo DB (nullable DATE) nhưng nên có
            DateTime? ngayKy = ParseDate(mskNK.Text);
            if (mskNK.Text.Replace("/", "").Trim().Length > 0 && ngayKy == null)
            { ShowWarn("Ngày ký không hợp lệ. Định dạng: dd/MM/yyyy", mskNK); return false; }

            DateTime? ngayBD = ParseDate(mskNBD.Text);
            DateTime? ngayKT = ParseDate(mskNKT.Text);

            if (mskNBD.Text.Replace("/", "").Trim().Length > 0 && ngayBD == null)
            { ShowWarn("Ngày bắt đầu không hợp lệ.", mskNBD); return false; }

            if (ngayBD.HasValue && ngayKy.HasValue && ngayBD.Value < ngayKy.Value)
            { ShowWarn("Ngày bắt đầu không được trước ngày ký.", mskNBD); return false; }

            if (mskNKT.Text.Replace("/", "").Trim().Length > 0 && ngayKT == null)
            { ShowWarn("Ngày kết thúc không hợp lệ.", mskNKT); return false; }

            if (ngayKT.HasValue && ngayBD.HasValue && ngayKT.Value < ngayBD.Value)
            { ShowWarn("Ngày kết thúc không được trước ngày bắt đầu.", mskNKT); return false; }

            decimal tgt = ParseDecimal(txtTGT.Text);
            if (tgt < 0)
            { ShowWarn("Tổng giá trị không được âm.", txtTGT); return false; }

            decimal dtt = ParseDecimal(txtDTT.Text);
            if (dtt < 0)
            { ShowWarn("Số tiền đã thanh toán không được âm.", txtDTT); return false; }

            if (dtt > tgt)
            { ShowWarn("Đã thanh toán không được lớn hơn tổng giá trị.", txtDTT); return false; }

            return true;
        }

        private void ShowWarn(string msg, Control focusCtrl = null)
        {
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusCtrl?.Focus();
        }

        // ──────────────────────────────────────────────
        // Phát hiện thay đổi (để hỏi trước khi Hủy)
        // ──────────────────────────────────────────────
        private bool CoThayDoi()
        {
            if (!IsEditMode)
                return cboKhachHang.SelectedIndex >= 0
                    || cboNhanVien.SelectedIndex >= 0
                    || !string.IsNullOrWhiteSpace(txtTGT.Text)
                    || !string.IsNullOrWhiteSpace(txtGhiChu.Text);

            try
            {
                int maKH = Convert.ToInt32(cboKhachHang.SelectedValue ?? 0);
                int maND = Convert.ToInt32(cboNhanVien.SelectedValue ?? 0);
                return maKH != _dtoGoc.MaKhachHang
                    || maND != _dtoGoc.MaNguoiDung
                    || cboLHD.SelectedItem?.ToString() != _dtoGoc.LoaiHopDong
                    || cboTrangThai.SelectedItem?.ToString() != _dtoGoc.TrangThaiHopDong
                    || ParseDecimal(txtTGT.Text) != _dtoGoc.TongGiaTri
                    || ParseDecimal(txtDTT.Text) != _dtoGoc.SoTienDaThanhToan
                    || txtGhiChu.Text.Trim() != (_dtoGoc.GhiChu ?? "");
            }
            catch { return true; }
        }

        // ──────────────────────────────────────────────
        // Parse helpers
        // ──────────────────────────────────────────────
        private static decimal ParseDecimal(string s)
        {
            s = (s ?? "").Replace(",", "").Replace(".", "").Trim();
            return decimal.TryParse(s, out decimal v) ? v : 0;
        }

        private static DateTime? ParseDate(string masked)
        {
            if (string.IsNullOrWhiteSpace(masked)) return null;
            if (DateTime.TryParseExact(masked.Trim(), "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime dt))
                return dt;
            return null;
        }
    }
}