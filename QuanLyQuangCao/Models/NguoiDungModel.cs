using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuangCao.Models
{
    public class NguoiDungModel
    {
        public int MaNguoiDung { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; } // Chỉ dùng khi tạo mới
        public string Salt { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string VaiTro { get; set; }
        public int TrangThaiHoatDong { get; set; }
    }
}
