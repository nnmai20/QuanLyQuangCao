using QuanLyQuangCao.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuangCao.BLL
{
    public class ThongKeBLL
    {
        public int DemNguoiDung()
        {
            object r = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM NGUOI_DUNG");
            return Convert.ToInt32(r);
        }

        public int DemKhachHang()
        {
            object r = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM KHACH_HANG");
            return Convert.ToInt32(r);
        }

        public int DemHopDong()
        {
            object r = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM HOP_DONG");
            return Convert.ToInt32(r);
        }

        public int DemHopDongTheoTrangThai(string trangThai)
        {
            string sql = "SELECT COUNT(*) FROM HOP_DONG WHERE TrangThaiHopDong=@TT";
            SqlParameter[] prms = {
                new SqlParameter("@TT", System.Data.SqlDbType.NVarChar, 50) { Value = trangThai }
            };
            object r = DatabaseHelper.ExecuteScalar(sql, prms);
            return Convert.ToInt32(r);
        }
    }
}
