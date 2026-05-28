using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AuthForms.BLL;
using AuthForms.DAL; // for KpiHopDongDto

namespace AuthForms.UI
{
    /// <summary>
    /// frmThongKeHopDong — Thống kê hợp đồng.
    ///   Mức tốt: biểu đồ cột + bánh GDI+ donut style, lọc theo ngày/tháng/năm,
    ///            4 thẻ KPI cao cấp, xuất CSV, chi tiết hợp đồng được phân chia màu trạng thái.
    /// </summary>
    public partial class frmThongKeHopDong : Form
    {
        private DataTable _dtTongHop   = new DataTable();
        private DataTable _dtTrangThai = new DataTable();
        private DataTable _dtChiTiet   = new DataTable();

        public frmThongKeHopDong()
        {
            InitializeComponent();
        }

        private void frmThongKeHopDong_Load(object sender, EventArgs e)
        {
            // Update labels
            lblKPI1.Text = "Tổng Hợp Đồng";
            lblKPI2.Text = "Đang Xử Lý";
            lblKPI3.Text = "Đã Đăng";
            lblKPI4.Text = "Đã Hủy";

            lblGridLeft.Text = "Tổng Hợp Theo Tháng";
            lblGridRight.Text = "Danh Sách Chi Tiết Hợp Đồng";

            // Add dynamic vertical accent bars to cards
            AddCardLeftAccent(pnlKPI1, Color.FromArgb(30, 70, 150));
            AddCardLeftAccent(pnlKPI2, Color.FromArgb(20, 130, 60));
            AddCardLeftAccent(pnlKPI3, Color.FromArgb(180, 120, 10));
            AddCardLeftAccent(pnlKPI4, Color.FromArgb(160, 30, 30));

            // Style grids
            StyleGrid(dgvTongHop);
            StyleGrid(dgvTrangThai);

            // Grid columns split: Left 35% (summary), Right 65% (details) - set in Designer

            // Paint color rows for right grid (dgvTrangThai is repurposed as Details List)
            dgvTrangThai.RowPrePaint += dgvTrangThai_RowPrePaint;

            KhoiTaoNam();
            KhoiTaoThang();
            KhoiTaoNgay();
            LoadDuLieu();
        }

