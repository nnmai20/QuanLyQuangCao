using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyQuangCao.Helpers
{
    public static class PasswordHelper
    {
        /// <summary>
        /// Tạo Salt ngẫu nhiên (chuỗi Hex 32 ký tự).
        /// Salt giúp cho cùng một mật khẩu nhưng mỗi user có hash khác nhau.
        /// </summary>
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return BitConverter.ToString(saltBytes).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Băm mật khẩu: Hash = SHA256(password + salt)
        /// </summary>
        public static string HashPassword(string password, string salt)
        {
            string combined = password + salt;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combined));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// Kiểm tra mật khẩu người dùng nhập có khớp với hash trong DB không.
        /// </summary>
        public static bool VerifyPassword(string inputPassword, string storedHash, string salt)
        {
            string inputHash = HashPassword(inputPassword, salt);
            return inputHash == storedHash;
        }

        /// <summary>
        /// Hàm tiện ích: Hash nhanh SHA256 thuần (dùng cho tài khoản mẫu cũ không có salt).
        /// </summary>
        public static string HashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}
