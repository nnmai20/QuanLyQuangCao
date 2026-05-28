using System;
using System.Data;
using System.Collections.Generic;

namespace AuthForms.BLL
{
    public class KhachHangBLL
    {
        private static readonly List<string> PredefinedCustomers = new List<string>
        {
            "Công ty TNHH ABC", 
            "Tập đoàn XYZ", 
            "Cty CP Minh Phát", 
            "Siêu thị BigMart",
            "Nhà hàng Phở Ngon", 
            "Bệnh viện Đa Khoa Tâm", 
            "Bệnh viện Quốc Tế Hà Nội",
            "Chuỗi cà phê The Bloom", 
            "Công ty Địa ốc Phát Đạt", 
            "Công ty Du lịch Xanh",
            "Công ty May Việt Tiến", 
            "Công ty Phần mềm NextGen", 
            "Công ty Vận tải Nhanh",
            "Cty TNHH Điện Tử Sao", 
            "Hãng xe Toyota VN", 
            "Ngân hàng Đông A",
            "Nhà sách Văn Lang", 
            "Resort Biển Xanh", 
            "Siêu thị Co.opmart",
            "Siêu thị Điện Máy Xanh", 
            "Tập đoàn FPT", 
            "Tập đoàn Thực phẩm Sạch",
            "Trung tâm Anh ngữ Apollo", 
            "Trường ĐH Bách Khoa"
        };

        public DataTable GetAll()
        {
            var dt = new DataTable();
            dt.Columns.Add("MaKhachHang", typeof(int));
            dt.Columns.Add("TenKhachHang", typeof(string));

            for (int i = 0; i < PredefinedCustomers.Count; i++)
            {
                dt.Rows.Add(i + 1, PredefinedCustomers[i]);
            }
            return dt;
        }

        public string GetNameById(int id)
        {
            if (id > 0 && id <= PredefinedCustomers.Count)
                return PredefinedCustomers[id - 1];
            return "Khách hàng vãng lai";
        }

        public int GetIdByName(string name)
        {
            int idx = PredefinedCustomers.FindIndex(c => c.Equals(name, StringComparison.OrdinalIgnoreCase));
            return idx >= 0 ? idx + 1 : 1;
        }
    }
}
