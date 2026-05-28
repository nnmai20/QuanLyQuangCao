using QLQC.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLQC.Forms
{
    public partial class FrmKhachHang : Form
    {
        DataTable tblKH;
        private readonly QLQC.BLL.KhachHangBLL _bll = new QLQC.BLL.KhachHangBLL();

        // ══ Palette chung – chỉnh 1 chỗ là thay đổi toàn bộ ══
        static readonly Color C_Primary = Color.FromArgb(4, 120, 87);   // xanh lá đậm
        static readonly Color C_Light = Color.FromArgb(16, 185, 129);   // xanh lá nhạt
        static readonly Color C_Accent = Color.FromArgb(6, 78, 59);    // xanh lá tối
        static readonly Color C_BgPage = Color.FromArgb(245, 247, 250);  // nền trang
        static readonly Color C_BgCard = Color.White;
        static readonly Color C_BgInput = Color.FromArgb(249, 250, 251);
        static readonly Color C_Border = Color.FromArgb(209, 213, 219);
        static readonly Color C_TextDark = Color.FromArgb(17, 24, 39);
        static readonly Color C_TextMid = Color.FromArgb(55, 65, 81);
        static readonly Color C_TextSoft = Color.FromArgb(107, 114, 128);
        static readonly Color C_Warning = Color.FromArgb(217, 119, 6);
        static readonly Color C_Danger = Color.FromArgb(220, 38, 38);
        static readonly Color C_EditMain = Color.FromArgb(180, 83, 9);
        static readonly Color C_EditLight = Color.FromArgb(245, 124, 0);

        public FrmKhachHang()
        {
            InitializeComponent();
            InitCustomStyles();
        }

        private void InitCustomStyles()
        {
            // Custom header stripe and icons
            Panel stripe = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = Color.FromArgb(16, 185, 129) };
            this.pnlHeader.Controls.Add(stripe);

            Label lblIcon = new Label
            {
                Text = "🤝",
                Font = new Font("Segoe UI", 18F),
                Size = new Size(48, 48),
                Location = new Point(20, 14),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(6, 95, 70),
                ForeColor = Color.White
            };
            this.pnlHeader.Controls.Add(lblIcon);

            Label lblBgIcon = new Label
            {
                Text = "👥",
                Font = new Font("Segoe UI", 36F),
                ForeColor = Color.FromArgb(40, 255, 255, 255),
                Size = new Size(80, 68),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            this.pnlHeader.Controls.Add(lblBgIcon);
            this.pnlHeader.Resize += (s, e) =>
                lblBgIcon.Location = new Point(this.pnlHeader.Width - 96, 2);

            // Wire custom placeholders
            WirePlaceholder(this.txtTimKiemTen, "Tìm theo tên...");
            WirePlaceholder(this.txtTimKiemDiaChi, "Tìm theo địa chỉ...");
            WirePlaceholder(this.txtTimKiemLinhVuc, "Tìm theo lĩnh vực...");

            // Set footer date dynamically
            this.lblFooterDate.Text = "📅  " + System.DateTime.Now.ToString("dd/MM/yyyy");
            this.pnlFooter.Resize += (s, e) =>
                lblFooterDate.Location = new Point(this.pnlFooter.Width - lblFooterDate.Width - 20, 9);
            
            // Set Them button auto-resize
            int row1Y = 30;
            this.pnlToolbar.Resize += (s, e) =>
                this.btnThem.Location = new Point(this.pnlToolbar.Width - this.btnThem.Width - 16, row1Y);
            this.Load += (s, e) =>
                this.btnThem.Location = new Point(this.pnlToolbar.Width - this.btnThem.Width - 16, row1Y);
        }

        private static void WirePlaceholder(TextBox tb, string placeholder)
        {
            tb.GotFocus += (s, e) =>
            {
                if (tb.ForeColor == Color.DarkGray) { tb.Text = ""; tb.ForeColor = Color.FromArgb(17, 24, 39); }
            };
            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = placeholder; tb.ForeColor = Color.DarkGray; }
            };
        }

        // ══════════════════════════════════════════════════════════════════
        //  LOAD
        // ══════════════════════════════════════════════════════════════════
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            Functions.Ketnot();
            LoadGrid();

            // Live search – gõ là tìm ngay, không cần nhấn nút hay Enter
            WireLiveSearch(txtTimKiemTen, "Tìm theo tên...");
            WireLiveSearch(txtTimKiemDiaChi, "Tìm theo địa chỉ...");
            WireLiveSearch(txtTimKiemLinhVuc, "Tìm theo lĩnh vực...");

            // Phân quyền
            if (!Session.IsAdmin())
            {
                btnThem.Visible = false;
            }
        }

        // ── Live search helper ─────────────────────────────────────────────
        // Mỗi lần người dùng gõ thêm/xoá ký tự → tìm luôn.
        // Bỏ qua khi TextBox đang hiện placeholder (ForeColor == DarkGray).
        private void WireLiveSearch(TextBox tb, string placeholder)
        {
            tb.TextChanged += (s, e) =>
            {
                if (tb.ForeColor == Color.DarkGray) return;
                RunSearch();
            };
            tb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; RunSearch(); }
            };
        }

        // ══════════════════════════════════════════════════════════════════
        //  LOAD GRID
        // ══════════════════════════════════════════════════════════════════
        private void LoadGrid(
            string tenFilter = "",
            string diaChiFilter = "",
            string linhVucFilter = "")
        {
            tblKH = _bll.GetAll(tenFilter, diaChiFilter, linhVucFilter);
            ApplyDataSource(tblKH);
        }

        private static string Esc(string v) => v?.Replace("'", "''") ?? "";

        // ══════════════════════════════════════════════════════════════════
        //  APPLY DATASOURCE
        // ══════════════════════════════════════════════════════════════════
        private void ApplyDataSource(DataTable dt)
        {
            if (dgridKhachHang.Columns.Contains("ColStt"))
                dgridKhachHang.Columns.Remove("ColStt");
            if (dgridKhachHang.Columns.Contains("ColThaoTac"))
                dgridKhachHang.Columns.Remove("ColThaoTac");

            dgridKhachHang.DataSource = dt;
            if (dgridKhachHang.Columns.Count == 0) return;

            // Cột STT
            var colSTT = new DataGridViewTextBoxColumn
            {
                Name = "ColStt",
                HeaderText = "STT",
                Width = 52,
                ReadOnly = true,
                DisplayIndex = 0,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgridKhachHang.Columns.Add(colSTT);

            // Header + width mapping
            var meta = new Dictionary<string, (string h, int w)>
            {
                { "MaKhachHang",     ("Mã KH",          70)  },
                { "TenKhachHang",    ("Tên khách hàng", 200)  },
                { "DiaChi",          ("Địa chỉ",        170)  },
                { "LinhVucHoatDong", ("Lĩnh vực",       160)  },
                { "Email",           ("Email",           190)  },
                { "SoDienThoai",     ("SĐT",            120)  },
            };
            foreach (var kv in meta)
            {
                if (!dgridKhachHang.Columns.Contains(kv.Key)) continue;
                dgridKhachHang.Columns[kv.Key].HeaderText = kv.Value.h;
                dgridKhachHang.Columns[kv.Key].Width = kv.Value.w;
                dgridKhachHang.Columns[kv.Key].ReadOnly = true;
                dgridKhachHang.Columns[kv.Key].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Cột Thao tác – style dropdown bo viền giống hình 3
            var colTT = new DataGridViewButtonColumn
            {
                Name = "ColThaoTac",
                HeaderText = "Thao tác",
                Text = "⚙  Thao tác  ▼",
                UseColumnTextForButtonValue = true,
                Width = 150,
                FlatStyle = FlatStyle.Flat,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colTT.DefaultCellStyle.BackColor = Color.White;
            colTT.DefaultCellStyle.ForeColor = C_Primary;
            colTT.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            colTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTT.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 253, 245);
            colTT.DefaultCellStyle.SelectionForeColor = C_Primary;
            colTT.HeaderCell.Style.BackColor = C_TextDark;
            colTT.HeaderCell.Style.ForeColor = Color.FromArgb(209, 213, 219);
            colTT.HeaderCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            colTT.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgridKhachHang.Columns.Add(colTT);

            // Vẽ nút Thao tác có viền bo tròn, giống dropdown button
            dgridKhachHang.CellPainting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                if (dgridKhachHang.Columns[ev.ColumnIndex].Name != "ColThaoTac") return;
                ev.PaintBackground(ev.ClipBounds, true);

                bool sel = (ev.State & DataGridViewElementStates.Selected) != 0;
                Color bg = sel ? Color.FromArgb(236, 253, 245) : Color.White;

                var btnRect = new Rectangle(
                    ev.CellBounds.X + 10,
                    ev.CellBounds.Y + 8,
                    ev.CellBounds.Width - 20,
                    ev.CellBounds.Height - 16);

                ev.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var gp = RoundedRect(btnRect, 6))
                {
                    using (var brush = new SolidBrush(bg))
                        ev.Graphics.FillPath(brush, gp);
                    using (var pen = new Pen(C_Light, 1.3f))
                        ev.Graphics.DrawPath(pen, gp);
                }
                TextRenderer.DrawText(ev.Graphics, "⚙  Thao tác  ▼",
                    new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    btnRect, C_Primary,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

                ev.Handled = true;
            };

            dgridKhachHang.AllowUserToAddRows = false;
        }

        // STT
        private void dgridKhachHang_CellFormatting(
            object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgridKhachHang.Columns[e.ColumnIndex].Name == "ColStt")
                e.Value = e.RowIndex + 1;
        }

        private void dgridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e) { }

        // ── Click nút Thao tác → context menu 3 mục ──────────────────────
        // FIX: lấy DataRow từ tblKH theo e.RowIndex (đã ổn định với cả cột STT thêm vào)
        private void dgridKhachHang_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (tblKH == null || e.RowIndex >= tblKH.Rows.Count) return;
            if (dgridKhachHang.Columns[e.ColumnIndex].Name != "ColThaoTac") return;

            DataRow dr = tblKH.Rows[e.RowIndex];
            ShowThaoTacMenu(dr, e.RowIndex, e.ColumnIndex);
        }

        private void ShowThaoTacMenu(DataRow dr, int rowIdx, int colIdx)
        {
            var menu = new ContextMenuStrip
            {
                Font = new Font("Segoe UI", 9.5F),
                BackColor = Color.White,
                RenderMode = ToolStripRenderMode.System
            };

            // ── Xem chi tiết ─────────────────────────────────────────────
            var iChiTiet = new ToolStripMenuItem("🔍   Xem chi tiết")
            {
                ForeColor = C_Primary,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                BackColor = Color.White
            };
            iChiTiet.Click += (s, e) => ShowChiTiet(dr);
            menu.Items.Add(iChiTiet);

            // Chỉ hiển thị Chỉnh sửa và Xóa nếu là Admin, quản lý
            if (Session.IsAdmin())
            {
                // ── Chỉnh sửa ────────────────────────────────────────────────
                var iSua = new ToolStripMenuItem("✏   Chỉnh sửa")
                {
                    ForeColor = C_Warning,
                    BackColor = Color.White
                };
                iSua.Click += (s, e) => ShowFormPopup(dr);

                // ── Xóa ──────────────────────────────────────────────────────
                var iXoa = new ToolStripMenuItem("🗑   Xóa")
                {
                    ForeColor = C_Danger,
                    BackColor = Color.White
                };
                iXoa.Click += (s, e) => ShowXacNhanXoa(
                    dr["MaKhachHang"]?.ToString() ?? "",
                    dr["TenKhachHang"]?.ToString() ?? "");

                menu.Items.Add(new ToolStripSeparator());
                menu.Items.Add(iSua);
                menu.Items.Add(new ToolStripSeparator());
                menu.Items.Add(iXoa);
            }

            var rect = dgridKhachHang.GetCellDisplayRectangle(colIdx, rowIdx, true);
            menu.Show(dgridKhachHang, new Point(rect.X, rect.Bottom));
        }

        // ══════════════════════════════════════════════════════════════════
        //  TÌM KIẾM
        // ══════════════════════════════════════════════════════════════════
        private void RunSearch()
        {
            LoadGrid(
                GetSearchText(txtTimKiemTen, "Tìm theo tên..."),
                GetSearchText(txtTimKiemDiaChi, "Tìm theo địa chỉ..."),
                GetSearchText(txtTimKiemLinhVuc, "Tìm theo lĩnh vực..."));
        }

        private void btnTimKiem_Click(object sender, EventArgs e) => RunSearch();

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            ResetSearchBox(txtTimKiemTen, "Tìm theo tên...");
            ResetSearchBox(txtTimKiemDiaChi, "Tìm theo địa chỉ...");
            ResetSearchBox(txtTimKiemLinhVuc, "Tìm theo lĩnh vực...");
            LoadGrid();
        }

        private static string GetSearchText(TextBox tb, string ph) =>
            tb.ForeColor == Color.DarkGray || tb.Text == ph ? "" : tb.Text.Trim();

        private static void ResetSearchBox(TextBox tb, string ph)
        {
            tb.Text = ph;
            tb.ForeColor = Color.DarkGray;
        }

        private void btnThem_Click(object sender, EventArgs e) => ShowFormPopup(null);

        // ══════════════════════════════════════════════════════════════════
        //  POPUP THÊM / SỬA  –  màu sắc đồng nhất theo C_Primary / C_EditMain
        // ══════════════════════════════════════════════════════════════════
        private void ShowFormPopup(DataRow drEdit)
        {
            bool isSua = drEdit != null;

            // Palette theo mode
            Color clrMain = isSua ? C_EditMain : C_Primary;
            Color clrLight = isSua ? C_EditLight : C_Light;
            Color clrBg = isSua ? Color.FromArgb(255, 251, 235) : Color.FromArgb(240, 253, 244);
            Color clrBorder = isSua ? Color.FromArgb(253, 186, 116) : Color.FromArgb(110, 231, 183);
            Color clrLabel = isSua ? Color.FromArgb(120, 53, 15) : C_Accent;
            Color clrFocus = isSua ? Color.FromArgb(254, 243, 199) : Color.FromArgb(236, 253, 245);

            // ── Form container ────────────────────────────────────────────
            const int POP_W = 620, POP_H = 600;
            var pop = new Form
            {
                Width = POP_W,
                Height = POP_H,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F)
            };
            pop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, POP_W, POP_H, 16, 16));

            bool closingByBtn = false;
            pop.FormClosing += (s, ev) =>
            {
                if (!closingByBtn && ev.CloseReason == CloseReason.UserClosing)
                {
                    if (AskClose() == DialogResult.No) ev.Cancel = true;
                }
            };

            // ── Header ────────────────────────────────────────────────────
            var pHead = new Panel { Location = new Point(0, 0), Size = new Size(POP_W, 88) };
            pHead.Paint += (s, ev) =>
            {
                using (var gb = new LinearGradientBrush(
                    new Point(0, 0), new Point(pHead.Width, 0), clrMain, clrLight))
                {
                    ev.Graphics.FillRectangle(gb, pHead.ClientRectangle);
                }
                // subtle pattern overlay
                using (var patPen = new Pen(Color.FromArgb(18, 255, 255, 255), 1))
                {
                    for (int x2 = -pHead.Height; x2 < pHead.Width; x2 += 20)
                        ev.Graphics.DrawLine(patPen, x2, 0, x2 + pHead.Height, pHead.Height);
                }
            };

            // Icon hình tròn
            var lblIco = new Label
            {
                Text = isSua ? "✏" : "➕",
                Font = new Font("Segoe UI", 18F),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                Size = new Size(48, 48),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(40, 0, 0, 0)
            };
            lblIco.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 48, 48, 24, 24));
            pHead.Controls.Add(lblIco);

            pHead.Controls.Add(new Label
            {
                Text = isSua ? "CHỈNH SỬA KHÁCH HÀNG" : "THÊM KHÁCH HÀNG MỚI",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                Location = new Point(80, 20),
                AutoSize = true
            });
            pHead.Controls.Add(new Label
            {
                Text = "Các trường có dấu (*) là bắt buộc",
                ForeColor = Color.FromArgb(210, 255, 255, 255),
                Font = new Font("Segoe UI", 8.5F),
                Location = new Point(82, 52),
                AutoSize = true
            });

            // Nút X
            var btnX = new Button
            {
                Text = "✕",
                Size = new Size(32, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Location = new Point(POP_W - 44, 12)
            };
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 0, 0, 0);
            btnX.Click += (s, ev) =>
            {
                if (AskClose() == DialogResult.Yes) { closingByBtn = true; pop.Close(); }
            };
            pHead.Controls.Add(btnX);

            // ── Body ──────────────────────────────────────────────────────
            // KHÔNG dùng Padding vì nó không offset Location của child controls.
            // Thay vào đó dùng offset thủ công: mX=32 (lề trái/phải), mY=20 (lề trên).
            // pBody: tọa độ tuyệt đối, nằm giữa header(88px) và footer(72px)
            const int HEAD_H = 88;
            const int FOOT_H = 72;
            var pBody = new Panel
            {
                Location = new Point(0, HEAD_H),
                Size = new Size(POP_W, POP_H - HEAD_H - FOOT_H),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            const int mX = 32;   // lề trái
            const int mY = 20;   // lề trên
            int fullW = POP_W - mX * 2;          // ~556px
            int halfW = (fullW - 20) / 2;        // ~268px
            int curY = mY;                      // bắt đầu từ dòng đầu trong body

            // Helper: nhãn + dấu *
            void AddLbl(string txt, bool req, int x, int y2)
            {
                var lbl = new Label
                {
                    Text = txt,
                    Font = new Font("Segoe UI", 8.8F, FontStyle.Bold),
                    ForeColor = C_TextMid,
                    Location = new Point(mX + x, y2),
                    AutoSize = true
                };
                pBody.Controls.Add(lbl);
                if (req)
                    pBody.Controls.Add(new Label
                    {
                        Text = " *",
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                        ForeColor = C_Danger,
                        Location = new Point(mX + x + TextRenderer.MeasureText(txt, lbl.Font).Width, y2 - 2),
                        AutoSize = true
                    });
            }

            // Helper: textbox
            TextBox AddTb(int x, int y2, int w, string ph = "")
            {
                var tb = new TextBox
                {
                    Location = new Point(mX + x, y2),
                    Size = new Size(w, 34),
                    Font = new Font("Segoe UI", 9.5F),
                    BackColor = C_BgInput,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = C_TextDark
                };
                tb.GotFocus += (s, e) => { tb.BackColor = clrFocus; };
                tb.LostFocus += (s, e) => { tb.BackColor = C_BgInput; };
                if (!string.IsNullOrEmpty(ph))
                {
                    tb.ForeColor = Color.DarkGray;
                    tb.Text = ph;
                    tb.GotFocus += (s, e) =>
                    {
                        if (tb.ForeColor == Color.DarkGray)
                        { tb.Text = ""; tb.ForeColor = C_TextDark; }
                    };
                    tb.LostFocus += (s, e) =>
                    {
                        if (string.IsNullOrWhiteSpace(tb.Text))
                        { tb.Text = ph; tb.ForeColor = Color.DarkGray; }
                    };
                }
                pBody.Controls.Add(tb);
                return tb;
            }

            // label(22) + textbox(34) + gap(14) = 70px mỗi hàng
            const int LH = 22;
            const int TBH = 34;
            const int GAP = 14;

            // 1. Tên khách hàng
            AddLbl("Tên khách hàng", true, 0, curY);
            curY += LH;
            var fTen = AddTb(0, curY, fullW, "Nhập tên khách hàng...");
            curY += TBH + GAP;

            // 2. Lĩnh vực + SĐT cùng hàng
            AddLbl("Lĩnh vực hoạt động", true, 0, curY);
            AddLbl("Số điện thoại", true, halfW + 20, curY);
            curY += LH;
            var fLinhVuc = AddTb(0, curY, halfW, "Ví dụ: Công nghệ...");
            var fSDT = AddTb(halfW + 20, curY, halfW, "0xxxxxxxxx");
            fSDT.MaxLength = 10;
            fSDT.KeyPress += (s, e2) =>
            {
                if (!char.IsDigit(e2.KeyChar) && e2.KeyChar != (char)Keys.Back)
                    e2.Handled = true;
            };
            curY += TBH + GAP;

            // 3. Email
            AddLbl("Email", true, 0, curY);
            curY += LH;
            var fEmail = AddTb(0, curY, fullW, "example@domain.com");
            curY += TBH + GAP;

            // 4. Địa chỉ
            AddLbl("Địa chỉ", false, 0, curY);
            curY += LH;
            var fDiaChi = AddTb(0, curY, fullW, "Số nhà, đường, quận/huyện...");

            // Điền dữ liệu khi SỬA
            if (isSua)
            {
                SetTb(fTen, drEdit["TenKhachHang"]);
                SetTb(fLinhVuc, drEdit["LinhVucHoatDong"]);
                SetTb(fSDT, drEdit["SoDienThoai"]);
                SetTb(fEmail, drEdit["Email"]);
                SetTb(fDiaChi, drEdit["DiaChi"]);
            }

            // ── Footer ────────────────────────────────────────────────────
            var pFoot = new Panel
            {
                Location = new Point(0, POP_H - FOOT_H),
                Size = new Size(POP_W, FOOT_H),
                BackColor = Color.FromArgb(249, 250, 251),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            pFoot.Controls.Add(new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                BackColor = C_Border
            });

            // Nút Lưu
            var btnLuu = new Button
            {
                Text = isSua ? "💾  Cập nhật" : "💾  Lưu lại",
                Size = new Size(150, 40),
                Location = new Point(32, 16),
                BackColor = clrMain,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatAppearance.MouseOverBackColor = clrLight;

            // Nút Huỷ
            var btnHuy = new Button
            {
                Text = "✕  Hủy bỏ",
                Size = new Size(110, 40),
                Location = new Point(192, 16),
                BackColor = Color.White,
                ForeColor = C_TextMid,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F),
                Cursor = Cursors.Hand
            };
            btnHuy.FlatAppearance.BorderColor = C_Border;
            btnHuy.FlatAppearance.BorderSize = 1;

            pFoot.Controls.Add(btnLuu);
            pFoot.Controls.Add(btnHuy);

            btnHuy.Click += (s, ev) =>
            {
                if (AskClose() == DialogResult.Yes) { closingByBtn = true; pop.Close(); }
            };

            btnLuu.Click += (s, ev) =>
            {
                string ten = ReadTb(fTen, "Nhập tên khách hàng...");
                string linhVuc = ReadTb(fLinhVuc, "Ví dụ: Công nghệ...");
                string sdt = ReadTb(fSDT, "0xxxxxxxxx");
                string email = ReadTb(fEmail, "example@domain.com");
                string diaChi = ReadTb(fDiaChi, "Số nhà, đường, quận/huyện...");

                // Validate
                if (string.IsNullOrWhiteSpace(ten))
                { ShowWarn("Vui lòng nhập Tên khách hàng!"); fTen.Focus(); return; }
                if (string.IsNullOrWhiteSpace(linhVuc))
                { ShowWarn("Vui lòng nhập Lĩnh vực hoạt động!"); fLinhVuc.Focus(); return; }
                if (string.IsNullOrWhiteSpace(sdt))
                { ShowWarn("Vui lòng nhập Số điện thoại!"); fSDT.Focus(); return; }
                if (!Regex.IsMatch(sdt, @"^\d{10}$"))
                { ShowWarn("Số điện thoại phải gồm đúng 10 chữ số!"); fSDT.Focus(); return; }
                if (string.IsNullOrWhiteSpace(email))
                { ShowWarn("Vui lòng nhập Email!"); fEmail.Focus(); return; }
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                { ShowWarn("Email không đúng định dạng!"); fEmail.Focus(); return; }

                try
                {
                    if (isSua)
                    {
                        int ma = Convert.ToInt32(drEdit["MaKhachHang"]);
                        _bll.CapNhat(ma, ten, diaChi, linhVuc, email, sdt);
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _bll.Them(ten, diaChi, linhVuc, email, sdt);
                        MessageBox.Show("Thêm khách hàng thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadGrid();
                    closingByBtn = true;
                    pop.DialogResult = DialogResult.OK;
                    pop.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Viền popup
            pop.Paint += (s, ev) =>
            {
                using (var pen = new Pen(clrBorder, 1.5f))
                    ev.Graphics.DrawRectangle(pen, 0, 0, pop.Width - 1, pop.Height - 1);
            };

            pop.Controls.Add(pBody);
            pop.Controls.Add(pFoot);
            pop.Controls.Add(pHead);
            // Đảm bảo footer luôn nằm đúng vị trí sau khi form render
            pop.Shown += (s, ev) =>
            {
                pHead.Location = new Point(0, 0);
                pHead.Size = new Size(POP_W, HEAD_H);
                pBody.Location = new Point(0, HEAD_H);
                pBody.Size = new Size(POP_W, POP_H - HEAD_H - FOOT_H);
                pFoot.Location = new Point(0, POP_H - FOOT_H);
                pFoot.Size = new Size(POP_W, FOOT_H);
            };
            pop.ShowDialog(this);
        }

        // ══════════════════════════════════════════════════════════════════
        //  XÁC NHẬN XÓA
        // ══════════════════════════════════════════════════════════════════
        private void ShowXacNhanXoa(string maKH, string tenKH)
        {
            var pop = new Form
            {
                Width = 440,
                Height = 270,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F)
            };
            pop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 440, 270, 16, 16));

            // Top band
            var pTop = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(440, 80),
                BackColor = Color.FromArgb(254, 242, 242)
            };
            pTop.Controls.Add(new Label
            {
                Text = "🗑️",
                Font = new Font("Segoe UI", 30F),
                Size = new Size(64, 64),
                Location = new Point(188, 8),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            });
            pop.Controls.Add(pTop);

            pop.Controls.Add(BuildLabel("Xác nhận xóa",
                new Font("Segoe UI", 13F, FontStyle.Bold),
                C_TextDark, new Rectangle(20, 92, 400, 28),
                ContentAlignment.MiddleCenter));

            pop.Controls.Add(BuildLabel(
                $"Bạn có chắc muốn xóa khách hàng\n\"{tenKH}\" không?",
                new Font("Segoe UI", 9.5F), C_TextMid,
                new Rectangle(20, 124, 400, 46), ContentAlignment.MiddleCenter));

            pop.Controls.Add(BuildLabel("⚠  Hành động này không thể hoàn tác!",
                new Font("Segoe UI", 8.5F, FontStyle.Italic),
                Color.FromArgb(185, 28, 28), new Rectangle(20, 174, 400, 20),
                ContentAlignment.MiddleCenter));

            var bYes = new Button
            {
                Text = "🗑️  Xóa",
                Size = new Size(120, 38),
                Location = new Point(128, 216),
                BackColor = C_Danger,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            bYes.FlatAppearance.BorderSize = 0;

            var bNo = new Button
            {
                Text = "Hủy",
                Size = new Size(100, 38),
                Location = new Point(264, 216),
                BackColor = Color.White,
                ForeColor = C_TextMid,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            bNo.FlatAppearance.BorderColor = C_Border;
            bNo.FlatAppearance.BorderSize = 1;

            bNo.Click += (s, e) => { pop.DialogResult = DialogResult.No; pop.Close(); };
            bYes.Click += (s, e) =>
            {
                _bll.Xoa(Convert.ToInt32(maKH));
                LoadGrid();
                pop.DialogResult = DialogResult.Yes;
                pop.Close();
            };

            pop.Paint += (s, ev) =>
            {
                using (var pen = new Pen(Color.FromArgb(254, 202, 202), 1.5f))
                    ev.Graphics.DrawRectangle(pen, 0, 0, pop.Width - 1, pop.Height - 1);
            };

            pop.Controls.Add(bYes);
            pop.Controls.Add(bNo);
            pop.ShowDialog(this);
        }

        // ══════════════════════════════════════════════════════════════════
        //  XEM CHI TIẾT
        // ══════════════════════════════════════════════════════════════════
        private void ShowChiTiet(DataRow dr)
        {
            string ma = dr["MaKhachHang"]?.ToString() ?? "";
            string ten = dr["TenKhachHang"]?.ToString() ?? "";
            string diaChi = dr["DiaChi"]?.ToString() ?? "";
            string linhVuc = dr["LinhVucHoatDong"]?.ToString() ?? "";
            string email = dr["Email"]?.ToString() ?? "";
            string sdt = dr["SoDienThoai"]?.ToString() ?? "";

            DataTable dtHD = new DataTable();
            try
            {
                dtHD = _bll.GetHopDongCuaKhachHang(Convert.ToInt32(ma));
            }
            catch { }

            var popup = new Form
            {
                Text = "Chi tiết – " + ten,
                Width = 800,
                Height = 700,
                MinimumSize = new Size(700, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.Sizable,
                BackColor = C_BgPage,
                Font = new Font("Segoe UI", 9.5F)
            };

            // Header
            var pTop = new Panel { Dock = DockStyle.Top, Height = 72, BackColor = C_Primary };
            pTop.Paint += (s, ev) =>
            {
                using (var gb = new LinearGradientBrush(
                    new Point(0, 0), new Point(pTop.Width, 0), C_Primary, C_Accent))
                {
                    ev.Graphics.FillRectangle(gb, pTop.ClientRectangle);
                }
            };
            pTop.Controls.Add(new Label
            {
                Text = "🤝  " + ten,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(16, 10)
            });
            pTop.Controls.Add(new Label
            {
                Text = "Mã KH: " + ma + "   •   " + linhVuc,
                ForeColor = Color.FromArgb(110, 231, 183),
                Font = new Font("Segoe UI", 9F),
                AutoSize = true,
                Location = new Point(18, 46)
            });

            // Footer
            var pFoot = new Panel { Dock = DockStyle.Bottom, Height = 56, BackColor = Color.White };
            pFoot.Controls.Add(new Panel { Dock = DockStyle.Top, Height = 1, BackColor = C_Border });
            var bClose = new Button
            {
                Text = "✖  Đóng",
                Size = new Size(130, 38),
                BackColor = C_TextDark,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            bClose.FlatAppearance.BorderSize = 0;
            bClose.Click += (s, ev) => popup.Close();
            pFoot.Controls.Add(bClose);
            popup.Shown += (s, ev) => bClose.Location = new Point((pFoot.Width - 130) / 2, 9);
            pFoot.Resize += (s, ev) => bClose.Location = new Point((pFoot.Width - 130) / 2, 9);

            // Scroll area
            var pScroll = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(16, 14, 16, 8),
                BackColor = C_BgPage
            };
            var flow = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Width = 730,
                BackColor = Color.Transparent
            };
            pScroll.Controls.Add(flow);

            // Section header
            Control MkSH(string ico, string title2, Color ac)
            {
                var b = new Panel { Size = new Size(730, 38), BackColor = Color.White, Margin = new Padding(0, 0, 0, 2) };
                b.Controls.Add(new Panel { Size = new Size(4, 38), Location = new Point(0, 0), BackColor = ac });
                b.Controls.Add(new Label
                {
                    Text = ico + "  " + title2,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = ac,
                    Location = new Point(14, 9),
                    AutoSize = true
                });
                return b;
            }

            // Row
            Control MkRow(string lb, string val2, Color? vc = null)
            {
                var row = new Panel { Size = new Size(730, 32), BackColor = Color.White, Margin = new Padding(0, 0, 0, 1) };
                row.Controls.Add(new Label
                {
                    Text = lb,
                    Location = new Point(16, 7),
                    Size = new Size(160, 20),
                    ForeColor = C_TextSoft,
                    Font = new Font("Segoe UI", 9F)
                });
                row.Controls.Add(new Label
                {
                    Text = string.IsNullOrWhiteSpace(val2) ? "—" : val2,
                    Location = new Point(184, 7),
                    Size = new Size(526, 20),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    ForeColor = vc ?? C_TextDark
                });
                row.Controls.Add(new Panel
                {
                    Location = new Point(0, 31),
                    Size = new Size(730, 1),
                    BackColor = Color.FromArgb(243, 244, 246)
                });
                return row;
            }

            Control Sp(int h = 10) => new Panel { Size = new Size(730, h), BackColor = Color.Transparent };

            flow.Controls.Add(MkSH("📋", "THÔNG TIN KHÁCH HÀNG", C_Primary));
            flow.Controls.Add(MkRow("Mã khách hàng:", ma));
            flow.Controls.Add(MkRow("Tên khách hàng:", ten));
            flow.Controls.Add(MkRow("Lĩnh vực HĐ:", linhVuc));
            flow.Controls.Add(MkRow("Số điện thoại:", sdt));
            flow.Controls.Add(MkRow("Email:", email));
            flow.Controls.Add(MkRow("Địa chỉ:", diaChi));
            flow.Controls.Add(Sp(14));

            flow.Controls.Add(MkSH("📊", "TỔNG QUAN HỢP ĐỒNG", Color.FromArgb(37, 99, 235)));
            flow.Controls.Add(MkRow("Số hợp đồng:",
                dtHD.Rows.Count == 0 ? "Chưa có hợp đồng nào" : dtHD.Rows.Count + " hợp đồng",
                dtHD.Rows.Count == 0 ? C_TextSoft : (Color?)null));
            flow.Controls.Add(Sp(14));

            flow.Controls.Add(MkSH("📄", "DANH SÁCH HỢP ĐỒNG", Color.FromArgb(124, 58, 237)));

            foreach (DataRow r in dtHD.Rows)
            {
                string tt = r["TrangThaiHopDong"]?.ToString() ?? "";
                Color ac2 = tt.ToLower().Contains("thúc") ? C_TextSoft
                           : tt.ToLower().Contains("đăng") ? C_Primary
                           : C_Warning;

                var card = new Panel { Size = new Size(730, 106), BackColor = Color.White, Margin = new Padding(0, 0, 0, 4) };
                card.Controls.Add(new Panel { Location = new Point(0, 0), Size = new Size(4, 106), BackColor = ac2 });
                card.Controls.Add(new Label { Text = "Hợp đồng #" + r["MaHopDong"], Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = C_TextDark, Location = new Point(14, 10), AutoSize = true });
                card.Controls.Add(new Label { Text = $"📅  Ký: {r["NgayKy"]}   BĐ: {r["NgayBatDau"]}   KT: {r["NgayKetThuc"]}", Font = new Font("Segoe UI", 8.5F), ForeColor = C_TextMid, Location = new Point(14, 32), AutoSize = true });
                card.Controls.Add(new Label { Text = $"💰  Tổng: {r["TongGiaTri"]} VNĐ   Đã TT: {r["DaThanhToan"]}   Còn: {r["ConLai"]} VNĐ", Font = new Font("Segoe UI", 8.5F), ForeColor = C_Primary, Location = new Point(14, 54), AutoSize = true });
                card.Controls.Add(new Label { Text = $"👤  NV: {(string.IsNullOrWhiteSpace(r["NhanVien"]?.ToString()) ? "Chưa gán" : r["NhanVien"].ToString())}", Font = new Font("Segoe UI", 8.5F), ForeColor = C_TextMid, Location = new Point(14, 76), AutoSize = true });
                flow.Controls.Add(card);
            }

            if (dtHD.Rows.Count == 0)
            {
                var nd = new Panel { Size = new Size(730, 60), BackColor = Color.White };
                nd.Controls.Add(new Label
                {
                    Text = "😶  Khách hàng này chưa có hợp đồng nào.",
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                    ForeColor = C_TextSoft,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                });
                flow.Controls.Add(nd);
            }

            popup.Controls.Add(pTop);
            popup.Controls.Add(pFoot);
            popup.Controls.Add(pScroll);
            popup.ShowDialog(this);
        }

        // ══════════════════════════════════════════════════════════════════
        //  HELPERS
        // ══════════════════════════════════════════════════════════════════
        // Đọc giá trị TextBox, bỏ qua nếu đang hiện placeholder
        private static string ReadTb(TextBox tb, string ph) =>
            tb.ForeColor == Color.DarkGray || tb.Text == ph ? "" : tb.Text.Trim();

        // Điền giá trị vào TextBox (bỏ placeholder)
        private static void SetTb(TextBox tb, object val)
        {
            tb.Text = val?.ToString() ?? "";
            tb.ForeColor = Color.FromArgb(17, 24, 39);
        }

        private static DialogResult AskClose() =>
            MessageBox.Show("Bạn có muốn đóng mà không lưu không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private static void ShowWarn(string msg) =>
            MessageBox.Show(msg, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private static Label BuildLabel(string text, Font font, Color fore,
            Rectangle bounds, ContentAlignment align) =>
            new Label
            {
                Text = text,
                Font = font,
                ForeColor = fore,
                Location = new Point(bounds.X, bounds.Y),
                Size = new Size(bounds.Width, bounds.Height),
                TextAlign = align,
                AutoSize = false
            };

        // Tạo GraphicsPath hình chữ nhật bo góc (dùng cho vẽ nút Thao tác)
        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }

        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int l, int t, int r, int b, int rw, int rh);

        // Stubs
        private void btnSua_Click(object sender, EventArgs e) { }
        private void btnXoa_Click(object sender, EventArgs e) { }
        private void btnLuu_Click(object sender, EventArgs e) { }
        private void btnBoqua_Click(object sender, EventArgs e) { }
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
        private void SetInputEnabled(bool enabled) { }
        private void ResetValues() { }
        private void SetBtnAfterSave() { }
        private void FillFormFromRow(DataGridViewRow row) { }
    }
}