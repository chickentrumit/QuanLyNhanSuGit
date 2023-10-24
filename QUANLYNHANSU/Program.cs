using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPhuCap());
            ////Application.Run(new frmMainForm());
            ////Application.Run(new frmDoiMatKhauMoi());
            ////Application.Run(new frmHopDongLaoDong());
            //Application.Run(new frmPhuCapNhanVien());
            //Application.Run(new frmKyLuatNhanVien());
            //Application.Run(new frmKhenThuongNhanVien());
            // Application.Run(new frmLoaiCa());
            //Application.Run(new frmLoaiCong());
            //Application.Run(new frmUngLuongNhanVien());
            //Application.Run(new frmThoiViecNhanVien());
            //Application.Run(new frmKyCong());
            //Application.Run(new frmBHYT());
            //Application.Run(new frmBHXH());
            //Application.Run(new frmKyCongNhanVien());
            Application.Run(new frmPhanQuyenTaiKhoan());
        }
    }
}
