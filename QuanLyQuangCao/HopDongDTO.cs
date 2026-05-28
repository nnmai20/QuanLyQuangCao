using System;

namespace QlyHopDong.DTO
{
   
    public class HopDongDTO
    {
        
        public int MaHopDong { get; set; }   

        // ── Thông tin hợp đồng ──────────────────────
        public string LoaiHopDong { get; set; }
        public string TrangThaiHopDong { get; set; }
        public DateTime? NgayKy { get; set; }
        public decimal TongGiaTri { get; set; }
        public decimal SoTienDaThanhToan { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        // ── Khoá ngoại (INT) ────────────────────────
        public int MaKhachHang { get; set; }
        public int MaNguoiDung { get; set; }   

        // ── Tính toán (không lưu DB) ─────────────────
        public decimal SoTienConLai => TongGiaTri - SoTienDaThanhToan;

        // ── Denormalised — JOIN để hiển thị Grid ─────
        public string TenKhachHang { get; set; }
        public string SoDienThoaiKH { get; set; }
        public string DiaChiKH { get; set; }
        public string HoTenNhanVien { get; set; }
        public string VaiTroNhanVien { get; set; }

        // ── Constructors ────────────────────────────
        public HopDongDTO() { }

        public HopDongDTO(string loaiHopDong, string trangThaiHopDong,
            DateTime? ngayKy, DateTime? ngayBatDau, DateTime? ngayKetThuc,
            decimal tongGiaTri, decimal soTienDaThanhToan,
            int maKhachHang, int maNguoiDung, string ghiChu = "")
        {
            LoaiHopDong = loaiHopDong;
            TrangThaiHopDong = trangThaiHopDong;
            NgayKy = ngayKy;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TongGiaTri = tongGiaTri;
            SoTienDaThanhToan = soTienDaThanhToan;
            MaKhachHang = maKhachHang;
            MaNguoiDung = maNguoiDung;
            GhiChu = ghiChu;
        }
    }
}