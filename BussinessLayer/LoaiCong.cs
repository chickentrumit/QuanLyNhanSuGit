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
                        throw new Exception("lỗi khi thêm . vui lòng kiểm tra đầu vào của bạn và thử lại!!!.");
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
                            jobTypeToDelete.DeletedBy = "Trần Nhật Phi";
                            jobTypeToDelete.DeletedDate = DateTime.Now;
                            jobTypeToDelete.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("loại công không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa loại công: " + ex.InnerException.Message);
                    }
                }
            }

        }
    }
}
