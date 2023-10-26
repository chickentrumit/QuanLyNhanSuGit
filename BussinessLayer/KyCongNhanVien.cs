using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class KyCongNhanVien
    {
        public void AddEmployeePayperiod(tb_EmployeePayperiod tb_EmployeePayperiods)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_EmployeePayperiod.Add(tb_EmployeePayperiods);
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
        public void DeleteEmployeePayperiod(int EmployeePayperiodIDs)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {

                        var EmployeePayperiODiD = conn.tb_EmployeePayperiod.FirstOrDefault(j => j.EmployeePayperiodID == EmployeePayperiodIDs);
                        if (EmployeePayperiODiD != null)
                        {

                            conn.tb_EmployeePayperiod.Remove(EmployeePayperiODiD);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception(" kỳ công Nhân Viên không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa kỳ công nhân viên : " + ex.InnerException.Message);
                    }
                }
            }

        }
    }
}
