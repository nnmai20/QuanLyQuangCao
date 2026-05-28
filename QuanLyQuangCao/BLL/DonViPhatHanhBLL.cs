using System;
using System.Data;
using System.Text.RegularExpressions;
using QLQC.DAL;

namespace QLQC.BLL
{
    public class DonViPhatHanhBLL
    {
        private readonly DonViPhatHanhDAL _dal = new DonViPhatHanhDAL();

        public DataTable GetAll(string tenFilter = "", string ttFilter = "")
        {
            return _dal.GetAll(tenFilter, ttFilter);
        }

        public void Them(string ten, string diaChi, string email, string sdt, string nguoiLH, int trangThai)
        {
            Validate(ten, sdt, nguoiLH, email, diaChi);
            _dal.Them(ten.Trim(), diaChi.Trim(), email.Trim(), sdt.Trim(), nguoiLH.Trim(), trangThai);
        }

        public void CapNhat(int ma, string ten, string diaChi, string email, string sdt, string nguoiLH, int trangThai)
        {
            if (ma <= 0)
                throw new ArgumentException("Mã đơn vị không hợp lệ!");

            Validate(ten, sdt, nguoiLH, email, diaChi);
            _dal.CapNhat(ma, ten.Trim(), diaChi.Trim(), email.Trim(), sdt.Trim(), nguoiLH.Trim(), trangThai);
        }

        public void Xoa(int ma)
        {
            if (ma <= 0)
                throw new ArgumentException("Mã đơn vị không hợp lệ!");
            _dal.Xoa(ma);
        }

        private void Validate(string ten, string sdt, string nguoiLH, string email, string diaChi)
        {
            if (string.IsNullOrWhiteSpace(ten))
                throw new ArgumentException("Vui lòng nhập Tên đơn vị!");

            if (string.IsNullOrWhiteSpace(sdt))
                throw new ArgumentException("Vui lòng nhập Số điện thoại!");

            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
                throw new ArgumentException("Số điện thoại phải đúng 10 chữ số!");

            if (string.IsNullOrWhiteSpace(nguoiLH))
                throw new ArgumentException("Vui lòng nhập Người liên hệ!");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Vui lòng nhập Email!");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email không đúng định dạng!");

            if (string.IsNullOrWhiteSpace(diaChi))
                throw new ArgumentException("Vui lòng nhập Địa chỉ!");
        }
    }
}
