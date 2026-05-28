namespace AuthForms.UI
{
    partial class frmBaoCaoDoanhThu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblTongHopDong = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblTongDaThanhToan = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblTongConLai = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.picChart = new System.Windows.Forms.PictureBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlHeader.Controls.Add(this.lblThongBao);
            this.pnlHeader.Controls.Add(this.lblMoTa);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 66);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.lblMoTa.Location = new System.Drawing.Point(20, 42);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(700, 18);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Thống kê doanh thu hợp đồng theo thời gian  |  Chỉ Admin";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(700, 28);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Báo Cáo Doanh Thu";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnXuatExcel);
            this.pnlFilter.Controls.Add(this.btnLamMoi);
            this.pnlFilter.Controls.Add(this.cboThang);
            this.pnlFilter.Controls.Add(this.lblThang);
            this.pnlFilter.Controls.Add(this.cboNam);
            this.pnlFilter.Controls.Add(this.lblNam);
            this.pnlFilter.Controls.Add(this.cboLoai);
            this.pnlFilter.Controls.Add(this.lblLoai);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 66);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1100, 52);
            this.pnlFilter.TabIndex = 7;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location = new System.Drawing.Point(613, 38);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(400, 20);
            this.lblThongBao.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(70)))));
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(936, 16);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(110, 28);
            this.btnXuatExcel.TabIndex = 4;
            this.btnXuatExcel.Text = "Xuất CSV";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(809, 17);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(383, 17);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(60, 28);
            this.cboThang.TabIndex = 2;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // lblThang
            // 
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThang.Location = new System.Drawing.Point(316, 21);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(61, 20);
            this.lblThang.TabIndex = 5;
            this.lblThang.Text = "Tháng:";
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNam.Location = new System.Drawing.Point(230, 19);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(80, 28);
            this.cboNam.TabIndex = 1;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // lblNam
            // 
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNam.Location = new System.Drawing.Point(176, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(50, 20);
            this.lblNam.TabIndex = 6;
            this.lblNam.Text = "Năm:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoai.Items.AddRange(new object[] {
            "Theo Ngay",
            "Theo Thang",
            "Theo Nam",
            "Khoang Ngay"});
            this.cboLoai.Location = new System.Drawing.Point(50, 18);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(120, 28);
            this.cboLoai.TabIndex = 0;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoai.Location = new System.Drawing.Point(10, 19);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(46, 20);
            this.lblLoai.TabIndex = 7;
            this.lblLoai.Text = "Loại:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(519, 20);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(105, 27);
            this.dtpTuNgay.TabIndex = 8;
            this.dtpTuNgay.Visible = false;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(674, 19);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(105, 27);
            this.dtpDenNgay.TabIndex = 9;
            this.dtpDenNgay.Visible = false;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.Location = new System.Drawing.Point(449, 22);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(79, 20);
            this.lblTuNgay.TabIndex = 10;
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.Visible = false;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.Location = new System.Drawing.Point(630, 22);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(58, 20);
            this.lblDenNgay.TabIndex = 11;
            this.lblDenNgay.Text = "Đến:";
            this.lblDenNgay.Visible = false;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlCards.ColumnCount = 4;
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCards.Controls.Add(this.pnlCard1, 0, 0);
            this.pnlCards.Controls.Add(this.pnlCard2, 1, 0);
            this.pnlCards.Controls.Add(this.pnlCard3, 2, 0);
            this.pnlCards.Controls.Add(this.pnlCard4, 3, 0);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 118);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(10, 10, 10, 6);
            this.pnlCards.RowCount = 1;
            this.pnlCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCards.Size = new System.Drawing.Size(1100, 96);
            this.pnlCards.TabIndex = 6;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.lblTongDoanhThu);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(10, 10);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(262, 80);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(12, 28);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(238, 28);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "0 VND";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblCard1Title.Location = new System.Drawing.Point(14, 10);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(230, 18);
            this.lblCard1Title.TabIndex = 1;
            this.lblCard1Title.Text = "Tổng Doanh Thu";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblTongHopDong);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(284, 10);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(262, 80);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblTongHopDong
            // 
            this.lblTongHopDong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(70)))));
            this.lblTongHopDong.Location = new System.Drawing.Point(12, 28);
            this.lblTongHopDong.Name = "lblTongHopDong";
            this.lblTongHopDong.Size = new System.Drawing.Size(238, 28);
            this.lblTongHopDong.TabIndex = 0;
            this.lblTongHopDong.Text = "0";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblCard2Title.Location = new System.Drawing.Point(14, 10);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(230, 18);
            this.lblCard2Title.TabIndex = 1;
            this.lblCard2Title.Text = "Số Hợp Đồng";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.lblTongDaThanhToan);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(554, 10);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(262, 80);
            this.pnlCard3.TabIndex = 2;
            // 
            // lblTongDaThanhToan
            // 
            this.lblTongDaThanhToan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.lblTongDaThanhToan.Location = new System.Drawing.Point(12, 28);
            this.lblTongDaThanhToan.Name = "lblTongDaThanhToan";
            this.lblTongDaThanhToan.Size = new System.Drawing.Size(238, 28);
            this.lblTongDaThanhToan.TabIndex = 0;
            this.lblTongDaThanhToan.Text = "0 VND";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblCard3Title.Location = new System.Drawing.Point(14, 10);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(230, 18);
            this.lblCard3Title.TabIndex = 1;
            this.lblCard3Title.Text = "Dã Thanh Toán";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Controls.Add(this.lblTongConLai);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(828, 10);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(262, 80);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblTongConLai
            // 
            this.lblTongConLai.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongConLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTongConLai.Location = new System.Drawing.Point(12, 28);
            this.lblTongConLai.Name = "lblTongConLai";
            this.lblTongConLai.Size = new System.Drawing.Size(220, 28);
            this.lblTongConLai.TabIndex = 0;
            this.lblTongConLai.Text = "0 VND";
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblCard4Title.Location = new System.Drawing.Point(14, 10);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(220, 18);
            this.lblCard4Title.TabIndex = 1;
            this.lblCard4Title.Text = "Còn Lại / Nợ";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 214);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlChart);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlGrid);
            this.splitContainerMain.Size = new System.Drawing.Size(1100, 506);
            this.splitContainerMain.SplitterDistance = 359;
            this.splitContainerMain.TabIndex = 5;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Controls.Add(this.picChart);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(8);
            this.pnlChart.Size = new System.Drawing.Size(1100, 359);
            this.pnlChart.TabIndex = 0;
            // 
            // picChart
            // 
            this.picChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChart.Location = new System.Drawing.Point(8, 8);
            this.picChart.Name = "picChart";
            this.picChart.Size = new System.Drawing.Size(1084, 343);
            this.picChart.TabIndex = 0;
            this.picChart.TabStop = false;
            this.picChart.Resize += new System.EventHandler(this.picChart_Resize);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvDoanhThu);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(8);
            this.pnlGrid.Size = new System.Drawing.Size(1100, 143);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoanhThu.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dgvDoanhThu.Location = new System.Drawing.Point(8, 8);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1084, 127);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu  [Admin]";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel       pnlHeader;
        private System.Windows.Forms.Label       lblTieuDe, lblMoTa;
        private System.Windows.Forms.Panel       pnlFilter;
        private System.Windows.Forms.Label       lblLoai, lblNam, lblThang, lblThongBao;
        private System.Windows.Forms.Label       lblTuNgay, lblDenNgay;
        private System.Windows.Forms.ComboBox    cboLoai, cboNam, cboThang;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.Button      btnLamMoi, btnXuatExcel;
        private System.Windows.Forms.TableLayoutPanel pnlCards;
        private System.Windows.Forms.Panel       pnlCard1, pnlCard2, pnlCard3, pnlCard4;
        private System.Windows.Forms.Label       lblCard1Title, lblTongDoanhThu;
        private System.Windows.Forms.Label       lblCard2Title, lblTongHopDong;
        private System.Windows.Forms.Label       lblCard3Title, lblTongDaThanhToan;
        private System.Windows.Forms.Label       lblCard4Title, lblTongConLai;
        private System.Windows.Forms.Panel       pnlChart;
        private System.Windows.Forms.PictureBox  picChart;
        private System.Windows.Forms.Panel       pnlGrid;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
    }
}
