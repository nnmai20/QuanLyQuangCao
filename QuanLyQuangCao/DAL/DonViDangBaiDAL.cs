using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuangCao.DAL
{
    public class DonViDangBaiDAL
    {
        string connStr =
            @"Data Source=.;
              Initial Catalog=QuanLyQuangCao;
              Integrated Security=True";

        public DataTable LayDanhSachDonVi()
        {
            SqlConnection conn = new SqlConnection(connStr);

            string sql = @"
                SELECT MaDonViDangBai, TenDonVi
                FROM DON_VI_DANG_BAI
                WHERE TrangThai = 1
            ";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}