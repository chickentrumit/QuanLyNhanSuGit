namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmployeePayperiod]")]
    public partial class tb_EmployeePayperiod
    {
        [Key]
        public int EmployeePayperiodID { get; set; }

        public int PayPeriodID { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        public int? WorkdayMonth { get; set; }

        public double? PermittedDayOff { get; set; }

        public double? UnauthorizedDayOff { get; set; }

        public double? HolidayWork { get; set; }

        public double? SundayWork { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedDate { get; set; }

        public virtual tb_Employee tb_Employee { get; set; }

        public virtual tb_PayPeriod tb_PayPeriod { get; set; }
    }
}
