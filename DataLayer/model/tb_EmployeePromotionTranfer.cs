namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmployeePromotionTranfer]")]
    public partial class tb_EmployeePromotionTranfer
    {
        [Key]
        public int EmployeePromotionID { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        public byte PositionID { get; set; }

        public byte DepartmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedDate { get; set; }

        public virtual tb_Department tb_Department { get; set; }

        public virtual tb_Employee tb_Employee { get; set; }

        public virtual tb_Position tb_Position { get; set; }
    }
}
