using QLQC.Class;
using QLQC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace QLQC.Forms
{
    public partial class FrmBieuDo : Form
    {
        // BLL layer
        private readonly BieuDoBLL _bll = new BieuDoBLL();

        // LiveCharts Controls
        private LiveCharts.WinForms.CartesianChart lvcDoanhThu;
        private LiveCharts.WinForms.PieChart lvcHopDong;
        private LiveCharts.WinForms.CartesianChart lvcBaiViet;
        private LiveCharts.WinForms.CartesianChart lvcLuyKe;

        // Colors
        static readonly System.Windows.Media.Color C_Indigo = System.Windows.Media.Color.FromRgb(79, 70, 229);
        static readonly System.Windows.Media.Color C_Teal = System.Windows.Media.Color.FromRgb(13, 148, 136);
        static readonly System.Windows.Media.Color C_Amber = System.Windows.Media.Color.FromRgb(217, 119, 6);
        static readonly System.Windows.Media.Color C_Green = System.Windows.Media.Color.FromRgb(22, 163, 74);

        private static readonly System.Windows.Media.Color[] BeautifulColors = {
            System.Windows.Media.Color.FromRgb(79, 70, 229),   // Indigo
            System.Windows.Media.Color.FromRgb(16, 185, 129),  // Emerald
            System.Windows.Media.Color.FromRgb(245, 158, 11),  // Amber
            System.Windows.Media.Color.FromRgb(239, 68, 68),   // Rose
            System.Windows.Media.Color.FromRgb(14, 165, 233),  // Sky
            System.Windows.Media.Color.FromRgb(168, 85, 247),  // Purple
            System.Windows.Media.Color.FromRgb(107, 114, 128)  // Gray
        };

        public FrmBieuDo()
        {
            InitializeComponent();
            InitCustomStyles();
        }

        private void InitCustomStyles()
        {
            // Top gradient stripe
            var stripe = new Panel { Dock = DockStyle.Top, Height = 4 };
            stripe.Paint += (s, e) =>
            {
                using (var gb = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Point(0, 0), new Point(stripe.Width, 0),
                    Color.FromArgb(79, 70, 229), Color.FromArgb(14, 165, 233)))
                    e.Graphics.FillRectangle(gb, 0, 0, stripe.Width, 4);
            };
            this.pnlHeader.Controls.Add(stripe);

            // Bottom border
            var headerBorder = new Panel { Dock = DockStyle.Bottom, Height = 1, BackColor = Color.FromArgb(229, 231, 235) };
            this.pnlHeader.Controls.Add(headerBorder);

            // Icon background circle
            var lblIconBg = new Label
            {
                Size = new Size(46, 46),
                Location = new Point(18, 18),
                BackColor = Color.FromArgb(238, 237, 255),
            };
            lblIconBg.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var br = new SolidBrush(Color.FromArgb(238, 237, 255)))
                    e.Graphics.FillEllipse(br, 0, 0, 45, 45);
            };
            this.pnlHeader.Controls.Add(lblIconBg);

            var lblIcon = new Label
            {
                Text = "📊",
                Font = new Font("Segoe UI", 20F),
                ForeColor = Color.FromArgb(79, 70, 229),
                Size = new Size(46, 46),
                Location = new Point(18, 18),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            this.pnlHeader.Controls.Add(lblIcon);

            var lblTitle = new Label
            {
                Text = "BIỂU ĐỒ THỐNG KÊ TỔNG HỢP",
                ForeColor = Color.FromArgb(17, 24, 39),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(76, 15),
                AutoSize = false,
                Size = new Size(600, 32)
            };
            this.pnlHeader.Controls.Add(lblTitle);

            var lblSub = new Label
            {
                Text = "Doanh thu · Hợp đồng · Bài viết · Lũy kế — lọc theo năm / tháng",
                ForeColor = Color.FromArgb(107, 114, 128),
                Font = new Font("Segoe UI", 9F),
                Location = new Point(78, 48),
                AutoSize = false,
                Size = new Size(800, 20)
            };
            this.pnlHeader.Controls.Add(lblSub);

            // Decorative icon right
            var lblBgIco = new Label
            {
                Text = "📈",
                Font = new Font("Segoe UI", 30F),
                ForeColor = Color.FromArgb(20, 79, 70, 229),
                Size = new Size(68, 66),
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.Transparent
            };
            this.pnlHeader.Controls.Add(lblBgIco);
            this.pnlHeader.Resize += (s, ev) =>
                lblBgIco.Location = new Point(this.pnlHeader.Width - 84, 7);

            var toolBorder = new Panel { Dock = DockStyle.Bottom, Height = 1, BackColor = Color.FromArgb(229, 231, 235) };
            this.pnlToolbar.Controls.Add(toolBorder);

            // Hover effects
            this.btnVeBieu.MouseEnter += (s, ev) => this.btnVeBieu.BackColor = Color.FromArgb(67, 56, 202);
            this.btnVeBieu.MouseLeave += (s, ev) => this.btnVeBieu.BackColor = Color.FromArgb(79, 70, 229);

            this.btnLamMoi.MouseEnter += (s, ev) => { this.btnLamMoi.BackColor = Color.FromArgb(238, 237, 255); };
            this.btnLamMoi.MouseLeave += (s, ev) => { this.btnLamMoi.BackColor = Color.White; };

            var footBorder = new Panel { Dock = DockStyle.Top, Height = 1, BackColor = Color.FromArgb(229, 231, 235) };
            this.pnlFooter.Controls.Add(footBorder);

            // Status dot
            var dot = new Label
            {
                Text = "●",
                ForeColor = Color.FromArgb(22, 163, 74),
                Font = new Font("Segoe UI", 8F),
                Location = new Point(14, 11),
                AutoSize = true
            };
            this.pnlFooter.Controls.Add(dot);

            // Version tag right
            var lblVer = new Label
            {
                Text = "QLQC v1.0",
                ForeColor = Color.FromArgb(209, 213, 219),
                Font = new Font("Segoe UI", 7.5F),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };
            this.pnlFooter.Controls.Add(lblVer);
            this.pnlFooter.Resize += (s, ev) =>
                lblVer.Location = new Point(this.pnlFooter.Width - lblVer.Width - 14, 11);
        }

        // ══════════════════════════════════════════════════════════════════
        //  LOAD
        // ══════════════════════════════════════════════════════════════════
        private void FrmBieuDo_Load(object sender, EventArgs e)
        {
            Functions.Ketnot();

            // Setup Comboboxes
            int curYear = DateTime.Now.Year;
            for (int y = curYear; y >= curYear - 5; y--)
                cboNam.Items.Add(y.ToString());
            cboNam.SelectedIndex = 0;

            cboThang.Items.Add("Cả năm");
            for (int m = 1; m <= 12; m++)
                cboThang.Items.Add($"Tháng {m}");
            cboThang.SelectedIndex = 0;

            cboLoaiBD.Items.AddRange(new object[]
            {
                "Tổng hợp (4 biểu đồ)",
                "Doanh thu theo tháng",
                "Hợp đồng theo trạng thái",
                "Bài viết theo trạng thái",
                "Doanh thu lũy kế"
            });
            cboLoaiBD.SelectedIndex = 0;

            // Initialize all 4 LiveCharts
            InitializeLiveCharts();

            // Load and draw
            LoadAndDraw();
        }

        // ══════════════════════════════════════════════════════════════════
        //  INITIALIZE LIVECHARTS
        // ══════════════════════════════════════════════════════════════════
        private void InitializeLiveCharts()
        {
            // 1. Doanh thu (Column Chart)
            lvcDoanhThu = new LiveCharts.WinForms.CartesianChart();
            lvcDoanhThu.Dock = DockStyle.Fill;
            lvcDoanhThu.BackColor = Color.White;
            lvcDoanhThu.LegendLocation = LegendLocation.None;
            pnlChart1.Controls.Add(lvcDoanhThu);

            // 2. Hợp đồng (Donut Pie Chart)
            lvcHopDong = new LiveCharts.WinForms.PieChart();
            lvcHopDong.Dock = DockStyle.Fill;
            lvcHopDong.BackColor = Color.White;
            lvcHopDong.LegendLocation = LegendLocation.Right;
            lvcHopDong.InnerRadius = 60; // Make it a Donut Chart!
            pnlChart2.Controls.Add(lvcHopDong);

            // 3. Bài viết (Row/Horizontal Bar Chart)
            lvcBaiViet = new LiveCharts.WinForms.CartesianChart();
            lvcBaiViet.Dock = DockStyle.Fill;
            lvcBaiViet.BackColor = Color.White;
            lvcBaiViet.LegendLocation = LegendLocation.None;
            pnlChart3.Controls.Add(lvcBaiViet);

            // 4. Doanh thu lũy kế (Area Line Chart)
            lvcLuyKe = new LiveCharts.WinForms.CartesianChart();
            lvcLuyKe.Dock = DockStyle.Fill;
            lvcLuyKe.BackColor = Color.White;
            lvcLuyKe.LegendLocation = LegendLocation.None;
            pnlChart4.Controls.Add(lvcLuyKe);
        }

        private void FrmBieuDo_Resize(object sender, EventArgs e) => LayoutCharts();
        private void btnVeBieu_Click(object sender, EventArgs e) => LoadAndDraw();
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLoaiBD.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            LoadAndDraw();
        }

        // ══════════════════════════════════════════════════════════════════
        //  LAYOUT
        // ══════════════════════════════════════════════════════════════════
        private void LayoutCharts()
        {
            int gap = 14;
            int pw = pnlChartArea.Width - gap * 3;
            int ph = pnlChartArea.Height - gap * 3;
            int hw = pw / 2;
            int hh = ph / 2;

            string sel = cboLoaiBD.SelectedItem?.ToString() ?? "";
            bool full = sel == "Tổng hợp (4 biểu đồ)";

            if (full)
            {
                pnlChart1.Visible = pnlChart2.Visible = pnlChart3.Visible = pnlChart4.Visible = true;
                pnlChart1.Location = new Point(gap, gap); pnlChart1.Size = new Size(hw, hh);
                pnlChart2.Location = new Point(gap * 2 + hw, gap); pnlChart2.Size = new Size(hw, hh);
                pnlChart3.Location = new Point(gap, gap * 2 + hh); pnlChart3.Size = new Size(hw, hh);
                pnlChart4.Location = new Point(gap * 2 + hw, gap * 2 + hh); pnlChart4.Size = new Size(hw, hh);
            }
            else
            {
                pnlChart1.Visible = (sel == "Doanh thu theo tháng");
                pnlChart2.Visible = (sel == "Hợp đồng theo trạng thái");
                pnlChart3.Visible = (sel == "Bài viết theo trạng thái");
                pnlChart4.Visible = (sel == "Doanh thu lũy kế");

                int fw = pnlChartArea.Width - gap * 2;
                int fh = pnlChartArea.Height - gap * 2;
                pnlChart1.Location = pnlChart2.Location =
                pnlChart3.Location = pnlChart4.Location = new Point(gap, gap);
                pnlChart1.Size = pnlChart2.Size = pnlChart3.Size = pnlChart4.Size = new Size(fw, fh);
            }
        }

        // ══════════════════════════════════════════════════════════════════
        //  DATA LOAD
        // ══════════════════════════════════════════════════════════════════
        private void LoadAndDraw()
        {
            int nam = int.Parse(cboNam.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString());
            int thang = cboThang.SelectedIndex;
            lblStatus.Text = $"Đang tải dữ liệu năm {nam}...";

            try
            {
                // Fetch & Draw each chart
                DrawDoanhThu(nam, thang);
                DrawHopDong(nam, thang);
                DrawBaiViet(nam, thang);

                lblStatus.Text = $"✔  Cập nhật lúc {DateTime.Now:HH:mm:ss}  |  Năm {nam}" +
                                 (thang > 0 ? $"  Tháng {thang}" : "  (Cả năm)");
            }
            catch (Exception ex)
            {
                lblStatus.Text = "⚠  Lỗi: " + ex.Message;
                MessageBox.Show("Có lỗi xảy ra khi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LayoutCharts();
        }

        // ══════════════════════════════════════════════════════════════════
        //  1. DRAW DOANH THU (Column Chart)
        // ══════════════════════════════════════════════════════════════════
        private void DrawDoanhThu(int nam, int thang)
        {
            string[] labels;
            double[] rawValues;

            if (thang == 0) // Cả năm - Group by Month
            {
                DataTable dt = _bll.GetDoanhThuTheoNam(nam);
                labels = new string[12];
                rawValues = new double[12];
                for (int i = 0; i < 12; i++)
                {
                    labels[i] = "T" + (i + 1);
                    rawValues[i] = 0;
                }
                foreach (DataRow r in dt.Rows)
                {
                    int m = Convert.ToInt32(r["Thang"]) - 1;
                    if (m >= 0 && m < 12)
                        rawValues[m] = Convert.ToDouble(r["DT"]);
                }
            }
            else // Theo tháng - Group by Day
            {
                int days = DateTime.DaysInMonth(nam, thang);
                DataTable dt = _bll.GetDoanhThuTheoThang(nam, thang);
                labels = new string[days];
                rawValues = new double[days];
                for (int i = 0; i < days; i++)
                {
                    labels[i] = (i + 1).ToString();
                    rawValues[i] = 0;
                }
                foreach (DataRow r in dt.Rows)
                {
                    int d = Convert.ToInt32(r["Ngay"]) - 1;
                    if (d >= 0 && d < days)
                        rawValues[d] = Convert.ToDouble(r["DT"]);
                }
            }

            // Convert to Millions for readable chart values
            ChartValues<double> chartValues = new ChartValues<double>();
            foreach (double val in rawValues)
            {
                chartValues.Add(val / 1_000_000.0); // convert to Millions
            }

            lvcDoanhThu.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh thu",
                    Values = chartValues,
                    Fill = new System.Windows.Media.SolidColorBrush(C_Indigo),
                    DataLabels = false,
                    MaxColumnWidth = 35
                }
            };

            lvcDoanhThu.AxisX.Clear();
            lvcDoanhThu.AxisX.Add(new Axis
            {
                Title = thang == 0 ? "Tháng trong năm" : "Ngày trong tháng",
                Labels = labels,
                Separator = new Separator { Step = 1, IsEnabled = false }
            });

            lvcDoanhThu.AxisY.Clear();
            lvcDoanhThu.AxisY.Add(new Axis
            {
                Title = "Triệu VNĐ",
                LabelFormatter = value => value.ToString("N0")
            });

            // 4. Draw cumulative chart directly based on this data
            DrawLuyKe(labels, rawValues);
        }

        // ══════════════════════════════════════════════════════════════════
        //  2. DRAW HOP DONG (Donut Chart)
        // ══════════════════════════════════════════════════════════════════
        private void DrawHopDong(int nam, int thang)
        {
            DataTable dt = _bll.GetHopDongTheoTrangThai(nam, thang);

            SeriesCollection series = new SeriesCollection();
            int idx = 0;
            double total = 0;

            foreach (DataRow r in dt.Rows)
            {
                double val = Convert.ToDouble(r["SoLuong"]);
                total += val;
            }

            foreach (DataRow r in dt.Rows)
            {
                string status = r["TT"].ToString();
                double val = Convert.ToDouble(r["SoLuong"]);
                System.Windows.Media.Color color = BeautifulColors[idx % BeautifulColors.Length];

                series.Add(new PieSeries
                {
                    Title = status,
                    Values = new ChartValues<double> { val },
                    Fill = new System.Windows.Media.SolidColorBrush(color),
                    DataLabels = true,
                    LabelPoint = chartPoint => string.Format("{0} ({1:P0})", chartPoint.Y, chartPoint.Participation)
                });
                idx++;
            }

            lvcHopDong.Series = series;
        }

        // ══════════════════════════════════════════════════════════════════
        //  3. DRAW BAI VIET (Row/Horizontal Bar Chart)
        // ══════════════════════════════════════════════════════════════════
        private void DrawBaiViet(int nam, int thang)
        {
            DataTable dt = _bll.GetBaiVietTheoTrangThai(nam, thang);

            ChartValues<double> values = new ChartValues<double>();
            string[] labels = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labels[i] = dt.Rows[i]["TT"].ToString();
                values.Add(Convert.ToDouble(dt.Rows[i]["SoLuong"]));
            }

            lvcBaiViet.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Số lượng",
                    Values = values,
                    Fill = new System.Windows.Media.SolidColorBrush(C_Amber),
                    DataLabels = true,
                    LabelPoint = chartPoint => chartPoint.X.ToString("0")
                }
            };

            lvcBaiViet.AxisY.Clear();
            lvcBaiViet.AxisY.Add(new Axis
            {
                Title = "Trạng thái bài viết",
                Labels = labels,
                Separator = new Separator { IsEnabled = false }
            });

            lvcBaiViet.AxisX.Clear();
            lvcBaiViet.AxisX.Add(new Axis
            {
                Title = "Số lượng bài",
                LabelFormatter = val => val.ToString("0")
            });
        }

        // ══════════════════════════════════════════════════════════════════
        //  4. DRAW LUY KE (Area Line Chart)
        // ══════════════════════════════════════════════════════════════════
        private void DrawLuyKe(string[] labels, double[] rawRevenueValues)
        {
            double[] luyKeValues = _bll.BuildLuyKe(rawRevenueValues);

            ChartValues<double> chartValues = new ChartValues<double>();
            foreach (double val in luyKeValues)
            {
                chartValues.Add(val / 1_000_000.0); // convert to Millions
            }

            // Create beautiful smooth line with subtle transparent fill
            var areaBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(40, 22, 163, 74));

            lvcLuyKe.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lũy kế doanh thu",
                    Values = chartValues,
                    Stroke = new System.Windows.Media.SolidColorBrush(C_Green),
                    Fill = areaBrush,
                    PointGeometrySize = 8,
                    LineSmoothness = 0.5,
                    DataLabels = false
                }
            };

            lvcLuyKe.AxisX.Clear();
            lvcLuyKe.AxisX.Add(new Axis
            {
                Title = lvcDoanhThu.AxisX[0].Title,
                Labels = labels,
                Separator = new Separator { Step = 1, IsEnabled = false }
            });

            lvcLuyKe.AxisY.Clear();
            lvcLuyKe.AxisY.Add(new Axis
            {
                Title = "Triệu VNĐ (Cộng dồn)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        // ══════════════════════════════════════════════════════════════════
        //  PAINT STUBS (Retained to avoid designer breakages)
        // ══════════════════════════════════════════════════════════════════
        private void pnlChart1_Paint(object sender, PaintEventArgs e) { }
        private void pnlChart2_Paint(object sender, PaintEventArgs e) { }
        private void pnlChart3_Paint(object sender, PaintEventArgs e) { }
        private void pnlChart4_Paint(object sender, PaintEventArgs e) { }
    }
}