using System.Drawing;
using System.Windows.Forms;

namespace QLQC.Forms
{
    partial class FrmThongKeBaiViet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.pnlFilter = new Panel();
            this.lblFilterTitle = new Label();
            this.lblTuNgay = new Label();
            this.dtpTuNgay = new DateTimePicker();
            this.lblDenNgay = new Label();
            this.dtpDenNgay = new DateTimePicker();
            this.lblTrangThai = new Label();
            this.cboTrangThai = new ComboBox();
            this.lblNhanVien = new Label();
            this.cboNhanVien = new ComboBox();
            this.btnLocDuLieu = new Button();
            this.btnXuatExcel = new Button();
            this.pnlSummary = new Panel();
            this.pnlGrid = new Panel();
            this.dgridBaiViet = new DataGridView();
            this.pnlFooter = new Panel();
            this.lblFooterNote = new Label();
            this.lblFooterDate = new Label();
            this.pnlChartHolder = new Panel();

            // ===================== FORM =====================
            this.ClientSize = new Size(1280, 860);
            this.BackColor = Color.FromArgb(245, 246, 250);
            this.Font = new Font("Segoe UI", 9.5F);
            this.Text = "Thống kê bài viết";
            this.MinimumSize = new Size(1060, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmThongKeBaiViet_Load);

            // ===================== HEADER =====================
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 100;
            this.pnlHeader.BackColor = Color.FromArgb(67, 56, 202); // Indigo

            Label lblIconEmoji = new Label();
            lblIconEmoji.Text = "📊";
            lblIconEmoji.Font = new Font("Segoe UI", 22F);
            lblIconEmoji.Size = new Size(60, 60);
            lblIconEmoji.Location = new Point(20, 18);
            lblIconEmoji.TextAlign = ContentAlignment.MiddleCenter;
            lblIconEmoji.BackColor = Color.FromArgb(55, 48, 163);
            lblIconEmoji.ForeColor = Color.White;

            this.lblTitle.Text = "THỐNG KÊ BÀI VIẾT";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.Location = new Point(95, 18);
            this.lblTitle.AutoSize = true;

            this.lblSubtitle.Text = "Thống kê và lọc bài viết theo trạng thái, nhân viên, thời gian";
            this.lblSubtitle.ForeColor = Color.FromArgb(165, 180, 252);
            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new Point(97, 55);
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Size = new Size(900, 25);

                        this.lblBgIcon = new Label();
            this.lblBgIcon.Text = "📝";
            this.lblBgIcon.Font = new Font("Segoe UI", 52F);
            this.lblBgIcon.ForeColor = Color.FromArgb(40, 255, 255, 255);
            this.lblBgIcon.Location = new Point(1120, 10);
            this.lblBgIcon.Size = new Size(100, 70);
            this.lblBgIcon.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBgIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;


