using System;
using System.Data;
using System.Text.RegularExpressions;
using QLQC.DAL;

namespace QLQC.BLL
{
    public class KhachHangBLL
    {
        private readonly KhachHangDAL _dal = new KhachHangDAL();

        public DataTable GetAll(string tenFilter = "", string diaChiFilter = "", string linhVucFilter = "")
        {
            return _dal.GetAll(tenFilter, diaChiFilter, linhVucFilter);
        }

        public void Them(string ten, string diaChi, string linhVuc, string email, string sdt)
        {
            Validate(ten, linhVuc, email, sdt);
            _dal.Them(ten.Trim(), diaChi?.Trim() ?? "", linhVuc.Trim(), email.Trim(), sdt.Trim());
        }

        public void CapNhat(int ma, string ten, string diaChi, string linhVuc, string email, string sdt)
        {
            if (ma <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");

            Validate(ten, linhVuc, email, sdt);
            _dal.CapNhat(ma, ten.Trim(), diaChi?.Trim() ?? "", linhVuc.Trim(), email.Trim(), sdt.Trim());
        }

        public void Xoa(int ma)
        {
            if (ma <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");
            _dal.Xoa(ma);
        }

        public DataTable GetHopDongCuaKhachHang(int maKH)
        {
            if (maKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");
            return _dal.GetHopDongCuaKhachHang(maKH);
        }

        private void Validate(string ten, string linhVuc, string email, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ten))
                throw new ArgumentException("Vui lòng nhập Tên khách hàng!");

            if (string.IsNullOrWhiteSpace(linhVuc))
                throw new ArgumentException("Vui lòng nhập Lĩnh vực hoạt động!");

            if (string.IsNullOrWhiteSpace(sdt))
                throw new ArgumentException("Vui lòng nhập Số điện thoại!");

            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải gồm đúng 10 chữ số!");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Vui lòng nhập Email!");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email không đúng định dạng!");
        }
    }
}
