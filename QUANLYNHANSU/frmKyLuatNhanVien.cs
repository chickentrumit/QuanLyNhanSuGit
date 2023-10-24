using BussinessLayer;
using DataLayer.model;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class frmKyLuatNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private DataLayer.model.tb_EmployeeDiscipline nhanvienkyluatDAL;
        private BussinessLayer.NhanVienKyLuat nhanvienkyluatBUS;
        private bool _isNewRecord;
        public frmKyLuatNhanVien()
        {
            InitializeComponent();
            nhanvienkyluatDAL = new tb_EmployeeDiscipline();
            nhanvienkyluatBUS = new NhanVienKyLuat();
            
            using (var conn = new DBcontext())
            {
                //lay ma nhan vien
                cbb_manhanvien.DataSource = conn.tb_Employee.ToList();
                cbb_manhanvien.DisplayMember = "EmployeeID";
                cbb_manhanvien.ValueMember = "EmployeeID";

                

                //lay id ky cong
                cbb_makycong.DataSource = conn.tb_PayPeriod.ToList();
                cbb_makycong.DisplayMember = "PayPeriodID";
                cbb_makycong.ValueMember = "PayPeriodID";

              
            }
            txthoten.Enabled=!Enabled;

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_EmployeeDiscipline.
                    Select(item => new
                    {
                       
                        item.EmployeeDisciplineID,
                        item.tb_Employee.FullName,
                        item.EmployeeID,
                        item.PayPeriodID,
                        item.Amount,
                        item.Note
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
            txtMakyluat.Enabled = !Enabled;
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
                        string employeediscipline = focusedObject.GetType().GetProperty("EmployeeDisciplineID").GetValue(focusedObject).ToString();

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa nhan vien ky luat có ID là  {employeediscipline} không?", " Xóa kỹ luật nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            nhanvienkyluatBUS.DeleteEmployeeDiscipline(employeediscipline);
                            MessageBox.Show("xóa  kỷ luật nhân viên thành công ", "thông báo");
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
                if (string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtGhiChu.Text) ||
                    string.IsNullOrEmpty(cbb_makycong.Text) || string.IsNullOrEmpty(cbb_manhanvien.Text) ||
                    string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtMakyluat.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else if (nhanvienkyluatBUS.DisciplineIDExists(txtMakyluat.Text))
                {
                    MessageBox.Show("vui lòng chọn ID khác ID này đã có người sử dụng");
                }
                else
                {
                    tb_EmployeeDiscipline newEmployeeDiscipline = new tb_EmployeeDiscipline
                    {
                        EmployeeDisciplineID = txtMakyluat.Text,
                        EmployeeID = cbb_manhanvien.Text,
                        // = cbb.SelectedValue.ToString()
                        PayPeriodID = int.Parse(cbb_makycong.Text),
                        Amount = int.Parse(txtSoTien.Text),
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,
                        Note = txtGhiChu.Text,
                    };
                    nhanvienkyluatBUS.AddEmloyeeDiscipline(newEmployeeDiscipline);
                    LoadData();
                    //bindinglist.Add(newEmployeeallowanceJob);
                    MessageBox.Show("thêm 1 kỷ luật nhân viên mới thành công ", "thông báo");
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
                        if (string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtGhiChu.Text) ||
                    string.IsNullOrEmpty(cbb_makycong.Text) || string.IsNullOrEmpty(cbb_manhanvien.Text) ||
                    string.IsNullOrEmpty(txtSoTien.Text))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                        }
                        else if (nhanvienkyluatBUS.DisciplineIDExists(txtMakyluat.Text))
                        {
                            MessageBox.Show("vui lòng chọn ID khác ID này đã có người sử dụng");
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
                                            string employedisciplineID = focusedObject.GetType().GetProperty("EmployeeDisciplineID").GetValue(focusedObject).ToString();
                                            tb_EmployeeDiscipline employeeDisciplineID = conn.tb_EmployeeDiscipline.FirstOrDefault(j => j.EmployeeDisciplineID == employedisciplineID);
                                            DialogResult result = MessageBox.Show($"Bạn có muốn sửa nhan vien ky luat có ID là  {employedisciplineID} không?", " Sửa kỹ luật nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                            if (result == DialogResult.Yes)
                                            {

                                                if (employeeDisciplineID != null)
                                                {


                                                    employeeDisciplineID.EmployeeID = cbb_manhanvien.Text;
                                                    employeeDisciplineID.PayPeriodID = int.Parse(cbb_makycong.Text);
                                                    employeeDisciplineID.Note = txtGhiChu.Text;
                                                    employeeDisciplineID.Amount = int.Parse(txtSoTien.Text);
                                                    employeeDisciplineID.UpdatedDate = DateTime.Now;
                                                    employeeDisciplineID.UpdatedBy = "Trần Nhật Phi";
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa kĩ luật nhân viên  thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("không có Nhân viên nào");
                                                }
                                            }
                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi trong khi sửa Kỹ luật nhân viên: " + ex.InnerException.Message);
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
            cbb_makycong.Enabled = !isEnabled;
            cbb_manhanvien.Enabled = !isEnabled;
            txtGhiChu.Enabled = !isEnabled;
            txtMakyluat.Enabled = !isEnabled;
            txtSoTien.Enabled = !isEnabled;

            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {
            txthoten.Text = string.Empty;
            cbb_makycong.Text = string.Empty;
            cbb_manhanvien.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtMakyluat.Text = string.Empty;
            txtSoTien.Text = string.Empty;

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
            if (cbb_manhanvien.SelectedItem != null)
            {
                // Get the selected employee from the ComboBox
                var selectedEmployee = (tb_Employee)cbb_manhanvien.SelectedItem;

                // Update txthoten with the Full Name of the selected employee
                txthoten.Text = selectedEmployee.FullName;
            }
        }

        private void frmKyLuatNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình Nhân Viên kỹ luật?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtMakyluat.Text = focusedObject.GetType().GetProperty("EmployeeDisciplineID").GetValue(focusedObject).ToString();
            cbb_makycong.Text = focusedObject.GetType().GetProperty("PayPeriodID").GetValue(focusedObject).ToString();
            cbb_manhanvien.Text = focusedObject.GetType().GetProperty("EmployeeID").GetValue(focusedObject).ToString();
            txthoten.Text = focusedObject.GetType().GetProperty("FullName").GetValue(focusedObject).ToString();
            txtSoTien.Text = focusedObject.GetType().GetProperty("Amount").GetValue(focusedObject).ToString();
            txtGhiChu.Text = focusedObject.GetType().GetProperty("Note").GetValue(focusedObject).ToString();
        }
    }
}