using QLQC.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLQC.Forms
{
    public partial class FrmDonViPhatHanh : Form
    {
        DataTable tblDV;
        private readonly QLQC.BLL.DonViPhatHanhBLL _bll = new QLQC.BLL.DonViPhatHanhBLL();

        // ══ Palette ══════════════════════════════════════════════════════
        static readonly Color C_Primary = Color.FromArgb(13, 71, 161);    // xanh dương đậm
        static readonly Color C_Light = Color.FromArgb(59, 130, 246);   // xanh dương nhạt
        static readonly Color C_Accent = Color.FromArgb(8, 50, 130);     // xanh dương tối
        static readonly Color C_BgPage = Color.FromArgb(245, 247, 250);
        static readonly Color C_BgInput = Color.FromArgb(249, 250, 251);
        static readonly Color C_Border = Color.FromArgb(209, 213, 219);
        static readonly Color C_TextDark = Color.FromArgb(17, 24, 39);
        static readonly Color C_TextMid = Color.FromArgb(55, 65, 81);
        static readonly Color C_TextSoft = Color.FromArgb(107, 114, 128);
        static readonly Color C_Warning = Color.FromArgb(217, 119, 6);
        static readonly Color C_Danger = Color.FromArgb(220, 38, 38);
        static readonly Color C_EditMain = Color.FromArgb(180, 83, 9);
        static readonly Color C_EditLight = Color.FromArgb(245, 124, 0);

        public FrmDonViPhatHanh()
        {
            InitializeComponent();
            this.Load += (s, e) => UpdateHeaderLayout();
            this.Resize += (s, e) => UpdateHeaderLayout();
        }

        private void UpdateHeaderLayout()
        {
            int maxRight = this.ClientSize.Width - 150; // reserve space for decorative icon
            if (lblTitle.Right > maxRight)
                lblTitle.Location = new Point(Math.Max(20, maxRight - lblTitle.Width), lblTitle.Location.Y);
            if (lblSubtitle.Right > maxRight)
                lblSubtitle.Location = new Point(Math.Max(20, maxRight - lblSubtitle.Width), lblSubtitle.Location.Y);
        }

        private static void WirePlaceholder(TextBox tb, string placeholder)
        {
            tb.GotFocus += (s, e) => {
                if (tb.ForeColor == Color.DarkGray) { tb.Text = ""; tb.ForeColor = Color.FromArgb(17, 24, 39); }
            };
            tb.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = placeholder; tb.ForeColor = Color.DarkGray; }
            };
        }

        // ══════════════════════════════════════════════════════════════════
        //  LOAD
        // ══════════════════════════════════════════════════════════════════
        private void FrmDonViPhatHanh_Load(object sender, EventArgs e)
        {
            Functions.Ketnot();
            LoadGrid();

            // Live search
            WireLiveSearch(txtTimKiemTen, "Tìm theo tên...");

            // Phân quyền
            // Ensure toolbar buttons respect admin visibility and have modern look
            btnThem.Visible = Session.IsAdmin();
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 71, 161);

            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 71, 161);

            // Ensure default filter status is "-- Tất cả --"
            cboTimKiemTT.SelectedIndex = 0;
            // Apply border style to Xóa lọc button for visual polish
            btnXoaLoc.FlatAppearance.BorderSize = 1;
            btnXoaLoc.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnXoaLoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 250, 252);
            btnXoaLoc.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 240, 245);
        }

        private void WireLiveSearch(TextBox tb, string placeholder)
        {
            tb.TextChanged += (s, ev) => {
                if (tb.ForeColor == Color.DarkGray) return;
                RunSearch();
            };
            tb.KeyDown += (s, ev) => {
                if (ev.KeyCode == Keys.Enter) { ev.SuppressKeyPress = true; RunSearch(); }
            };
        }

        // ══════════════════════════════════════════════════════════════════
        //  LOAD GRID
        // ══════════════════════════════════════════════════════════════════
        private void LoadGrid(string tenFilter = "", string ttFilter = "")
        {
            tblDV = _bll.GetAll(tenFilter, ttFilter);
            ApplyDataSource(tblDV);
        }

        private static string Esc(string v) => v?.Replace("'", "''") ?? "";

        // ══════════════════════════════════════════════════════════════════
        //  APPLY DATASOURCE
        // ══════════════════════════════════════════════════════════════════
        private void ApplyDataSource(DataTable dt)
        {
            if (dgridDonVi.Columns.Contains("ColStt")) dgridDonVi.Columns.Remove("ColStt");
            if (dgridDonVi.Columns.Contains("ColThaoTac")) dgridDonVi.Columns.Remove("ColThaoTac");

            dgridDonVi.DataSource = dt;
            if (dgridDonVi.Columns.Count == 0) return;

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
            dgridDonVi.Columns.Add(colSTT);

            // Header + width mapping
            var meta = new Dictionary<string, (string h, int w)>
            {
                { "MaDonVi",      ("Mã ĐV",        65) },
                { "TenDonVi",     ("Tên đơn vị",  200) },
                { "DiaChi",       ("Địa chỉ",     165) },
                { "Email",        ("Email",        160) },
                { "SoDienThoai",  ("SĐT",         110) },
                { "NguoiLienHe",  ("Người LH",    125) },
                { "TrangThai",    ("Trạng thái",  115) },
            };
            foreach (var kv in meta)
            {
                if (!dgridDonVi.Columns.Contains(kv.Key)) continue;
                dgridDonVi.Columns[kv.Key].HeaderText = kv.Value.h;
                dgridDonVi.Columns[kv.Key].Width = kv.Value.w;
                dgridDonVi.Columns[kv.Key].ReadOnly = true;
                dgridDonVi.Columns[kv.Key].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Cột Thao tác – button column
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
            colTT.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            colTT.DefaultCellStyle.SelectionForeColor = C_Primary;
            colTT.HeaderCell.Style.BackColor = C_TextDark;
            colTT.HeaderCell.Style.ForeColor = Color.FromArgb(209, 213, 219);
            colTT.HeaderCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            colTT.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgridDonVi.Columns.Add(colTT);

            // Refined button rendering for "Thao tác" column – more padding, rounded corners, clearer text
            dgridDonVi.CellPainting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                if (dgridDonVi.Columns[ev.ColumnIndex].Name != "ColThaoTac") return;

                // Paint the default background first
                ev.PaintBackground(ev.ClipBounds, true);

                // Determine selected state for hover effect
                bool sel = (ev.State & DataGridViewElementStates.Selected) != 0;
                Color bg = sel ? Color.FromArgb(219, 234, 254) : Color.White;

                // Use a slightly larger padded rectangle for the button
                var btnRect = new Rectangle(
                    ev.CellBounds.X + 8,
                    ev.CellBounds.Y + 8,
                    ev.CellBounds.Width - 16,
                    ev.CellBounds.Height - 16);

                ev.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
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

            dgridDonVi.AllowUserToAddRows = false;
        }

        // ══════════════════════════════════════════════════════════════════
        //  FORMATTING & EVENTS
        // ══════════════════════════════════════════════════════════════════
        private void dgridDonVi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string col = dgridDonVi.Columns[e.ColumnIndex].Name;

            if (col == "ColStt")
            {
                e.Value = e.RowIndex + 1;
                return;
            }
            if (col == "TrangThai" && e.Value != null)
            {
                e.CellStyle.ForeColor = e.Value.ToString() == "Đang hợp tác"
                    ? Color.FromArgb(4, 120, 87) : Color.FromArgb(185, 28, 28);
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                e.FormattingApplied = true;
            }
        }

        private void dgridDonVi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || tblDV == null || e.RowIndex >= tblDV.Rows.Count) return;
            if (dgridDonVi.Columns[e.ColumnIndex].Name != "ColThaoTac") return;
            ShowThaoTacMenu(tblDV.Rows[e.RowIndex], e.RowIndex, e.ColumnIndex);
        }

        private void ShowThaoTacMenu(DataRow dr, int rowIdx, int colIdx)
        {
            var menu = new ContextMenuStrip
            {
                Font = new Font("Segoe UI", 9.5F),
                BackColor = Color.White,
                RenderMode = ToolStripRenderMode.System
            };

            var iChiTiet = new ToolStripMenuItem("🔍   Xem chi tiết")
            { ForeColor = C_Primary, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), BackColor = Color.White };
            iChiTiet.Click += (s, e) => ShowChiTietPopup(dr);
            menu.Items.Add(iChiTiet);

            if (Session.IsAdmin())
            {
                var iSua = new ToolStripMenuItem("✏   Chỉnh sửa")
                { ForeColor = C_Warning, BackColor = Color.White };
                iSua.Click += (s, e) => ShowFormPopup(dr);

                var iXoa = new ToolStripMenuItem("🗑   Xóa")
                { ForeColor = C_Danger, BackColor = Color.White };
                iXoa.Click += (s, e) => ShowXacNhanXoa(dr);

                menu.Items.Add(new ToolStripSeparator());
                menu.Items.Add(iSua);
                menu.Items.Add(new ToolStripSeparator());
                menu.Items.Add(iXoa);
            }

            var rect = dgridDonVi.GetCellDisplayRectangle(colIdx, rowIdx, true);
            menu.Show(dgridDonVi, new Point(rect.X, rect.Bottom));
        }

        // ══════════════════════════════════════════════════════════════════
        //  TÌM KIẾM
        // ══════════════════════════════════════════════════════════════════
        private void RunSearch()
        {
            string ten = GetSearchText(txtTimKiemTen, "Tìm theo tên...");
            string tt = cboTimKiemTT.SelectedItem?.ToString() ?? "-- Tất cả --";
            LoadGrid(ten, tt);
        }

        private void btnTimKiem_Click(object sender, EventArgs e) => RunSearch();

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            ResetSearchBox(txtTimKiemTen, "Tìm theo tên...");
            cboTimKiemTT.SelectedIndex = 0;
            LoadGrid();
        }

        private void btnThem_Click(object sender, EventArgs e) => ShowFormPopup(null);

        private static string GetSearchText(TextBox tb, string ph) =>
            tb.ForeColor == Color.DarkGray || tb.Text == ph ? "" : tb.Text.Trim();

        private static void ResetSearchBox(TextBox tb, string ph)
        { tb.Text = ph; tb.ForeColor = Color.DarkGray; }

        // Stubs giữ lại để tránh lỗi compile
        private void btnSua_Click(object sender, EventArgs e) { }
        private void btnXoa_Click(object sender, EventArgs e) { }
        private void btnLuu_Click(object sender, EventArgs e) { }
        private void btnBoqua_Click(object sender, EventArgs e) { }
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
        private void txtTimKiem_TextChanged(object sender, EventArgs e) { }

        // ══════════════════════════════════════════════════════════════════
        //  POPUP THÊM / SỬA  –  bo góc, gradient header như FrmKhachHang
        // ══════════════════════════════════════════════════════════════════
        private void ShowFormPopup(DataRow drEdit)
        {
            bool isSua = drEdit != null;

            Color clrMain = isSua ? C_EditMain : C_Primary;
            Color clrLight2 = isSua ? C_EditLight : C_Light;
            Color clrFocus = isSua ? Color.FromArgb(254, 243, 199) : Color.FromArgb(219, 234, 254);

            const int POP_W = 620;
            const int POP_H = 580;
            const int HEAD_H = 88;
            const int FOOT_H = 72;

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
                    if (AskClose() == DialogResult.No) ev.Cancel = true;
            };

            // ── Header ───────────────────────────────────────────────────
            var pHead = new Panel { Location = new Point(0, 0), Size = new Size(POP_W, HEAD_H) };
            pHead.Paint += (s, ev) =>
            {
                using (var gb = new LinearGradientBrush(
                    new Point(0, 0), new Point(pHead.Width, 0), clrMain, clrLight2))
                    ev.Graphics.FillRectangle(gb, pHead.ClientRectangle);
                using (var pp = new Pen(Color.FromArgb(18, 255, 255, 255), 1))
                    for (int x2 = -pHead.Height; x2 < pHead.Width; x2 += 20)
                        ev.Graphics.DrawLine(pp, x2, 0, x2 + pHead.Height, pHead.Height);
            };

            var lblIco = new Label
            {
                Text = isSua ? "✏" : "🏢",
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
                Text = isSua ? "CHỈNH SỬA ĐƠN VỊ PHÁT HÀNH" : "THÊM ĐƠN VỊ PHÁT HÀNH MỚI",
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
            { if (AskClose() == DialogResult.Yes) { closingByBtn = true; pop.Close(); } };
            pHead.Controls.Add(btnX);

            // ── Body ─────────────────────────────────────────────────────
            var pBody = new Panel
            {
                Location = new Point(0, HEAD_H),
                Size = new Size(POP_W, POP_H - HEAD_H - FOOT_H),
                BackColor = Color.White
            };

            const int mX = 32;
            const int mY = 18;
            int fullW = POP_W - mX * 2;
            int halfW = (fullW - 20) / 2;
            int curY = mY;
            const int LH = 22;
            const int TBH = 34;
            const int GAP = 14;

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

            TextBox AddTb(int x, int y2, int w, string ph = "")
            {
                var tb = new TextBox
                {
                    Location = new Point(mX + x, y2),
                    Size = new Size(w, TBH),
                    Font = new Font("Segoe UI", 9.5F),
                    BackColor = C_BgInput,
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = C_TextDark
                };
                tb.GotFocus += (s, e) => tb.BackColor = clrFocus;
                tb.LostFocus += (s, e) => tb.BackColor = C_BgInput;
                if (!string.IsNullOrEmpty(ph))
                {
                    tb.ForeColor = Color.DarkGray; tb.Text = ph;
                    tb.GotFocus += (s, e) => { if (tb.ForeColor == Color.DarkGray) { tb.Text = ""; tb.ForeColor = C_TextDark; } };
                    tb.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = ph; tb.ForeColor = Color.DarkGray; } };
                }
                pBody.Controls.Add(tb);
                return tb;
            }

            // Dòng 1: Tên đơn vị
            AddLbl("Tên đơn vị", true, 0, curY); curY += LH;
            var fTen = AddTb(0, curY, fullW, "Nhập tên đơn vị..."); curY += TBH + GAP;

            // Dòng 2: SĐT + Người liên hệ
            AddLbl("Số điện thoại", true, 0, curY);
            AddLbl("Người liên hệ", true, halfW + 20, curY); curY += LH;
            var fSDT = AddTb(0, curY, halfW, "0xxxxxxxxx");
            var fNguoiLH = AddTb(halfW + 20, curY, halfW, "Nhập tên người liên hệ...");
            fSDT.MaxLength = 10;
            fSDT.KeyPress += (s, ev) => { if (!char.IsDigit(ev.KeyChar) && ev.KeyChar != (char)Keys.Back) ev.Handled = true; };
            curY += TBH + GAP;

            // Dòng 3: Email
            AddLbl("Email", true, 0, curY); curY += LH;
            var fEmail = AddTb(0, curY, fullW, "example@domain.com"); curY += TBH + GAP;

            // Dòng 4: Địa chỉ
            AddLbl("Địa chỉ", true, 0, curY); curY += LH;
            var fDiaChi = AddTb(0, curY, fullW, "Số nhà, đường, quận/huyện..."); curY += TBH + GAP;

            // Dòng 5: Trạng thái
            AddLbl("Trạng thái", false, 0, curY); curY += LH;
            var cbTT = new ComboBox
            {
                Location = new Point(mX, curY),
                Size = new Size(200, TBH),
                Font = new Font("Segoe UI", 9.5F),
                BackColor = C_BgInput,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
            cbTT.Items.AddRange(new object[] { "Đang hợp tác", "Tạm dừng" });
            cbTT.SelectedIndex = 0;
            pBody.Controls.Add(cbTT);

            // Điền dữ liệu khi SỬA
            if (isSua)
            {
                SetTb(fTen, drEdit["TenDonVi"]);
                SetTb(fSDT, drEdit["SoDienThoai"]);
                SetTb(fNguoiLH, drEdit["NguoiLienHe"]);
                SetTb(fEmail, drEdit["Email"]);
                SetTb(fDiaChi, drEdit["DiaChi"]);
                string tt = drEdit["TrangThai"]?.ToString() ?? "Đang hợp tác";
                cbTT.SelectedItem = cbTT.Items.Contains(tt) ? (object)tt : "Đang hợp tác";
            }

            // ── Footer ───────────────────────────────────────────────────
            var pFoot = new Panel
            {
                Location = new Point(0, POP_H - FOOT_H),
                Size = new Size(POP_W, FOOT_H),
                BackColor = Color.FromArgb(249, 250, 251)
            };
            pFoot.Controls.Add(new Panel { Dock = DockStyle.Top, Height = 1, BackColor = C_Border });

            var btnLuuPop = new Button
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
            btnLuuPop.FlatAppearance.BorderSize = 0;
            btnLuuPop.FlatAppearance.MouseOverBackColor = clrLight2;

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
            btnHuy.Click += (s, ev) =>
            { if (AskClose() == DialogResult.Yes) { closingByBtn = true; pop.Close(); } };

            btnLuuPop.Click += (s, ev) =>
            {
                string ten = ReadTb(fTen, "Nhập tên đơn vị...");
                string sdt = ReadTb(fSDT, "0xxxxxxxxx");
                string nguoiLH = ReadTb(fNguoiLH, "Nhập tên người liên hệ...");
                string email = ReadTb(fEmail, "example@domain.com");
                string diaChi = ReadTb(fDiaChi, "Số nhà, đường, quận/huyện...");
                string ttText = cbTT.Text;
                int ttInt = ttText == "Đang hợp tác" ? 1 : 0;

                if (string.IsNullOrWhiteSpace(ten)) { ShowWarn("Vui lòng nhập Tên đơn vị!"); fTen.Focus(); return; }
                if (string.IsNullOrWhiteSpace(sdt)) { ShowWarn("Vui lòng nhập Số điện thoại!"); fSDT.Focus(); return; }
                if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
                { ShowWarn("Số điện thoại phải đúng 10 chữ số!"); fSDT.Focus(); return; }
                if (string.IsNullOrWhiteSpace(nguoiLH)) { ShowWarn("Vui lòng nhập Người liên hệ!"); fNguoiLH.Focus(); return; }
                if (string.IsNullOrWhiteSpace(email)) { ShowWarn("Vui lòng nhập Email!"); fEmail.Focus(); return; }
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                { ShowWarn("Email không đúng định dạng!"); fEmail.Focus(); return; }
                if (string.IsNullOrWhiteSpace(diaChi)) { ShowWarn("Vui lòng nhập Địa chỉ!"); fDiaChi.Focus(); return; }

                try
                {
                    if (isSua)
                    {
                        int ma = Convert.ToInt32(drEdit["MaDonVi"]);
                        _bll.CapNhat(ma, ten, diaChi, email, sdt, nguoiLH, ttInt);
                        UpdateRowInMemory(ma.ToString(), ten, diaChi, email, sdt, nguoiLH, ttText);
                        MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _bll.Them(ten, diaChi, email, sdt, nguoiLH, ttInt);
                        LoadGrid();
                        MessageBox.Show("Thêm đơn vị phát hành thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    closingByBtn = true;
                    pop.DialogResult = DialogResult.OK;
                    pop.Close();
                }
                catch (Exception ex)
                { MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            };

            pFoot.Controls.Add(btnLuuPop);
            pFoot.Controls.Add(btnHuy);

            // Viền popup bo góc
            pop.Paint += (s, ev) =>
            {
                using (var pen = new Pen(C_Light, 1.5f))
                    ev.Graphics.DrawRectangle(pen, 0, 0, pop.Width - 1, pop.Height - 1);
            };

            pop.Controls.Add(pBody);
            pop.Controls.Add(pFoot);
            pop.Controls.Add(pHead);
            pop.Shown += (s, ev) =>
            {
                pHead.Location = new Point(0, 0); pHead.Size = new Size(POP_W, HEAD_H);
                pBody.Location = new Point(0, HEAD_H); pBody.Size = new Size(POP_W, POP_H - HEAD_H - FOOT_H);
                pFoot.Location = new Point(0, POP_H - FOOT_H); pFoot.Size = new Size(POP_W, FOOT_H);
            };
            pop.ShowDialog(this);
        }

        // ══════════════════════════════════════════════════════════════════
        //  XÁC NHẬN XÓA
        // ══════════════════════════════════════════════════════════════════
        private void ShowXacNhanXoa(DataRow dr)
        {
            string maDV = dr["MaDonVi"]?.ToString() ?? "";
            string tenDV = dr["TenDonVi"]?.ToString() ?? "";

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

            var pTop = new Panel { Location = new Point(0, 0), Size = new Size(440, 80), BackColor = Color.FromArgb(254, 242, 242) };
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
                new Font("Segoe UI", 13F, FontStyle.Bold), C_TextDark,
                new Rectangle(20, 92, 400, 28), ContentAlignment.MiddleCenter));

            pop.Controls.Add(BuildLabel(
                $"Bạn có chắc muốn xóa đơn vị\n\"{tenDV}\" không?",
                new Font("Segoe UI", 9.5F), C_TextMid,
                new Rectangle(20, 124, 400, 46), ContentAlignment.MiddleCenter));

            pop.Controls.Add(BuildLabel("⚠  Hành động này không thể hoàn tác!",
                new Font("Segoe UI", 8.5F, FontStyle.Italic), Color.FromArgb(185, 28, 28),
                new Rectangle(20, 174, 400, 20), ContentAlignment.MiddleCenter));

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
                _bll.Xoa(Convert.ToInt32(maDV));
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
        //  CHI TIẾT
        // ══════════════════════════════════════════════════════════════════
        private void ShowChiTietPopup(DataRow dr)
        {
            string ma = dr["MaDonVi"]?.ToString() ?? "";
            string ten = dr["TenDonVi"]?.ToString() ?? "";
            string diaChi = dr["DiaChi"]?.ToString() ?? "";
            string email = dr["Email"]?.ToString() ?? "";
            string sdt = dr["SoDienThoai"]?.ToString() ?? "";
            string nguoiLH = dr["NguoiLienHe"]?.ToString() ?? "";
            string tt = dr["TrangThai"]?.ToString() ?? "";

            var popup = new Form
            {
                Text = "Chi tiết – " + ten,
                Width = 520,
                Height = 440,
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
                    ev.Graphics.FillRectangle(gb, pTop.ClientRectangle);
            };
            pTop.Controls.Add(new Label
            {
                Text = "🏢  " + ten,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(16, 10)
            });
            pTop.Controls.Add(new Label
            {
                Text = "Mã ĐV: " + ma + "   •   " + tt,
                ForeColor = Color.FromArgb(147, 197, 253),
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

            // Scroll body
            var pScroll = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = C_BgPage, Padding = new Padding(16, 12, 16, 8) };
            var flow = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoSize = true, Width = 450, BackColor = Color.Transparent };
            pScroll.Controls.Add(flow);

            Control MkSH(string ico, string title2, Color ac)
            {
                var b = new Panel { Size = new Size(450, 38), BackColor = Color.White, Margin = new Padding(0, 0, 0, 2) };
                b.Controls.Add(new Panel { Size = new Size(4, 38), Location = new Point(0, 0), BackColor = ac });
                b.Controls.Add(new Label { Text = ico + "  " + title2, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = ac, Location = new Point(14, 9), AutoSize = true });
                return b;
            }

            Control MkRow(string lb, string val2, Color? vc = null)
            {
                var row = new Panel { Size = new Size(450, 34), BackColor = Color.White, Margin = new Padding(0, 0, 0, 1) };
                row.Controls.Add(new Label { Text = lb, Location = new Point(14, 8), Size = new Size(140, 20), ForeColor = C_TextSoft, Font = new Font("Segoe UI", 9F) });
                row.Controls.Add(new Label { Text = string.IsNullOrWhiteSpace(val2) ? "—" : val2, Location = new Point(162, 8), Size = new Size(270, 20), Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = vc ?? C_TextDark });
                row.Controls.Add(new Panel { Location = new Point(0, 33), Size = new Size(450, 1), BackColor = Color.FromArgb(243, 244, 246) });
                return row;
            }

            Color ttColor = tt == "Đang hợp tác" ? Color.FromArgb(4, 120, 87) : Color.FromArgb(185, 28, 28);

            flow.Controls.Add(MkSH("📋", "THÔNG TIN ĐƠN VỊ PHÁT HÀNH", C_Primary));
            flow.Controls.Add(MkRow("Mã đơn vị:", ma));
            flow.Controls.Add(MkRow("Tên đơn vị:", ten));
            flow.Controls.Add(MkRow("Địa chỉ:", diaChi));
            flow.Controls.Add(MkRow("Email:", email));
            flow.Controls.Add(MkRow("Số điện thoại:", sdt));
            flow.Controls.Add(MkRow("Người liên hệ:", nguoiLH));
            flow.Controls.Add(MkRow("Trạng thái:", tt, ttColor));

            popup.Controls.Add(pTop);
            popup.Controls.Add(pFoot);
            popup.Controls.Add(pScroll);
            popup.ShowDialog(this);
        }

        // ══════════════════════════════════════════════════════════════════
        //  HELPERS
        // ══════════════════════════════════════════════════════════════════
        private static string ReadTb(TextBox tb, string ph) =>
            tb.ForeColor == Color.DarkGray || tb.Text == ph ? "" : tb.Text.Trim();

        private static void SetTb(TextBox tb, object val)
        { tb.Text = val?.ToString() ?? ""; tb.ForeColor = Color.FromArgb(17, 24, 39); }

        private static DialogResult AskClose() =>
            MessageBox.Show("Bạn có muốn đóng mà không lưu không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private static void ShowWarn(string msg) =>
            MessageBox.Show(msg, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private static Label BuildLabel(string text, Font font, Color fore, Rectangle bounds, ContentAlignment align) =>
            new Label { Text = text, Font = font, ForeColor = fore, Location = new Point(bounds.X, bounds.Y), Size = new Size(bounds.Width, bounds.Height), TextAlign = align, AutoSize = false };

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var gp = new GraphicsPath(); int d = radius * 2;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure(); return gp;
        }

        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int l, int t, int r, int b, int rw, int rh);

        private void UpdateRowInMemory(string maDV, string ten, string diaChi,
                                       string email, string sdt, string nguoiLH, string ttText)
        {
            if (tblDV == null) return;
            foreach (DataRow r in tblDV.Rows)
                if (r["MaDonVi"].ToString() == maDV)
                {
                    r["TenDonVi"] = ten; r["DiaChi"] = diaChi;
                    r["Email"] = email; r["SoDienThoai"] = sdt;
                    r["NguoiLienHe"] = nguoiLH; r["TrangThai"] = ttText;
                    break;
                }
        }

        private void SetInputEnabled(bool enabled) { }
        private void ResetValues() { }
        private void SetBtnAfterSave() { }
    }
}