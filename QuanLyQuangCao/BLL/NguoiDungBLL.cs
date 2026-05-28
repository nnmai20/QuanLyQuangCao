using System;
using AuthForms.DAL;
using AuthForms.Functions;

namespace AuthForms.BLL
{
    public enum LoginResult
    {
        Success,
        WrongCredentials,
        AccountDisabled,
        LegacyMustReset
    }

    public static class NguoiDungBLL
    {
        private const string LEGACY_SENTINEL = "LEGACY_RESET_REQUIRED";

        public static (LoginResult result, NguoiDungInfo user) DangNhap(string tenDangNhap, string matKhauNhap)
        {
            NguoiDungRow row = NguoiDungDAL.GetByTenDangNhap(tenDangNhap);
            if (row == null) return (LoginResult.WrongCredentials, null);

            if (!row.TrangThaiHoatDong)
                return (LoginResult.AccountDisabled, null);

            var info = new NguoiDungInfo
            {
                MaNguoiDung       = row.MaNguoiDung,
                TenDangNhap       = row.TenDangNhap,
                HoTen             = row.HoTen,
                VaiTro            = row.VaiTro,
                TrangThaiHoatDong = row.TrangThaiHoatDong
            };

            // Tài khoản cũ (plain text)
            if (row.SaltMatKhau == LEGACY_SENTINEL)
            {
                if (row.MatKhau != matKhauNhap) return (LoginResult.WrongCredentials, null);
                return (LoginResult.LegacyMustReset, info);
            }

            // Tài khoản mới (PBKDF2)
            if (!CryptoHelper.VerifyPassword(matKhauNhap, row.MatKhau, row.SaltMatKhau))
                return (LoginResult.WrongCredentials, null);

            return (LoginResult.Success, info);
        }

        public static (bool ok, string error) DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi)
        {
            NguoiDungRow row = NguoiDungDAL.GetByMaNguoiDung(maNguoiDung);
            if (row == null) return (false, "Không tìm thấy tài khoản.");

            bool cuDung = row.SaltMatKhau == LEGACY_SENTINEL
                ? row.MatKhau == matKhauCu
                : CryptoHelper.VerifyPassword(matKhauCu, row.MatKhau, row.SaltMatKhau);

            if (!cuDung) return (false, "Mật khẩu hiện tại không đúng.");

            string newSalt = CryptoHelper.GenerateSalt();
            string newHash = CryptoHelper.HashPassword(matKhauMoi, newSalt);

            NguoiDungDAL.UpdatePassword(maNguoiDung, newHash, newSalt);
            return (true, "");
        }

        public static (bool ok, int maNguoiDung) XacMinhNguoiDung(string tenDangNhap, string email)
        {
            object result = NguoiDungDAL.VerifyUserEmail(tenDangNhap, email);
            if (result == null) return (false, -1);
            return (true, (int)result);
        }

        public static void DatLaiMatKhau(int maNguoiDung, string matKhauMoi)
        {
            string newSalt = CryptoHelper.GenerateSalt();
            string newHash = CryptoHelper.HashPassword(matKhauMoi, newSalt);
            NguoiDungDAL.UpdatePassword(maNguoiDung, newHash, newSalt);
        }
    }
}
