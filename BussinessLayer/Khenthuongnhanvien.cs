using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Khenthuongnhanvien
    {
        public List<tb_EmployeeReward> GetTb_EmployeeReward()
        {
            List<tb_EmployeeReward> list;
            /* return conn.tb_EmployeeAllowanceJob.ToList();*/
            using (var conn = new DBcontext())
            {
                list = conn.tb_EmployeeReward.ToList();
            }
            return list;
        }
        public void AddEmloyeeAllowanceJob(tb_EmployeeReward tb_Employeerewards)
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
                        throw new Exception("Error while adding employee reward job. Please check your input and try again.");
                    }
                }
            }


        }   
    }
}
