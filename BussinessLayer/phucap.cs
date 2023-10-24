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
                    throw new Exception("lỗi khi thêm . vui lòng kiểm tra đầu vào của bạn và thử lại!!!.");
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
                        allowanceJobToDelete.DeletedBy = "Tràn Nhật Phi";
                        allowanceJobToDelete.DeletedDate = DateTime.Now;
                        allowanceJobToDelete.State = false;
                            phucapDAL.SaveChanges();
                            transaction.Commit();
                    }
                    else
                    {
                        throw new Exception("phụ cấp không tìm thấy.");
                    }
                }
                catch (DbUpdateException ex)
                {
                    transaction.Rollback();
                    throw new Exception("lỗi khi xóa phụ cấp: " + ex.InnerException.Message);
                }
            }

        }
    }
}
