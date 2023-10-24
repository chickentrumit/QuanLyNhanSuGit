using DataLayer.model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QUANLYNHANSU
{
    public partial class frmPhanQuyenTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyenTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmPhanQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            using(var conn = new DBcontext())
            {
                gcTaiKhoan.DataSource = conn.tb_Account.ToList();
            }
        }
    }
}