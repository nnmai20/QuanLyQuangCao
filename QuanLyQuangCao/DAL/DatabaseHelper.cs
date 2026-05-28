using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyQuangCao.DAL
{
    public static class DatabaseHelper
    {
        // ===== THAY connection string theo máy của bạn =====
        private const string CONNECTION_STRING =
            "Data Source=LAPTOP-QHOLJELI\\SQLEXPRESS;Initial Catalog=QuanLyQuangCao;Integrated Security=True;Encrypt=False";

        /// <summary>Tạo và mở một SqlConnection mới.</summary>
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Thực thi câu lệnh SELECT, trả về DataTable.
        /// Dùng parameterized query để chống SQL Injection.
        /// </summary>
        /// <param name="sql">Câu lệnh SQL có placeholder (@param)</param>
        /// <param name="parameters">Mảng SqlParameter tương ứng</param>
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Gán tham số nếu có
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn CSDL:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>
        /// Thực thi INSERT / UPDATE / DELETE có Transaction.
        /// Tự động Rollback nếu xảy ra lỗi.
        /// Trả về số dòng bị ảnh hưởng (-1 nếu lỗi).
        /// </summary>
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            int rowsAffected = -1;
            SqlConnection conn = null;
            SqlTransaction tran = null;
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction(); // Bắt đầu Transaction

                using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    rowsAffected = cmd.ExecuteNonQuery();
                }

                tran.Commit(); // Commit khi thành công
            }
            catch (Exception ex)
            {
                tran?.Rollback(); // Rollback khi có lỗi
                MessageBox.Show("Lỗi thao tác CSDL:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = -1;
            }
            finally
            {
                conn?.Close();
                conn?.Dispose();
            }
            return rowsAffected;
        }

        /// <summary>
        /// Thực thi truy vấn trả về một giá trị đơn (scalar).
        /// Ví dụ: SELECT COUNT(*) FROM ...
        /// </summary>
        public static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn CSDL:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
