using System;

namespace AuthForms.BLL
{
    public class HopDongRow
    {
        public int Id { get; set; }
        public string MaHopDong { get; set; }
        public string LoaiHopDong { get; set; }
        public string TrangThai { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNguoiDung { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal TongGiaTri { get; set; }
        public decimal DaThanhToan { get; set; }
        public string GhiChu { get; set; }
    }
}
