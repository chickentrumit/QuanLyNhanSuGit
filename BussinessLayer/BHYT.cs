using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{   
     public class BHYT
    {
        public void addtb_HealthInsurance(tb_HealthInsurance tb_HealthInsurances)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        tb_HealthInsurances.State = true;
                        tb_HealthInsurances.CreatedBy = "Trần Nhật Phi";
                        conn.tb_HealthInsurance.Add(tb_HealthInsurances);

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
        public void Deletetb_HealthInsurances(string HealthInsurances)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {
                    try
                    {

                        var EmployeeHealthInsurances = conn.tb_HealthInsurance.FirstOrDefault(j => j.HealthInsuranceID == HealthInsurances);
                        if (EmployeeHealthInsurances != null)
                        {
                            EmployeeHealthInsurances.DeletedBy = "Trần Nhật Phi";
                            EmployeeHealthInsurances.DeletedDate = DateTime.Now;
                            EmployeeHealthInsurances.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("BHYT không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi trong khi xóa BHYT : " + ex.InnerException.Message);
                    }
                }
            }
        }
        public bool ResignationIDExists(string HealthInsurancesID)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_HealthInsurance.Any(r => r.HealthInsuranceID == HealthInsurancesID);
            }
        }
    }
}
