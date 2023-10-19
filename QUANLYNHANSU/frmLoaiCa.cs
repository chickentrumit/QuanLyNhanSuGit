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
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<tb_ShiftType> bindinglist = new BindingList<tb_ShiftType>();
        
        private DataLayer.model.tb_ShiftType loaicaDAL;
        private BussinessLayer.LoaiCa loaicaBUS;
        private bool _isNewRecord;
        public frmLoaiCa()
        {
            InitializeComponent();
            loaicaDAL = new tb_ShiftType();
            loaicaBUS = new LoaiCa ();
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
            foreach (tb_ShiftType job in loaicaBUS.GetTb_shiftType())
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
                        tb_ShiftType currentRowHandle = gridView.FocusedRowObject as tb_ShiftType;
                        if (currentRowHandle != null)
                        {
                            DialogResult result = MessageBox.Show($"Bạn có muốn xóa loai ca có ID là  {currentRowHandle.ShiftTypeID} không?", " Xóa Loaica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                //currentRowHandle.DeletedDate = DateTime.Now;
                                _isNewRecord = false;
                                loaicaBUS.DeleteshiftType(currentRowHandle.ShiftTypeID);
                                MessageBox.Show("xóa loại ca mới thành công ", "thông báo");
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
            txtTenLoaiCa.Enabled = !isEnabled;
            txtHeSo.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (_isNewRecord)
            {
                if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCa.Text)){
                    MessageBox.Show("vui lòng nhập đầy đủ tên loại ca và hệ số");
                }      
                else
                {
                    tb_ShiftType newshifttype = new tb_ShiftType
                    {
                        CreatedDate = DateTime.Now,
                        State = true,
                        ShiftTypeName = txtTenLoaiCa.Text,
                        Coefficinet = double.Parse(txtHeSo.Text)
                    };
                    loaicaBUS.AddshiftType(newshifttype);
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
                using(var conn = new DBcontext())
                {
                    try
                    {
                        int rowIndex = gcDanhSach.FocusedView.DataRowCount;
                        if (rowIndex > 0)
                        {
                            GridView gridView = gcDanhSach.MainView as GridView;
                            tb_ShiftType currentRowHandle = gridView.FocusedRowObject as tb_ShiftType;
                            if (currentRowHandle != null)
                            {

                                using (var transaction = conn.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        
                                        var shifttypeID = conn.tb_ShiftType.FirstOrDefault(j => j.ShiftTypeID == currentRowHandle.ShiftTypeID);
                                        if (shifttypeID != null)
                                        {
                                            if (string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtTenLoaiCa.Text)){
                                                MessageBox.Show("vui lòng nhập đầy đủ tên loại ca và hệ số");
                                            }
                                            else
                                            {
                                                currentRowHandle.ShiftTypeName = txtTenLoaiCa.Text;
                                                shifttypeID.ShiftTypeName = txtTenLoaiCa.Text;
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
            txtTenLoaiCa.Text = string.Empty;
            loaicaDAL = null;
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình loại ca?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}