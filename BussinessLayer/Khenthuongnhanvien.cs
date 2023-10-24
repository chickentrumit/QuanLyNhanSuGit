using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Khenthuongnhanvien
    {
        public void AddEmployeeReward(tb_EmployeeReward tb_Employeerewards)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_EmployeeReward.Add(tb_Employeerewards);
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
        public void DeleteEmployeeReward(string employeeReward)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {

                        var EmployeeRewardToDelete = conn.tb_EmployeeReward.FirstOrDefault(j => j.EmployeeRewardID == employeeReward);
                        if (EmployeeRewardToDelete != null)
                        {

                            conn.tb_EmployeeReward.Remove(EmployeeRewardToDelete);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("khen thưởng Nhân Viên không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa Khen thưởng nhân viên: " + ex.InnerException.Message);
                    }
                }
            }

        }
        public bool employeeRewardIDExists(string employeeRewardID)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_EmployeeReward.Any(r => r.EmployeeRewardID == employeeRewardID);
            }
        }
    }
}
