using System.Drawing;
using System.Windows.Forms;

namespace QLQC.Forms
{
    partial class FrmKhachHang
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblSearchTen = new System.Windows.Forms.Label();
            this.lblSearchDiaChi = new System.Windows.Forms.Label();
            this.lblSearchLinhVuc = new System.Windows.Forms.Label();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.txtTimKiemDiaChi = new System.Windows.Forms.TextBox();
            this.txtTimKiemLinhVuc = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaLoc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgridKhachHang = new System.Windows.Forms.DataGridView();
            // 
            // panelNav
            // 
            this.panelNav = new System.Windows.Forms.Panel();
            this.treeViewNav = new System.Windows.Forms.TreeView();
            // 
            // panelNav
            // 
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 28);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 732);
            this.panelNav.TabIndex = 3;
            // 
            // treeViewNav
            // 
            this.treeViewNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNav.Location = new System.Drawing.Point(0, 0);
            this.treeViewNav.Name = "treeViewNav";
            this.treeViewNav.Size = new System.Drawing.Size(200, 732);
            this.treeViewNav.TabIndex = 0;
            this.treeViewNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                new System.Windows.Forms.TreeNode("Khách hàng"),
                new System.Windows.Forms.TreeNode("Đơn vị phát hành"),
                new System.Windows.Forms.TreeNode("Thống kê bài viết"),
                new System.Windows.Forms.TreeNode("Biểu đồ")
            });
            this.treeViewNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNav_AfterSelect);
            // 
            // Add to panelNav
            // 
            this.panelNav.Controls.Add(this.treeViewNav);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.lblSubtitle.Location = new System.Drawing.Point(80, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(331, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Thêm, sửa, xóa và tìm kiếm thông tin khách hàng";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblSearchTen);
            this.pnlToolbar.Controls.Add(this.lblSearchDiaChi);
            this.pnlToolbar.Controls.Add(this.lblSearchLinhVuc);
            this.pnlToolbar.Controls.Add(this.txtTimKiemTen);
            this.pnlToolbar.Controls.Add(this.txtTimKiemDiaChi);
            this.pnlToolbar.Controls.Add(this.txtTimKiemLinhVuc);
            this.pnlToolbar.Controls.Add(this.btnTimKiem);
            this.pnlToolbar.Controls.Add(this.btnXoaLoc);
            this.pnlToolbar.Controls.Add(this.btnThem);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 72);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 76);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblSearchTen
            // 
            this.lblSearchTen.AutoSize = true;
            this.lblSearchTen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSearchTen.Location = new System.Drawing.Point(16, 10);
            this.lblSearchTen.Name = "lblSearchTen";
            this.lblSearchTen.Size = new System.Drawing.Size(105, 19);
            this.lblSearchTen.TabIndex = 0;
            this.lblSearchTen.Text = "Tên khách hàng";
            // 
            // lblSearchDiaChi
            // 
            this.lblSearchDiaChi.AutoSize = true;
            this.lblSearchDiaChi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSearchDiaChi.Location = new System.Drawing.Point(198, 10);
            this.lblSearchDiaChi.Name = "lblSearchDiaChi";
            this.lblSearchDiaChi.Size = new System.Drawing.Size(50, 19);
            this.lblSearchDiaChi.TabIndex = 2;
            this.lblSearchDiaChi.Text = "Địa chỉ";
            // 
            // lblSearchLinhVuc
            // 
            this.lblSearchLinhVuc.AutoSize = true;
            this.lblSearchLinhVuc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchLinhVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblSearchLinhVuc.Location = new System.Drawing.Point(380, 10);
            this.lblSearchLinhVuc.Name = "lblSearchLinhVuc";
            this.lblSearchLinhVuc.Size = new System.Drawing.Size(60, 19);
            this.lblSearchLinhVuc.TabIndex = 4;
            this.lblSearchLinhVuc.Text = "Lĩnh vực";
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtTimKiemTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiemTen.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemTen.Location = new System.Drawing.Point(16, 30);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(170, 29);
            this.txtTimKiemTen.TabIndex = 1;
            this.txtTimKiemTen.Text = "Tìm theo tên...";
            // 
            // txtTimKiemDiaChi
            // 
            this.txtTimKiemDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtTimKiemDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiemDiaChi.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemDiaChi.Location = new System.Drawing.Point(198, 30);
            this.txtTimKiemDiaChi.Name = "txtTimKiemDiaChi";
            this.txtTimKiemDiaChi.Size = new System.Drawing.Size(170, 29);
            this.txtTimKiemDiaChi.TabIndex = 3;
            this.txtTimKiemDiaChi.Text = "Tìm theo địa chỉ...";
            // 
            // txtTimKiemLinhVuc
            // 
            this.txtTimKiemLinhVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtTimKiemLinhVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemLinhVuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiemLinhVuc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemLinhVuc.Location = new System.Drawing.Point(380, 30);
            this.txtTimKiemLinhVuc.Name = "txtTimKiemLinhVuc";
            this.txtTimKiemLinhVuc.Size = new System.Drawing.Size(170, 29);
            this.txtTimKiemLinhVuc.TabIndex = 5;
            this.txtTimKiemLinhVuc.Text = "Tìm theo lĩnh vực...";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(562, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 28);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "🔍  Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaLoc
            // 
            this.btnXoaLoc.BackColor = System.Drawing.Color.White;
            this.btnXoaLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnXoaLoc.Location = new System.Drawing.Point(682, 30);
            this.btnXoaLoc.Name = "btnXoaLoc";
            this.btnXoaLoc.Size = new System.Drawing.Size(100, 28);
            this.btnXoaLoc.TabIndex = 7;
            this.btnXoaLoc.Text = "✕  Xóa lọc";
            this.btnXoaLoc.UseVisualStyleBackColor = false;
            this.btnXoaLoc.Click += new System.EventHandler(this.btnXoaLoc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(916, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 28);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "➕  Thêm khách hàng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dgridKhachHang);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 148);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlContent.Size = new System.Drawing.Size(1100, 576);
            this.pnlContent.TabIndex = 2;
            // 
            // dgridKhachHang
            // 
            this.dgridKhachHang.AllowUserToAddRows = false;
            this.dgridKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgridKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridKhachHang.Location = new System.Drawing.Point(16, 12);
            this.dgridKhachHang.Name = "dgridKhachHang";
            this.dgridKhachHang.RowHeadersVisible = false;
            this.dgridKhachHang.RowHeadersWidth = 51;
            this.dgridKhachHang.RowTemplate.Height = 24;
            this.dgridKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridKhachHang.Size = new System.Drawing.Size(1068, 552);
            this.dgridKhachHang.TabIndex = 0;
            this.dgridKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridKhachHang_CellClick);
            this.dgridKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridKhachHang_CellContentClick);
            this.dgridKhachHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgridKhachHang_CellFormatting);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblFooterNote);
            this.pnlFooter.Controls.Add(this.lblFooterDate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 724);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1100, 36);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooterNote
            // 
            this.lblFooterNote.AutoSize = true;
            this.lblFooterNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFooterNote.Location = new System.Drawing.Point(16, 9);
            this.lblFooterNote.Name = "lblFooterNote";
            this.lblFooterNote.Size = new System.Drawing.Size(205, 20);
            this.lblFooterNote.TabIndex = 0;
            this.lblFooterNote.Text = "ℹ  (*) Trường bắt buộc nhập";
            // 
            // lblFooterDate
            // 
            this.lblFooterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterDate.AutoSize = true;
            this.lblFooterDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFooterDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.lblFooterDate.Location = new System.Drawing.Point(950, 9);
            this.lblFooterDate.Name = "lblFooterDate";
            this.lblFooterDate.Size = new System.Drawing.Size(42, 20);
            this.lblFooterDate.TabIndex = 1;
            this.lblFooterDate.Text = "Date";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(0, 0);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(1, 29);
            this.txtMaKH.TabIndex = 99;
            this.txtMaKH.Visible = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(0, 0);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(1, 29);
            this.txtTenKH.TabIndex = 99;
            this.txtTenKH.Visible = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(0, 0);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(1, 29);
            this.txtDiaChi.TabIndex = 99;
            this.txtDiaChi.Visible = false;
            // 
            // txtLinhVuc
            // 
            this.txtLinhVuc.Location = new System.Drawing.Point(0, 0);
            this.txtLinhVuc.Name = "txtLinhVuc";
            this.txtLinhVuc.Size = new System.Drawing.Size(1, 29);
            this.txtLinhVuc.TabIndex = 99;
            this.txtLinhVuc.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(1, 29);
            this.txtEmail.TabIndex = 99;
            this.txtEmail.Visible = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(0, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(1, 29);
            this.txtSDT.TabIndex = 99;
            this.txtSDT.Visible = false;
            // 
            // txtNguoiLH
            // 
            this.txtNguoiLH.Location = new System.Drawing.Point(0, 0);
            this.txtNguoiLH.Name = "txtNguoiLH";
            this.txtNguoiLH.Size = new System.Drawing.Size(1, 29);
            this.txtNguoiLH.TabIndex = 99;
            this.txtNguoiLH.Visible = false;
            // 
            // FrmKhachHang
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKhachHang)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.TreeView treeViewNav;    }
}