﻿using DataLayer.model;
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
                            throw new Exception("employee discipline không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while deleting employee discipline job: " + ex.InnerException.Message);
                    }
                }
            }

        }
    }
}
