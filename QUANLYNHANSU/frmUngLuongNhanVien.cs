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
    public partial class frmUngLuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_SalaryAdvance ungluongnhanvienDAL;
        private BussinessLayer.ungluongnhanvien ungluongnhanvienBUS;
        private bool _isNewRecord;
        public frmUngLuongNhanVien()
        {
            InitializeComponent();
            ungluongnhanvienDAL = new tb_SalaryAdvance();
            ungluongnhanvienBUS = new ungluongnhanvien();

            using (var conn = new DBcontext())
            {
                //lay ma nhan vien
                cbb_MaNhanVien.DataSource = conn.tb_Employee.ToList();
                cbb_MaNhanVien.DisplayMember = "EmployeeID";
                cbb_MaNhanVien.ValueMember = "EmployeeID";



                //lay id ky cong
                cbb_MaKyCong.DataSource = conn.tb_PayPeriod.ToList();
                cbb_MaKyCong.DisplayMember = "PayPeriodID";
                cbb_MaKyCong.ValueMember = "PayPeriodID";


            }
            txt_TenNhanVien.Enabled = !Enabled;

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_SalaryAdvance.
                    Select(item => new
                    {
                        item.SalaryAdvanceID,
                        item.EmployeeID, 
                        item.tb_Employee.FullName,
                        item.PayPeriodID,
                        item.AdvanceAmount,
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
                        int employeesalaryadvance =(int)focusedObject.GetType().GetProperty("SalaryAdvanceID").GetValue(focusedObject);

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa tạm ứng nhan vien  có ID là  {employeesalaryadvance} không?", " Xóa tạm ứng lương nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            ungluongnhanvienBUS.DeletesalaryAdvance(employeesalaryadvance);
                            MessageBox.Show("xóa  tạm ứng  nhân viên thành công ", "thông báo");
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
                if (string.IsNullOrEmpty(txt_SoTienTamUng.Text) || string.IsNullOrEmpty(txt_TenNhanVien.Text)||
                    string.IsNullOrEmpty(cbb_MaKyCong.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    tb_SalaryAdvance newsalaryadvance = new tb_SalaryAdvance
                    {

                        EmployeeID = cbb_MaNhanVien.Text,
                        PayPeriodID = int.Parse(cbb_MaKyCong.Text),
                        AdvanceAmount = int.Parse(txt_SoTienTamUng.Text),
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,

                    };
                    ungluongnhanvienBUS.AddSalaryadvance(newsalaryadvance);
                    LoadData();
                    //bindinglist.Add(newEmployeeallowanceJob);
                    MessageBox.Show("thêm 1 kỹ luật nhân viên mới thành công ", "thông báo");
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
                        if (string.IsNullOrEmpty(txt_SoTienTamUng.Text) || string.IsNullOrEmpty(txt_TenNhanVien.Text) ||
                    string.IsNullOrEmpty(cbb_MaKyCong.Text))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ thông tin");
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
                                            int salaryADVANCEID = (int)focusedObject.GetType().GetProperty("SalaryAdvanceID").GetValue(focusedObject);
                                            tb_SalaryAdvance employeeSalaryADVANceIDs = conn.tb_SalaryAdvance.FirstOrDefault(j => j.SalaryAdvanceID == salaryADVANCEID);

                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa tạm ứng nhan vien  có ID là  {salaryADVANCEID} không?", " sửa tạm ứng lương nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {
                                                if (employeeSalaryADVANceIDs != null)
                                                {

                                                    employeeSalaryADVANceIDs.EmployeeID = cbb_MaNhanVien.Text;
                                                    employeeSalaryADVANceIDs.PayPeriodID = int.Parse(cbb_MaKyCong.Text);
                                                    employeeSalaryADVANceIDs.AdvanceAmount = int.Parse(txt_SoTienTamUng.Text);
                                                    employeeSalaryADVANceIDs.UpdatedBy = "Trần Nhật Phi";
                                                    employeeSalaryADVANceIDs.UpdatedDate = DateTime.Now;
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa ung luong nhan vien  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Không có nhân Viên nào");
                                                }
                                            }
                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi khi sửa ứng lương nhân viên: " + ex.InnerException.Message);
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
            
            cbb_MaKyCong.Enabled = !isEnabled;
            cbb_MaNhanVien.Enabled = !isEnabled;
            //txt_TenNhanVien.Enabled = !isEnabled;
            txt_SoTienTamUng.Enabled= !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {
           
            cbb_MaKyCong.Text = string.Empty;
            cbb_MaNhanVien.Text = string.Empty;
            txt_TenNhanVien.Text = string.Empty;
            txt_SoTienTamUng.Text = string.Empty;

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
            if (cbb_MaNhanVien.SelectedItem != null)
            {
                // Get the selected employee from the ComboBox
                var selectedEmployee = (tb_Employee)cbb_MaNhanVien.SelectedItem;

                // Update txthoten with the Full Name of the selected employee
                txt_TenNhanVien.Text = selectedEmployee.FullName;
            }
        }


        private void frmKhenThuongNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình ứng Lương Nhan Vien?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            cbb_MaKyCong.Text = focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject).ToString();
            cbb_MaNhanVien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txt_TenNhanVien.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            txt_SoTienTamUng.Text = focusedObject.GetType().GetProperty("AdvanceAmount").GetValue(focusedObject).ToString();
        }
    }
}