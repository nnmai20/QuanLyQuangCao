using System.Data;
using QuanLyQuangCao.DAL;
using QuanLyQuangCao.Models;

namespace QuanLyQuangCao.BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL dal = new TheLoaiDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(TheLoaiBaiViet tl)
        {
            if (string.IsNullOrWhiteSpace(tl.TenTheLoai))
            {
                return false;
            }

            return dal.Insert(tl);
        }

        public bool Update(TheLoaiBaiViet tl)
        {
            if (string.IsNullOrWhiteSpace(tl.TenTheLoai))
            {
                return false;
            }

            return dal.Update(tl);
        }

        public bool Delete(int ma)
        {
            return dal.Delete(ma);
        }

        public DataTable Search(string tukhoa)
        {
            return dal.Search(tukhoa);
        }
    }
}