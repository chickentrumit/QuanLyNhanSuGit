using DataLayer.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class LoaiCa
    {
        public List<tb_ShiftType> GetTb_shiftType()
        {
            List<tb_ShiftType> listshifttype;
            using (var conn = new DBcontext())
            {
               listshifttype = conn.tb_ShiftType.Where(item => item.State==true).ToList();
            }
            return listshifttype;
        }
        public void AddshiftType(tb_ShiftType tb_ShiftTypes)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {
                        conn.tb_ShiftType.Add(tb_ShiftTypes);
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


        public void DeleteshiftType(int shiftTypesID)
        {
            using (var conn = new DBcontext())
            {
                using (var transaction = conn.Database.BeginTransaction())
                {

                    try
                    {

                        var shifttypeToDelete = conn.tb_ShiftType.FirstOrDefault(j => j.ShiftTypeID == shiftTypesID);
                        if (shifttypeToDelete != null)
                        {
                            shifttypeToDelete.DeletedBy = "Trần Nhật Phi";
                            shifttypeToDelete.DeletedDate=DateTime.Now;
                            shifttypeToDelete.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("loại ca không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("lỗi khi xóa loại ca: " + ex.InnerException.Message);
                    }
                }
            }
            
        }
    }
}
