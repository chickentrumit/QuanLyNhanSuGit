namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmployeeSalaryIncrease]")]
    public partial class tb_EmployeeSalaryIncrease
    {
        [Key]
        public int EmployeeSalaryIncrease { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        public int? Salary { get; set; }

        public int? ResponsibleSalary { get; set; }

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
