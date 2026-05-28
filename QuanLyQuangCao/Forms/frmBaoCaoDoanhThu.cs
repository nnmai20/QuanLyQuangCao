using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AuthForms.BLL;

namespace AuthForms.UI
{
    /// <summary>
    /// frmBaoCaoDoanhThu — Báo cáo doanh thu.
    ///   Mức tốt: Biểu đồ đường (Line Chart) GDI+ mượt mà + lọc ngày/tháng/năm đầy đủ,
    ///            4 thẻ KPI cao cấp, xuất CSV.
    /// </summary>
    public partial class frmBaoCaoDoanhThu : Form
    {
        private DataTable _dt = new DataTable();
        private Label lblKPI3Sub; // Sub-label for growth comparison

        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        // Load event
        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            // Set title text and styles
            lblCard3Title.Text = "Tỷ Lệ Tăng Trưởng";
            lblCard4Title.Text = "Còn Lại / Chưa Thu";

            // Add dynamic vertical accent bars to cards
            AddCardLeftAccent(pnlCard1, Color.FromArgb(22, 55, 120));
            AddCardLeftAccent(pnlCard2, Color.FromArgb(20, 120, 65));
            AddCardLeftAccent(pnlCard3, Color.FromArgb(140, 80, 10));
            AddCardLeftAccent(pnlCard4, Color.FromArgb(150, 35, 35));

            // Create sub-label for growth Card 3
            lblKPI3Sub = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 7.5F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(12, 56),
                Size = new Size(238, 18)
            };
            pnlCard3.Controls.Add(lblKPI3Sub);

            // Style grid
            StyleGrid(dgvDoanhThu);

            KhoiTaoNam();
            KhoiTaoNgay();
            cboThang.SelectedIndex = DateTime.Now.Month - 1;
            cboLoai.SelectedIndex = 1; // Theo Tháng
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

        // ============================================================
        //  Khởi tạo ComboBox năm
        // ============================================================
        private void KhoiTaoNam()
        {
            int namHienTai = DateTime.Now.Year;
            cboNam.Items.Clear();
            for (int y = namHienTai; y >= namHienTai - 5; y--)
                cboNam.Items.Add(y);
            cboNam.SelectedIndex = 0;
        }

        // ============================================================
        //  Khởi tạo DateTimePicker lọc ngày cụ thể
        // ============================================================
        private void KhoiTaoNgay()
        {
            dtpTuNgay.Value  = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now.Date;
        }

        // ============================================================
        //  Load dữ liệu (Public để frmMain gọi)
        // ============================================================
        public void LoadDuLieu()
        {
            if (cboLoai == null || cboNam.SelectedItem == null) return;
            try
            {
                _dt = LayDoanhThu();
                dgvDoanhThu.DataSource = _dt;

                // Rename headers to be professional
                if (dgvDoanhThu.Columns.Contains("ThoiGian"))    dgvDoanhThu.Columns["ThoiGian"].HeaderText    = "Thời Gian";
                if (dgvDoanhThu.Columns.Contains("SoHopDong"))   dgvDoanhThu.Columns["SoHopDong"].HeaderText   = "Số HĐ";
                if (dgvDoanhThu.Columns.Contains("DoanhThu"))    dgvDoanhThu.Columns["DoanhThu"].HeaderText    = "Doanh Thu (VNĐ)";
                if (dgvDoanhThu.Columns.Contains("DaThanhToan")) dgvDoanhThu.Columns["DaThanhToan"].HeaderText  = "Đã TT (VNĐ)";
                if (dgvDoanhThu.Columns.Contains("ConLai"))      dgvDoanhThu.Columns["ConLai"].HeaderText      = "Còn Lại (VNĐ)";

                VeBieuDo();
                CapNhatTongKet();
                lblThongBao.Text = "";
            }
            catch (Exception ex)
            {
                lblThongBao.ForeColor = Color.Crimson;
                lblThongBao.Text = "Lỗi: " + ex.Message;
            }
        }

