using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BHXH
    {
        public void addtb_SocialInsurance(tb_SocialInsurance tb_SocialInsurances)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        tb_SocialInsurances.State = true;
                        tb_SocialInsurances.CreatedBy = "Trần Nhật Phi";
                        conn.tb_SocialInsurance.Add(tb_SocialInsurances);

                        conn.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi thêm . vui lòng kiểm tra đầu vào của bạn và thử lại!!!..");
                    }
                }
            }
        }
        public void Deletetb_SocialInsurances(string SocialInsurances)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {
                    try
                    {

                        var EmployeeSocialInsurances = conn.tb_SocialInsurance.FirstOrDefault(j => j.SocialInsuranceID == SocialInsurances);
                        if (EmployeeSocialInsurances != null)
                        {
                            EmployeeSocialInsurances.DeletedBy = "Trần Nhật Phi";
                            EmployeeSocialInsurances.DeletedDate = DateTime.Now;
                            EmployeeSocialInsurances.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("bảo hiểm xã hội không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi trong khi xóa bảo hiểm xã hội : " + ex.InnerException.Message);
                    }
                }
            }
        }
        public bool ResignationIDExists(string SocialInsurancesID)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_SocialInsurance.Any(r => r.SocialInsuranceID == SocialInsurancesID);
            }
        }
    }
}
