using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QlyHopDong.BLL;
using QlyHopDong.DTO;

namespace QlyHopDong.UI
{
    public partial class UI_HopDong : UserControl
    {
        private readonly HopDongBLL _bll = new HopDongBLL();
        private List<HopDongDTO> _danhSach = new List<HopDongDTO>();

        public UI_HopDong()
        {
            InitializeComponent();
            this.Load += UI_HopDong_Load;
        }

        private void UI_HopDong_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            NapCboTrangThai();
            TaiDuLieu();
        }

        // ──────────────────────────────────────────────
        // Cấu hình DataGridView
        // ──────────────────────────────────────────────
        private void CauHinhDataGridView()
        {
            var dgv = dgvHopDong;
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.Cursor = Cursors.Hand;

            // Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 248);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(90, 100, 120);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 44;
            dgv.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 50, 65);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 50, 90);
            dgv.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 253);
            dgv.RowTemplate.Height = 52;

            // ── Cột dữ liệu ──
            ThemCot("MaHopDong", "Mã HĐ", 80, DataGridViewContentAlignment.MiddleCenter);
            ThemCot("TenKhachHang", "Khách hàng", 200, DataGridViewContentAlignment.MiddleLeft);
            ThemCot("LoaiHopDong", "Loại hợp đồng", 190, DataGridViewContentAlignment.MiddleLeft);
            ThemCot("HoTenNhanVien", "Nhân viên PT", 160, DataGridViewContentAlignment.MiddleLeft);
            ThemCot("NgayKy", "Ngày ký", 110, DataGridViewContentAlignment.MiddleCenter);
            ThemCot("TongGiaTri", "Tổng giá trị", 140, DataGridViewContentAlignment.MiddleRight);
            ThemCot("SoTienConLai", "Còn lại", 130, DataGridViewContentAlignment.MiddleRight);

            // Cột badge Trạng thái
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThaiHopDong",
                HeaderText = "Trạng thái",
                Width = 160,
                ReadOnly = true,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Cột nút Thao tác
            dgv.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ThaoTac",
                HeaderText = "Thao tác",
                Width = 125,
                Text = "Thao tác ▼",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle =
                {
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(40, 50, 65),
                    Font      = new Font("Segoe UI", 9.5f),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgv.CellPainting += Dgv_CellPainting;
            dgv.CellClick += Dgv_CellClick;
        }

        private void ThemCot(string name, string header, int width,
            DataGridViewContentAlignment align)
        {
            dgvHopDong.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = name,
                Width = width,
                ReadOnly = true,
                DefaultCellStyle = { Alignment = align }
            });
        }

        // ──────────────────────────────────────────────
        // Vẽ badge trạng thái & nút thao tác
        // ──────────────────────────────────────────────
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ── Badge Trạng thái ──
            if (e.ColumnIndex == dgvHopDong.Columns["TrangThaiHopDong"].Index)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Background |
                                      DataGridViewPaintParts.Border |
                                      DataGridViewPaintParts.SelectionBackground);

                string tt = e.Value?.ToString() ?? "";
                HopDongBLL.GetBadgeColor(tt, out Color bgColor, out Color textColor);

                using (var f = new Font("Segoe UI", 9f))
                using (var sf = new StringFormat
                { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    SizeF sz = e.Graphics.MeasureString(tt, f);
                    int pH = 10, pV = 4;
                    int bW = (int)sz.Width + pH * 2, bH = (int)sz.Height + pV * 2;
                    int bX = e.CellBounds.X + (e.CellBounds.Width - bW) / 2;
                    int bY = e.CellBounds.Y + (e.CellBounds.Height - bH) / 2;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (var path = RoundedRect(new Rectangle(bX, bY, bW, bH), 10))
                    using (var brush = new SolidBrush(bgColor))
                        e.Graphics.FillPath(brush, path);

                    using (var tb = new SolidBrush(textColor))
                        e.Graphics.DrawString(tt, f, tb, new RectangleF(bX, bY, bW, bH), sf);
                }
                e.Handled = true;
                return;
            }

            // ── Nút Thao tác ──
            if (e.ColumnIndex == dgvHopDong.Columns["ThaoTac"].Index)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Background |
                                      DataGridViewPaintParts.Border |
                                      DataGridViewPaintParts.SelectionBackground);

                int bW = 112, bH = 34;
                int bX = e.CellBounds.X + (e.CellBounds.Width - bW) / 2;
                int bY = e.CellBounds.Y + (e.CellBounds.Height - bH) / 2;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundedRect(new Rectangle(bX, bY, bW, bH), 6))
                using (var border = new Pen(Color.FromArgb(200, 200, 210), 1.5f))
                using (var bg = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(bg, path);
                    e.Graphics.DrawPath(border, path);
                }

                using (var sf = new StringFormat
                { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var f = new Font("Segoe UI", 9.5f))
                using (var tb = new SolidBrush(Color.FromArgb(50, 60, 80)))
                    e.Graphics.DrawString("Thao tác  ▼", f, tb,
                        new RectangleF(bX, bY, bW, bH), sf);

                e.Handled = true;
            }
        }

        // ──────────────────────────────────────────────
        // Click Thao tác → menu dropdown Sửa / Xóa
        // ──────────────────────────────────────────────
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvHopDong.Columns[e.ColumnIndex].Name != "ThaoTac") return;

            var dto = _danhSach[e.RowIndex];
            var menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 10f);

            var itemSua = new ToolStripMenuItem("✏  Sửa hợp đồng");
            itemSua.Click += (s, ev) => MoFormThemSua(dto);

            var itemXoa = new ToolStripMenuItem("🗑  Xóa hợp đồng");
            itemXoa.ForeColor = Color.FromArgb(200, 50, 50);
            itemXoa.Click += (s, ev) => XoaHopDong(dto);

            menu.Items.Add(itemSua);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(itemXoa);

            Rectangle cell = dgvHopDong.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            Point pt = dgvHopDong.PointToScreen(new Point(cell.Left, cell.Bottom));
            menu.Show(pt);
        }

        // ──────────────────────────────────────────────
        // Tải & hiển thị dữ liệu
        // ──────────────────────────────────────────────
        private void TaiDuLieu(string keyword = null, string trangThai = null)
        {
            try
            {
                _danhSach = (string.IsNullOrWhiteSpace(keyword) && string.IsNullOrWhiteSpace(trangThai))
                    ? _bll.GetAll()
                    : _bll.Search(keyword, trangThai);
                HienThiLenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiLenGrid()
        {
            dgvHopDong.Rows.Clear();
            foreach (var hd in _danhSach)
            {
                int idx = dgvHopDong.Rows.Add(
                    hd.MaHopDong,
                    hd.TenKhachHang,
                    hd.LoaiHopDong,
                    hd.HoTenNhanVien,
                    hd.NgayKy.HasValue ? hd.NgayKy.Value.ToString("dd/MM/yyyy") : "",
                    hd.TongGiaTri.ToString("N0"),
                    hd.SoTienConLai.ToString("N0"),
                    hd.TrangThaiHopDong,
                    ""   // ThaoTac — chỉ vẽ
                );

                var row = dgvHopDong.Rows[idx];

                // Màu cột Còn lại
                int colCL = dgvHopDong.Columns["SoTienConLai"].Index;
                row.Cells[colCL].Style.ForeColor = hd.SoTienConLai > 0
                    ? Color.FromArgb(220, 80, 30) : Color.FromArgb(40, 167, 69);

                // Bold cột MaHD
                int colMa = dgvHopDong.Columns["MaHopDong"].Index;
                row.Cells[colMa].Style.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                row.Cells[colMa].Style.ForeColor = Color.FromArgb(46, 74, 122);
            }
        }

        // ──────────────────────────────────────────────
        // ComboBox Trạng thái
        // ──────────────────────────────────────────────
        private void NapCboTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Tất cả trạng thái");
            foreach (var tt in HopDongBLL.GetDanhSachTrangThai())
                cboTrangThai.Items.Add(tt);
            cboTrangThai.SelectedIndex = 0;
        }

        // ──────────────────────────────────────────────
        // Sự kiện controls
        // ──────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
            => MoFormThemSua(null);

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            string tt = cboTrangThai.SelectedIndex > 0
                ? cboTrangThai.SelectedItem.ToString() : null;
            TaiDuLieu(kw, tt);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboTrangThai.SelectedIndex = 0;
            TaiDuLieu();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTimKiem_Click(null, null);
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated && cboTrangThai.SelectedIndex >= 0)
                btnTimKiem_Click(null, null);
        }

        // ──────────────────────────────────────────────
        // Mở form Thêm/Sửa (dùng chung UI_CTHopDong)
        // ──────────────────────────────────────────────
        private void MoFormThemSua(HopDongDTO dto)
        {
            var form = dto == null ? new UI_CTHopDong() : new UI_CTHopDong(dto);
            form.OnLuuThanhCong += () => TaiDuLieu();
            Class.Function.LoadModule(panelContent, form);
        }

        // ──────────────────────────────────────────────
        // Xóa hợp đồng
        // ──────────────────────────────────────────────
        private void XoaHopDong(HopDongDTO dto)
        {
            string tenKH = string.IsNullOrEmpty(dto.TenKhachHang)
                ? dto.MaKhachHang.ToString() : dto.TenKhachHang;

            if (MessageBox.Show(
                    $"Xóa hợp đồng #{dto.MaHopDong} — {tenKH}?\n\nHành động này không thể hoàn tác!",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                != DialogResult.Yes) return;

            try
            {
                _bll.Delete(dto.MaHopDong);
                MessageBox.Show("Xóa hợp đồng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        // Helper vẽ rounded rectangle
        // ──────────────────────────────────────────────
        private static GraphicsPath RoundedRect(Rectangle b, int r)
        {
            int d = r * 2;
            var p = new GraphicsPath();
            p.AddArc(b.X, b.Y, d, d, 180, 90);
            p.AddArc(b.Right - d, b.Y, d, d, 270, 90);
            p.AddArc(b.Right - d, b.Bottom - d, d, d, 0, 90);
            p.AddArc(b.X, b.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}