        private DataTable LayDoanhThu()
        {
            int loaiIdx = cboLoai.SelectedIndex;   // 0=Ngày, 1=Tháng, 2=Năm, 3=Khoảng ngày
            int nam     = (cboNam.SelectedItem != null) ? (int)cboNam.SelectedItem : DateTime.Now.Year;
            int thang   = cboThang.SelectedIndex + 1;
            DateTime tuNgay  = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            return HopDongBLL.LayDoanhThu(loaiIdx, nam, thang, tuNgay, denNgay);
        }

        // ============================================================
        //  Cập nhật 4 thẻ KPI
        // ============================================================
        private void CapNhatTongKet()
        {
            if (_dt == null || _dt.Rows.Count == 0)
            {
                lblTongDoanhThu.Text    = "0 đ";
                lblTongHopDong.Text     = "0 HĐ";
                lblTongDaThanhToan.Text = "—";
                lblTongConLai.Text      = "0 đ";
                if (lblKPI3Sub != null) lblKPI3Sub.Text = "";
                return;
            }

            decimal tdt = 0, tcl = 0;
            int     thd = 0;
            foreach (DataRow r in _dt.Rows)
            {
                tdt  += Convert.ToDecimal(r["DoanhThu"]);
                thd  += Convert.ToInt32(r["SoHopDong"]);
                tcl  += Convert.ToDecimal(r["ConLai"]);
            }
            lblTongDoanhThu.Text    = tdt.ToString("N0")  + " đ";
            lblTongHopDong.Text     = thd.ToString("N0") + " HĐ";
            lblTongConLai.Text      = tcl.ToString("N0")  + " đ";

            // Tỷ lệ tăng trưởng so kỳ trước (Card 3)
            int loaiIdx = cboLoai.SelectedIndex;
            int nam     = (int)cboNam.SelectedItem;
            int thang   = cboThang.SelectedIndex + 1;
            DateTime tuNgay  = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            try
            {
                var (hienTai, kyTruoc) = HopDongBLL.LayTangTruong(loaiIdx, nam, thang, tuNgay, denNgay);
                if (kyTruoc == 0)
                {
                    lblTongDaThanhToan.Text = hienTai > 0 ? "Mới" : "—";
                    lblTongDaThanhToan.ForeColor = Color.FromArgb(140, 80, 10);
                    if (lblKPI3Sub != null) lblKPI3Sub.Text = "(Chưa có kỳ trước)";
                }
                else
                {
                    double pct = (double)(hienTai - kyTruoc) / (double)kyTruoc * 100.0;
                    bool up = pct >= 0;
                    lblTongDaThanhToan.Text = (up ? "▲ +" : "▼ ") + pct.ToString("F1") + "%";
                    lblTongDaThanhToan.ForeColor = up ? Color.FromArgb(20, 140, 60) : Color.FromArgb(180, 30, 30);
                    if (lblKPI3Sub != null)
                        lblKPI3Sub.Text = "Kỳ trước: " + kyTruoc.ToString("N0") + " đ";
                }
            }
            catch
            {
                lblTongDaThanhToan.Text = "—";
                lblTongDaThanhToan.ForeColor = Color.Gray;
                if (lblKPI3Sub != null) lblKPI3Sub.Text = "";
            }
        }

