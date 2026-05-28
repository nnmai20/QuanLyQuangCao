using System;
using System.Collections.Generic;
using System.Data;
using QlyHopDong.DAL;
using QlyHopDong.DTO;

namespace QlyHopDong.BLL
{
    
    public class HopDongBLL
    {
        private readonly HopDongDAL _dal = new HopDongDAL();

        
        public List<HopDongDTO> GetAll() => _dal.GetAll();
        public HopDongDTO GetByMa(int maHopDong) => _dal.GetByMa(maHopDong);
        public List<HopDongDTO> Search(string kw, string tt) => _dal.Search(kw, tt);

        public int Add(HopDongDTO dto)
        {
            Validate(dto);
            return _dal.Add(dto);   
        }

        public bool Update(HopDongDTO dto)
        {
            if (dto.MaHopDong <= 0) throw new Exception("Mã hợp đồng không hợp lệ.");
            Validate(dto);
            return _dal.Update(dto);
        }

        public bool Delete(int maHopDong)
        {
            if (maHopDong <= 0) throw new Exception("Mã hợp đồng không hợp lệ.");
            return _dal.Delete(maHopDong);
        }

        // ── Danh mục cho ComboBox ────────────────────
        public DataTable GetDanhSachKhachHang() => _dal.GetDanhSachKhachHang();
        public DataTable GetDanhSachNhanVien() => _dal.GetDanhSachNhanVien();

        
        /// Danh sách trạng thái
       
        public static List<string> GetDanhSachTrangThai() => new List<string>
        {
            "Đang chờ xử lý",
            "Đang xử lý",
            "Đã đăng",
            "Đã kết thúc",
            "Hủy"
        };

        
        /// Màu badge cho từng trạng thái — dùng ở UI_HopDong.
        
        public static void GetBadgeColor(string trangThai,
            out System.Drawing.Color bgColor, out System.Drawing.Color textColor)
        {
            switch (trangThai)
            {
                case "Đang xử lý":
                    bgColor = System.Drawing.Color.FromArgb(209, 236, 241);
                    textColor = System.Drawing.Color.FromArgb(31, 119, 180);
                    break;
                case "Đang chờ xử lý":
                    bgColor = System.Drawing.Color.FromArgb(255, 243, 205);
                    textColor = System.Drawing.Color.FromArgb(180, 120, 20);
                    break;
                case "Đã đăng":
                    bgColor = System.Drawing.Color.FromArgb(212, 237, 218);
                    textColor = System.Drawing.Color.FromArgb(40, 167, 69);
                    break;
                case "Đã kết thúc":
                    bgColor = System.Drawing.Color.FromArgb(220, 220, 220);
                    textColor = System.Drawing.Color.FromArgb(90, 90, 90);
                    break;
                case "Hủy":
                    bgColor = System.Drawing.Color.FromArgb(248, 215, 218);
                    textColor = System.Drawing.Color.FromArgb(220, 53, 69);
                    break;
                default:
                    bgColor = System.Drawing.Color.FromArgb(230, 230, 230);
                    textColor = System.Drawing.Color.FromArgb(100, 100, 100);
                    break;
            }
        }

        // ── Validation nghiệp vụ ────────────────────
        private void Validate(HopDongDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            if (dto.MaKhachHang <= 0)
                throw new Exception("Vui lòng chọn khách hàng.");

            if (dto.MaNguoiDung <= 0)
                throw new Exception("Vui lòng chọn nhân viên phụ trách.");

            if (string.IsNullOrWhiteSpace(dto.LoaiHopDong))
                throw new Exception("Loại hợp đồng không được để trống.");

            if (string.IsNullOrWhiteSpace(dto.TrangThaiHopDong))
                throw new Exception("Trạng thái không được để trống.");

            // Kiểm tra trạng thái nằm trong danh sách hợp lệ (khớp CHECK CONSTRAINT)
            var ttHopLe = GetDanhSachTrangThai();
            if (!ttHopLe.Contains(dto.TrangThaiHopDong))
                throw new Exception($"Trạng thái '{dto.TrangThaiHopDong}' không hợp lệ.");

            if (dto.TongGiaTri < 0)
                throw new Exception("Tổng giá trị không được âm.");

            if (dto.SoTienDaThanhToan < 0)
                throw new Exception("Số tiền đã thanh toán không được âm.");

            if (dto.SoTienDaThanhToan > dto.TongGiaTri)
                throw new Exception("Đã thanh toán không được lớn hơn tổng giá trị.");

            if (dto.NgayBatDau.HasValue && dto.NgayKy.HasValue
                && dto.NgayBatDau.Value < dto.NgayKy.Value)
                throw new Exception("Ngày bắt đầu không được trước ngày ký.");

            if (dto.NgayKetThuc.HasValue && dto.NgayBatDau.HasValue
                && dto.NgayKetThuc.Value < dto.NgayBatDau.Value)
                throw new Exception("Ngày kết thúc không được trước ngày bắt đầu.");
        }
    }
}