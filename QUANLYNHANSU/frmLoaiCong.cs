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
                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa loai công có ID là  {currentRowHandle.JobTypeID} không?", " Xóa Loai công", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        throw new Exception("Dữ liệu không đúng ");
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
                    MessageBox.Show("vui lòng nhập đầy đủ tên loại công và hệ số");
                }
                else
                {
                    tb_JobType newjobtype = new tb_JobType
                    {
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,
                        State = true,
                        JobTypeName = txtTenLoaiCong.Text,
                        Coefficinet = double.Parse(txtHeSo.Text)
                    };
                    loaicongBUS.AddjobType(newjobtype);
                    bindinglist.Add(newjobtype);
                    LoadData();

                    MessageBox.Show("thêm loại công mới thành công ", "thông báo");
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
                        if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCong.Text))
                        {
                            MessageBox.Show("vui lòng nhập đầy đủ tên loại công và hệ số");
                        }
                        else
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

                                            var jobtypeID = conn.tb_JobType.FirstOrDefault(j => j.JobTypeID == currentRowHandle.JobTypeID);
                                            if (jobtypeID != null)
                                            {
                                                if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCong.Text))
                                                {
                                                    MessageBox.Show("vui lòng nhập đầy đủ tên loại công và hệ số");
                                                }
                                                else
                                                {
                                                    currentRowHandle.JobTypeName = txtTenLoaiCong.Text;
                                                    jobtypeID.JobTypeName = txtTenLoaiCong.Text;
                                                    currentRowHandle.Coefficinet = double.Parse(txtHeSo.Text);
                                                    jobtypeID.Coefficinet = double.Parse(txtHeSo.Text);
                                                    //currentRowHandle.UpdatedDate = DateTime.Now;
                                                    jobtypeID.UpdatedBy = "Trần Nhật Phi";
                                                    jobtypeID.UpdatedDate = DateTime.Now;
                                                    conn.SaveChanges();
                                                    transaction.Commit();
                                                    MessageBox.Show("sửa loại công mới thành công ", "thông báo");
                                                    LoadData();
                                                    ToggleFormState(true);
                                                    ClearForm();

                                                }


                                            }

                                        }
                                        catch (DbUpdateException ex)
                                        {
                                            transaction.Rollback();
                                            throw new Exception("lỗi trong khi đang sửa loại công: " + ex.InnerException.Message);
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtHeSo.Text = focusedObject.GetType().GetProperty("Coefficinet").GetValue(focusedObject).ToString();
            txtTenLoaiCong.Text = focusedObject.GetType().GetProperty("JobTypeName").GetValue(focusedObject).ToString();
        }
    }
}