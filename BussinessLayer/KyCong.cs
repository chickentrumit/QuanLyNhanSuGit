using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class KyCong
    {
        public List<tb_PayPeriod> Gettb_PayPeriod()
        {
            List<tb_PayPeriod> list;
            /* return conn.tb_EmployeeAllowanceJob.ToList();*/
            using (var conn = new DBcontext())
            {
                list = conn.tb_PayPeriod.ToList();
            }
            return list;
        }
        public void Addtb_PayPeriod(tb_PayPeriod tb_PayPeriods)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_PayPeriod.Add(tb_PayPeriods);
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
        public void Deletetb_PayPeriod(int PayPeriodId)
        {

            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {
                    try
                    {

                        var PayPeriodtodelete = conn.tb_PayPeriod.FirstOrDefault(j => j.PayPeriodID == PayPeriodId);
                        if (PayPeriodtodelete != null)
                        {

                            conn.tb_PayPeriod.Remove(PayPeriodtodelete);
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("Kỳ Công không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa kỳ Công: " + ex.InnerException.Message);
                    }
                }
            }
        }
        public bool ResignationIDExists(int PayPeriodIDs)
        {
            using (var conn = new DBcontext())
            {
                return conn.tb_PayPeriod.Any(r => r.PayPeriodID == PayPeriodIDs);
            }
        }
    }
}
