using BussinessLayer;
using DataLayer.model;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class frmPhuCapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        //private BindingList<tb_EmployeeAllowanceJob> bindinglist = new BindingList<tb_EmployeeAllowanceJob>();
        private DataLayer.model.tb_EmployeeAllowanceJob nhanvienphucapDal;
        private BussinessLayer.NhanVienphucap nhanvienphucapBus;
        private bool _isNewRecord;
        public frmPhuCapNhanVien()
        {
            InitializeComponent();
            nhanvienphucapDal = new tb_EmployeeAllowanceJob();
            nhanvienphucapBus = new NhanVienphucap();
            //lay ten nhan vien
            using(var conn = new DBcontext())
            {
                cbb_TenNhanVien.DataSource = conn.tb_Employee.ToList();
                cbb_TenNhanVien.DisplayMember = "FullName";
                cbb_TenNhanVien.ValueMember = "EmployeeID";

                //lay ten phu cap 
                cbb_TenPhuCap.DataSource = conn.tb_AllowanceJob.ToList();
                cbb_TenPhuCap.DisplayMember = "AllowanceJobName";
                cbb_TenPhuCap.ValueMember = "AllowanceJobID";

                //lay id ky cong
                cbb_MaKyCong.DataSource = conn.tb_PayPeriod.ToList();
                cbb_MaKyCong.DisplayMember = "PayPeriodID";
                cbb_MaKyCong.ValueMember = "PayPeriodID";
            }

            //gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            using(var conn = new DBcontext())
            {
                gcDanhSach.DataSource = conn.tb_EmployeeAllowanceJob.
                    Select(item => new
                    {
                        item.EmployeeAllowanceJobID,
                        item.tb_Employee.FullName,
                        item.PayPeriodID,
                        item.tb_AllowanceJob.AllowanceJobName,
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
                tb_EmployeeAllowanceJob newEmployeeallowanceJob = new tb_EmployeeAllowanceJob
                {
                    EmployeeID = cbb_TenNhanVien.SelectedValue.ToString(),
                    PayPeriodID = int.Parse(cbb_MaKyCong.Text),
                    AllowanceJobID = short.Parse(cbb_TenPhuCap.SelectedValue.ToString()),
                    CreatedDate = DateTime.Now,
                    Note = txtNote.Text,
                };
                nhanvienphucapBus.AddEmloyeeAllowanceJob(newEmployeeallowanceJob);
                LoadData();
                //bindinglist.Add(newEmployeeallowanceJob);
                MessageBox.Show("thêm nhân viên phụ cấp mới thành công ", "thông báo");
                _isNewRecord = false;
                ToggleFormState(true);
                ClearForm();
            }
            else
            {
               object value = gridView1.FocusedValue;
                
                using(var conn = new DBcontext())   
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
                           /* if (currentRowHandle != null)
                            {
                              
                               
                                using (var transaction = conn.Database.BeginTransaction())
                                {
                                    try
                                    {

                                        tb_EmployeeAllowanceJob employeeAllowanceID = conn.tb_EmployeeAllowanceJob.FirstOrDefault(j => j.EmployeeAllowanceJobID == employeeAllowanceJobid) ;
                                        if (employeeAllowanceID != null)
                                        {
                                            employeeAllowanceID.tb_AllowanceJob.AllowanceJobName = cbb_TenPhuCap.Text;
                                            employeeAllowanceID.tb_Employee.FullName = cbb_TenNhanVien.Text;
                                            employeeAllowanceID.tb_PayPeriod.PayPeriodID = int.Parse(cbb_MaKyCong.Text);
                                            employeeAllowanceID.Note = txtNote.Text;
                                            employeeAllowanceID.UpdatedDate = DateTime.Now;
                                           *//* currentRowHandle.tb_AllowanceJob.AllowanceJobName = cbb_TenPhuCap.Text;
                                            currentRowHandle.tb_Employee.FullName = cbb_TenNhanVien.Text;
                                            currentRowHandle.PayPeriodID = int.Parse(cbb_MaKyCong.Text);
                                            currentRowHandle.Note = txtNote.Text;
                                            currentRowHandle.UpdatedDate = DateTime.Now;*//*
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
                            }*/
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
            cbb_TenNhanVien.Enabled = !isEnabled;
            cbb_MaKyCong.Enabled = !isEnabled;
            cbb_TenPhuCap.Enabled = !isEnabled;
            txtNote.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }
        private void ClearForm()
        {
            cbb_TenNhanVien.Text = string.Empty;
            cbb_TenPhuCap.Text = string.Empty;
            cbb_MaKyCong.Text = string.Empty;
            txtNote.Text = string.Empty;
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

        private void frmPhuCapNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình Nhân Viên Phụ Cấpss?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}