using QLQC.Class;
using QLQC.BLL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace QLQC.Forms
{
    public partial class FrmThongKeBaiViet : Form
    {
        private DataTable tblBaiViet;
        private readonly ThongKeBaiVietBLL _bll = new ThongKeBaiVietBLL();
        private LiveCharts.WinForms.PieChart pieChart;
        private Panel pnlChartEmpty;  // placeholder khi chưa có dữ liệu

        // Màu theo trạng thái
        private static Color GetTrangThaiColor(string tt)
        {
            tt = (tt ?? "").ToLower();
            if (tt.Contains("đang viết") || tt.Contains("viết")) return Color.FromArgb(217, 119, 6);
            if (tt.Contains("chờ duyệt") || tt.Contains("duyệt")) return Color.FromArgb(37, 99, 235);
            if (tt.Contains("đã duyệt") || tt.Contains("chờ đăng")) return Color.FromArgb(124, 58, 237);
            if (tt.Contains("đã đăng") || tt.Contains("đăng")) return Color.FromArgb(4, 120, 87);
            if (tt.Contains("kết thúc") || tt.Contains("thúc")) return Color.FromArgb(107, 114, 128);
            if (tt.Contains("chờ xử lý") || tt.Contains("xử lý")) return Color.FromArgb(220, 38, 38);
            return Color.FromArgb(67, 56, 202);
        }

        public FrmThongKeBaiViet()
        {
            InitializeComponent();
            InitCustomStyles();
        }

        private void InitCustomStyles()
        {
            this.lblFooterDate.Text = "📅  " + System.DateTime.Now.ToString("dd/MM/yyyy");
            this.Resize += (s, e) =>
            {
                lblFooterDate.Location = new Point(this.ClientSize.Width - lblFooterDate.Width - 20, 10);
                UpdateHeaderLayout();
            };
            this.Load += (s, e) =>
            {
                lblFooterDate.Location = new Point(this.ClientSize.Width - lblFooterDate.Width - 20, 10);
                UpdateHeaderLayout();
            };
        }

        private void UpdateHeaderLayout()
        {
            // Ensure title and subtitle do not overlap with right-side content
            int maxRight = this.ClientSize.Width - 150; // reserve space for decorative icon
            if (lblTitle.Right > maxRight)
            {
                lblTitle.Location = new Point(Math.Max(20, maxRight - lblTitle.Width), lblTitle.Location.Y);
            }
            if (lblSubtitle.Right > maxRight)
            {
                lblSubtitle.Location = new Point(Math.Max(20, maxRight - lblSubtitle.Width), lblSubtitle.Location.Y);
            }
        }
        

        private void FrmThongKeBaiViet_Load(object sender, EventArgs e)
        {
            Functions.Ketnot();

            // Mặc định: từ đầu tháng đến hôm nay
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            InitializeLiveChart();
            LoadCboTrangThai();
            LoadCboNhanVien();
            LoadGrid();
        }

        // ─── Khởi tạo LiveCharts PieChart ─────────────────────────────────────
        private void InitializeLiveChart()
        {
            // --- Tiêu đề của khu vực biểu đồ ---
            Panel pnlChartHeader = new Panel();
            pnlChartHeader.Dock = DockStyle.Top;
            pnlChartHeader.Height = 50;
            pnlChartHeader.BackColor = Color.FromArgb(238, 242, 255);

            Panel barLeft = new Panel();
            barLeft.Location = new Point(0, 0);
            barLeft.Size = new Size(4, 50);
            barLeft.BackColor = Color.FromArgb(67, 56, 202);
            pnlChartHeader.Controls.Add(barLeft);

            Label lblChartTitle = new Label();
            lblChartTitle.Text = "📊  Cơ cấu trạng thái bài viết";
            lblChartTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(67, 56, 202);
            lblChartTitle.Location = new Point(14, 5);
            lblChartTitle.AutoSize = false;
            lblChartTitle.Size = new Size(400, 22);
            pnlChartHeader.Controls.Add(lblChartTitle);

            Label lblChartDesc = new Label();
            lblChartDesc.Text = "Tỷ lệ % mỗi trạng thái sau khi lọc";
            lblChartDesc.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
            lblChartDesc.ForeColor = Color.FromArgb(107, 114, 128);
            lblChartDesc.Location = new Point(14, 28);
            lblChartDesc.AutoSize = false;
            lblChartDesc.Size = new Size(400, 20);
            pnlChartHeader.Controls.Add(lblChartDesc);

            // --- Placeholder khi chưa có dữ liệu ---
            pnlChartEmpty = new Panel();
            pnlChartEmpty.Dock = DockStyle.Fill;
            pnlChartEmpty.BackColor = Color.White;

            Label lblEmptyIcon = new Label();
            lblEmptyIcon.Text = "📊";
            lblEmptyIcon.Font = new Font("Segoe UI", 32F);
            lblEmptyIcon.ForeColor = Color.FromArgb(209, 213, 219);
            lblEmptyIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblEmptyIcon.Dock = DockStyle.Fill;
            pnlChartEmpty.Controls.Add(lblEmptyIcon);

            Label lblEmptyText = new Label();
            lblEmptyText.Text = "Nhấn 'Lọc dữ liệu' để xem biểu đồ";
            lblEmptyText.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblEmptyText.ForeColor = Color.FromArgb(156, 163, 175);
            lblEmptyText.TextAlign = ContentAlignment.BottomCenter;
            lblEmptyText.Dock = DockStyle.Bottom;
            lblEmptyText.Height = 40;
            pnlChartEmpty.Controls.Add(lblEmptyText);

            // --- PieChart LiveCharts ---
            pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Dock = DockStyle.Fill;
            pieChart.LegendLocation = LiveCharts.LegendLocation.Bottom;
            pieChart.BackColor = Color.White;
            pieChart.Visible = false; // Ẩn đến khi có dữ liệu

            pnlChartHolder.Controls.Add(pieChart);
            pnlChartHolder.Controls.Add(pnlChartEmpty);
            pnlChartHolder.Controls.Add(pnlChartHeader);
        }

        // ─── Nạp ComboBox Trạng thái ─────────────────────────────────────────
        private void LoadCboTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("-- Tất cả --");
            cboTrangThai.Items.AddRange(new object[]
            {
                "Đang chờ xử lý", "Đang viết", "Chờ duyệt",
                "Đã duyệt – chờ đăng", "Đã đăng", "Đã kết thúc"
            });
            cboTrangThai.SelectedIndex = 0;
        }

        // ─── Nạp ComboBox Nhân viên ──────────────────────────────────────────
        private void LoadCboNhanVien()
        {
            try
            {
                DataTable dt = _bll.GetNhanVienVietBai();

                cboNhanVien.Items.Clear();
                cboNhanVien.Items.Add(new ComboItem(0, "-- Tất cả --"));
                foreach (DataRow r in dt.Rows)
                    cboNhanVien.Items.Add(new ComboItem(
                        Convert.ToInt32(r["MaNguoiDung"]),
                        r["HoTen"].ToString()));

                cboNhanVien.DisplayMember = "Text";
                cboNhanVien.ValueMember = "Value";
                cboNhanVien.SelectedIndex = 0;
            }
            catch { cboNhanVien.Items.Add("-- Tất cả --"); cboNhanVien.SelectedIndex = 0; }
        }

        // ─── Helper ComboItem ─────────────────────────────────────────────────
        private class ComboItem
        {
            public int Value { get; }
            public string Text { get; }
            public ComboItem(int v, string t) { Value = v; Text = t; }
            public override string ToString() => Text;
        }

        // ─── Nạp grid + summary + chart ───────────────────────────────────────────────
        private void LoadGrid()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;
                string trangThai = cboTrangThai.SelectedItem?.ToString() ?? "";
                
                int maNV = 0;
                if (cboNhanVien.SelectedItem is ComboItem ci)
                {
                    maNV = ci.Value;
                }

                tblBaiViet = _bll.GetBaiVietThongKe(tuNgay, denNgay, trangThai, maNV);
                ApplyDataSource(tblBaiViet);
                RefreshSummaryCards(tblBaiViet);
                UpdateChart(tblBaiViet);

                lblTongSo.Text = $"Tổng: {tblBaiViet.Rows.Count} bài viết";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Gắn DataSource + cột ────────────────────────────────────────────
        private void ApplyDataSource(DataTable dt)
        {
            dgridBaiViet.DataSource = dt;

            if (dgridBaiViet.Columns.Count == 0) return;

            var headers = new System.Collections.Generic.Dictionary<string, (string Header, int Width)>
            {
                { "MaBaiViet",        ("Mã BV",        60)  },
                { "TieuDe",           ("Tiêu đề",      240) },
                { "TrangThaiBaiViet", ("Trạng thái",   140) },
                { "TheLoai",          ("Thể loại",     110) },
                { "NhanVien",         ("Nhân viên",    130) },
                { "MaHopDong",        ("Mã HĐ",        70)  },
                { "NgayTao",          ("Ngày tạo",     95)  },
                { "NgayNop",          ("Ngày nộp",     95)  },
                { "NgayDuyet",        ("Ngày duyệt",   95)  },
                { "NgayDang",         ("Ngày đăng",    95)  },
                { "GhiChu",           ("Ghi chú",      180) },
            };

            foreach (var kv in headers)
            {
                if (dgridBaiViet.Columns.Contains(kv.Key))
                {
                    dgridBaiViet.Columns[kv.Key].HeaderText = kv.Value.Header;
                    dgridBaiViet.Columns[kv.Key].Width = kv.Value.Width;
                    dgridBaiViet.Columns[kv.Key].ReadOnly = true;
                }
            }

            dgridBaiViet.AllowUserToAddRows = false;
        }

        // ─── Cập nhật biểu đồ trạng thái LiveCharts ───────────────────────────
        private void UpdateChart(DataTable dt)
        {
            if (pieChart == null) return;

            if (dt.Rows.Count == 0)
            {
                // Hiển thị placeholder, ẩn biểu đồ
                pieChart.Visible = false;
                if (pnlChartEmpty != null) pnlChartEmpty.Visible = true;
                return;
            }

            var counts = new System.Collections.Generic.Dictionary<string, int>();
            foreach (DataRow r in dt.Rows)
            {
                string tt = r["TrangThaiBaiViet"]?.ToString() ?? "Không rõ";
                if (!counts.ContainsKey(tt)) counts[tt] = 0;
                counts[tt]++;
            }

            var series = new LiveCharts.SeriesCollection();
            foreach (var kv in counts)
            {
                Color clr = GetTrangThaiColor(kv.Key);
                System.Windows.Media.Color wpfColor = System.Windows.Media.Color.FromRgb(clr.R, clr.G, clr.B);

                series.Add(new LiveCharts.Wpf.PieSeries
                {
                    Title = kv.Key,
                    Values = new LiveCharts.ChartValues<int> { kv.Value },
                    DataLabels = true,
                    Fill = new System.Windows.Media.SolidColorBrush(wpfColor),
                    LabelPoint = chartPoint => string.Format("{0} ({1:P0})", chartPoint.Y, chartPoint.Participation)
                });
            }

            pieChart.Series = series;

            // Hiển thị biểu đồ, ẩn placeholder
            if (pnlChartEmpty != null) pnlChartEmpty.Visible = false;
            pieChart.Visible = true;
        }

        // ─── Summary Cards ────────────────────────────────────────────────────
        private void RefreshSummaryCards(DataTable dt)
        {
            pnlSummary.Controls.Clear();

            int total = dt.Rows.Count;
            int daDang = 0, choDuyet = 0, dangViet = 0, ketThuc = 0;

            foreach (DataRow r in dt.Rows)
            {
                string tt = (r["TrangThaiBaiViet"]?.ToString() ?? "").ToLower();
                if (tt.Contains("đã đăng") || tt.Contains("đăng")) daDang++;
                else if (tt.Contains("chờ duyệt") || tt.Contains("duyệt")) choDuyet++;
                else if (tt.Contains("đang viết") || tt.Contains("viết")) dangViet++;
                else if (tt.Contains("kết thúc")) ketThuc++;
            }

            var cards = new (string Icon, string Label, int Count, Color Bg, Color Fg, Color Border)[]
            {
                ("📄", "Tổng bài viết",  total,    Color.FromArgb(238,242,255), Color.FromArgb(67,56,202),  Color.FromArgb(67,56,202)),
                ("✍️", "Đang viết",      dangViet, Color.FromArgb(255,251,235), Color.FromArgb(217,119,6),  Color.FromArgb(217,119,6)),
                ("🕐", "Chờ duyệt",      choDuyet, Color.FromArgb(239,246,255), Color.FromArgb(37,99,235),  Color.FromArgb(37,99,235)),
                ("✅", "Đã đăng",        daDang,   Color.FromArgb(240,253,244), Color.FromArgb(4,120,87),   Color.FromArgb(4,120,87)),
            };

            int cardW = (pnlSummary.Width - 45) / 4;
            int cx = 0;

            foreach (var card in cards)
            {
                Panel p = new Panel();
                p.Location = new Point(cx, 0);
                p.Size = new Size(cardW, 86);
                p.BackColor = card.Bg;

                // Viền trái màu
                Panel bar = new Panel();
                bar.Location = new Point(0, 0);
                bar.Size = new Size(4, 86);
                bar.BackColor = card.Border;
                p.Controls.Add(bar);

                Label lIcon = new Label();
                lIcon.Text = card.Icon;
                lIcon.Font = new Font("Segoe UI", 18F);
                lIcon.Location = new Point(12, 23);
                lIcon.Size = new Size(40, 40);
                lIcon.AutoSize = false;
                lIcon.TextAlign = ContentAlignment.MiddleCenter;
                p.Controls.Add(lIcon);

                Label lCount = new Label();
                lCount.Text = card.Count.ToString();
                lCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
                lCount.ForeColor = card.Fg;
                lCount.Location = new Point(60, 12);
                lCount.AutoSize = false;
                lCount.Size = new Size(200, 38);
                p.Controls.Add(lCount);

                Label lLabel = new Label();
                lLabel.Text = card.Label;
                lLabel.Font = new Font("Segoe UI", 9.5F);
                lLabel.ForeColor = card.Fg;
                lLabel.Location = new Point(62, 50);
                lLabel.AutoSize = false;
                lLabel.Size = new Size(200, 25);
                p.Controls.Add(lLabel);

                pnlSummary.Controls.Add(p);
                cx += cardW + 15;
            }
        }

        // ─── CellFormatting – tô màu cột Trạng thái ─────────────────────────
        private void dgridBaiViet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgridBaiViet.Columns[e.ColumnIndex].Name != "TrangThaiBaiViet") return;

            string tt = e.Value?.ToString() ?? "";
            Color clr = GetTrangThaiColor(tt);
            e.CellStyle.ForeColor = clr;
            e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            e.CellStyle.SelectionForeColor = Color.White;
            e.FormattingApplied = true;
        }

        // ─── Nút Lọc ─────────────────────────────────────────────────────────
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!",
                    "Ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadGrid();
        }

        // ─── Nút Xuất Excel (CSV đơn giản) ───────────────────────────────────
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (tblBaiViet == null || tblBaiViet.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV File (*.csv)|*.csv";
            dlg.FileName = $"ThongKeBaiViet_{DateTime.Now:yyyyMMdd_HHmm}.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    // Header
                    string[] cols = { "Mã BV","Tiêu đề","Trạng thái","Thể loại","Nhân viên",
                                      "Mã HĐ","Ngày tạo","Ngày nộp","Ngày duyệt","Ngày đăng","Ghi chú" };
                    sb.AppendLine(string.Join(",", cols));

                    foreach (DataRow r in tblBaiViet.Rows)
                    {
                        string[] vals = {
                            r["MaBaiViet"].ToString(),
                            $"\"{r["TieuDe"]}\"",
                            r["TrangThaiBaiViet"].ToString(),
                            r["TheLoai"].ToString(),
                            r["NhanVien"].ToString(),
                            r["MaHopDong"].ToString(),
                            r["NgayTao"].ToString(),
                            r["NgayNop"].ToString(),
                            r["NgayDuyet"].ToString(),
                            r["NgayDang"].ToString(),
                            $"\"{r["GhiChu"]}\""
                        };
                        sb.AppendLine(string.Join(",", vals));
                    }

                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show($"Xuất file thành công!\n{dlg.FileName}", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}