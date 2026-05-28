using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuangCao.Forms;

namespace QuanLyQuangCao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Vòng lặp: mở Login → nếu OK thì mở Main → nếu Cancel (đăng xuất) thì mở lại Login
            while (true)
            {
                frmLogin frmLogin = new frmLogin();
                if (frmLogin.ShowDialog() != DialogResult.OK)
                    break; // Người dùng đóng cửa sổ Login → thoát ứng dụng

                frmMain frmMain = new frmMain();
                frmMain.NguoiDungHienTai = frmLogin.NguoiDungHienTai;

                Application.Run(frmMain); // Chạy form chính

                // Nếu frmMain đóng với DialogResult.Cancel → đăng xuất → lặp lại để mở Login
                if (frmMain.DialogResult != DialogResult.Cancel)
                    break; // Thoát hẳn ứng dụng nếu không phải đăng xuất
            }
        }
    }
}
