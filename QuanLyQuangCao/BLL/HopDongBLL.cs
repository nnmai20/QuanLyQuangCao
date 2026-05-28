using System;
using System.Data;
using AuthForms.DAL;

namespace AuthForms.BLL
{
    public class HopDongBLL
    {
        // ── Các trạng thái hợp lệ theo CHECK CONSTRAINT trong DB ──
        public static readonly string[] DanhSachTrangThai =
        {
            "Đang chờ xử lý", "Đang xử lý", "Đã đăng", "Đã kết thúc", "Hủy"
        };

        // ── Các loại hợp đồng gợi ý ──
        public static readonly string[] DanhSachLoaiHopDong =
        {
            "Hợp đồng quảng cáo trang bìa",
            "Hợp đồng quảng cáo nửa trang",
            "Hợp đồng quảng cáo 1/4 trang",
            "Hợp đồng quảng cáo cả trang",
            "Hợp đồng quảng cáo tuyển sinh",
            "Hợp đồng quảng cáo dự án BĐS",
            "Hợp đồng quảng cáo sản phẩm",
            "Hợp đồng quảng cáo du lịch",
            "Hợp đồng quảng cáo chuyên trang",
            "Hợp đồng quảng cáo tạp chí cao cấp"
        };

        // ──────────────────────────────────────────────────────────
        //  Instance CRUD (dùng cho frmMain)
        // ──────────────────────────────────────────────────────────
        public DataTable GetAll()   => HopDongDAL.GetAll();

        public DataTable Search(string keyword) => HopDongDAL.Search(keyword);

        public void Insert(HopDongRow row)
        {
            HopDongDAL.Insert(
                row.LoaiHopDong, row.TrangThai,
                row.NgayKy, row.TongGiaTri, row.DaThanhToan,
                row.GhiChu, row.NgayBatDau, row.NgayKetThuc,
                row.MaKhachHang, row.MaNguoiDung);
        }

        public void Update(HopDongRow row)
        {
            HopDongDAL.Update(
                row.Id,
                row.LoaiHopDong, row.TrangThai,
                row.NgayKy, row.TongGiaTri, row.DaThanhToan,
                row.GhiChu, row.NgayBatDau, row.NgayKetThuc,
                row.MaKhachHang, row.MaNguoiDung);
        }

        public void Delete(int id) => HopDongDAL.Delete(id);

        // ──────────────────────────────────────────────────────────
        //  Static helpers dùng cho frmBaoCaoDoanhThu & frmThongKeHopDong
        // ──────────────────────────────────────────────────────────
        public static DataTable LayDoanhThu(int loaiIdx, int nam, int thang, DateTime tuNgay, DateTime denNgay)
        {
            if (loaiIdx == 3) return HopDongDAL.LayDoanhThuTheoKhoangNgay(tuNgay.Date, denNgay.Date);
            if (loaiIdx == 0) return HopDongDAL.LayDoanhThuTheoNgayTrongThang(nam, thang);
            if (loaiIdx == 1) return HopDongDAL.LayDoanhThuTheoThangTrongNam(nam);
            return HopDongDAL.LayDoanhThuTheoNam();
        }

        public static DataTable LayTongHopTheoThang(int nam, int thang)
            => HopDongDAL.LayTongHopTheoThang(nam, thang);

        public static DataTable LayTheoTrangThai(int nam, int thang)
            => HopDongDAL.LayTheoTrangThai(nam, thang);

        public static DataTable LayTongHopKhoangNgay(DateTime tuNgay, DateTime denNgay)
            => HopDongDAL.LayTongHopKhoangNgay(tuNgay.Date, denNgay.Date);

        public static DataTable LayTrangThaiKhoangNgay(DateTime tuNgay, DateTime denNgay)
            => HopDongDAL.LayTrangThaiKhoangNgay(tuNgay.Date, denNgay.Date);

        public static KpiHopDongDto LayKPITongHop(int nam, int thang)
            => HopDongDAL.LayKPITongHop(nam, thang);

        public static KpiHopDongDto LayKPIKhoangNgay(DateTime tuNgay, DateTime denNgay)
            => HopDongDAL.LayKPIKhoangNgay(tuNgay.Date, denNgay.Date);

        public static (decimal hienTai, decimal kyTruoc) LayTangTruong(
            int loaiIdx, int nam, int thang, DateTime tuNgay, DateTime denNgay)
            => HopDongDAL.LayTangTruong(loaiIdx, nam, thang, tuNgay.Date, denNgay.Date);

        public static DataTable LayDanhSachHopDong(int nam, int thang, DateTime tuNgay, DateTime denNgay, bool isKhoangNgay)
            => HopDongDAL.LayDanhSachHopDong(nam, thang, tuNgay.Date, denNgay.Date, isKhoangNgay);
    }
}
