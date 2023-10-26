using BussinessLayer;
using DataLayer.model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class frmKyCong : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_PayPeriod KyCongDAL;
        private BussinessLayer.KyCong KyCongBUS;
        private bool _isNewRecord;
        public frmKyCong()
        {
            InitializeComponent();
            KyCongDAL = new tb_PayPeriod();
            KyCongBUS = new KyCong();

           
            txt_MaKyCong.Enabled = !Enabled;
            //txt_MaKyCong.Text  = (cbbThang.SelectedItem.ToString()+cbbNam.SelectedItem.ToString());

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_PayPeriod.
                    Select(item => new
                    {
                        item.PayPeriodID,
                        item.Month,
                        item.Year,
                        item.WorkDayInMonth,
                    }).ToList();
            }

            /* bindinglist.Clear();
             foreach (tb_EmployeeAllowanceJob job in nhanvienphucapBus.GetTb_EmployeeAllowanceJobs())
             {
                 bindinglist.Add(job);
             }*/
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isNewRecord = true;
            ToggleFormState(false);
            ClearForm();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isFormPainted = false;
            ToggleFormState(false);
            cbbThang.Enabled = !Enabled;
            cbbNam.Enabled = !Enabled;

            ClearForm();
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int rowIndex = gcDanhSach.FocusedView.DataRowCount;
                if (rowIndex > 0)
                {
                    var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
                    if (focusedObject != null)
                    {
                        int payPeriodIDss =(int) focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject);

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa nhan vien thoi viec có ID là  {payPeriodIDss} không?", " Xóa thôi việc nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                          
                            KyCongBUS.Deletetb_PayPeriod(payPeriodIDss);
                            MessageBox.Show("xóa nhân viên thoi viec thành công ", "thông báo");
                            LoadData();
                        }

                    }
                    else
                    {
                        throw new Exception("data không đúng ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_isNewRecord)
            {
                if (string.IsNullOrEmpty(cbbThang.Text) || string.IsNullOrEmpty(cbbNam.Text) ||
                    string.IsNullOrEmpty(cbb_ngaylamviec.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (KyCongBUS.ResignationIDExists(int.Parse(cbbThang.SelectedItem.ToString() + cbbNam.SelectedItem.ToString())))
                {
                    MessageBox.Show("vui lòng chọn tháng năm  khác tháng năm này đã tồn tại");
                }
                else
                {

                    tb_PayPeriod newpayperiod = new tb_PayPeriod
                    {

                        PayPeriodID = int.Parse(((cbbThang.Text).ToString() + (cbbNam.Text).ToString())),
                        Month =byte.Parse( cbbThang.Text),
                        Year = int.Parse(cbbNam.Text),
                        WorkDayInMonth=byte.Parse(cbb_ngaylamviec.Text)
                    };
                    KyCongBUS.Addtb_PayPeriod(newpayperiod);
                    LoadData();
                    //bindinglist.Add(newEmployeeallowanceJob);
                    MessageBox.Show("thêm 1 kỳ công mới thành công ", "thông báo");
                    _isNewRecord = false;
                    ToggleFormState(true);
                    ClearForm();
                }
            }
            else
            {
                using (var conn = new DBcontext())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(cbb_ngaylamviec.Text))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                        }
                        else if (KyCongBUS.ResignationIDExists
                            (int.Parse(cbbThang.SelectedItem.ToString() + cbbNam.SelectedItem.ToString())))
                        {
                            MessageBox.Show("vui lòng chọn Ngày tháng khác ngày tháng này đã tồn tại");
                        }

                        else
                        {
                            int rowIndex = gcDanhSach.FocusedView.DataRowCount;
                            if (rowIndex > 0)
                            {
                                var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
                                if (focusedObject != null)
                                {
                                    using (var transaction = conn.Database.BeginTransaction())
                                    {
                                        try
                                        {
                                          int PayperiodIDs =(int) focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject);
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa kỳ công có ID là  {PayperiodIDs} không?", "Sửa Kỳ Công", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {
                                                tb_PayPeriod PayPerioddID1 = conn.tb_PayPeriod.FirstOrDefault(j => j.PayPeriodID == PayperiodIDs);
                                                if (PayPerioddID1 != null)
                                                {

                                                    PayPerioddID1.WorkDayInMonth = byte.Parse(cbb_ngaylamviec.Text);
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa  Kỳ công  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("ko có Kỳ Công nao");
                                                }
                                            }

                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("Error while edit payperiod: " + ex.InnerException.Message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void ToggleFormState(bool isEnabled)
        {
            btnThem.Enabled = isEnabled;
            btnSua.Enabled = isEnabled;
            btnLuu.Enabled = !isEnabled;
            btnKhongLuu.Enabled = !isEnabled;
            btnThoat.Enabled = isEnabled;
            btnXoa.Enabled = isEnabled;

            cbbThang.Enabled = !isEnabled;
            cbbNam.Enabled = !isEnabled;
            cbb_ngaylamviec.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {

            txt_MaKyCong.Text = string.Empty;
            cbbThang.Text = string.Empty;
            cbbNam.Text = string.Empty;
            cbb_ngaylamviec.Text = string.Empty;
        }

        private void btnKhongLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ToggleFormState(true);
            LoadData();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void frmthoiviecnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình ky cong?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txt_MaKyCong.Text = focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject).ToString();
            cbbThang.Text = focusedObject.GetType().GetProperty("Month").GetValue(focusedObject).ToString();
            cbbThang.Text = focusedObject.GetType().GetProperty("Year").GetValue(focusedObject).ToString();
            cbb_ngaylamviec.Text = focusedObject.GetType().GetProperty("WorkDayInMonth").GetValue(focusedObject).ToString();
        }
    }
}