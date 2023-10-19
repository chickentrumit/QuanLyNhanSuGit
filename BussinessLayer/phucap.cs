using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.model;

namespace BussinessLayer
{
    public class phucap
    {
        private DBcontext phucapDAL = new DBcontext();
        public List<tb_AllowanceJob> GetTb_AllowanceJobs()
        {
            return phucapDAL.tb_AllowanceJob.Where(item => item.State == true).ToList();
        }
        public void AddAllowanceJob(tb_AllowanceJob tb_AllowanceJobs)
        {
            using (var transaction = phucapDAL.Database.BeginTransaction())
            {

                try
                {
                    phucapDAL.tb_AllowanceJob.Add(tb_AllowanceJobs);
                    phucapDAL.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw new Exception("Error while adding allowance job. Please check your input and try again.");
                }
            }

        }
            
        
        public void DeleteAllowanceJob(int allowanceJobId)
        {
            using (var transaction = phucapDAL.Database.BeginTransaction())
            {
                
                try
                {

                    var allowanceJobToDelete = phucapDAL.tb_AllowanceJob.FirstOrDefault(j => j.AllowanceJobID == allowanceJobId);
                    if (allowanceJobToDelete != null)
                    {
                        allowanceJobToDelete.DeletedDate = DateTime.Now;
                        allowanceJobToDelete.State = false;
                            phucapDAL.SaveChanges();
                            transaction.Commit();
                    }
                    else
                    {
                        throw new Exception("Allowance job không tìm thấy.");
                    }
                }
                catch (DbUpdateException ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error while deleting allowance job: " + ex.InnerException.Message);
                }
            }

        }
        public void UpdateAllowanceJob(tb_AllowanceJob updatedAllowanceJob)
        {
            using (var transaction = phucapDAL.Database.BeginTransaction())
            {
                try
                {
                    var allowanceJobToUpdate = phucapDAL.tb_AllowanceJob.Find(updatedAllowanceJob.AllowanceJobID);
                    if (allowanceJobToUpdate != null)
                    {
                        allowanceJobToUpdate.AllowanceJobName = updatedAllowanceJob.AllowanceJobName;
                        allowanceJobToUpdate.AllowanceAmount = updatedAllowanceJob.AllowanceAmount;

                        phucapDAL.SaveChanges();
                        transaction.Commit();
                    }
                    else
                    {
                        throw new Exception("Allowance job not found.");
                    }
                }
                catch (DbUpdateException ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error while updating allowance job: " + ex.InnerException.Message);
                }
            }
        }
    }
}
