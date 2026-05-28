namespace AuthForms.UI
{
    partial class frmThongKeHopDong
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.chkKhoangNgay = new System.Windows.Forms.CheckBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.pnlKPI = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKPI1 = new System.Windows.Forms.Panel();
            this.lblKPI1Val = new System.Windows.Forms.Label();
            this.lblKPI1 = new System.Windows.Forms.Label();
            this.pnlKPI2 = new System.Windows.Forms.Panel();
            this.lblKPI2Val = new System.Windows.Forms.Label();
            this.lblKPI2 = new System.Windows.Forms.Label();
            this.pnlKPI3 = new System.Windows.Forms.Panel();
            this.lblKPI3Val = new System.Windows.Forms.Label();
            this.lblKPI3 = new System.Windows.Forms.Label();
            this.pnlKPI4 = new System.Windows.Forms.Panel();
            this.lblKPI4Val = new System.Windows.Forms.Label();
            this.lblKPI4 = new System.Windows.Forms.Label();
            this.pnlCharts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChartCot = new System.Windows.Forms.Panel();
            this.picCot = new System.Windows.Forms.PictureBox();
            this.lblChartCot = new System.Windows.Forms.Label();
            this.pnlChartBanh = new System.Windows.Forms.Panel();
            this.picBanh = new System.Windows.Forms.PictureBox();
            this.lblChartBanh = new System.Windows.Forms.Label();
            this.pnlGrids = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridLeft = new System.Windows.Forms.Panel();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.lblGridLeft = new System.Windows.Forms.Label();
            this.pnlGridRight = new System.Windows.Forms.Panel();
            this.dgvTrangThai = new System.Windows.Forms.DataGridView();
            this.lblGridRight = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlKPI.SuspendLayout();
            this.pnlKPI1.SuspendLayout();
            this.pnlKPI2.SuspendLayout();
            this.pnlKPI3.SuspendLayout();
            this.pnlKPI4.SuspendLayout();
            this.pnlCharts.SuspendLayout();
            this.pnlChartCot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCot)).BeginInit();
            this.pnlChartBanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanh)).BeginInit();
            this.pnlGrids.SuspendLayout();
            this.pnlGridLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.pnlGridRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).BeginInit();
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
            this.pnlHeader.TabIndex = 4;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThongBao.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBao.Location = new System.Drawing.Point(380, 10);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(500, 20);
            this.lblThongBao.TabIndex = 0;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.lblMoTa.Location = new System.Drawing.Point(20, 42);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(700, 18);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Số lượng hợp đồng theo thời gian và trạng thái  |  Chỉ Admin";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(700, 28);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Thống kê hợp đồng";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnXuatCSV);
            this.pnlFilter.Controls.Add(this.btnLamMoi);
            this.pnlFilter.Controls.Add(this.cboNam);
            this.pnlFilter.Controls.Add(this.lblNam);
            this.pnlFilter.Controls.Add(this.cboThang);
            this.pnlFilter.Controls.Add(this.lblThang);
            this.pnlFilter.Controls.Add(this.chkKhoangNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 66);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1100, 50);
            this.pnlFilter.TabIndex = 3;
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(70)))));
            this.btnXuatCSV.FlatAppearance.BorderSize = 0;
            this.btnXuatCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatCSV.ForeColor = System.Drawing.Color.White;
            this.btnXuatCSV.Location = new System.Drawing.Point(988, 11);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(100, 28);
            this.btnXuatCSV.TabIndex = 2;
            this.btnXuatCSV.Text = "Xuất CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = false;
            this.btnXuatCSV.Click += new System.EventHandler(this.btnXuatCSV_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(855, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNam.Location = new System.Drawing.Point(83, 13);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(80, 28);
            this.cboNam.TabIndex = 0;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // lblNam
            // 
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNam.Location = new System.Drawing.Point(14, 15);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(63, 20);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThang.Location = new System.Drawing.Point(238, 14);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(110, 28);
            this.cboThang.TabIndex = 1;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // lblThang
            // 
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThang.Location = new System.Drawing.Point(169, 17);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(63, 18);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng:";
            // 
            // chkKhoangNgay
            // 
            this.chkKhoangNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkKhoangNgay.Location = new System.Drawing.Point(368, 13);
            this.chkKhoangNgay.Name = "chkKhoangNgay";
            this.chkKhoangNgay.Size = new System.Drawing.Size(130, 28);
            this.chkKhoangNgay.TabIndex = 5;
            this.chkKhoangNgay.Text = "Lọc khoảng ngày";
            this.chkKhoangNgay.CheckedChanged += new System.EventHandler(this.chkKhoangNgay_CheckedChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(552, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(105, 27);
            this.dtpTuNgay.TabIndex = 6;
            this.dtpTuNgay.Visible = false;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(711, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(105, 27);
            this.dtpDenNgay.TabIndex = 7;
            this.dtpDenNgay.Visible = false;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.Location = new System.Drawing.Point(504, 17);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(56, 18);
            this.lblTuNgay.TabIndex = 8;
            this.lblTuNgay.Text = "Từ:";
            this.lblTuNgay.Visible = false;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.Location = new System.Drawing.Point(663, 14);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(48, 18);
            this.lblDenNgay.TabIndex = 9;
            this.lblDenNgay.Text = "Đến:";
            this.lblDenNgay.Visible = false;
            // 
            // pnlKPI
            // 
            this.pnlKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlKPI.ColumnCount = 4;
            this.pnlKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlKPI.Controls.Add(this.pnlKPI1, 0, 0);
            this.pnlKPI.Controls.Add(this.pnlKPI2, 1, 0);
            this.pnlKPI.Controls.Add(this.pnlKPI3, 2, 0);
            this.pnlKPI.Controls.Add(this.pnlKPI4, 3, 0);
            this.pnlKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKPI.Location = new System.Drawing.Point(0, 116);
            this.pnlKPI.Name = "pnlKPI";
            this.pnlKPI.Padding = new System.Windows.Forms.Padding(10, 8, 10, 4);
            this.pnlKPI.RowCount = 1;
            this.pnlKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlKPI.Size = new System.Drawing.Size(1100, 80);
            this.pnlKPI.TabIndex = 2;
            // 
            // pnlKPI1
            // 
            this.pnlKPI1.BackColor = System.Drawing.Color.White;
            this.pnlKPI1.Controls.Add(this.lblKPI1Val);
            this.pnlKPI1.Controls.Add(this.lblKPI1);
            this.pnlKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKPI1.Location = new System.Drawing.Point(10, 8);
            this.pnlKPI1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlKPI1.Name = "pnlKPI1";
            this.pnlKPI1.Size = new System.Drawing.Size(262, 68);
            this.pnlKPI1.TabIndex = 3;
            // 
            // lblKPI1Val
            // 
            this.lblKPI1Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKPI1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblKPI1Val.Location = new System.Drawing.Point(10, 24);
            this.lblKPI1Val.Name = "lblKPI1Val";
            this.lblKPI1Val.Size = new System.Drawing.Size(234, 30);
            this.lblKPI1Val.TabIndex = 0;
            this.lblKPI1Val.Text = "0";
            // 
            // lblKPI1
            // 
            this.lblKPI1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKPI1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblKPI1.Location = new System.Drawing.Point(12, 8);
            this.lblKPI1.Name = "lblKPI1";
            this.lblKPI1.Size = new System.Drawing.Size(232, 18);
            this.lblKPI1.TabIndex = 1;
            this.lblKPI1.Text = "Tổng hợp đồng năm";
            // 
            // pnlKPI2
            // 
            this.pnlKPI2.BackColor = System.Drawing.Color.White;
            this.pnlKPI2.Controls.Add(this.lblKPI2Val);
            this.pnlKPI2.Controls.Add(this.lblKPI2);
            this.pnlKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKPI2.Location = new System.Drawing.Point(284, 8);
            this.pnlKPI2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlKPI2.Name = "pnlKPI2";
            this.pnlKPI2.Size = new System.Drawing.Size(262, 68);
            this.pnlKPI2.TabIndex = 2;
            // 
            // lblKPI2Val
            // 
            this.lblKPI2Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKPI2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(70)))));
            this.lblKPI2Val.Location = new System.Drawing.Point(10, 24);
            this.lblKPI2Val.Name = "lblKPI2Val";
            this.lblKPI2Val.Size = new System.Drawing.Size(234, 30);
            this.lblKPI2Val.TabIndex = 0;
            this.lblKPI2Val.Text = "0";
            // 
            // lblKPI2
            // 
            this.lblKPI2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKPI2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblKPI2.Location = new System.Drawing.Point(12, 8);
            this.lblKPI2.Name = "lblKPI2";
            this.lblKPI2.Size = new System.Drawing.Size(232, 18);
            this.lblKPI2.TabIndex = 1;
            this.lblKPI2.Text = "Đang hiệu lực";
            // 
            // pnlKPI3
            // 
            this.pnlKPI3.BackColor = System.Drawing.Color.White;
            this.pnlKPI3.Controls.Add(this.lblKPI3Val);
            this.pnlKPI3.Controls.Add(this.lblKPI3);
            this.pnlKPI3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKPI3.Location = new System.Drawing.Point(554, 8);
            this.pnlKPI3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlKPI3.Name = "pnlKPI3";
            this.pnlKPI3.Size = new System.Drawing.Size(262, 68);
            this.pnlKPI3.TabIndex = 1;
            // 
            // lblKPI3Val
            // 
            this.lblKPI3Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKPI3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.lblKPI3Val.Location = new System.Drawing.Point(10, 24);
            this.lblKPI3Val.Name = "lblKPI3Val";
            this.lblKPI3Val.Size = new System.Drawing.Size(234, 30);
            this.lblKPI3Val.TabIndex = 0;
            this.lblKPI3Val.Text = "0";
            // 
            // lblKPI3
            // 
            this.lblKPI3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKPI3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblKPI3.Location = new System.Drawing.Point(12, 8);
            this.lblKPI3.Name = "lblKPI3";
            this.lblKPI3.Size = new System.Drawing.Size(232, 18);
            this.lblKPI3.TabIndex = 1;
            this.lblKPI3.Text = "Hết hạn";
            // 
            // pnlKPI4
            // 
            this.pnlKPI4.BackColor = System.Drawing.Color.White;
            this.pnlKPI4.Controls.Add(this.lblKPI4Val);
            this.pnlKPI4.Controls.Add(this.lblKPI4);
            this.pnlKPI4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKPI4.Location = new System.Drawing.Point(828, 8);
            this.pnlKPI4.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlKPI4.Name = "pnlKPI4";
            this.pnlKPI4.Size = new System.Drawing.Size(262, 68);
            this.pnlKPI4.TabIndex = 0;
            // 
            // lblKPI4Val
            // 
            this.lblKPI4Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKPI4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblKPI4Val.Location = new System.Drawing.Point(10, 24);
            this.lblKPI4Val.Name = "lblKPI4Val";
            this.lblKPI4Val.Size = new System.Drawing.Size(234, 30);
            this.lblKPI4Val.TabIndex = 0;
            this.lblKPI4Val.Text = "0";
            // 
            // lblKPI4
            // 
            this.lblKPI4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKPI4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblKPI4.Location = new System.Drawing.Point(12, 8);
            this.lblKPI4.Name = "lblKPI4";
            this.lblKPI4.Size = new System.Drawing.Size(232, 18);
            this.lblKPI4.TabIndex = 1;
            this.lblKPI4.Text = "Đã hủy";
            // 
            // pnlCharts
            // 
            this.pnlCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlCharts.ColumnCount = 2;
            this.pnlCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlCharts.Controls.Add(this.pnlChartCot, 0, 0);
            this.pnlCharts.Controls.Add(this.pnlChartBanh, 1, 0);
            this.pnlCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCharts.Location = new System.Drawing.Point(0, 196);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.pnlCharts.RowCount = 1;
            this.pnlCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCharts.Size = new System.Drawing.Size(1100, 280);
            this.pnlCharts.TabIndex = 1;
            // 
            // pnlChartCot
            // 
            this.pnlChartCot.BackColor = System.Drawing.Color.White;
            this.pnlChartCot.Controls.Add(this.picCot);
            this.pnlChartCot.Controls.Add(this.lblChartCot);
            this.pnlChartCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartCot.Location = new System.Drawing.Point(10, 4);
            this.pnlChartCot.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlChartCot.Name = "pnlChartCot";
            this.pnlChartCot.Size = new System.Drawing.Size(694, 272);
            this.pnlChartCot.TabIndex = 1;
            // 
            // picCot
            // 
            this.picCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCot.Location = new System.Drawing.Point(0, 26);
            this.picCot.Name = "picCot";
            this.picCot.Size = new System.Drawing.Size(694, 246);
            this.picCot.TabIndex = 0;
            this.picCot.TabStop = false;
            this.picCot.Resize += new System.EventHandler(this.picCot_Resize);
            // 
            // lblChartCot
            // 
            this.lblChartCot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartCot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChartCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblChartCot.Location = new System.Drawing.Point(0, 0);
            this.lblChartCot.Name = "lblChartCot";
            this.lblChartCot.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.lblChartCot.Size = new System.Drawing.Size(694, 26);
            this.lblChartCot.TabIndex = 1;
            this.lblChartCot.Text = "Số lượng hợp đồng theo tháng";
            // 
            // pnlChartBanh
            // 
            this.pnlChartBanh.BackColor = System.Drawing.Color.White;
            this.pnlChartBanh.Controls.Add(this.picBanh);
            this.pnlChartBanh.Controls.Add(this.lblChartBanh);
            this.pnlChartBanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartBanh.Location = new System.Drawing.Point(720, 4);
            this.pnlChartBanh.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlChartBanh.Name = "pnlChartBanh";
            this.pnlChartBanh.Size = new System.Drawing.Size(370, 272);
            this.pnlChartBanh.TabIndex = 0;
            // 
            // picBanh
            // 
            this.picBanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanh.Location = new System.Drawing.Point(0, 26);
            this.picBanh.Name = "picBanh";
            this.picBanh.Size = new System.Drawing.Size(370, 246);
            this.picBanh.TabIndex = 0;
            this.picBanh.TabStop = false;
            this.picBanh.Resize += new System.EventHandler(this.picBanh_Resize);
            // 
            // lblChartBanh
            // 
            this.lblChartBanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartBanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChartBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblChartBanh.Location = new System.Drawing.Point(0, 0);
            this.lblChartBanh.Name = "lblChartBanh";
            this.lblChartBanh.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.lblChartBanh.Size = new System.Drawing.Size(370, 26);
            this.lblChartBanh.TabIndex = 1;
            this.lblChartBanh.Text = "Cơ cấu trạng thái";
            // 
            // pnlGrids
            // 
            this.pnlGrids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlGrids.ColumnCount = 2;
            this.pnlGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlGrids.Controls.Add(this.pnlGridLeft, 0, 0);
            this.pnlGrids.Controls.Add(this.pnlGridRight, 1, 0);
            this.pnlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrids.Location = new System.Drawing.Point(0, 476);
            this.pnlGrids.Name = "pnlGrids";
            this.pnlGrids.Padding = new System.Windows.Forms.Padding(10, 4, 10, 8);
            this.pnlGrids.RowCount = 1;
            this.pnlGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlGrids.Size = new System.Drawing.Size(1100, 284);
            this.pnlGrids.TabIndex = 0;
            // 
            // pnlGridLeft
            // 
            this.pnlGridLeft.BackColor = System.Drawing.Color.White;
            this.pnlGridLeft.Controls.Add(this.dgvTongHop);
            this.pnlGridLeft.Controls.Add(this.lblGridLeft);
            this.pnlGridLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridLeft.Location = new System.Drawing.Point(10, 4);
            this.pnlGridLeft.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlGridLeft.Name = "pnlGridLeft";
            this.pnlGridLeft.Size = new System.Drawing.Size(370, 272);
            this.pnlGridLeft.TabIndex = 1;
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.AllowUserToAddRows = false;
            this.dgvTongHop.AllowUserToDeleteRows = false;
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.BackgroundColor = System.Drawing.Color.White;
            this.dgvTongHop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTongHop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTongHop.ColumnHeadersHeight = 30;
            this.dgvTongHop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongHop.EnableHeadersVisualStyles = false;
            this.dgvTongHop.Location = new System.Drawing.Point(0, 26);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.RowHeadersVisible = false;
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.RowTemplate.Height = 26;
            this.dgvTongHop.Size = new System.Drawing.Size(370, 246);
            this.dgvTongHop.TabIndex = 0;
            // 
            // lblGridLeft
            // 
            this.lblGridLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGridLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblGridLeft.Location = new System.Drawing.Point(0, 0);
            this.lblGridLeft.Name = "lblGridLeft";
            this.lblGridLeft.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.lblGridLeft.Size = new System.Drawing.Size(370, 26);
            this.lblGridLeft.TabIndex = 1;
            this.lblGridLeft.Text = "Tổng Hợp Theo Tháng";
            this.lblGridLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGridRight
            // 
            this.pnlGridRight.BackColor = System.Drawing.Color.White;
            this.pnlGridRight.Controls.Add(this.dgvTrangThai);
            this.pnlGridRight.Controls.Add(this.lblGridRight);
            this.pnlGridRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridRight.Location = new System.Drawing.Point(396, 4);
            this.pnlGridRight.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlGridRight.Name = "pnlGridRight";
            this.pnlGridRight.Size = new System.Drawing.Size(694, 272);
            this.pnlGridRight.TabIndex = 0;
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.AllowUserToAddRows = false;
            this.dgvTrangThai.AllowUserToDeleteRows = false;
            this.dgvTrangThai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrangThai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrangThai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrangThai.ColumnHeadersHeight = 30;
            this.dgvTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrangThai.EnableHeadersVisualStyles = false;
            this.dgvTrangThai.Location = new System.Drawing.Point(0, 26);
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.ReadOnly = true;
            this.dgvTrangThai.RowHeadersVisible = false;
            this.dgvTrangThai.RowHeadersWidth = 51;
            this.dgvTrangThai.RowTemplate.Height = 26;
            this.dgvTrangThai.Size = new System.Drawing.Size(694, 246);
            this.dgvTrangThai.TabIndex = 0;
            // 
            // lblGridRight
            // 
            this.lblGridRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGridRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.lblGridRight.Location = new System.Drawing.Point(0, 0);
            this.lblGridRight.Name = "lblGridRight";
            this.lblGridRight.Padding = new System.Windows.Forms.Padding(10, 6, 0, 0);
            this.lblGridRight.Size = new System.Drawing.Size(694, 26);
            this.lblGridRight.TabIndex = 1;
            this.lblGridRight.Text = "Danh Sách Chi Tiết Hợp Đồng";
            this.lblGridRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmThongKeHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.pnlGrids);
            this.Controls.Add(this.pnlCharts);
            this.Controls.Add(this.pnlKPI);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "frmThongKeHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hợp đồng  [Admin]";
            this.Load += new System.EventHandler(this.frmThongKeHopDong_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlKPI.ResumeLayout(false);
            this.pnlKPI1.ResumeLayout(false);
            this.pnlKPI2.ResumeLayout(false);
            this.pnlKPI3.ResumeLayout(false);
            this.pnlKPI4.ResumeLayout(false);
            this.pnlCharts.ResumeLayout(false);
            this.pnlChartCot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCot)).EndInit();
            this.pnlChartBanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanh)).EndInit();
            this.pnlGrids.ResumeLayout(false);
            this.pnlGridLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.pnlGridRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        // Fields — khai báo tường minh, KHÔNG dùng SetupCard/MakeKPI helper
        private System.Windows.Forms.Panel         pnlHeader, pnlFilter;
        private System.Windows.Forms.TableLayoutPanel pnlKPI, pnlCharts, pnlGrids;
        private System.Windows.Forms.Label         lblTieuDe, lblMoTa, lblThongBao, lblNam;
        private System.Windows.Forms.Label         lblThang, lblTuNgay, lblDenNgay;
        private System.Windows.Forms.ComboBox      cboNam;
        private System.Windows.Forms.ComboBox      cboThang;
        private System.Windows.Forms.CheckBox      chkKhoangNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.Button        btnLamMoi, btnXuatCSV;
        private System.Windows.Forms.Panel         pnlKPI1, pnlKPI2, pnlKPI3, pnlKPI4;
        private System.Windows.Forms.Label         lblKPI1, lblKPI1Val;
        private System.Windows.Forms.Label         lblKPI2, lblKPI2Val;
        private System.Windows.Forms.Label         lblKPI3, lblKPI3Val;
        private System.Windows.Forms.Label         lblKPI4, lblKPI4Val;
        private System.Windows.Forms.Panel         pnlChartCot, pnlChartBanh;
        private System.Windows.Forms.Label         lblChartCot, lblChartBanh;
        private System.Windows.Forms.PictureBox    picCot, picBanh;
        private System.Windows.Forms.Panel         pnlGridLeft, pnlGridRight;
        private System.Windows.Forms.Label         lblGridLeft, lblGridRight;
        private System.Windows.Forms.DataGridView  dgvTongHop, dgvTrangThai;
    }
}
