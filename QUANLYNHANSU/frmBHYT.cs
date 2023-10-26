using BussinessLayer;
using DataLayer.model;
using DevExpress.Mvvm.Native;
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
    public partial class frmBHYT : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_HealthInsurance BHYTDAL;
        private BussinessLayer.BHYT BHYTBUS;
        private bool _isNewRecord;
        public frmBHYT()
        {
            InitializeComponent();
            BHYTDAL = new tb_HealthInsurance();
            BHYTBUS = new BHYT();

            using (var conn = new DBcontext())
            {
                //lay ma nhan vien
                cbb_MaNhanVien.DataSource = conn.tb_Employee.ToList();
                cbb_MaNhanVien.DisplayMember = "EmployeeID";
                cbb_MaNhanVien.ValueMember = "EmployeeID";


            }
            txtHoTen.Enabled = !Enabled;

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_HealthInsurance.
                    Where(item => item.State == true).
                    Select(item => new
                    {
                        item.HealthInsuranceID,
                        item.HealthInsuranceCreatedDate,
                        item.EmployeeID,
                        item.tb_Employee.FullName
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
            txtMaBHYT.Enabled = !Enabled;
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
                        string HealthInsuranceIDs = focusedObject.GetType().GetProperty("HealthInsuranceID").GetValue(focusedObject).ToString();

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa BHYT có ID là {HealthInsuranceIDs} không?", " Xóa BHYT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            BHYTBUS.Deletetb_HealthInsurances(HealthInsuranceIDs);
                            MessageBox.Show("xóa BHYT thành công ", "thông báo");
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
                if (string.IsNullOrEmpty(txtMaBHYT.Text) || string.IsNullOrEmpty(cbb_MaNhanVien.Text) ||
                    string.IsNullOrEmpty(dtNgaytao.Value.ToString()))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (BHYTBUS.ResignationIDExists(txtMaBHYT.Text))
                {
                    MessageBox.Show("vui lòng chọn ID khác ID này đã có người sử dụng");
                }
                else if (BHYTBUS.ResignationIDExists(cbb_MaNhanVien.Text))
                {
                    MessageBox.Show("vui lòng chọn ID nhân viên khác ID nhân viên này đã có người sử dụng");
                }
                else
                {
                    tb_HealthInsurance newHealthInsurance = new tb_HealthInsurance
                    {

                        HealthInsuranceID = txtMaBHYT.Text,
                        EmployeeID = cbb_MaNhanVien.Text,
                        HealthInsuranceCreatedDate = dtNgaytao.Value,
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,
                    };
                    BHYTBUS.addtb_HealthInsurance(newHealthInsurance);
                    LoadData();
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
                        if ( string.IsNullOrEmpty(cbb_MaNhanVien.Text) || string.IsNullOrEmpty(dtNgaytao.Value.ToString()))
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
                                            string HealthInsuranceIDs = focusedObject.GetType().GetProperty("HealthInsuranceID").GetValue(focusedObject).ToString();
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa BHYT có ID là  {HealthInsuranceIDs} không?", " sửa BHYT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {
                                                tb_HealthInsurance HealthInSuranceID = conn.tb_HealthInsurance.FirstOrDefault(j => j.HealthInsuranceID == HealthInsuranceIDs);
                                                if (HealthInSuranceID != null)
                                                {

                                                    HealthInSuranceID.EmployeeID = cbb_MaNhanVien.Text;
                                                    HealthInSuranceID.HealthInsuranceCreatedDate = dtNgaytao.Value;
                                                    HealthInSuranceID.UpdatedDate = DateTime.Now;
                                                    HealthInSuranceID.UpdatedBy = "Trần Nhật Phi";
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa  BHYT  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Không có BHYT Nào");
                                                }
                                            }

                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi trong khi Sửa BHYT: " + ex.InnerException.Message);
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

          
            cbb_MaNhanVien.Enabled = !isEnabled;
            //txt_TenNhanVien.Enabled = !isEnabled;
            txtMaBHYT.Enabled = !isEnabled;
            dtNgaytao.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {

            txtMaBHYT.Text = string.Empty;
            cbb_MaNhanVien.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            dtNgaytao.Text = string.Empty;
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
                txtHoTen.Text = selectedEmployee.FullName;
            }
        }


        private void frmthoiviecnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình BHYT ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtMaBHYT.Text = focusedObject.GetType().GetProperty("HealthInsuranceID").GetValue(focusedObject).ToString();
            cbb_MaNhanVien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txtHoTen.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            dtNgaytao.Text = focusedObject.GetType().GetProperty("HealthInsuranceCreatedDate").GetValue(focusedObject).ToString();
        }
    }
}