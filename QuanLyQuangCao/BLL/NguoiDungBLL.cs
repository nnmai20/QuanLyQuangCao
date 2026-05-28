using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using QuanLyQuangCao.DAL;
using QuanLyQuangCao.Helpers;
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.BLL
{
    public class NguoiDungBLL
    {
        private readonly NguoiDungDAL _dal = new NguoiDungDAL();

        // ── Đăng nhập ────────────────────────────────────────────────────────
        /// <summary>
        /// Trả về model nếu đăng nhập thành công, null nếu thất bại.
        /// </summary>
        public NguoiDungModel DangNhap(string tenDangNhap, string matKhauNhap, out string thongBao)
        {
            thongBao = "";
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhauNhap))
            {
                thongBao = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return null;
            }

            DataRow row = _dal.GetUserByUsername(tenDangNhap.Trim());
            if (row == null)
            {
                thongBao = "Tên đăng nhập không tồn tại.";
                return null;
            }

            if (Convert.ToInt32(row["TrangThaiHoatDong"]) == 0)
            {
                thongBao = "Tài khoản này đã bị khóa. Liên hệ Admin để được hỗ trợ.";
                return null;
            }

            // Kiểm tra mật khẩu — hỗ trợ cả tài khoản mẫu (salt rỗng) và tài khoản mới (có salt)
            string storedHash = row["MatKhau"].ToString();
            string salt = row["Salt"].ToString();
            bool hopLe;

            if (string.IsNullOrEmpty(salt))
                // Tài khoản cũ: so sánh SHA256 thuần (không salt)
                hopLe = PasswordHelper.HashSHA256(matKhauNhap) == storedHash;
            else
                // Tài khoản mới: Hash+Salt
                hopLe = PasswordHelper.VerifyPassword(matKhauNhap, storedHash, salt);

            if (!hopLe)
            {
                thongBao = "Mật khẩu không đúng.";
                return null;
            }

            // Đăng nhập thành công
            return new NguoiDungModel
            {
                MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                TenDangNhap = row["TenDangNhap"].ToString(),
                HoTen = row["HoTen"].ToString(),
                VaiTro = row["VaiTro"].ToString(),
                TrangThaiHoatDong = Convert.ToInt32(row["TrangThaiHoatDong"])
            };
        }

        // ── Lấy danh sách ────────────────────────────────────────────────────
        public DataTable GetDanhSach(string tuKhoa = "")
            => _dal.GetAllNguoiDung(tuKhoa ?? "");

        // ── Validate & Thêm ──────────────────────────────────────────────────
        public bool ThemNguoiDung(NguoiDungModel nd, out string thongBao)
        {
            if (!Validate(nd, isNew: true, out thongBao)) return false;

            // Sinh Salt và hash mật khẩu
            nd.Salt = PasswordHelper.GenerateSalt();
            nd.MatKhau = PasswordHelper.HashPassword(nd.MatKhau, nd.Salt);

            int rows = _dal.ThemNguoiDung(nd);
            if (rows <= 0) { thongBao = "Thêm tài khoản thất bại."; return false; }
            return true;
        }

        // ── Validate & Sửa ───────────────────────────────────────────────────
        public bool SuaNguoiDung(NguoiDungModel nd, string matKhauMoi, out string thongBao)
        {
            if (!Validate(nd, isNew: false, out thongBao)) return false;

            // Nếu người dùng nhập mật khẩu mới thì hash lại
            if (!string.IsNullOrWhiteSpace(matKhauMoi))
            {
                if (matKhauMoi.Length < 6)
                { thongBao = "Mật khẩu mới phải có ít nhất 6 ký tự."; return false; }
                nd.Salt = PasswordHelper.GenerateSalt();
                nd.MatKhau = PasswordHelper.HashPassword(matKhauMoi, nd.Salt);
            }
            else
            {
                nd.MatKhau = null; // Không đổi mật khẩu
            }

            int rows = _dal.SuaNguoiDung(nd);
            if (rows <= 0) { thongBao = "Cập nhật tài khoản thất bại."; return false; }
            return true;
        }

        // ── Khóa / Mở ────────────────────────────────────────────────────────
        public bool DoiTrangThai(int maNguoiDung, int trangThaiHienTai, out string thongBao)
        {
            int trangThaiMoi = trangThaiHienTai == 1 ? 0 : 1;
            int rows = _dal.CapNhatTrangThai(maNguoiDung, trangThaiMoi);
            thongBao = rows > 0 ? "" : "Thao tác thất bại.";
            return rows > 0;
        }

        // ── Validate tập trung ────────────────────────────────────────────────
        private bool Validate(NguoiDungModel nd, bool isNew, out string thongBao)
        {
            thongBao = "";

            if (string.IsNullOrWhiteSpace(nd.TenDangNhap))
            { thongBao = "Tên đăng nhập không được để trống."; return false; }

            if (nd.TenDangNhap.Length > 50)
            { thongBao = "Tên đăng nhập không quá 50 ký tự."; return false; }

            if (string.IsNullOrWhiteSpace(nd.HoTen))
            { thongBao = "Họ tên không được để trống."; return false; }

            if (isNew && string.IsNullOrWhiteSpace(nd.MatKhau))
            { thongBao = "Mật khẩu không được để trống khi tạo mới."; return false; }

            if (isNew && nd.MatKhau.Length < 6)
            { thongBao = "Mật khẩu phải có ít nhất 6 ký tự."; return false; }

            if (!string.IsNullOrEmpty(nd.Email) &&
                !Regex.IsMatch(nd.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { thongBao = "Định dạng Email không hợp lệ."; return false; }

            if (!string.IsNullOrEmpty(nd.SoDienThoai) &&
                !Regex.IsMatch(nd.SoDienThoai, @"^0\d{9}$"))
            { thongBao = "Số điện thoại phải có 10 chữ số, bắt đầu bằng 0."; return false; }

            // Kiểm tra trùng tên đăng nhập (bỏ qua chính nó khi sửa)
            if (_dal.TenDangNhapDaTon(nd.TenDangNhap, isNew ? 0 : nd.MaNguoiDung))
            { thongBao = $"Tên đăng nhập '{nd.TenDangNhap}' đã tồn tại."; return false; }

            return true;
        }
    }
}
