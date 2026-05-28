using System;
using System.Data;
using QLQC.DAL;

namespace QLQC.BLL
{
    public class BieuDoBLL
    {
        private readonly BieuDoDAL _dal = new BieuDoDAL();

        public DataTable GetDoanhThuTheoNam(int nam)
        {
            return _dal.GetDoanhThuTheoNam(nam);
        }

        public DataTable GetDoanhThuTheoThang(int nam, int thang)
        {
            return _dal.GetDoanhThuTheoThang(nam, thang);
        }

        public DataTable GetHopDongTheoTrangThai(int nam, int thang)
        {
            return _dal.GetHopDongTheoTrangThai(nam, thang);
        }

        public DataTable GetBaiVietTheoTrangThai(int nam, int thang)
        {
            return _dal.GetBaiVietTheoTrangThai(nam, thang);
        }

        public double[] BuildLuyKe(double[] revenueValues)
        {
            if (revenueValues == null) return new double[0];
            double[] cumulative = new double[revenueValues.Length];
            double sum = 0;
            for (int i = 0; i < revenueValues.Length; i++)
            {
                sum += revenueValues[i];
                cumulative[i] = sum;
            }
            return cumulative;
        }
    }
}
