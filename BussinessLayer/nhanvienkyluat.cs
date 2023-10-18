using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BussinessLayer
{
    public class NhanVienKyLuat
    {
        public List<tb_EmployeeDiscipline> GetTb_EmployeeDiscipline()
        {
            List<tb_EmployeeDiscipline> list;
            /* return conn.tb_EmployeeAllowanceJob.ToList();*/
            using (var conn = new DBcontext())
            {
                list = conn.tb_EmployeeDiscipline.ToList();
            }
            return list;
        }
        public void AddEmloyeeAllowanceJob(tb_EmployeeDiscipline tb_EmployeeDisciplines)
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
                        throw new Exception("Error while adding employee discipline job. Please check your input and try again.");
                    }
                }
            }


        }
    }
}