            pnlHeader.Controls.Add(lblIconEmoji);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblBgIcon);

            // ===================== FILTER PANEL =====================
            this.pnlFilter.Location = new Point(15, 110);
            this.pnlFilter.Size = new Size(1250, 70);
            this.pnlFilter.BackColor = Color.White;
            this.pnlFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            Panel filterLine = new Panel();
            filterLine.Location = new Point(0, 0);
            filterLine.Size = new Size(4, 70);
            filterLine.BackColor = Color.FromArgb(67, 56, 202);

            this.lblFilterTitle.Text = "🔍  BỘ LỌC";
            this.lblFilterTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilterTitle.ForeColor = Color.FromArgb(67, 56, 202);
            this.lblFilterTitle.Location = new Point(15, 8);
            this.lblFilterTitle.AutoSize = true;

            // Từ ngày
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.Font = new Font("Segoe UI", 9F);
            this.lblTuNgay.ForeColor = Color.FromArgb(75, 85, 99);
            this.lblTuNgay.Location = new Point(85, 12);
            this.lblTuNgay.AutoSize = true;

            this.dtpTuNgay.Location = new Point(145, 8);
            this.dtpTuNgay.Size = new Size(145, 26);
            this.dtpTuNgay.Format = DateTimePickerFormat.Short;
            this.dtpTuNgay.Font = new Font("Segoe UI", 9.5F);

            // Đến ngày
            this.lblDenNgay.Text = "Đến ngày:";
            this.lblDenNgay.Font = new Font("Segoe UI", 9F);
            this.lblDenNgay.ForeColor = Color.FromArgb(75, 85, 99);
            this.lblDenNgay.Location = new Point(305, 12);
            this.lblDenNgay.AutoSize = true;

            this.dtpDenNgay.Location = new Point(370, 8);
            this.dtpDenNgay.Size = new Size(145, 26);
            this.dtpDenNgay.Format = DateTimePickerFormat.Short;
            this.dtpDenNgay.Font = new Font("Segoe UI", 9.5F);

            // Trạng thái
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Font = new Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = Color.FromArgb(75, 85, 99);
            this.lblTrangThai.Location = new Point(530, 12);
            this.lblTrangThai.AutoSize = true;

            this.cboTrangThai.Location = new Point(600, 8);
            this.cboTrangThai.Size = new Size(150, 26);
            this.cboTrangThai.Font = new Font("Segoe UI", 9.5F);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = FlatStyle.Flat;

            // Nhân viên
            this.lblNhanVien.Text = "Nhân viên:";
            this.lblNhanVien.Font = new Font("Segoe UI", 9F);
            this.lblNhanVien.ForeColor = Color.FromArgb(75, 85, 99);
            this.lblNhanVien.Location = new Point(765, 12);
            this.lblNhanVien.AutoSize = true;

            this.cboNhanVien.Location = new Point(835, 8);
            this.cboNhanVien.Size = new Size(180, 26);
            this.cboNhanVien.Font = new Font("Segoe UI", 9.5F);
            this.cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNhanVien.FlatStyle = FlatStyle.Flat;

            // Nút Lọc
            this.btnLocDuLieu.Text = "🔍  Lọc dữ liệu";
            this.btnLocDuLieu.Location = new Point(1060, 6);
            this.btnLocDuLieu.Size = new Size(130, 34);
            this.btnLocDuLieu.BackColor = Color.FromArgb(67, 56, 202);
            this.btnLocDuLieu.ForeColor = Color.White;
            this.btnLocDuLieu.FlatStyle = FlatStyle.Flat;
            this.btnLocDuLieu.FlatAppearance.BorderSize = 0;
            this.btnLocDuLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLocDuLieu.Cursor = Cursors.Hand;
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);

            // Nút Xuất Excel
            this.btnXuatExcel.Text = "📥  Xuất Excel";
            this.btnXuatExcel.Location = new Point(1060, 44);
            this.btnXuatExcel.Size = new Size(130, 22);
            this.btnXuatExcel.BackColor = Color.FromArgb(22, 163, 74);
            this.btnXuatExcel.ForeColor = Color.White;
            this.btnXuatExcel.FlatStyle = FlatStyle.Flat;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnXuatExcel.Cursor = Cursors.Hand;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // Dòng thứ 2 của filter (row 2)
            // Thêm label hướng dẫn
            Label lblHint = new Label();
            lblHint.Text = "* Để trống = lấy tất cả";
            lblHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblHint.ForeColor = Color.FromArgb(156, 163, 175);
            lblHint.Location = new Point(145, 48);
            lblHint.AutoSize = false;
            lblHint.Size = new Size(250, 20);

            pnlFilter.Controls.Add(filterLine);
            pnlFilter.Controls.Add(lblFilterTitle);
            pnlFilter.Controls.Add(lblTuNgay);
            pnlFilter.Controls.Add(dtpTuNgay);
            pnlFilter.Controls.Add(lblDenNgay);
            pnlFilter.Controls.Add(dtpDenNgay);
            pnlFilter.Controls.Add(lblTrangThai);
            pnlFilter.Controls.Add(cboTrangThai);
            pnlFilter.Controls.Add(lblNhanVien);
            pnlFilter.Controls.Add(cboNhanVien);
            pnlFilter.Controls.Add(btnLocDuLieu);
            pnlFilter.Controls.Add(btnXuatExcel);
            pnlFilter.Controls.Add(lblHint);

            // ===================== SUMMARY PANEL (4 card) =====================
            this.pnlSummary.Location = new Point(15, 192);
            this.pnlSummary.Size = new Size(1250, 90);
            this.pnlSummary.BackColor = Color.Transparent;
            this.pnlSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Cards sẽ được tạo động trong code-behind qua RefreshSummaryCards()

            // ===================== GRID PANEL =====================
            this.pnlGrid.Location = new Point(15, 292);
            this.pnlGrid.Size = new Size(1250, 490);
            this.pnlGrid.BackColor = Color.White;
            this.pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // Header bar grid
            Panel pnlGridHeader = new Panel();
            pnlGridHeader.Location = new Point(0, 0);
            pnlGridHeader.Size = new Size(1250, 40);
            pnlGridHeader.BackColor = Color.White;

            Panel gridHeaderLine = new Panel();
            gridHeaderLine.Location = new Point(0, 0);
            gridHeaderLine.Size = new Size(4, 40);
            gridHeaderLine.BackColor = Color.FromArgb(67, 56, 202);

            Label lblGridTitle = new Label();
            lblGridTitle.Text = "📋  DANH SÁCH BÀI VIẾT";
            lblGridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(67, 56, 202);
            lblGridTitle.Location = new Point(14, 10);
            lblGridTitle.AutoSize = true;

            this.lblTongSo = new Label();
            this.lblTongSo.Text = "Tổng: 0 bài viết";
            this.lblTongSo.Font = new Font("Segoe UI", 9F);
            this.lblTongSo.ForeColor = Color.FromArgb(107, 114, 128);
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Location = new Point(1060, 13);

            Panel gridUnderline = new Panel();
            gridUnderline.Location = new Point(0, 39);
            gridUnderline.Size = new Size(1250, 1);
            gridUnderline.BackColor = Color.FromArgb(229, 231, 235);

            pnlGridHeader.Controls.Add(gridHeaderLine);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Controls.Add(lblTongSo);
            pnlGridHeader.Controls.Add(gridUnderline);

            // DataGridView
            this.dgridBaiViet.Location = new Point(0, 40);
            this.dgridBaiViet.Size = new Size(800, 450);
            this.dgridBaiViet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.dgridBaiViet.BackgroundColor = Color.White;
            this.dgridBaiViet.BorderStyle = BorderStyle.None;
            this.dgridBaiViet.EnableHeadersVisualStyles = false;
            this.dgridBaiViet.RowHeadersVisible = false;
            this.dgridBaiViet.AllowUserToAddRows = false;
            this.dgridBaiViet.ReadOnly = true;
            this.dgridBaiViet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgridBaiViet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.dgridBaiViet.ScrollBars = ScrollBars.Both;
            this.dgridBaiViet.ColumnHeadersHeight = 40;
            this.dgridBaiViet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgridBaiViet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 56, 202);
            this.dgridBaiViet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgridBaiViet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.dgridBaiViet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgridBaiViet.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            this.dgridBaiViet.DefaultCellStyle.SelectionBackColor = Color.FromArgb(67, 56, 202);
            this.dgridBaiViet.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgridBaiViet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255);
            this.dgridBaiViet.RowTemplate.Height = 34;
            this.dgridBaiViet.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgridBaiViet_CellFormatting);

            // pnlChartHolder
            this.pnlChartHolder.Location = new Point(810, 40);
            this.pnlChartHolder.Size = new Size(440, 450);
            this.pnlChartHolder.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            this.pnlChartHolder.BackColor = Color.White;

            pnlGrid.Controls.Add(pnlGridHeader);
            pnlGrid.Controls.Add(dgridBaiViet);
            pnlGrid.Controls.Add(pnlChartHolder);

            // ===================== FOOTER =====================
            this.pnlFooter.Dock = DockStyle.Bottom;
            this.pnlFooter.Height = 36;
            this.pnlFooter.BackColor = Color.White;

            Panel footLine = new Panel();
            footLine.Dock = DockStyle.Top;
            footLine.Height = 1;
            footLine.BackColor = Color.FromArgb(220, 220, 220);

            this.lblFooterNote.Text = "ℹ  Dữ liệu được lọc theo bộ lọc phía trên. Nhấn 'Lọc dữ liệu' để cập nhật.";
            this.lblFooterNote.Font = new Font("Segoe UI", 8.5F);
            this.lblFooterNote.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblFooterNote.Location = new Point(10, 10);
            this.lblFooterNote.AutoSize = false;
            this.lblFooterNote.Size = new Size(800, 20);

            this.lblFooterDate.Text = "Date";
            this.lblFooterDate.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblFooterDate.ForeColor = Color.FromArgb(67, 56, 202);
            this.lblFooterDate.AutoSize = true;

            pnlFooter.Controls.Add(footLine);
            pnlFooter.Controls.Add(lblFooterNote);
            pnlFooter.Controls.Add(lblFooterDate);

            // ===================== ASSEMBLE =====================
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlFilter);
            this.Controls.Add(pnlSummary);
            this.Controls.Add(pnlGrid);
            this.Controls.Add(pnlFooter);
        }

        private Panel pnlHeader, pnlFilter, pnlSummary, pnlGrid, pnlFooter;
        private Label lblTitle, lblSubtitle, lblFilterTitle;
        private Label lblBgIcon;
        private Label lblTuNgay, lblDenNgay, lblTrangThai, lblNhanVien;
        private Label lblFooterNote, lblFooterDate;
        public Label lblTongSo;
        private DateTimePicker dtpTuNgay, dtpDenNgay;
        private ComboBox cboTrangThai, cboNhanVien;
        private Button btnLocDuLieu, btnXuatExcel;
        private DataGridView dgridBaiViet;
        private Panel pnlChartHolder;
    }
}