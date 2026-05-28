namespace QuanLyQuangCao.Forms
{
    partial class frmNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnKhoa);
            this.pnlTop.Controls.Add(this.btnSua);
            this.pnlTop.Controls.Add(this.btnThem);
            this.pnlTop.Controls.Add(this.txtTimKiem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 55);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(800, 395);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(361, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(482, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(593, 12);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnKhoa.TabIndex = 3;
            this.btnKhoa.Text = "Khóa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(697, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}