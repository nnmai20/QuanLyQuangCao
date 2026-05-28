using System;

namespace AuthForms.BLL
{
    public static class Session
    {
        public static NguoiDungInfo NguoiDungHienTai { get; set; }
        public static bool DaDangNhap => NguoiDungHienTai != null;
        public static void DangXuat() => NguoiDungHienTai = null;

        public static bool CoQuyen(params string[] cacVaiTro)
        {
            if (!DaDangNhap) return false;
            foreach (var vt in cacVaiTro)
                if (NguoiDungHienTai.VaiTro.Equals(vt, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }
    }
}
