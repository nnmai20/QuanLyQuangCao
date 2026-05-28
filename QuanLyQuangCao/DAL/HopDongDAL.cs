using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QlyHopDong.DTO;

namespace QlyHopDong.DAL
{
    public class HopDongDAL
    {
        // ── Đúng tên database theo file SQL ──────────
        private const string ConnStr =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyQuangCao;Integrated Security=True;Encrypt=False";

        private SqlConnection GetConn() => new SqlConnection(ConnStr);

        // ─────────────────────────────────────────────
        // HELPER: Map DataRow → DTO  (dùng View V_HopDong_DayDu)
        // ─────────────────────────────────────────────
        private HopDongDTO MapRow(DataRow r)
        {
            var dto = new HopDongDTO
            {
                MaHopDong = Convert.ToInt32(r["MaHopDong"]),
                LoaiHopDong = r["LoaiHopDong"].ToString(),
                TrangThaiHopDong = r["TrangThaiHopDong"].ToString(),
                NgayKy = r["NgayKy"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayKy"]),
                NgayBatDau = r["NgayBatDau"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayBatDau"]),
                NgayKetThuc = r["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayKetThuc"]),
                TongGiaTri = Convert.ToDecimal(r["TongGiaTri"]),
                SoTienDaThanhToan = Convert.ToDecimal(r["SoTienDaThanhToan"]),
                GhiChu = r["GhiChu"] == DBNull.Value ? "" : r["GhiChu"].ToString(),
                MaKhachHang = Convert.ToInt32(r["MaKhachHang"]),
                MaNguoiDung = Convert.ToInt32(r["MaNguoiDung"]),
            };

            // Denormalised từ JOIN (có trong View)
            if (r.Table.Columns.Contains("TenKhachHang"))
                dto.TenKhachHang = r["TenKhachHang"].ToString();
            if (r.Table.Columns.Contains("DienThoaiKH"))
                dto.SoDienThoaiKH = r["DienThoaiKH"].ToString();
            if (r.Table.Columns.Contains("NhanVienPhuTrach"))
                dto.HoTenNhanVien = r["NhanVienPhuTrach"].ToString();
            if (r.Table.Columns.Contains("VaiTro"))
                dto.VaiTroNhanVien = r["VaiTro"].ToString();

            return dto;
        }

        private DataTable RunQuery(string sql, Action<SqlCommand> addParams = null)
        {
            using (var conn = GetConn())
            using (var cmd = new SqlCommand(sql, conn))
            {
                addParams?.Invoke(cmd);
                conn.Open();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ─────────────────────────────────────────────
        // LẤY TOÀN BỘ — dùng View V_HopDong_DayDu
        // ─────────────────────────────────────────────
        public List<HopDongDTO> GetAll()
        {
            var dt = RunQuery("SELECT * FROM V_HopDong_DayDu ORDER BY MaHopDong DESC");
            var list = new List<HopDongDTO>();
            foreach (DataRow r in dt.Rows) list.Add(MapRow(r));
            return list;
        }

        // ─────────────────────────────────────────────
        // LẤY THEO MÃ
        // ─────────────────────────────────────────────
        public HopDongDTO GetByMa(int maHopDong)
        {
            var dt = RunQuery("SELECT * FROM V_HopDong_DayDu WHERE MaHopDong = @Ma",
                cmd => cmd.Parameters.AddWithValue("@Ma", maHopDong));
            return dt.Rows.Count > 0 ? MapRow(dt.Rows[0]) : null;
        }

        // ─────────────────────────────────────────────
        // TÌM KIẾM / LỌC
        // ─────────────────────────────────────────────
        public List<HopDongDTO> Search(string keyword, string trangThai)
        {
            string sql = @"
                SELECT * FROM V_HopDong_DayDu
                WHERE  (@Keyword   IS NULL
                        OR TenKhachHang LIKE N'%' + @Keyword + '%'
                        OR CAST(MaHopDong AS NVARCHAR) LIKE '%' + @Keyword + '%')
                AND    (@TrangThai IS NULL OR TrangThaiHopDong = @TrangThai)
                ORDER BY MaHopDong DESC";

            var dt = RunQuery(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@Keyword",
                    string.IsNullOrWhiteSpace(keyword) ? (object)DBNull.Value : keyword.Trim());
                cmd.Parameters.AddWithValue("@TrangThai",
                    string.IsNullOrWhiteSpace(trangThai) ? (object)DBNull.Value : trangThai.Trim());
            });

            var list = new List<HopDongDTO>();
            foreach (DataRow r in dt.Rows) list.Add(MapRow(r));
            return list;
        }

        // ─────────────────────────────────────────────
        // THÊM — trả về MaHopDong vừa được IDENTITY sinh
        // ─────────────────────────────────────────────
        public int Add(HopDongDTO dto)
        {
            string sql = @"
                INSERT INTO HOP_DONG
                    (LoaiHopDong, TrangThaiHopDong, NgayKy, TongGiaTri, SoTienDaThanhToan,
                     GhiChu, NgayBatDau, NgayKetThuc, MaKhachHang, MaNguoiDung)
                VALUES
                    (@LoaiHopDong, @TrangThai, @NgayKy, @TongGia, @DaThanhToan,
                     @GhiChu, @NgayBatDau, @NgayKetThuc, @MaKH, @MaND);
                SELECT SCOPE_IDENTITY();";

            using (var conn = GetConn())
            using (var cmd = new SqlCommand(sql, conn))
            {
                AddParams(cmd, dto);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ─────────────────────────────────────────────
        // SỬA
        // ─────────────────────────────────────────────
        public bool Update(HopDongDTO dto)
        {
            string sql = @"
                UPDATE HOP_DONG SET
                    LoaiHopDong       = @LoaiHopDong,
                    TrangThaiHopDong  = @TrangThai,
                    NgayKy            = @NgayKy,
                    TongGiaTri        = @TongGia,
                    SoTienDaThanhToan = @DaThanhToan,
                    GhiChu            = @GhiChu,
                    NgayBatDau        = @NgayBatDau,
                    NgayKetThuc       = @NgayKetThuc,
                    MaKhachHang       = @MaKH,
                    MaNguoiDung       = @MaND
                WHERE MaHopDong = @MaHopDong";

            using (var conn = GetConn())
            using (var cmd = new SqlCommand(sql, conn))
            {
                AddParams(cmd, dto);
                cmd.Parameters.AddWithValue("@MaHopDong", dto.MaHopDong);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ─────────────────────────────────────────────
        // XÓA
        // ─────────────────────────────────────────────
        public bool Delete(int maHopDong)
        {
            using (var conn = GetConn())
            using (var cmd = new SqlCommand(
                "DELETE FROM HOP_DONG WHERE MaHopDong = @Ma", conn))
            {
                cmd.Parameters.AddWithValue("@Ma", maHopDong);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ─────────────────────────────────────────────
        // KIỂM TRA TỒN TẠI
        // ─────────────────────────────────────────────
        public bool IsExists(int maHopDong)
        {
            var dt = RunQuery("SELECT 1 FROM HOP_DONG WHERE MaHopDong = @Ma",
                cmd => cmd.Parameters.AddWithValue("@Ma", maHopDong));
            return dt.Rows.Count > 0;
        }

        // ─────────────────────────────────────────────
        // DANH SÁCH KHÁCH HÀNG cho ComboBox
        // ─────────────────────────────────────────────
        public DataTable GetDanhSachKhachHang()
        {
            return RunQuery(@"
                SELECT MaKhachHang, TenKhachHang, SoDienThoai, DiaChi
                FROM   KHACH_HANG
                ORDER  BY TenKhachHang");
        }

        // ─────────────────────────────────────────────
        // DANH SÁCH NHÂN VIÊN cho ComboBox
        // (chỉ lấy Marketing vì họ phụ trách hợp đồng)
        // ─────────────────────────────────────────────
        public DataTable GetDanhSachNhanVien()
        {
            return RunQuery(@"
                SELECT MaNguoiDung, HoTen, VaiTro
                FROM   NGUOI_DUNG
                WHERE  TrangThaiHoatDong = 1
                  AND  VaiTro IN (N'Marketing', N'QuanLy', N'Admin')
                ORDER  BY HoTen");
        }

        // ─────────────────────────────────────────────
        // PRIVATE: gom params Thêm/Sửa
        // ─────────────────────────────────────────────
        private void AddParams(SqlCommand cmd, HopDongDTO dto)
        {
            cmd.Parameters.AddWithValue("@LoaiHopDong", dto.LoaiHopDong ?? "");
            cmd.Parameters.AddWithValue("@TrangThai", dto.TrangThaiHopDong ?? "Đang chờ xử lý");
            cmd.Parameters.AddWithValue("@NgayKy",
                dto.NgayKy.HasValue ? (object)dto.NgayKy.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@TongGia", dto.TongGiaTri);
            cmd.Parameters.AddWithValue("@DaThanhToan", dto.SoTienDaThanhToan);
            cmd.Parameters.AddWithValue("@GhiChu",
                string.IsNullOrEmpty(dto.GhiChu) ? (object)DBNull.Value : dto.GhiChu);
            cmd.Parameters.AddWithValue("@NgayBatDau",
                dto.NgayBatDau.HasValue ? (object)dto.NgayBatDau.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@NgayKetThuc",
                dto.NgayKetThuc.HasValue ? (object)dto.NgayKetThuc.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@MaKH", dto.MaKhachHang);
            cmd.Parameters.AddWithValue("@MaND", dto.MaNguoiDung);
        }
    }
}