        private void AddCardLeftAccent(Panel card, Color accent)
        {
            var p = new Panel { Width = 5, Dock = DockStyle.Left, BackColor = accent };
            card.Controls.Add(p);
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 55, 100);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 248, 255);
            dgv.RowTemplate.Height = 28;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(230, 232, 240);
        }

        private void dgvTrangThai_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || dgvTrangThai.Rows[e.RowIndex].Cells.Count == 0) return;
            
            // TrangThai column index
            int colIdx = dgvTrangThai.Columns.Contains("TrangThai") 
                ? dgvTrangThai.Columns["TrangThai"].Index 
                : dgvTrangThai.Columns.Count - 1;
                
            if (colIdx < 0) return;
            string tt = dgvTrangThai.Rows[e.RowIndex].Cells[colIdx].Value?.ToString() ?? "";
            Color bg;
            
            if (tt.Contains("Đang xử lý"))                               bg = Color.FromArgb(220, 240, 255); // xanh nhạt
            else if (tt.Contains("Đã đăng"))                              bg = Color.FromArgb(220, 245, 225); // xanh lá nhạt
            else if (tt.Contains("Đã kết thúc"))                          bg = Color.FromArgb(255, 245, 205); // vàng nhạt
            else if (tt.Contains("Hủy"))                                  bg = Color.FromArgb(255, 225, 225); // đỏ nhạt
            else if (tt.Contains("Đang chờ"))                             bg = Color.FromArgb(235, 225, 255); // tím nhạt
            else bg = (e.RowIndex % 2 == 0) ? Color.White : Color.FromArgb(246, 248, 255);

            dgvTrangThai.Rows[e.RowIndex].DefaultCellStyle.BackColor = bg;
            dgvTrangThai.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 50);
        }

        private void KhoiTaoNam()
        {
            int y = DateTime.Now.Year;
            cboNam.Items.Clear();
            for (int i = y; i >= y - 5; i--)
                cboNam.Items.Add(i);
            cboNam.SelectedIndex = 0;
        }

        private void KhoiTaoThang()
        {
            cboThang.Items.Clear();
            cboThang.Items.Add("-- Tất cả tháng --");
            for (int m = 1; m <= 12; m++)
                cboThang.Items.Add($"Tháng {m:00}");
            cboThang.SelectedIndex = 0;
        }

        private void KhoiTaoNgay()
        {
            dtpTuNgay.Value  = new DateTime(DateTime.Now.Year, 1, 1);
            dtpDenNgay.Value = DateTime.Now.Date;
            lblTuNgay.Visible  = false;
            dtpTuNgay.Visible  = false;
            lblDenNgay.Visible = false;
            dtpDenNgay.Visible = false;
        }

        // ============================================================
        //  Load dữ liệu (Public để frmMain gọi)
        // ============================================================
        public void LoadDuLieu()
        {
            if (cboNam.SelectedItem == null) return;
            try
            {
                int nam    = (int)cboNam.SelectedItem;
                int thang  = cboThang.SelectedIndex;
                DateTime tuNgay  = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;
                bool isKhoang    = chkKhoangNgay.Checked;

                // KPI values
                KpiHopDongDto kpi = isKhoang
                    ? HopDongBLL.LayKPIKhoangNgay(tuNgay, denNgay)
                    : HopDongBLL.LayKPITongHop(nam, thang);
                
                lblKPI1Val.Text = kpi.Tong.ToString("N0");
                lblKPI2Val.Text = kpi.DangXuLy.ToString("N0");
                lblKPI3Val.Text = kpi.DaDang.ToString("N0");
                lblKPI4Val.Text = kpi.DaHuy.ToString("N0");

                // Tables
                _dtTongHop = isKhoang
                    ? HopDongBLL.LayTongHopKhoangNgay(tuNgay, denNgay)
                    : HopDongBLL.LayTongHopTheoThang(nam, thang);
                dgvTongHop.DataSource = _dtTongHop;
                if (dgvTongHop.Columns.Contains("Thang"))   dgvTongHop.Columns["Thang"].HeaderText   = "Tháng";
                if (dgvTongHop.Columns.Contains("TongSo"))  dgvTongHop.Columns["TongSo"].HeaderText  = "Tổng";
                if (dgvTongHop.Columns.Contains("HieuLuc")) dgvTongHop.Columns["HieuLuc"].HeaderText = "Hiệu Lực";
                if (dgvTongHop.Columns.Contains("HetHan"))  dgvTongHop.Columns["HetHan"].HeaderText  = "Hết Hạn";
                if (dgvTongHop.Columns.Contains("DaHuy"))   dgvTongHop.Columns["DaHuy"].HeaderText   = "Đã Hủy";
                if (dgvTongHop.Columns.Contains("ChoKy"))   dgvTongHop.Columns["ChoKy"].HeaderText   = "Chờ Ký";

                _dtTrangThai = isKhoang
                    ? HopDongBLL.LayTrangThaiKhoangNgay(tuNgay, denNgay)
                    : HopDongBLL.LayTheoTrangThai(nam, thang);

                // Details List bound to dgvTrangThai
                _dtChiTiet = HopDongBLL.LayDanhSachHopDong(nam, thang, tuNgay, denNgay, isKhoang);
                dgvTrangThai.DataSource = _dtChiTiet;
                if (dgvTrangThai.Columns.Contains("MaHopDong"))   dgvTrangThai.Columns["MaHopDong"].HeaderText   = "Mã HĐ";
                if (dgvTrangThai.Columns.Contains("KhachHang"))   dgvTrangThai.Columns["KhachHang"].HeaderText   = "Khách Hàng";
                if (dgvTrangThai.Columns.Contains("NgayKy"))      dgvTrangThai.Columns["NgayKy"].HeaderText      = "Ngày Ký";
                if (dgvTrangThai.Columns.Contains("NgayHetHan"))  dgvTrangThai.Columns["NgayHetHan"].HeaderText  = "Hết Hạn";
                if (dgvTrangThai.Columns.Contains("GiaTri"))      dgvTrangThai.Columns["GiaTri"].HeaderText      = "Giá Trị (VNĐ)";
                if (dgvTrangThai.Columns.Contains("DaThanhToan")) dgvTrangThai.Columns["DaThanhToan"].HeaderText = "Đã TT (VNĐ)";
                if (dgvTrangThai.Columns.Contains("TrangThai"))   dgvTrangThai.Columns["TrangThai"].HeaderText   = "Trạng Thái";

                VeBieuDoCot();
                VeBieuDoBanh();
                lblThongBao.Text = "";
            }
            catch (Exception ex)
            {
                lblThongBao.ForeColor = Color.Crimson;
                lblThongBao.Text = "Lỗi: " + ex.Message;
            }
        }

        private void LoadDuLieuTheoKhoangNgay()
        {
            LoadDuLieu();
        }

        // ============================================================
        //  Biểu đồ cột — số HĐ theo tháng
        // ============================================================
        private void VeBieuDoCot()
        {
            if (picCot.Width < 10 || picCot.Height < 10) return;

            var bmp = new Bitmap(picCot.Width, picCot.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(245, 247, 252));

                if (_dtTongHop == null || _dtTongHop.Rows.Count == 0)
                {
                    picCot.Image = bmp;
                    return;
                }

                int W = bmp.Width, H = bmp.Height;
                int pad = 44, padTop = 24, padBot = 52;
                int cw = W - pad * 2, ch = H - padTop - padBot;
                int n  = _dtTongHop.Rows.Count;

                double maxV = 1;
                foreach (DataRow r in _dtTongHop.Rows)
                {
                    double v = Convert.ToDouble(r["TongSo"]);
                    if (v > maxV) maxV = v;
                }

                int barW = Math.Max(8, cw / n - 6);
                int gap  = Math.Max(3, (cw - barW * n) / (n + 1));

                var colors = new Color[]
                {
                    Color.FromArgb(22,  55,  100),  // HieuLuc — xanh đậm
                    Color.FromArgb(180, 130,  20),  // HetHan  — vàng
                    Color.FromArgb(160,  40,  40),  // DaHuy   — đỏ
                    Color.FromArgb(60,  130, 180)   // ChoKy   — xanh nhạt
                };
                string[] cols   = { "HieuLuc", "HetHan", "DaHuy", "ChoKy" };
                string[] lnames = { "Hiệu Lực", "Hết Hạn", "Đã Huỷ", "Chờ Ký" };

                var fontSm = new Font("Segoe UI", 7.5f);
                var fontAx = new Font("Segoe UI", 8f);
                var brTxt  = new SolidBrush(Color.FromArgb(80, 90, 110));

                // Gridlines
                using (var penG = new Pen(Color.FromArgb(210, 215, 225), 0.6f) { DashStyle = DashStyle.Dash })
                    for (int gi = 1; gi <= 4; gi++)
                    {
                        int gy = padTop + (int)(ch * gi / 4.0);
                        g.DrawLine(penG, pad, gy, W - pad, gy);
                        g.DrawString(((int)(maxV * (4 - gi) / 4)).ToString(), fontAx, brTxt, 2, gy - 7);
                    }

                // Bars
                for (int i = 0; i < n; i++)
                {
                    var row  = _dtTongHop.Rows[i];
                    int x    = pad + gap + i * (barW + gap);
                    int segW = Math.Max(1, barW / cols.Length);

                    for (int c = 0; c < cols.Length; c++)
                    {
                        double v = Convert.ToDouble(row[cols[c]]);
                        int    h = (int)(ch * v / maxV);
                        if (h < 1) continue;
                        var rect = new Rectangle(x + c * segW, padTop + ch - h, segW - 1, h);
                        using (var br = new SolidBrush(colors[c]))
                            g.FillRectangle(br, rect);
                    }

                    string lbl = row["Thang"].ToString().Replace("Tháng ", "T");
                    var sf = new StringFormat { Alignment = StringAlignment.Center };
                    g.DrawString(lbl, fontSm, brTxt,
                        new RectangleF(x, padTop + ch + 4, barW, 16), sf);
                }

                // Legend
                for (int li = 0; li < colors.Length; li++)
                {
                    int lx = pad + li * 88;
                    using (var br = new SolidBrush(colors[li]))
                        g.FillRectangle(br, lx, H - 16, 10, 10);
                    g.DrawString(lnames[li], fontAx, brTxt, lx + 14, H - 18);
                }

                fontSm.Dispose(); fontAx.Dispose(); brTxt.Dispose();
            }
            picCot.Image = bmp;
        }

        // ============================================================
        //  Biểu đồ bánh — theo trạng thái (Donut Chart)
        // ============================================================
        private void VeBieuDoBanh()
        {
            if (picBanh.Width < 10 || picBanh.Height < 10) return;

            var bmp = new Bitmap(picBanh.Width, picBanh.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                if (_dtTrangThai == null || _dtTrangThai.Rows.Count == 0)
                {
                    picBanh.Image = bmp;
                    return;
                }

                var colors = new Color[]
                {
                    Color.FromArgb(22,  55,  100),
                    Color.FromArgb(30,  130,  70),
                    Color.FromArgb(160,  40,  40),
                    Color.FromArgb(60,  130, 180),
                    Color.FromArgb(180, 130,  20),
                    Color.FromArgb(100,  60, 160)
                };

                double total = 0;
                foreach (DataRow r in _dtTrangThai.Rows)
                    total += Convert.ToDouble(r["SoLuong"]);
                if (total == 0) total = 1;

                int cx = bmp.Width / 2 - 20, cy = bmp.Height / 2;
                int r0 = Math.Min(cx, cy) - 30;
                if (r0 < 5) r0 = 5;

                float startAngle = -90f;
                var fontSm = new Font("Segoe UI", 8f);
                var brTxt  = new SolidBrush(Color.FromArgb(60, 70, 90));

                for (int i = 0; i < _dtTrangThai.Rows.Count; i++)
                {
                    var row  = _dtTrangThai.Rows[i];
                    double v = Convert.ToDouble(row["SoLuong"]);
                    float  sw = (float)(360.0 * v / total);
                    var col   = colors[i % colors.Length];

                    using (var br = new SolidBrush(col))
                        g.FillPie(br, cx - r0, cy - r0, r0 * 2, r0 * 2, startAngle, sw);
                    using (var pen = new Pen(Color.White, 2))
                        g.DrawPie(pen, cx - r0, cy - r0, r0 * 2, r0 * 2, startAngle, sw);

                    // Legend bên phải
                    int ly = 18 + i * 22;
                    if (bmp.Width - 142 > 0)
                    {
                        using (var br = new SolidBrush(col))
                            g.FillRectangle(br, bmp.Width - 142, ly, 12, 12);
                        g.DrawString(row["TrangThai"] + " (" + (int)v + ")",
                            fontSm, brTxt, bmp.Width - 126, ly - 1);
                    }

                    startAngle += sw;
                }

                // Số tổng ở giữa (donut style)
                using (var br = new SolidBrush(Color.White))
                    g.FillEllipse(br, cx - r0 / 2, cy - r0 / 2, r0, r0);
                using (var brN = new SolidBrush(Color.FromArgb(22, 55, 100)))
                using (var fN  = new Font("Segoe UI", 12f, FontStyle.Bold))
                {
                    var sf = new StringFormat
                    { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(((int)total).ToString(), fN, brN,
                        new RectangleF(cx - r0 / 2f, cy - r0 / 2f, r0, r0), sf);
                }

                fontSm.Dispose(); brTxt.Dispose();
            }
            picBanh.Image = bmp;
        }

        // ============================================================
        //  Event handlers
        // ============================================================
        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkKhoangNgay != null && chkKhoangNgay.Checked) return;
            LoadDuLieu();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkKhoangNgay != null && chkKhoangNgay.Checked) return;
            LoadDuLieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void picCot_Resize(object sender, EventArgs e)  => VeBieuDoCot();
        private void picBanh_Resize(object sender, EventArgs e) => VeBieuDoBanh();

        private void chkKhoangNgay_CheckedChanged(object sender, EventArgs e)
        {
            bool on = chkKhoangNgay.Checked;
            lblTuNgay.Visible  = on;
            dtpTuNgay.Visible  = on;
            lblDenNgay.Visible = on;
            dtpDenNgay.Visible = on;
            cboNam.Enabled     = !on;
            cboThang.Enabled   = !on;
            LoadDuLieu();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        { if (chkKhoangNgay.Checked) LoadDuLieu(); }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        { if (chkKhoangNgay.Checked) LoadDuLieu(); }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (_dtChiTiet == null || _dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog
            {
                Filter   = "CSV Files|*.csv",
                FileName = "ThongKeHopDong_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("Ma HD,Khach Hang,Ngay Ky,Ngay Het Han,Gia Tri,Da Thanh Toan,Trang Thai");
                foreach (DataRow r in _dtChiTiet.Rows)
                    sb.AppendLine($"{r[0]},{r[1]},{r[2]},{r[3]},{r[4]},{r[5]},{r[6]}");
                System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                MessageBox.Show("Xuất CSV thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
