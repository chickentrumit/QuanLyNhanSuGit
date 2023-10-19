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
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<tb_JobType> bindinglist = new BindingList<tb_JobType>();

        private DataLayer.model.tb_JobType loaicongDAL;
        private BussinessLayer.LoaiCong loaicongBUS;
        private bool _isNewRecord;
        public frmLoaiCong()
        {
            InitializeComponent();
            loaicongDAL = new tb_JobType();
            loaicongBUS = new LoaiCong();
            gcDanhSach.DataSource = bindinglist;
            LoadData();
            ToggleFormState(true);
        }
        private void LoadData()
        {
            /* gcDanhSach.DataSource = phucapBus.GetTb_AllowanceJobs()
                 .Select(alj => new
                 {
                     alj.AllowanceJobID,
                     alj.AllowanceJobName,
                     alj.AllowanceAmount
                 });*/
            bindinglist.Clear();
            foreach (tb_JobType job in loaicongBUS.GetTb_jobType())
            {
                bindinglist.Add(job);
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
                    GridView gridView = gcDanhSach.MainView as GridView;
                    tb_JobType currentRowHandle = gridView.FocusedRowObject as tb_JobType;
                    if (currentRowHandle != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa loai công có ID là  {currentRowHandle.JobTypeID} không?", " Xóa Loai scông", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            //currentRowHandle.DeletedDate = DateTime.Now;
                            _isNewRecord = false;
                            loaicongBUS.DeletejobType(currentRowHandle.JobTypeID);
                            MessageBox.Show("xóa loại công mới thành công ", "thông báo");
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
        private void ToggleFormState(bool isEnabled)
        {
            btnThem.Enabled = isEnabled;
            btnSua.Enabled = isEnabled;
            btnXoa.Enabled = isEnabled;
            btnLuu.Enabled = !isEnabled;
            btnKhongLuu.Enabled = !isEnabled;
            btnThoat.Enabled = isEnabled;
            txtTenLoaiCong.Enabled = !isEnabled;
            txtHeSo.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (_isNewRecord)
            {
                if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCong.Text))
                {
                    MessageBox.Show("vui lòng nhập đầy đủ tên loại ca và hệ số");
                }
                else
                {
                    tb_JobType newshifttype = new tb_JobType
                    {
                        CreatedDate = DateTime.Now,
                        State = true,
                        JobTypeName = txtTenLoaiCong.Text,
                        Coefficinet = double.Parse(txtHeSo.Text)
                    };
                    loaicongBUS.AddjobType(newshifttype);
                    bindinglist.Add(newshifttype);
                    LoadData();

                    MessageBox.Show("thêm loại ca mới thành công ", "thông báo");
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
                            GridView gridView = gcDanhSach.MainView as GridView;
                            tb_JobType currentRowHandle = gridView.FocusedRowObject as tb_JobType;
                            if (currentRowHandle != null)
                            {

                                using (var transaction = conn.Database.BeginTransaction())
                                {
                                    try
                                    {

                                        var shifttypeID = conn.tb_JobType.FirstOrDefault(j => j.JobTypeID == currentRowHandle.JobTypeID);
                                        if (shifttypeID != null)
                                        {
                                            if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCong.Text))
                                            {
                                                MessageBox.Show("vui lòng nhập đầy đủ tên loại ca và hệ số");
                                            }
                                            else
                                            {
                                                currentRowHandle.JobTypeName = txtTenLoaiCong.Text;
                                                shifttypeID.JobTypeName = txtTenLoaiCong.Text;
                                                currentRowHandle.Coefficinet = double.Parse(txtHeSo.Text);
                                                shifttypeID.Coefficinet = double.Parse(txtHeSo.Text);
                                                //currentRowHandle.UpdatedDate = DateTime.Now;
                                                shifttypeID.UpdatedDate = DateTime.Now;
                                                conn.SaveChanges();
                                                transaction.Commit();
                                                MessageBox.Show("sửa loại ca mới thành công ", "thông báo");
                                                LoadData();
                                                ToggleFormState(true);
                                                ClearForm();

                                            }


                                        }

                                    }
                                    catch (DbUpdateException ex)
                                    {
                                        transaction.Rollback();
                                        throw new Exception("Error while edit shift type: " + ex.InnerException.Message);
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
        private void ClearForm()
        {
            txtHeSo.Text = string.Empty;
            txtTenLoaiCong.Text = string.Empty;
            loaicongDAL = null;
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
        private void frmPhuCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình loại công?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}