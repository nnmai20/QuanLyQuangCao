using System;
using System.Data;
using QLQC.Class;

namespace QLQC.DAL
{
    public class BieuDoDAL
    {
        public DataTable GetDoanhThuTheoNam(int nam)
        {
            string sql = $@"SELECT MONTH(NgayKy) AS Thang, ISNULL(SUM(TongGiaTri),0) AS DT
                            FROM HOP_DONG WHERE YEAR(NgayKy)={nam}
                            GROUP BY MONTH(NgayKy) ORDER BY MONTH(NgayKy)";
            return Functions.GetDataToTable(sql);
        }

        public DataTable GetDoanhThuTheoThang(int nam, int thang)
        {
            string sql = $@"SELECT DAY(NgayKy) AS Ngay, ISNULL(SUM(TongGiaTri),0) AS DT
                            FROM HOP_DONG WHERE YEAR(NgayKy)={nam} AND MONTH(NgayKy)={thang}
                            GROUP BY DAY(NgayKy) ORDER BY DAY(NgayKy)";
            return Functions.GetDataToTable(sql);
        }

        public DataTable GetHopDongTheoTrangThai(int nam, int thang)
        {
            string whereTh = thang > 0 ? $" AND MONTH(NgayKy)={thang}" : "";
            string sql = $@"SELECT ISNULL(TrangThaiHopDong,N'Không rõ') AS TT, COUNT(*) AS SoLuong
                            FROM HOP_DONG WHERE YEAR(NgayKy)={nam}{whereTh}
                            GROUP BY TrangThaiHopDong";
            return Functions.GetDataToTable(sql);
        }

        public DataTable GetBaiVietTheoTrangThai(int nam, int thang)
        {
            string whereTh = thang > 0 ? $" AND MONTH(NgayTao)={thang}" : "";
            string sql = $@"SELECT ISNULL(TrangThaiBaiViet,N'Không rõ') AS TT, COUNT(*) AS SoLuong
                            FROM BAI_VIET WHERE YEAR(NgayTao)={nam}{whereTh}
                            GROUP BY TrangThaiBaiViet";
            return Functions.GetDataToTable(sql);
        }
    }
}
