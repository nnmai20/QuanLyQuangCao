
using System.Data;
using System.Data.SqlClient;
using QuanLyQuangCao.Database;
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.DAL
{
    public class TheLoaiDAL : DBConnection
    {
        // LOAD DANH SÁCH
        public DataTable GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM THE_LOAI_BAI_VIET",
                conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        // THÊM
        public bool Insert(TheLoaiBaiViet tl)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO THE_LOAI_BAI_VIET
                  (
                    TenTheLoai,
                    MoTa
                  )
                  VALUES
                  (
                    @ten,
                    @mota
                  )",
                conn);

            cmd.Parameters.AddWithValue(
                "@ten",
                tl.TenTheLoai);

            // THÊM MÔ TẢ
            cmd.Parameters.AddWithValue(
                "@mota",
                tl.MoTa);

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        // SỬA
        public bool Update(TheLoaiBaiViet tl)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                @"UPDATE THE_LOAI_BAI_VIET
                  SET
                    TenTheLoai=@ten,
                    MoTa=@mota
                  WHERE MaTheLoai=@ma",
                conn);

            cmd.Parameters.AddWithValue(
                "@ten",
                tl.TenTheLoai);

            // THÊM MÔ TẢ
            cmd.Parameters.AddWithValue(
                "@mota",
                tl.MoTa);

            cmd.Parameters.AddWithValue(
                "@ma",
                tl.MaTheLoai);

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        // XÓA
        public bool Delete(int ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                @"DELETE FROM THE_LOAI_BAI_VIET
                  WHERE MaTheLoai=@ma",
                conn);

            cmd.Parameters.AddWithValue(
                "@ma",
                ma);

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        // TÌM KIẾM
        public DataTable Search(string tukhoa)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT *
                  FROM THE_LOAI_BAI_VIET
                  WHERE TenTheLoai LIKE @tk",
                conn);

            da.SelectCommand.Parameters.AddWithValue(
                "@tk",
                "%" + tukhoa + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}

