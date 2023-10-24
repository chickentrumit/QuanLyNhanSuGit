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
    public partial class frmBHXH : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_SocialInsurance BHXHDAL;
        private BussinessLayer.BHXH BHXHBUS;
        private bool _isNewRecord;
        public frmBHXH()
        {
            InitializeComponent();
            BHXHDAL = new tb_SocialInsurance();
            BHXHBUS = new BHXH();

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
                gcDanhSach.DataSource = conn.tb_SocialInsurance.
                    Where(item => item.State == true).
                    Select(item => new
                    {
                        item.SocialInsuranceID,
                        item.SocialInsuranceCreatedDate,
                        item.EmployeeID,
                        item.tb_Employee.FullName
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
            txtMaBHXH.Enabled = !Enabled;
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
                        string SocialInsuranceIDs = focusedObject.GetType().GetProperty("SocialInsuranceID").GetValue(focusedObject).ToString();

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa BHXH có ID là {SocialInsuranceIDs} không?", " Xóa BHXH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            BHXHBUS.Deletetb_SocialInsurances(SocialInsuranceIDs);
                            MessageBox.Show("xóa BHXH thành công ", "thông báo");
                            LoadData();
                        }

                    }
                    else
                    {
                        throw new Exception("Dử liệu không đúng ");
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
                if (string.IsNullOrEmpty(txtMaBHXH.Text) || string.IsNullOrEmpty(cbb_MaNhanVien.Text) ||
                    string.IsNullOrEmpty(dtNgaytao.Value.ToString()))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (BHXHBUS.ResignationIDExists(txtMaBHXH.Text))
                {
                    MessageBox.Show("vui lòng chọn ID khác ID này đã có người sử dụng");
                }
                else
                {

                    tb_SocialInsurance newHealthInsurance = new tb_SocialInsurance
                    {

                        SocialInsuranceID = txtMaBHXH.Text,
                        EmployeeID = cbb_MaNhanVien.Text,
                        SocialInsuranceCreatedDate = dtNgaytao.Value,
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,
                    };
                    BHXHBUS.addtb_SocialInsurance(newHealthInsurance);
                    LoadData();

                    MessageBox.Show("thêm 1 BHXH mới thành công ", "thông báo");
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
                        if (string.IsNullOrEmpty(cbb_MaNhanVien.Text) || string.IsNullOrEmpty(dtNgaytao.Value.ToString()))
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
                                            string SocialInsuranceIDs = focusedObject.GetType().GetProperty("SocialInsuranceID").GetValue(focusedObject).ToString();
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa BHXH có ID là  {SocialInsuranceIDs} không?", " sửa BHXH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {
                                                tb_SocialInsurance SocialInsuranceID = conn.tb_SocialInsurance.FirstOrDefault(j => j.SocialInsuranceID == SocialInsuranceIDs);
                                                if (SocialInsuranceID != null)
                                                {

                                                    SocialInsuranceID.EmployeeID = cbb_MaNhanVien.Text;
                                                    SocialInsuranceID.SocialInsuranceCreatedDate = dtNgaytao.Value;
                                                    SocialInsuranceID.UpdatedDate = DateTime.Now;
                                                    SocialInsuranceID.UpdatedBy = "Trần Nhật Phi";
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa  BHXH  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Không có BHXH nào");
                                                }
                                            }

                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("Lỗi trong khi sửa BHXH " + ex.InnerException.Message);
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
            txtMaBHXH.Enabled = !isEnabled;
            dtNgaytao.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {

            txtMaBHXH.Text = string.Empty;
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình BHXH ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtMaBHXH.Text = focusedObject.GetType().GetProperty("SocialInsuranceID").GetValue(focusedObject).ToString();
            cbb_MaNhanVien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txtHoTen.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            dtNgaytao.Text = focusedObject.GetType().GetProperty("SocialInsuranceCreatedDate").GetValue(focusedObject).ToString();
        }
    }
}