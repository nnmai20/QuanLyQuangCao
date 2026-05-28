using System;
using System.Data;
using QLQC.DAL;

namespace QLQC.BLL
{
    public class ThongKeBaiVietBLL
    {
        private readonly ThongKeBaiVietDAL _dal = new ThongKeBaiVietDAL();

        public DataTable GetNhanVienVietBai()
        {
            return _dal.GetNhanVienVietBai();
        }

        public DataTable GetBaiVietThongKe(DateTime tuNgay, DateTime denNgay, string trangThaiFilter = "", int maNhanVienFilter = 0)
        {
            if (tuNgay > denNgay)
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");

            return _dal.GetBaiVietThongKe(tuNgay, denNgay, trangThaiFilter, maNhanVienFilter);
        }
    }
}
