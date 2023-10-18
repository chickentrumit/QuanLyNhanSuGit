using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class NhanVienphucap
    {
        //private DBcontext conn = new DBcontext();
        public List<tb_EmployeeAllowanceJob> GetTb_EmployeeAllowanceJobs()
        {
            List<tb_EmployeeAllowanceJob> list;
           /* return conn.tb_EmployeeAllowanceJob.ToList();*/
            using (var  conn = new DBcontext())
            {
                list= conn.tb_EmployeeAllowanceJob.ToList();
            }
            return list;
        }
        public void AddEmloyeeAllowanceJob(tb_EmployeeAllowanceJob tb_EmoloyeeAllowanceJobs)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_EmployeeAllowanceJob.Add(tb_EmoloyeeAllowanceJobs);
                        conn.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while adding employee allowance job. Please check your input and try again.");
                    }
                }
            }
            

        }
    }
}
