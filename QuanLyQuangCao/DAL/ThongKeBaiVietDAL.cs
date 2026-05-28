using System;
using System.Data;
using QLQC.Class;

namespace QLQC.DAL
{
    public class ThongKeBaiVietDAL
    {
        public DataTable GetNhanVienVietBai()
        {
            string sql = @"SELECT MaNguoiDung, HoTen FROM NGUOI_DUNG
                           WHERE VaiTro IN (N'Nhân viên viết bài', N'Nhân viên marketing')
                           ORDER BY HoTen";
            return Functions.GetDataToTable(sql);
        }

        public DataTable GetBaiVietThongKe(DateTime tuNgay, DateTime denNgay, string trangThaiFilter = "", int maNhanVienFilter = 0)
        {
            string tuNgayStr = tuNgay.ToString("yyyy-MM-dd");
            string denNgayStr = denNgay.ToString("yyyy-MM-dd");

            string sqlWhere = $" WHERE CAST(b.NgayTao AS DATE) BETWEEN '{tuNgayStr}' AND '{denNgayStr}'";

            // Lọc trạng thái
            if (!string.IsNullOrWhiteSpace(trangThaiFilter) && trangThaiFilter != "-- Tất cả --")
                sqlWhere += $" AND b.TrangThaiBaiViet = N'{trangThaiFilter}'";

            // Lọc nhân viên
            if (maNhanVienFilter > 0)
                sqlWhere += $" AND b.MaNguoiDung = {maNhanVienFilter}";

            string sql = $@"
                SELECT
                    b.MaBaiViet,
                    b.TieuDe,
                    b.TrangThaiBaiViet,
                    ISNULL(tl.TenTheLoai, N'—')     AS TheLoai,
                    ISNULL(n.HoTen, N'—')            AS NhanVien,
                    ISNULL(hd.MaHopDong, 0)          AS MaHopDong,
                    ISNULL(CONVERT(VARCHAR(10),b.NgayTao,103),   '—') AS NgayTao,
                    ISNULL(CONVERT(VARCHAR(10),b.NgayNop,103),   '—') AS NgayNop,
                    ISNULL(CONVERT(VARCHAR(10),b.NgayDuyet,103), '—') AS NgayDuyet,
                    ISNULL(CONVERT(VARCHAR(10),b.NgayDang,103),  '—') AS NgayDang,
                    ISNULL(b.GhiChu, N'')            AS GhiChu
                FROM BAI_VIET b
                LEFT JOIN THE_LOAI_BAI_VIET tl ON tl.MaTheLoai   = b.MaTheLoai
                LEFT JOIN NGUOI_DUNG        n  ON n.MaNguoiDung   = b.MaNguoiDung
                LEFT JOIN HOP_DONG          hd ON hd.MaHopDong    = b.MaHopDong
                {sqlWhere}
                ORDER BY b.NgayTao DESC";

            return Functions.GetDataToTable(sql);
        }
    }
}
