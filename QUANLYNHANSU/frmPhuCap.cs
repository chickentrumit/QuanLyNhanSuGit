﻿using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer;
using DataLayer.model;
using DevExpress.XtraGrid.Views.Grid;

namespace QUANLYNHANSU
{
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<tb_AllowanceJob> bindinglist = new BindingList<tb_AllowanceJob>();
        private DBcontext conn = new DBcontext();
        private DataLayer.model.tb_AllowanceJob phucapDal;
        private BussinessLayer.phucap phucapBus;
        private bool _isNewRecord;
        public frmPhuCap()
        {
            InitializeComponent();
            phucapDal = new tb_AllowanceJob();
            phucapBus = new phucap();
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
            foreach (tb_AllowanceJob job in phucapBus.GetTb_AllowanceJobs())
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
                    tb_AllowanceJob currentRowHandle = gridView.FocusedRowObject as tb_AllowanceJob;
                    if (currentRowHandle != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có muốn xóa phụ cấp có ID là  {currentRowHandle.AllowanceJobID} không?", " Xóa Phụ Cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {   
                            _isNewRecord = false;
                            phucapBus.DeleteAllowanceJob(currentRowHandle.AllowanceJobID);
                            MessageBox.Show("xóa phụ cấp mới thành công ", "thông báo");
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
            txtTenPhuCap.Enabled = !isEnabled;
            txtSoTienPhuCap.Enabled = !isEnabled;
            //chkTrangThai.Enabled = !isEnabled;
            gcDanhSach.Enabled = isEnabled;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (_isNewRecord)
            {
                if (string.IsNullOrEmpty(txtTenPhuCap.Text) || string.IsNullOrEmpty(txtSoTienPhuCap.Text))

                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                }
                else
                {


                    tb_AllowanceJob newallowanceJob = new tb_AllowanceJob
                    {
                        CreatedBy = "Trần Nhật Phi",
                        CreatedDate = DateTime.Now,
                        State = true,
                        AllowanceJobName = txtTenPhuCap.Text,
                        AllowanceAmount = int.Parse(txtSoTienPhuCap.Text)
                    };
                    phucapBus.AddAllowanceJob(newallowanceJob);
                    LoadData();
                    //bindinglist.Add(newallowanceJob);
                    MessageBox.Show("thêm phụ cấp mới thành công ", "thông báo");
                    _isNewRecord = false;
                    ToggleFormState(true);
                    ClearForm();
                }
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txtTenPhuCap.Text) || string.IsNullOrEmpty(txtSoTienPhuCap.Text))

                    {
                        MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {


                        int rowIndex = gcDanhSach.FocusedView.DataRowCount;
                        if (rowIndex > 0)
                        {
                            GridView gridView = gcDanhSach.MainView as GridView;
                            tb_AllowanceJob currentRowHandle = gridView.FocusedRowObject as tb_AllowanceJob;
                            if (currentRowHandle != null)
                            {

                                using (var transaction = conn.Database.BeginTransaction())
                                {
                                    try
                                    {

                                        var allowanceID = conn.tb_AllowanceJob.FirstOrDefault(j => j.AllowanceJobID == currentRowHandle.AllowanceJobID);
                                        if (allowanceID != null)
                                        {

                                            currentRowHandle.AllowanceJobName = txtTenPhuCap.Text;
                                            allowanceID.AllowanceJobName = txtTenPhuCap.Text;
                                            currentRowHandle.AllowanceAmount = int.Parse(txtSoTienPhuCap.Text);
                                            allowanceID.AllowanceAmount = int.Parse(txtSoTienPhuCap.Text);
                                            //currentRowHandle.UpdatedDate = DateTime.Now;
                                            allowanceID.UpdatedBy = "Trần Nhật Phi";
                                            allowanceID.UpdatedDate = DateTime.Now;
                                            conn.SaveChanges();
                                            transaction.Commit();
                                            MessageBox.Show("sửa phụ cấp mới thành công ", "thông báo");
                                            LoadData();
                                            ToggleFormState(true);

                                            ClearForm();
                                        }

                                    }
                                    catch (DbUpdateException ex)
                                    {
                                        transaction.Rollback();
                                        throw new Exception("Lỗi Trong khi đang sửa phụ cấp: " + ex.InnerException.Message);
                                    }
                                }
                            }
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                
                }
                
            }
        }
        private void ClearForm()
        {
            txtTenPhuCap.Text = string.Empty;
            txtSoTienPhuCap.Text = string.Empty;
            phucapDal = null;
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát màn hình phu cap?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            var focusedObject = (gcDanhSach.MainView as GridView).FocusedRowObject;
            txtTenPhuCap.Text = focusedObject.GetType().GetProperty("AllowanceJobName").GetValue(focusedObject).ToString();
            txtSoTienPhuCap.Text = focusedObject.GetType().GetProperty("AllowanceAmount").GetValue(focusedObject).ToString();
            
        }
    }
}