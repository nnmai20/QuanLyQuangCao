using System.Data;
using QuanLyQuangCao.DAL;

namespace QuanLyQuangCao.BLL
{
    public class DonViDangBaiBLL
    {
        DonViDangBaiDAL dal = new DonViDangBaiDAL();

        public DataTable LayDanhSachDonVi()
        {
            return dal.LayDanhSachDonVi();
        }
    }
}