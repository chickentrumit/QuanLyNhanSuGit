using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class NhanVienThoiViec
    {   public void AddResignation(tb_Resignation tb_Resignations)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_Resignation.Add(tb_Resignations);
                        conn.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi thêm . vui lòng kiểm tra đầu vào của bạn và thử lại!!!.");
                    }
                }
            }
        }
        public void DeleteEmployeeResignation(string EmployeeResignationID)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {
                    try
                    {

                        var EmployeeResignationToDelete = conn.tb_Resignation.FirstOrDefault(j => j.ResignationID == EmployeeResignationID);
                        if (EmployeeResignationToDelete != null)
                        {

                            conn.tb_Resignation.Remove(EmployeeResignationToDelete);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("Nhân viên kỳ công không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi trong khi xóa nhân viên kỳ công : " + ex.InnerException.Message);
                    }
                }
            }
        }
        public bool ResignationIDExists(string resignationID)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_Resignation.Any(r => r.ResignationID == resignationID);
            }
        }


    }
}
