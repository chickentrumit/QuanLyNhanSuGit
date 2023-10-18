using BussinessLayer;
using DataLayer.model;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
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
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_isNewRecord)
            {
                tb_EmployeeDiscipline newEmployeeDiscipline = new tb_EmployeeDiscipline
                {
                    EmployeeDisciplineID = txtMakyluat.Text,
                    EmployeeID = cbb_manhanvien.Text,
                    // = cbb.SelectedValue.ToString()
                    PayPeriodID = int.Parse(cbb_makycong.Text),
                    Amount = int.Parse(txtSoTien.Text),
                    CreatedDate = DateTime.Now,
                    Note = txtGhiChu.Text,
                };
                nhanvienkyluatBUS.AddEmloyeeAllowanceJob(newEmployeeDiscipline);
                LoadData();
                //bindinglist.Add(newEmployeeallowanceJob);
                MessageBox.Show("thêm 1 kỹ luật nhân viên mới thành công ", "thông báo");
                _isNewRecord = false;
                ToggleFormState(true);
                ClearForm();
            }
            /*else
            {
                object value = gridView1.FocusedValue;

                using (var conn = new DBcontext())
                {
                    try
                    {
                        int rowIndex = gcDanhSach.FocusedView.DataRowCount;
                        if (rowIndex > 0)
                        {
                            GridView gridView = gcDanhSach.MainView as GridView;
                            //tb_EmployeeAllowanceJob currentRowHandle = gridView.FocusedRowObject as tb_EmployeeAllowanceJob;
                            var currentRowHandle = gridView.FocusedRowObject;
                            // Lấy dòng đang được chọn trong GridControl
                            var selectedRow = gridView1.GetFocusedDataRow();
                            // Lấy giá trị EmployeeAllowanceJobID từ dòng đang được chọn
                            if (selectedRow != null && selectedRow["EmployeeAllowanceJobID"] != null)
                            {
                                int employeeAllowanceJobid = (int)selectedRow["EmployeeAllowanceJobID"];
                                // Tiếp tục với các bước khác
                            }
                            else
                            {
                                MessageBox.Show("Không thể tìm thấy EmployeeAllowanceJobID hoặc dòng đang được chọn không hợp lệ.");
                            }


                            return;
                            if (currentRowHandle != null)
                            {


                                using (var transaction = conn.Database.BeginTransaction())
                                {
                                    try
                                    {

                                        tb_EmployeeAllowanceJob employeeAllowanceID = conn.tb_EmployeeAllowanceJob.FirstOrDefault(j => j.EmployeeAllowanceJobID == employeeAllowanceJobid);
                                        if (employeeAllowanceID != null)
                                        {
                                            employeeAllowanceID.tb_AllowanceJob.AllowanceJobName = cbb_TenPhuCap.Text;
                                            employeeAllowanceID.tb_Employee.FullName = cbb_TenNhanVien.Text;
                                            employeeAllowanceID.tb_PayPeriod.PayPeriodID = int.Parse(cbb_MaKyCong.Text);
                                            employeeAllowanceID.Note = txtNote.Text;
                                            employeeAllowanceID.UpdatedDate = DateTime.Now;
                                            currentRowHandle.tb_AllowanceJob.AllowanceJobName = cbb_TenPhuCap.Text;
                                            currentRowHandle.tb_Employee.FullName = cbb_TenNhanVien.Text;
                                            currentRowHandle.PayPeriodID = int.Parse(cbb_MaKyCong.Text);
                                            currentRowHandle.Note = txtNote.Text;
                                            currentRowHandle.UpdatedDate = DateTime.Now;
                                            //employeeAllowanceID.AllowanceAmount = int.Parse(txtSoTienPhuCap.Text);
                                            //currentRowHandle.UpdatedDate = DateTime.Now;

                                            conn.SaveChanges();
                                            transaction.Commit();
                                            MessageBox.Show("sửa phụ cấp mới thành công ", "thông báo");
                                            LoadData();
                                            ToggleFormState(true);

                                            ClearForm();
                                        }
                                        else
                                        {
                                            MessageBox.Show("bi null");
                                        }
                                    }
                                    catch (DbUpdateException ex)
                                    {
                                        transaction.Rollback();
                                        throw new Exception("Error while edit allowance job: " + ex.InnerException.Message);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                


            }*/
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
    }
}