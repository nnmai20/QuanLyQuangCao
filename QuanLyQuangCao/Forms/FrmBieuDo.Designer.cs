using System.Drawing;
using System.Windows.Forms;

namespace QLQC.Forms
{
    partial class FrmBieuDo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlChartArea = new System.Windows.Forms.Panel();
            this.pnlChart1 = new System.Windows.Forms.Panel();
            this.pnlChart2 = new System.Windows.Forms.Panel();
            this.pnlChart3 = new System.Windows.Forms.Panel();
            this.lblBaiViet = new System.Windows.Forms.Label();
            this.pnlChart4 = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboLoaiBD = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnVeBieu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblLoaiBD = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlChartArea.SuspendLayout();
            this.pnlChart3.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblLoaiBD);
            this.pnlToolbar.Controls.Add(this.lblNam);
            this.pnlToolbar.Controls.Add(this.lblThang);
            this.pnlToolbar.Controls.Add(this.cboLoaiBD);
            this.pnlToolbar.Controls.Add(this.cboNam);
            this.pnlToolbar.Controls.Add(this.cboThang);
            this.pnlToolbar.Controls.Add(this.btnVeBieu);
            this.pnlToolbar.Controls.Add(this.btnLamMoi);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 80);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1280, 62);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblLoaiBD
            // 
            this.lblLoaiBD.AutoSize = true;
            this.lblLoaiBD.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLoaiBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblLoaiBD.Location = new System.Drawing.Point(16, 19);
            this.lblLoaiBD.Name = "lblLoaiBD";
            this.lblLoaiBD.Size = new System.Drawing.Size(99, 20);
            this.lblLoaiBD.TabIndex = 0;
            this.lblLoaiBD.Text = "Loại biểu đồ:";
            // 
            // cboLoaiBD
            // 
            this.cboLoaiBD.BackColor = System.Drawing.Color.White;
            this.cboLoaiBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiBD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.cboLoaiBD.Location = new System.Drawing.Point(118, 16);
            this.cboLoaiBD.Name = "cboLoaiBD";
            this.cboLoaiBD.Size = new System.Drawing.Size(220, 29);
            this.cboLoaiBD.TabIndex = 1;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblNam.Location = new System.Drawing.Point(352, 19);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(44, 20);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.White;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.cboNam.Location = new System.Drawing.Point(398, 16);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(75, 29);
            this.cboNam.TabIndex = 3;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblThang.Location = new System.Drawing.Point(488, 19);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(53, 20);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng:";
            // 
            // cboThang
            // 
            this.cboThang.BackColor = System.Drawing.Color.White;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.cboThang.Location = new System.Drawing.Point(542, 16);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(120, 29);
            this.cboThang.TabIndex = 5;
            // 
            // btnVeBieu
            // 
            this.btnVeBieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnVeBieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeBieu.FlatAppearance.BorderSize = 0;
            this.btnVeBieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeBieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVeBieu.ForeColor = System.Drawing.Color.White;
            this.btnVeBieu.Location = new System.Drawing.Point(678, 14);
            this.btnVeBieu.Name = "btnVeBieu";
            this.btnVeBieu.Size = new System.Drawing.Size(138, 32);
            this.btnVeBieu.TabIndex = 6;
            this.btnVeBieu.Text = "📊  Vẽ biểu đồ";
            this.btnVeBieu.UseVisualStyleBackColor = false;
            this.btnVeBieu.Click += new System.EventHandler(this.btnVeBieu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnLamMoi.Location = new System.Drawing.Point(826, 14);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 32);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "↺  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlChartArea
            // 
            this.pnlChartArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlChartArea.Controls.Add(this.pnlChart4);
            this.pnlChartArea.Controls.Add(this.pnlChart3);
            this.pnlChartArea.Controls.Add(this.pnlChart2);
            this.pnlChartArea.Controls.Add(this.pnlChart1);
            this.pnlChartArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartArea.Location = new System.Drawing.Point(0, 142);
            this.pnlChartArea.Name = "pnlChartArea";
            this.pnlChartArea.Size = new System.Drawing.Size(1280, 602);
            this.pnlChartArea.TabIndex = 2;
            // 
            // pnlChart1
            // 
            this.pnlChart1.BackColor = System.Drawing.Color.White;
            this.pnlChart1.Location = new System.Drawing.Point(16, 16);
            this.pnlChart1.Name = "pnlChart1";
            this.pnlChart1.Size = new System.Drawing.Size(200, 200);
            this.pnlChart1.TabIndex = 0;
            this.pnlChart1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart1_Paint);
            // 
            // pnlChart2
            // 
            this.pnlChart2.BackColor = System.Drawing.Color.White;
            this.pnlChart2.Location = new System.Drawing.Point(232, 16);
            this.pnlChart2.Name = "pnlChart2";
            this.pnlChart2.Size = new System.Drawing.Size(200, 200);
            this.pnlChart2.TabIndex = 1;
            this.pnlChart2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart2_Paint);
            // 
            // pnlChart3
            // 
            this.pnlChart3.BackColor = System.Drawing.Color.White;
            this.pnlChart3.Controls.Add(this.lblBaiViet);
            this.pnlChart3.Location = new System.Drawing.Point(448, 16);
            this.pnlChart3.Name = "pnlChart3";
            this.pnlChart3.Size = new System.Drawing.Size(200, 200);
            this.pnlChart3.TabIndex = 2;
            this.pnlChart3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart3_Paint);
            // 
            // lblBaiViet
            // 
            this.lblBaiViet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaiViet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBaiViet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBaiViet.Location = new System.Drawing.Point(0, 0);
            this.lblBaiViet.Name = "lblBaiViet";
            this.lblBaiViet.Size = new System.Drawing.Size(200, 28);
            this.lblBaiViet.TabIndex = 0;
            this.lblBaiViet.Text = "Bài viết theo trạng thái";
            this.lblBaiViet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChart4
            // 
            this.pnlChart4.BackColor = System.Drawing.Color.White;
            this.pnlChart4.Location = new System.Drawing.Point(664, 16);
            this.pnlChart4.Name = "pnlChart4";
            this.pnlChart4.Size = new System.Drawing.Size(200, 200);
            this.pnlChart4.TabIndex = 3;
            this.pnlChart4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart4_Paint);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblStatus);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 744);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1280, 36);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatus.Location = new System.Drawing.Point(30, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Sẵn sàng";
            // 
            // FrmBieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.pnlChartArea);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "FrmBieuDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ thống kê";
            this.Load += new System.EventHandler(this.FrmBieuDo_Load);
            this.Resize += new System.EventHandler(this.FrmBieuDo_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlChartArea.ResumeLayout(false);
            this.pnlChart3.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader, pnlToolbar, pnlChartArea;
        private System.Windows.Forms.Panel pnlChart1, pnlChart2, pnlChart3, pnlChart4, pnlFooter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboLoaiBD, cboNam, cboThang;
        private System.Windows.Forms.Button btnVeBieu, btnLamMoi;
        private System.Windows.Forms.Label lblBaiViet;
        private System.Windows.Forms.Label lblLoaiBD;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
    }
}