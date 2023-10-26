namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.SalaryCalculation]")]
    public partial class tb_SalaryCalculation
    {
        [Key]
        public int SalaryCalculationID { get; set; }

        public int? PayPeriodID { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        public double? OvertimeAmount { get; set; }

        public double? OtherBonuses { get; set; }

        public double? NetSalary { get; set; }

        public virtual tb_Employee tb_Employee { get; set; }
    }
}
