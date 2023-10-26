using BussinessLayer;
using DataLayer.model;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Commands;
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
    public partial class frmThoiViecNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_Resignation thoiviecnhanvienDAL;
        private BussinessLayer.NhanVienThoiViec thoiviecnhanvienBUS;
        private bool _isNewRecord;
        public frmThoiViecNhanVien()
        {
            InitializeComponent();
            thoiviecnhanvienDAL = new tb_Resignation();
            thoiviecnhanvienBUS = new NhanVienThoiViec();

            using (var conn = new DBcontext())
            {
                //lay ma nhan vien
                cbb_MaNhanVien.DataSource = conn.tb_Employee.ToList();
                cbb_MaNhanVien.DisplayMember = "EmployeeID";
                cbb_MaNhanVien.ValueMember = "EmployeeID";


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
                gcDanhSach.DataSource = conn.tb_Resignation.
                    Select(item => new
                    {
                        item.ResignationID,
                        item.ResignationDate,
                        item.EmployeeID,
                        item.tb_Employee.FullName,
                        item.EndDate,
                        item.Note,
                        item.KeyResiqnation
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
            txt_MaThoiViec.Enabled = !Enabled;
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
                        string employeeResignationIDa = focusedObject.GetType().GetProperty("ResignationID").GetValue(focusedObject).ToString();

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa nhan vien thoi viec có ID là  {employeeResignationIDa} không?", " Xóa thôi việc nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            thoiviecnhanvienBUS.DeleteEmployeeResignation(employeeResignationIDa);
                            MessageBox.Show("xóa nhân viên thoi viec thành công ", "thông báo");
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
                if (string.IsNullOrEmpty(txt_MaThoiViec.Text) || string.IsNullOrEmpty(txt_LyDo.Text) ||
                    string.IsNullOrEmpty(cbb_MaNhanVien.Text)||string.IsNullOrEmpty(dt_NgayNopDon.Value.ToString())||
                    string.IsNullOrEmpty(dt_NgayNghiViec.Value.ToString()))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (dt_NgayNghiViec.Value<dt_NgayNopDon.Value)
                {
                    MessageBox.Show("chọn sai ngày,vui lòng kiểm tra lại ");
                }
                else if (thoiviecnhanvienBUS.ResignationIDExists(txt_MaThoiViec.Text))
                {
                    MessageBox.Show("vui lòng chọn ID khác ID này đã có người sử dụng");
                }
                else if (thoiviecnhanvienBUS.ResignationIDExists(cbb_MaNhanVien.Text))
                {
                    MessageBox.Show("vui lòng chọn ID nhân viên khác ID nhân viên này đã có người sử dụng");
                }

                else
                {

                    tb_Resignation newResignation = new tb_Resignation
                    {

                        ResignationID = txt_MaThoiViec.Text,
                        EmployeeID = cbb_MaNhanVien.Text,
                        EndDate = dt_NgayNghiViec.Value,
                        Note = txt_LyDo.Text,
                        ResignationDate = dt_NgayNopDon.Value,
                        KeyResiqnation = cbbKey.Checked,
                        CreatedDate = DateTime.Now,
                    };
                    thoiviecnhanvienBUS.AddResignation(newResignation);
                    LoadData();
                    MessageBox.Show("thêm 1 thoi viec nhan vien mới thành công ", "thông báo");
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
                        if ( string.IsNullOrEmpty(txt_LyDo.Text) ||string.IsNullOrEmpty(cbb_MaNhanVien.Text) || 
                            string.IsNullOrEmpty(dt_NgayNopDon.Value.ToString()) || string.IsNullOrEmpty(dt_NgayNghiViec.Value.ToString()))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                        }
                        else if (dt_NgayNghiViec.Value < dt_NgayNopDon.Value)
                        {
                            MessageBox.Show("chọn sai ngày,vui lòng kiểm tra lại ");
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
                                            string EmployeeResignationIDs = focusedObject.GetType().GetProperty("ResignationID").GetValue(focusedObject).ToString();
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa thôi việc nhân viên có ID là  {EmployeeResignationIDs} không?", " sửa thôi việc nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {
                                                tb_Resignation employeeResignationID = conn.tb_Resignation.FirstOrDefault(j => j.ResignationID == EmployeeResignationIDs);
                                                if (employeeResignationID != null)
                                                {

                                                    employeeResignationID.EmployeeID = cbb_MaNhanVien.Text;
                                                    employeeResignationID.Note = txt_LyDo.Text;
                                                    employeeResignationID.ResignationDate = dt_NgayNopDon.Value;
                                                    employeeResignationID.EndDate = dt_NgayNghiViec.Value;
                                                    employeeResignationID.UpdatedBy = "Tràn Nhật Phi";
                                                    employeeResignationID.UpdatedDate = DateTime.Now;
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa  nhân viên  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("không có Nhân Viên nào");
                                                }
                                            }
                                            
                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi khi sửa nhân viên Kỳ Công: " + ex.InnerException.Message);
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
           
            txt_LyDo.Enabled = !isEnabled;
            cbb_MaNhanVien.Enabled = !isEnabled;
            //txt_TenNhanVien.Enabled = !isEnabled;
            txt_MaThoiViec.Enabled = !isEnabled;
            dt_NgayNghiViec.Enabled= !isEnabled;
            dt_NgayNopDon.Enabled = !isEnabled;
            cbbKey.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {

            txt_MaThoiViec.Text = string.Empty;
            cbb_MaNhanVien.Text = string.Empty;
            txt_TenNhanVien.Text = string.Empty;
            txt_LyDo.Text = string.Empty;
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


        private void frmthoiviecnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình thôi việc Nhan Vien?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txt_MaThoiViec.Text = focusedObject.GetType().GetProperty("ResignationID").GetValue(focusedObject).ToString();
            cbb_MaNhanVien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txt_TenNhanVien.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            dt_NgayNopDon.Text = focusedObject.GetType().GetProperty("ResignationDate").GetValue(focusedObject).ToString();
            dt_NgayNghiViec.Text = focusedObject.GetType().GetProperty("EndDate").GetValue(focusedObject).ToString();
            txt_LyDo.Text = focusedObject.GetType().GetProperty("Note").GetValue(focusedObject).ToString();
            cbbKey.Checked =bool.Parse( focusedObject.GetType().GetProperty("KeyResiqnation").GetValue(focusedObject).ToString());
            if (cbbKey.Checked == true)
            {
                btnThem.Enabled = !Enabled;
                btnSua.Enabled = !Enabled;
                btnXoa.Enabled = !Enabled;
            }
            else
            {
                btnThem.Enabled = Enabled;
                btnSua.Enabled = Enabled;
                btnXoa.Enabled = Enabled;
            }


        }
    }
}