        // ============================================================
        //  Vẽ biểu đồ đường (Line Chart) GDI+
        // ============================================================
        private void VeBieuDo()
        {
            if (picChart.Width < 30 || picChart.Height < 30) return;

            var bmp = new Bitmap(picChart.Width, picChart.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode      = SmoothingMode.AntiAlias;
                g.TextRenderingHint  = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                g.Clear(Color.White);

                if (_dt == null || _dt.Rows.Count == 0)
                {
                    using (var fMsg = new Font("Segoe UI", 11F, FontStyle.Italic))
                    using (var brMsg = new SolidBrush(Color.FromArgb(180, 190, 210)))
                    {
                        var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString("Chưa có dữ liệu — hãy chọn bộ lọc và nhấn Làm Mới", fMsg, brMsg,
                            new RectangleF(0, 0, bmp.Width, bmp.Height), sf);
                    }
                    picChart.Image = bmp;
                    return;
                }

                int W = bmp.Width, H = bmp.Height;
                int padL = 68, padR = 20, padT = 22, padB = 52;
                int cw = W - padL - padR;
                int ch = H - padT - padB;
                int n  = Math.Min(_dt.Rows.Count, 30);

                // Tính max
                double maxV = 1;
                for (int i = 0; i < n; i++)
                {
                    double v = Convert.ToDouble(_dt.Rows[i]["DoanhThu"]);
                    if (v > maxV) maxV = v;
                }
                double scale = ch / maxV;

                // Helpers
                float Yp(double v) => (float)(padT + ch - v * scale);
                float Xp(int i)   => (float)(padL + (n == 1 ? cw / 2 : i * (double)cw / (n - 1)));

                // Gridlines ngang
                using (var penGrid = new Pen(Color.FromArgb(235, 238, 245), 1f))
                using (var fontAx  = new Font("Segoe UI", 7.5f))
                using (var brAxis  = new SolidBrush(Color.FromArgb(140, 150, 170)))
                {
                    for (int gi = 0; gi <= 5; gi++)
                    {
                        float gy  = padT + ch * gi / 5f;
                        g.DrawLine(penGrid, padL, gy, W - padR, gy);
                        double yVal = maxV * (5 - gi) / 5;
                        string yLbl = yVal >= 1_000_000
                            ? (yVal / 1_000_000).ToString("N1") + "M"
                            : yVal >= 1_000 ? (yVal / 1_000).ToString("N0") + "K"
                            : yVal.ToString("N0");
                        g.DrawString(yLbl, fontAx, brAxis, 2f, gy - 8);
                    }

                    // Nhãn trục X
                    for (int i = 0; i < n; i++)
                    {
                        string lbl = _dt.Rows[i]["ThoiGian"].ToString();
                        if (lbl.Length > 8) lbl = lbl.Substring(lbl.Length - 5);
                        float x = Xp(i);
                        var sf = new StringFormat { Alignment = StringAlignment.Center };
                        g.DrawString(lbl, fontAx, brAxis,
                            new RectangleF(x - 24, H - padB + 6, 48, 18), sf);
                        using (var penTick = new Pen(Color.FromArgb(200, 210, 225), 1))
                            g.DrawLine(penTick, x, padT + ch, x, padT + ch + 4);
                    }
                }

                // Điểm dữ liệu
                var ptsDT = new PointF[n];
                var ptsTT = new PointF[n];
                for (int i = 0; i < n; i++)
                {
                    double vDT  = Convert.ToDouble(_dt.Rows[i]["DoanhThu"]);
                    double vDaTT = Convert.ToDouble(_dt.Rows[i]["DaThanhToan"]);
                    ptsDT[i] = new PointF(Xp(i), Yp(vDT));
                    ptsTT[i] = new PointF(Xp(i), Yp(vDaTT));
                }

                // Area Gradient Fills
                if (n >= 2)
                {
                    var fillPts = new PointF[n + 2];
                    for (int i = 0; i < n; i++) fillPts[i] = ptsDT[i];
                    fillPts[n]     = new PointF(Xp(n - 1), padT + ch);
                    fillPts[n + 1] = new PointF(Xp(0),     padT + ch);
                    using (var gfx = new LinearGradientBrush(
                        new PointF(0, padT), new PointF(0, padT + ch),
                        Color.FromArgb(80, 22, 55, 160), Color.FromArgb(5, 22, 55, 160)))
                        g.FillPolygon(gfx, fillPts);

                    var fillTT = new PointF[n + 2];
                    for (int i = 0; i < n; i++) fillTT[i] = ptsTT[i];
                    fillTT[n]     = new PointF(Xp(n - 1), padT + ch);
                    fillTT[n + 1] = new PointF(Xp(0),     padT + ch);
                    using (var gTT = new LinearGradientBrush(
                        new PointF(0, padT), new PointF(0, padT + ch),
                        Color.FromArgb(60, 20, 160, 80), Color.FromArgb(5, 20, 160, 80)))
                        g.FillPolygon(gTT, fillTT);
                }

                // Vẽ lines
                if (n == 1)
                {
                    using (var penDT = new Pen(Color.FromArgb(40, 100, 220), 3))
                        g.DrawEllipse(penDT, ptsDT[0].X - 5, ptsDT[0].Y - 5, 10, 10);
                }
                else
                {
                    using (var penDT = new Pen(Color.FromArgb(40, 100, 220), 2.5f))
                    {
                        penDT.LineJoin = LineJoin.Round;
                        g.DrawCurve(penDT, ptsDT, 0.35f);
                    }
                    using (var penTT = new Pen(Color.FromArgb(25, 170, 80), 2f))
                    {
                        penTT.DashStyle = DashStyle.Dash;
                        g.DrawCurve(penTT, ptsTT, 0.35f);
                    }
                }

                // Dots
                for (int i = 0; i < n; i++)
                {
                    using (var brDot = new SolidBrush(Color.FromArgb(22, 55, 160)))
                        g.FillEllipse(brDot, ptsDT[i].X - 4, ptsDT[i].Y - 4, 8, 8);
                    using (var brW = new SolidBrush(Color.White))
                        g.FillEllipse(brW, ptsDT[i].X - 2, ptsDT[i].Y - 2, 4, 4);

                    using (var brDot2 = new SolidBrush(Color.FromArgb(20, 150, 70)))
                        g.FillEllipse(brDot2, ptsTT[i].X - 3, ptsTT[i].Y - 3, 6, 6);
                }

                // Legend
                using (var fontLg = new Font("Segoe UI", 8.5f))
                using (var brLg   = new SolidBrush(Color.FromArgb(80, 90, 110)))
                {
                    int lx = padL + 6, ly = H - padB + 24;
                    using (var br = new SolidBrush(Color.FromArgb(40, 100, 220)))
                        g.FillRectangle(br, lx, ly + 2, 18, 10);
                    g.DrawString("Doanh thu", fontLg, brLg, lx + 22, ly);

                    lx += 120;
                    using (var br = new SolidBrush(Color.FromArgb(25, 170, 80)))
                        g.FillRectangle(br, lx, ly + 2, 18, 10);
                    g.DrawString("Đã thanh toán", fontLg, brLg, lx + 22, ly);
                }
            }
            picChart.Image = bmp;
        }

        // ============================================================
        //  Event handlers
        // ============================================================
        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cboLoai.SelectedIndex;
            bool showThang  = (idx == 0);
            bool showNgay   = (idx == 3);
            lblThang.Visible    = showThang;
            cboThang.Visible    = showThang;
            lblTuNgay.Visible   = showNgay;
            dtpTuNgay.Visible   = showNgay;
            lblDenNgay.Visible  = showNgay;
            dtpDenNgay.Visible  = showNgay;
            lblNam.Visible      = (idx != 3);
            cboNam.Visible      = (idx != 3);
            LoadDuLieu();
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)   => LoadDuLieu();
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e) => LoadDuLieu();
        private void btnLamMoi_Click(object sender, EventArgs e)               => LoadDuLieu();
        private void picChart_Resize(object sender, EventArgs e)               => VeBieuDo();

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)        => LoadDuLieu();
        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)       => LoadDuLieu();

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (_dt == null || _dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog
            {
                Filter   = "CSV Files|*.csv",
                FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("Thoi Gian,So Hop Dong,Doanh Thu,Da Thanh Toan,Con Lai");
                foreach (DataRow row in _dt.Rows)
                    sb.AppendLine($"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]}");
                System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                MessageBox.Show("Xuất CSV thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
