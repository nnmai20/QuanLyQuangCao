using System;
using System.Data;
using QuanLyQuangCao.DAL;

namespace QuanLyQuangCao.BLL
{
public class BaiVietBLL
{
BaiVietDAL dal = new BaiVietDAL();

    // LOAD DANH SÁCH BÀI VIẾT
    public DataTable LayDanhSachBaiViet()
    {
        return dal.LayDanhSachBaiViet();
    }

    // LOAD HỢP ĐỒNG
    public DataTable LayHopDong()
    {
        return dal.LayHopDong();
    }

    // LOAD THỂ LOẠI
    public DataTable LayTheLoai()
    {
        return dal.LayTheLoai();
    }

    // LOAD NHÂN VIÊN
    public DataTable LayNhanVien()
    {
        return dal.LayNhanVien();
    }

    // THÊM BÀI VIẾT
    public bool ThemBaiViet(
        string tieuDe,
        string trangThai,
        string noiDung,
        string ghiChu,
        DateTime ngayNop,
        DateTime ngayDuyet,
        DateTime ngayDang,
        int maTheLoai,
        int maHopDong,
        int maNguoiDung)
    {
        return dal.ThemBaiViet(
            tieuDe,
            trangThai,
            noiDung,
            ghiChu,
            ngayNop,
            ngayDuyet,
            ngayDang,
            maTheLoai,
            maHopDong,
            maNguoiDung);
    }

    // SỬA BÀI VIẾT
    public bool SuaBaiViet(
        int maBaiViet,
        string tieuDe,
        string trangThai,
        string noiDung,
        string ghiChu,
        DateTime ngayNop,
        DateTime ngayDuyet,
        DateTime ngayDang,
        int maTheLoai,
        int maHopDong,
        int maNguoiDung)
    {
        return dal.SuaBaiViet(
            maBaiViet,
            tieuDe,
            trangThai,
            noiDung,
            ghiChu,
            ngayNop,
            ngayDuyet,
            ngayDang,
            maTheLoai,
            maHopDong,
            maNguoiDung);
    }

    // XÓA BÀI VIẾT
    public bool XoaBaiViet(int maBaiViet)
    {
        return dal.XoaBaiViet(maBaiViet);
    }
}

}
