using System;
using System.Data;
using QLQC.Class;

namespace QLQC.DAL
{
    public class DonViPhatHanhDAL
    {
        private string Esc(string v) => v?.Replace("'", "''") ?? "";

        public DataTable GetAll(string tenFilter = "", string ttFilter = "")
        {
            string sql = @"
SELECT MaDonVi, TenDonVi, DiaChi, Email,
       SoDienThoai, NguoiLienHe,
       CASE WHEN TrangThai=1 THEN N'Đang hợp tác' ELSE N'Tạm dừng' END AS TrangThai
FROM DON_VI_PHAT_HANH WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(tenFilter))
                sql += $" AND TenDonVi LIKE N'%{Esc(tenFilter)}%'";

            if (!string.IsNullOrWhiteSpace(ttFilter) && ttFilter != "-- Tất cả --")
            {
                int ttVal = ttFilter == "Đang hợp tác" ? 1 : 0;
                sql += $" AND TrangThai = {ttVal}";
            }

            sql += " ORDER BY MaDonVi";
            return Functions.GetDataToTable(sql);
        }

        public void Them(string ten, string diaChi, string email, string sdt, string nguoiLH, int trangThai)
        {
            string sql = $@"
INSERT INTO DON_VI_PHAT_HANH(TenDonVi, DiaChi, Email, SoDienThoai, NguoiLienHe, TrangThai)
VALUES(N'{Esc(ten)}', N'{Esc(diaChi)}', N'{Esc(email)}', N'{Esc(sdt)}', N'{Esc(nguoiLH)}', {trangThai})";
            Functions.RunSql(sql);
        }

        public void CapNhat(int ma, string ten, string diaChi, string email, string sdt, string nguoiLH, int trangThai)
        {
            string sql = $@"
UPDATE DON_VI_PHAT_HANH
SET TenDonVi=N'{Esc(ten)}', DiaChi=N'{Esc(diaChi)}',
    Email=N'{Esc(email)}', SoDienThoai=N'{Esc(sdt)}',
    NguoiLienHe=N'{Esc(nguoiLH)}', TrangThai={trangThai}
WHERE MaDonVi={ma}";
            Functions.RunSql(sql);
        }

        public void Xoa(int ma)
        {
            string sql = $"DELETE FROM DON_VI_PHAT_HANH WHERE MaDonVi={ma}";
            Functions.RunSqlDel(sql);
        }
    }
}
