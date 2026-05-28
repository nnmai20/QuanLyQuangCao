using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuangCao.DAL;
using QuanLyQuangCao.BLL;

namespace QuanLyQuangCao.Forms
{
    public partial class frmDashboard : Form
    {
        private readonly ThongKeBLL _bll = new ThongKeBLL(); 
        
        public frmDashboard()
        {
            InitializeComponent();
            ThietLapGiaoDien();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            // Truy vấn 3 con số từ CSDL
            lblSoNguoiDung.Text = _bll.DemNguoiDung().ToString("N0");
            lblSoKhachHang.Text = _bll.DemKhachHang().ToString("N0");
            lblSoHopDong.Text = _bll.DemHopDong().ToString("N0");

            // Thống kê chi tiết hợp đồng theo trạng thái
            lblDangChoXuLy.Text = _bll.DemHopDongTheoTrangThai("Đang chờ xử lý").ToString();
            lblDangXuLy.Text = _bll.DemHopDongTheoTrangThai("Đang xử lý").ToString();
            lblDaDang.Text = _bll.DemHopDongTheoTrangThai("Đã đăng").ToString();
        }

        private void ThietLapGiaoDien()
        {
            this.BackColor = Color.FromArgb(240, 242, 245);

            // Thẻ 1 — Người dùng
            ThietLapCard(pnlNguoiDung, Color.FromArgb(41, 128, 185));
            // Thẻ 2 — Khách hàng
            ThietLapCard(pnlKhachHang, Color.FromArgb(39, 174, 96));
            // Thẻ 3 — Hợp đồng
            ThietLapCard(pnlHopDong, Color.FromArgb(52, 152, 219));

            // Label tiêu đề trang
            lblTieuDe.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(26, 58, 92);

            // Cấu hình Anchor cho các card để responsive khi resize
            pnlNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlHopDong.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void ThietLapCard(Panel pnl, Color mauNen)
        {
            pnl.BackColor = mauNen;
            pnl.Size = new Size(200, 110);

            // Bo góc và đổ bóng bằng cách vẽ thủ công
            pnl.Paint += (s, e) =>
            {
                // Vẽ border trắng mỏng ở đáy để tạo hiệu ứng chiều sâu
                e.Graphics.DrawLine(new System.Drawing.Pen(Color.FromArgb(50, 255, 255, 255), 3),
                    0, pnl.Height - 3, pnl.Width, pnl.Height - 3);
            };

            // Style label số liệu
            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl.Name.StartsWith("lblSo"))
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.Font = new Font("Segoe UI", 28, FontStyle.Bold);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(220, 255, 255, 255);
                    lbl.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                }
            }
        }
    }
}
