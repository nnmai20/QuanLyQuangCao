using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyQuangCao.Database
{
    public class  DBConnection
    {
        protected SqlConnection conn =
            new SqlConnection(
                @"Data Source=DUYENNT86\SQLEXPRESS_2022;
                  Initial Catalog=QuanLyQuangCao;
                  Integrated Security=True");
    }
}
