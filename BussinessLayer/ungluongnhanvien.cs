using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class ungluongnhanvien
    {
        public void AddSalaryadvance(tb_SalaryAdvance tb_Salaryadvances)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_SalaryAdvance.Add(tb_Salaryadvances);
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
        public void DeletesalaryAdvance(int EmployeesalaryadvanceId)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {

                        var employeeSalaryADVANceID = conn.tb_SalaryAdvance.FirstOrDefault(j => j.SalaryAdvanceID == EmployeesalaryadvanceId);
                        if (employeeSalaryADVANceID != null)
                        {

                            conn.tb_SalaryAdvance.Remove(employeeSalaryADVANceID);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception(" Ứng Lương Nhân Viên không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa ứng lương nhân viên : " + ex.InnerException.Message);
                    }
                }
            }

        }
    }
}
