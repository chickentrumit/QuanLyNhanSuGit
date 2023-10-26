namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmployeeDiscipline]")]
    public partial class tb_EmployeeDiscipline
    {
        [Key]
        [StringLength(10)]
        public string EmployeeDisciplineID { get; set; }

        public int PayPeriodID { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        public int? Amount { get; set; }

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

        public virtual tb_Employee tb_Employee { get; set; }
    }
}
