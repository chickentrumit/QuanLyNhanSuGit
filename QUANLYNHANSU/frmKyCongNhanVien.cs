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
    public partial class frmKyCongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_EmployeePayperiod nhanvienkyCongDAL;
        private BussinessLayer.KyCongNhanVien nhanvienkycongBUS;
        private bool _isNewRecord;
        public frmKyCongNhanVien()
        {
            InitializeComponent();
            nhanvienkyCongDAL = new tb_EmployeePayperiod();
            nhanvienkycongBUS = new KyCongNhanVien();

            using (var conn = new DBcontext())
            {
                //lay ma nhan vien
                cbbMaNhanVien.DataSource = conn.tb_Employee.ToList();
                cbbMaNhanVien.DisplayMember = "EmployeeID";
                cbbMaNhanVien.ValueMember = "EmployeeID";



                //lay id ky cong
                cbbMaKyCong.DataSource = conn.tb_PayPeriod.ToList();
                cbbMaKyCong.DisplayMember = "PayPeriodID";
                cbbMaKyCong.ValueMember = "PayPeriodID";



            }
            txtTenNhanVien.Enabled = !Enabled;

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_EmployeePayperiod.
                    Select(item => new
                    {

                        item.EmployeePayperiodID,
                        item.PayPeriodID, 
                        item.EmployeeID,
                        item.tb_Employee.FullName,
                        item.WorkdayMonth,
                        item.PermittedDayOff,
                        item.UnauthorizedDayOff,
                        item.HolidayWork,
                        item.SundayWork
                    }).ToList();
            }
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
                        int EmployeePayperiod =(int) focusedObject.GetType().GetProperty("EmployeePayperiodID").GetValue(focusedObject);

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa kỳ công nhân viên có ID là  {EmployeePayperiod} không?", " Xóa Kỳ Công Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            nhanvienkycongBUS.DeleteEmployeePayperiod(EmployeePayperiod);
                            MessageBox.Show("xóa  Kỳ Công Nhân Viên thành công ", "thông báo");
                            LoadData();
                        }

                    }
                    else
                    {
                        throw new Exception("dữ liệu không đúng ");
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
                if (string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtCongChuNhat.Text) ||
                    string.IsNullOrEmpty(cbbMaKyCong.Text) || string.IsNullOrEmpty(cbbMaNhanVien.Text) ||
                    string.IsNullOrEmpty(txtNgayLamViec.Text) || string.IsNullOrEmpty(txtCongKyNghi.Text)||
                    string.IsNullOrEmpty(txtNghiCoPhep.Text)|| string.IsNullOrEmpty(txtNghiKhongPhep.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (!(txtCongChuNhat.MaskCompleted && txtCongKyNghi.MaskCompleted && txtNghiCoPhep.MaskCompleted && txtNghiKhongPhep.MaskCompleted))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ 2 số trước và sau dấu chấm __.__ ");
                }
                else
                {
                    try
                    {
                        tb_EmployeePayperiod newEmployeePayperiod = new tb_EmployeePayperiod
                        {
                            EmployeeID = cbbMaNhanVien.Text,
                            PayPeriodID = int.Parse(cbbMaKyCong.Text),
                            WorkdayMonth = int.Parse(txtNgayLamViec.Text),
                            PermittedDayOff = double.Parse(txtNghiCoPhep.Text),
                            UnauthorizedDayOff = double.Parse(txtNghiKhongPhep.Text),
                            HolidayWork = double.Parse(txtCongKyNghi.Text),
                            SundayWork = double.Parse(txtCongChuNhat.Text),
                            CreatedBy = "Trần Nhật Phi",
                            CreatedDate = DateTime.Now,
                        };
                        nhanvienkycongBUS.AddEmployeePayperiod(newEmployeePayperiod);
                        LoadData();
                        //bindinglist.Add(newEmployeeallowanceJob);
                        MessageBox.Show("thêm 1 kỳ công nhân viên mới thành công ", "thông báo");
                        _isNewRecord = false;
                        ToggleFormState(true);
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi:"+ex.Message);
                    }
                    
                }

            }
            else
            {
                using (var conn = new DBcontext())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtCongChuNhat.Text) ||
                     string.IsNullOrEmpty(cbbMaKyCong.Text) || string.IsNullOrEmpty(cbbMaNhanVien.Text) ||
                     string.IsNullOrEmpty(txtNgayLamViec.Text) || string.IsNullOrEmpty(txtCongKyNghi.Text) ||
                     string.IsNullOrEmpty(txtNghiCoPhep.Text) || string.IsNullOrEmpty(txtNghiKhongPhep.Text))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                        }
                        else if (!(txtCongChuNhat.MaskCompleted && txtCongKyNghi.MaskCompleted && txtNghiCoPhep.MaskCompleted && txtNghiKhongPhep.MaskCompleted))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ 2 số trước và sau dấu chấm __.__ ");
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
                                            int employeepayperiodID =(int) focusedObject.GetType().GetProperty("EmployeePayperiodID").GetValue(focusedObject);
                                            tb_EmployeePayperiod employeePayperiodID = conn.tb_EmployeePayperiod.FirstOrDefault(j => j.EmployeePayperiodID == employeepayperiodID);
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa Kỳ Công Nhân Viên có ID là  {employeepayperiodID} không?", " Sửa kỳ Công Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {

                                                if (employeePayperiodID != null)
                                                {


                                                    employeePayperiodID.EmployeeID = cbbMaNhanVien.Text;
                                                    employeePayperiodID.PayPeriodID = int.Parse(cbbMaKyCong.Text);
                                                    employeePayperiodID.WorkdayMonth = int.Parse(txtNgayLamViec.Text);
                                                    employeePayperiodID.PermittedDayOff = double.Parse(txtNghiCoPhep.Text);
                                                    employeePayperiodID.UnauthorizedDayOff = double.Parse(txtNghiKhongPhep.Text);
                                                    employeePayperiodID.HolidayWork = double.Parse(txtCongKyNghi.Text);
                                                    employeePayperiodID.SundayWork = double.Parse(txtCongChuNhat.Text);
                                                    employeePayperiodID.UpdatedDate = DateTime.Now;
                                                    employeePayperiodID.UpdatedBy = "Trần Nhật Phi";
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa kỳ công nhân viên  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Không Có Nhân Viên nào");
                                                }
                                            }
                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi khi sửa nhân viên: " + ex.InnerException.Message);
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
            cbbMaKyCong.Enabled = !isEnabled;
            cbbMaNhanVien.Enabled = !isEnabled;
            txtNgayLamViec.Enabled = !isEnabled;
            txtCongChuNhat.Enabled = !isEnabled;
            txtCongKyNghi.Enabled = !isEnabled;
            txtNghiCoPhep.Enabled = !isEnabled;
            txtNghiKhongPhep.Enabled = !isEnabled;

            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {
            txtTenNhanVien.Text = string.Empty;
            cbbMaKyCong.Text = string.Empty;
            cbbMaNhanVien.Text = string.Empty;
            txtNgayLamViec.Text = string.Empty;
            txtCongChuNhat.Text = string.Empty;
            txtCongKyNghi.Text = string.Empty;
            txtNghiCoPhep.Text = string.Empty;
            txtNghiKhongPhep.Text= string.Empty;
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



        private void cbb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaNhanVien.SelectedItem != null)
            {
                // Get the selected employee from the ComboBox
                var selectedEmployee = (tb_Employee)cbbMaNhanVien.SelectedItem;

                // Update txtTenNhanVien with the Full Name of the selected employee
                txtTenNhanVien.Text = selectedEmployee.FullName;
            }
        }
        private void cbbMaKyCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaKyCong.SelectedItem != null)
            {
                // Get the selected employee from the ComboBox
                var selectedPayperiod = (tb_PayPeriod)cbbMaKyCong.SelectedItem;

                // Update txtTenNhanVien with the Full Name of the selected employee
                txtNgayLamViec.Text = selectedPayperiod.WorkDayInMonth.ToString();
            }
        }

        private void frmKyLuatNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình Kỳ Công?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtNgayLamViec.Text = focusedObject.GetType().GetProperty("WorkdayMonth").GetValue(focusedObject).ToString();
            cbbMaKyCong.Text = focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject).ToString();
            cbbMaNhanVien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txtTenNhanVien.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            txtCongChuNhat.Text = focusedObject.GetType().GetProperty("SundayWork").GetValue(focusedObject).ToString();
            txtCongKyNghi.Text = focusedObject.GetType().GetProperty("HolidayWork").GetValue(focusedObject).ToString();
            txtNghiKhongPhep.Text = focusedObject.GetType().GetProperty("UnauthorizedDayOff").GetValue(focusedObject).ToString();
            txtNghiCoPhep.Text = focusedObject.GetType().GetProperty("PermittedDayOff").GetValue(focusedObject).ToString();
        }

        
    }
}