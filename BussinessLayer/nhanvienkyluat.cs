using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
namespace BussinessLayer
{
    public class NhanVienKyLuat
    {
       public void AddEmloyeeDiscipline(tb_EmployeeDiscipline tb_EmployeeDisciplines)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_EmployeeDiscipline.Add(tb_EmployeeDisciplines);
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
        public void DeleteEmployeeDiscipline(string EmployeeDisciplineId)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {
                    try
                    {

                        var EmployeedisciplineToDelete = conn.tb_EmployeeDiscipline.FirstOrDefault(j => j.EmployeeDisciplineID == EmployeeDisciplineId);
                        if (EmployeedisciplineToDelete != null)
                        {

                            conn.tb_EmployeeDiscipline.Remove(EmployeedisciplineToDelete);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("nhân viên Kỹ Luật không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa nhân viên kỹ luật: " + ex.InnerException.Message);
                    }
                }
            }

        }
        public bool DisciplineIDExists(string disciplineID)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_EmployeeDiscipline.Any(r => r.EmployeeDisciplineID == disciplineID);
            }
        }
    }
}
