using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class LoaiCong
    {
        public List<tb_JobType> GetTb_jobType()
        {
            List<tb_JobType> listJobType;
            using (var conn = new DBcontext())
            {
                listJobType = conn.tb_JobType.Where(item => item.State == true).ToList();
            }
            return listJobType;
        }
        public void AddjobType(tb_JobType tb_jobtypes)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_JobType.Add(tb_jobtypes);
                        conn.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while adding job type. Please check your input and try again.");
                    }
                }
            }


        }


        public void DeletejobType(int jobTypeID)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {

                        var jobTypeToDelete = conn.tb_JobType.FirstOrDefault(j => j.JobTypeID == jobTypeID);
                        if (jobTypeToDelete != null)
                        {
                            jobTypeToDelete.DeletedDate = DateTime.Now;
                            jobTypeToDelete.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("job type not found.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while deleting job type: " + ex.InnerException.Message);
                    }
                }
            }

        }
    }
}
