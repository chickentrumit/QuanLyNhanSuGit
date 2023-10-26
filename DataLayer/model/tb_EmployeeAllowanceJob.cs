namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmployeeAllowanceJob]")]
    public partial class tb_EmployeeAllowanceJob
    {
        [Key]
        public int EmployeeAllowanceJobID { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        public int PayPeriodID { get; set; }

        public short AllowanceJobID { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedDate { get; set; }

        public virtual tb_AllowanceJob tb_AllowanceJob { get; set; }

        public virtual tb_Employee tb_Employee { get; set; }

        public virtual tb_PayPeriod tb_PayPeriod { get; set; }
    }
}
