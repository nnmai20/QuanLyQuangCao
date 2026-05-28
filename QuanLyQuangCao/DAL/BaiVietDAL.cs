
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuangCao.DAL
{
    public class BaiVietDAL
    {
        private string connectionString =
        @"Data Source=.;Initial Catalog=QuanLyQuangCao;Integrated Security=True";

    // LOAD DANH SÁCH BÀI VIẾT
    public DataTable LayDanhSachBaiViet()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT *
                FROM BAI_VIET";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // LOAD COMBO HỢP ĐỒNG
        public DataTable LayHopDong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT MaHopDong,
                       CAST(MaHopDong AS NVARCHAR) + ' - ' + LoaiHopDong AS TenHopDong
                FROM HOP_DONG";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // LOAD COMBO THỂ LOẠI
        public DataTable LayTheLoai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT MaTheLoai,
                       TenTheLoai
                FROM THE_LOAI_BAI_VIET";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // LOAD COMBO NHÂN VIÊN
        public DataTable LayNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT MaNguoiDung,
                       HoTen
                FROM NGUOI_DUNG";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // THÊM BÀI VIẾT
        public bool ThemBaiViet(
            string tieuDe,
            string trangThai,
            string noiDung,
            string ghiChu,
            DateTime ngayNop,
            DateTime ngayDuyet,
            DateTime ngayDang,
            int maTheLoai,
            int maHopDong,
            int maNguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                INSERT INTO BAI_VIET
                (
                    TieuDe,
                    TrangThaiBaiViet,
                    NoiDung,
                    GhiChu,
                    NgayNop,
                    NgayDuyet,
                    NgayDang,
                    NgayTao,
                    NgayCapNhat,
                    MaTheLoai,
                    MaHopDong,
                    MaNguoiDung
                )
                VALUES
                (
                    @TieuDe,
                    @TrangThai,
                    @NoiDung,
                    @GhiChu,
                    @NgayNop,
                    @NgayDuyet,
                    @NgayDang,
                    GETDATE(),
                    GETDATE(),
                    @MaTheLoai,
                    @MaHopDong,
                    @MaNguoiDung
                )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TieuDe", tieuDe);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                cmd.Parameters.AddWithValue("@NgayNop", ngayNop);
                cmd.Parameters.AddWithValue("@NgayDuyet", ngayDuyet);
                cmd.Parameters.AddWithValue("@NgayDang", ngayDang);
                cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SỬA BÀI VIẾT
        public bool SuaBaiViet(
            int maBaiViet,
            string tieuDe,
            string trangThai,
            string noiDung,
            string ghiChu,
            DateTime ngayNop,
            DateTime ngayDuyet,
            DateTime ngayDang,
            int maTheLoai,
            int maHopDong,
            int maNguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                UPDATE BAI_VIET
                SET
                    TieuDe = @TieuDe,
                    TrangThaiBaiViet = @TrangThai,
                    NoiDung = @NoiDung,
                    GhiChu = @GhiChu,
                    NgayNop = @NgayNop,
                    NgayDuyet = @NgayDuyet,
                    NgayDang = @NgayDang,
                    NgayCapNhat = GETDATE(),
                    MaTheLoai = @MaTheLoai,
                    MaHopDong = @MaHopDong,
                    MaNguoiDung = @MaNguoiDung
                WHERE MaBaiViet = @MaBaiViet";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBaiViet", maBaiViet);
                cmd.Parameters.AddWithValue("@TieuDe", tieuDe);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                cmd.Parameters.AddWithValue("@NgayNop", ngayNop);
                cmd.Parameters.AddWithValue("@NgayDuyet", ngayDuyet);
                cmd.Parameters.AddWithValue("@NgayDang", ngayDang);
                cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // XÓA BÀI VIẾT
        public bool XoaBaiViet(int maBaiViet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                DELETE FROM BAI_VIET
                WHERE MaBaiViet = @MaBaiViet";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBaiViet", maBaiViet);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

}
