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
    public partial class frmKhenThuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
       
        private DataLayer.model.tb_EmployeeReward nhanvienkhenthuongDAL;
        private BussinessLayer.Khenthuongnhanvien nhanvienkhenthuongBUS;
        private bool _isNewRecord;
        public frmKhenThuongNhanVien()
        {
            InitializeComponent();
            nhanvienkhenthuongDAL = new tb_EmployeeReward();
            nhanvienkhenthuongBUS = new Khenthuongnhanvien();

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
            txtHoTen.Enabled = !Enabled;

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using (var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_EmployeeReward.
                    Select(item => new
                    {

                        item.EmployeeRewardID,
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
            txtQuyetDinhKhenThuong.Enabled =!Enabled;
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
                        string employeerewardID = focusedObject.GetType().GetProperty("EmployeeRewardID").GetValue(focusedObject).ToString();

                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa nhan vien ky luat có ID là  {employeerewardID} không?", " Xóa kỹ luật nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            _isNewRecord = false;
                            nhanvienkhenthuongBUS.DeleteEmployeeReward(employeerewardID);
                            MessageBox.Show("xóa  khen thưởng nhân viên thành công ", "thông báo");
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
                if (string.IsNullOrEmpty(txtQuyetDinhKhenThuong.Text) || string.IsNullOrEmpty(txtGhiChu.Text) ||
                    string.IsNullOrEmpty(cbb_makycong.Text)||string.IsNullOrEmpty(cbb_manhanvien.Text)||string.IsNullOrEmpty(txtSoTien.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    tb_EmployeeReward newEmployeeReward = new tb_EmployeeReward
                    {
                        EmployeeRewardID = txtQuyetDinhKhenThuong.Text,
                        EmployeeID = cbb_manhanvien.Text,
                        PayPeriodID = int.Parse(cbb_makycong.Text),
                        Amount = int.Parse(txtSoTien.Text),
                        CreatedDate = DateTime.Now,
                        Note = txtGhiChu.Text,
                    };
                    nhanvienkhenthuongBUS.AddEmployeeReward(newEmployeeReward);
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
                                        string employeeRewardID = focusedObject.GetType().GetProperty("EmployeeRewardID").GetValue(focusedObject).ToString();
                                        tb_EmployeeReward employeeREwardID = conn.tb_EmployeeReward.FirstOrDefault(j => j.EmployeeRewardID == employeeRewardID);
                                        if (employeeREwardID != null)
                                        {

                                            employeeREwardID.EmployeeID = cbb_manhanvien.Text;
                                            employeeREwardID.PayPeriodID = int.Parse(cbb_makycong.Text);
                                            employeeREwardID.Note = txtGhiChu.Text;
                                            employeeREwardID.Amount = int.Parse(txtSoTien.Text);
                                            employeeREwardID.UpdatedDate = DateTime.Now;
                                            conn.SaveChanges();
                                            transaction.Commit();
                                            MessageBox.Show("sửa khen thưởng nhân viên  thành công ", "thông báo");
                                            LoadData();
                                            ToggleFormState(true);
                                            ClearForm();
                                        }
                                        else
                                        {
                                            MessageBox.Show("ko có nhan vien nao");
                                        }
                                    }
                                    catch (DbUpdateException ex)
                                    {
                                        transaction.Rollback();
                                        throw new Exception("Error while editting employee reward: " + ex.InnerException.Message);
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
            txtQuyetDinhKhenThuong.Enabled = !isEnabled;
            cbb_makycong.Enabled = !isEnabled;
            cbb_manhanvien.Enabled = !isEnabled;
            txtGhiChu.Enabled = !isEnabled;
            txtSoTien.Enabled = !isEnabled;

            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {
            txtHoTen.Text = string.Empty;
            cbb_makycong.Text = string.Empty;
            cbb_manhanvien.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtQuyetDinhKhenThuong.Text = string.Empty;
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
                txtHoTen.Text = selectedEmployee.FullName;
            }
        }

        
        private void frmKhenThuongNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình Nhân Viên khen thuong?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }
            
    }
}