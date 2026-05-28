using System;
using System.Data;
using QLQC.Class;

namespace QLQC.DAL
{
    public class KhachHangDAL
    {
        private string Esc(string v) => v?.Replace("'", "''") ?? "";

        public DataTable GetAll(string tenFilter = "", string diaChiFilter = "", string linhVucFilter = "")
        {
            string sql = @"
SELECT MaKhachHang, TenKhachHang, DiaChi,
       LinhVucHoatDong, Email, SoDienThoai
FROM KHACH_HANG WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(tenFilter))
                sql += $" AND TenKhachHang LIKE N'%{Esc(tenFilter)}%'";
            if (!string.IsNullOrWhiteSpace(diaChiFilter))
                sql += $" AND DiaChi LIKE N'%{Esc(diaChiFilter)}%'";
            if (!string.IsNullOrWhiteSpace(linhVucFilter))
                sql += $" AND LinhVucHoatDong LIKE N'%{Esc(linhVucFilter)}%'";

            sql += " ORDER BY MaKhachHang";
            return Functions.GetDataToTable(sql);
        }

        public void Them(string ten, string diaChi, string linhVuc, string email, string sdt)
        {
            string sql = $@"
INSERT INTO KHACH_HANG (TenKhachHang, DiaChi, LinhVucHoatDong, Email, SoDienThoai)
VALUES (N'{Esc(ten)}', N'{Esc(diaChi)}', N'{Esc(linhVuc)}', N'{Esc(email)}', N'{Esc(sdt)}')";
            Functions.RunSql(sql);
        }

        public void CapNhat(int ma, string ten, string diaChi, string linhVuc, string email, string sdt)
        {
            string sql = $@"
UPDATE KHACH_HANG
SET TenKhachHang=N'{Esc(ten)}', DiaChi=N'{Esc(diaChi)}',
    LinhVucHoatDong=N'{Esc(linhVuc)}', Email=N'{Esc(email)}',
    SoDienThoai=N'{Esc(sdt)}'
WHERE MaKhachHang={ma}";
            Functions.RunSql(sql);
        }

        public void Xoa(int ma)
        {
            string sql = $"DELETE FROM KHACH_HANG WHERE MaKhachHang = {ma}";
            Functions.RunSqlDel(sql);
        }

        public DataTable GetHopDongCuaKhachHang(int maKH)
        {
            string sql = $@"
SELECT h.MaHopDong,
       ISNULL(h.TrangThaiHopDong,'')                              AS TrangThaiHopDong,
       ISNULL(CONVERT(VARCHAR(10),h.NgayKy,103),'')               AS NgayKy,
       ISNULL(CONVERT(VARCHAR(10),h.NgayBatDau,103),'')           AS NgayBatDau,
       ISNULL(CONVERT(VARCHAR(10),h.NgayKetThuc,103),'')          AS NgayKetThuc,
       ISNULL(FORMAT(h.TongGiaTri,'N0'),'0')                      AS TongGiaTri,
       ISNULL(FORMAT(h.SoTienDaThanhToan,'N0'),'0')               AS DaThanhToan,
       ISNULL(FORMAT(h.TongGiaTri-h.SoTienDaThanhToan,'N0'),'0')  AS ConLai,
       ISNULL(n.HoTen,'') AS NhanVien
FROM HOP_DONG h
LEFT JOIN NGUOI_DUNG n ON n.MaNguoiDung = h.MaNguoiDung
WHERE h.MaKhachHang = {maKH} ORDER BY h.NgayKy DESC";
            return Functions.GetDataToTable(sql);
        }
    }
}
