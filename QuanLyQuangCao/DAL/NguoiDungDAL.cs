using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.DAL
{
    public class NguoiDungDAL
    {
        // ── Đăng nhập ────────────────────────────────────────────────────────
        /// <summary>
        /// Tìm tài khoản theo TenDangNhap. Trả về DataRow chứa MatKhau, Salt, VaiTro...
        /// Việc so sánh mật khẩu được thực hiện ở tầng BLL (tránh lộ logic bảo mật vào SQL).
        /// </summary>
        public DataRow GetUserByUsername(string tenDangNhap)
        {
            string sql = @"SELECT MaNguoiDung, TenDangNhap, MatKhau, Salt,
                                  HoTen, VaiTro, TrangThaiHoatDong
                           FROM   NGUOI_DUNG
                           WHERE  TenDangNhap = @TenDangNhap";

            SqlParameter[] prms = {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap }
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, prms);
            return (dt.Rows.Count > 0) ? dt.Rows[0] : null;
        }

        // ── Lấy danh sách tài khoản ──────────────────────────────────────────
        public DataTable GetAllNguoiDung(string tuKhoa = "")
        {
            string sql = @"SELECT MaNguoiDung, TenDangNhap, HoTen,
                                  Email, SoDienThoai, VaiTro, TrangThaiHoatDong
                           FROM   NGUOI_DUNG
                           WHERE  HoTen       LIKE @TuKhoa
                              OR  TenDangNhap LIKE @TuKhoa
                           ORDER BY MaNguoiDung";

            SqlParameter[] prms = {
                new SqlParameter("@TuKhoa", SqlDbType.NVarChar, 200)
                    { Value = "%" + tuKhoa + "%" }
            };
            return DatabaseHelper.ExecuteQuery(sql, prms);
        }

        // ── Thêm tài khoản ───────────────────────────────────────────────────
        public int ThemNguoiDung(NguoiDungModel nd)
        {
            string sql = @"INSERT INTO NGUOI_DUNG
                               (TenDangNhap, MatKhau, Salt, HoTen, Email,
                                SoDienThoai, VaiTro, TrangThaiHoatDong)
                           VALUES
                               (@TenDangNhap, @MatKhau, @Salt, @HoTen, @Email,
                                @SoDienThoai, @VaiTro, 1)";

            SqlParameter[] prms = {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar,  50)  { Value = nd.TenDangNhap },
                new SqlParameter("@MatKhau",     SqlDbType.VarChar,  255) { Value = nd.MatKhau },
                new SqlParameter("@Salt",        SqlDbType.VarChar,  64)  { Value = nd.Salt },
                new SqlParameter("@HoTen",       SqlDbType.NVarChar, 100) { Value = nd.HoTen },
                new SqlParameter("@Email",       SqlDbType.VarChar,  150) { Value = (object)nd.Email ?? DBNull.Value },
                new SqlParameter("@SoDienThoai", SqlDbType.VarChar,  15)  { Value = (object)nd.SoDienThoai ?? DBNull.Value },
                new SqlParameter("@VaiTro",      SqlDbType.NVarChar, 50)  { Value = nd.VaiTro }
            };
            return DatabaseHelper.ExecuteNonQuery(sql, prms);
        }

        // ── Sửa tài khoản ────────────────────────────────────────────────────
        public int SuaNguoiDung(NguoiDungModel nd)
        {
            // Nếu người dùng nhập mật khẩu mới thì cập nhật, ngược lại giữ nguyên
            string sql = nd.MatKhau != null
                ? @"UPDATE NGUOI_DUNG
                    SET HoTen=@HoTen, Email=@Email, SoDienThoai=@SoDienThoai,
                        VaiTro=@VaiTro, MatKhau=@MatKhau, Salt=@Salt
                    WHERE MaNguoiDung=@MaNguoiDung"
                : @"UPDATE NGUOI_DUNG
                    SET HoTen=@HoTen, Email=@Email, SoDienThoai=@SoDienThoai,
                        VaiTro=@VaiTro
                    WHERE MaNguoiDung=@MaNguoiDung";

            var prmList = new System.Collections.Generic.List<SqlParameter>
            {
                new SqlParameter("@HoTen",       SqlDbType.NVarChar, 100) { Value = nd.HoTen },
                new SqlParameter("@Email",       SqlDbType.VarChar,  150) { Value = (object)nd.Email ?? DBNull.Value },
                new SqlParameter("@SoDienThoai", SqlDbType.VarChar,  15)  { Value = (object)nd.SoDienThoai ?? DBNull.Value },
                new SqlParameter("@VaiTro",      SqlDbType.NVarChar, 50)  { Value = nd.VaiTro },
                new SqlParameter("@MaNguoiDung", SqlDbType.Int)           { Value = nd.MaNguoiDung }
            };

            if (nd.MatKhau != null)
            {
                prmList.Add(new SqlParameter("@MatKhau", SqlDbType.VarChar, 255) { Value = nd.MatKhau });
                prmList.Add(new SqlParameter("@Salt", SqlDbType.VarChar, 64) { Value = nd.Salt });
            }

            return DatabaseHelper.ExecuteNonQuery(sql, prmList.ToArray());
        }

        // ── Khóa / Mở tài khoản ──────────────────────────────────────────────
        public int CapNhatTrangThai(int maNguoiDung, int trangThai)
        {
            string sql = "UPDATE NGUOI_DUNG SET TrangThaiHoatDong=@TrangThai WHERE MaNguoiDung=@Ma";
            SqlParameter[] prms = {
                new SqlParameter("@TrangThai", SqlDbType.TinyInt) { Value = trangThai },
                new SqlParameter("@Ma",        SqlDbType.Int)     { Value = maNguoiDung }
            };
            return DatabaseHelper.ExecuteNonQuery(sql, prms);
        }

        // ── Kiểm tra trùng tên đăng nhập ─────────────────────────────────────
        public bool TenDangNhapDaTon(string tenDangNhap, int bỏQuaMa = 0)
        {
            string sql = @"SELECT COUNT(*) FROM NGUOI_DUNG
                           WHERE TenDangNhap = @TenDangNhap
                             AND MaNguoiDung <> @BoQuaMa";
            SqlParameter[] prms = {
                new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50) { Value = tenDangNhap },
                new SqlParameter("@BoQuaMa",     SqlDbType.Int)         { Value = bỏQuaMa }
            };
            object result = DatabaseHelper.ExecuteScalar(sql, prms);
            return Convert.ToInt32(result) > 0;
        }
    }
}
