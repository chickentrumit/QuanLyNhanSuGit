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
                        throw new Exception("Error while adding shift type. Please check your input and try again.");
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
                            shifttypeToDelete.DeletedDate=DateTime.Now;
                            shifttypeToDelete.State = false;
                            conn.SaveChanges();
                            transaction.Commit();
                        }
                        else
                        {
                            throw new Exception("shift type không tìm thấy.");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while deleting shift type: " + ex.InnerException.Message);
                    }
                }
            }
            
        }
    }
}
