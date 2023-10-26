namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.PayPeriod]")]
    public partial class tb_PayPeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_PayPeriod()
        {
            tb_EmployeeAllowanceJob = new HashSet<tb_EmployeeAllowanceJob>();
            tb_EmployeePayperiod = new HashSet<tb_EmployeePayperiod>();
            tb_EmployeeReward = new HashSet<tb_EmployeeReward>();
            tb_SalaryAdvance = new HashSet<tb_SalaryAdvance>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayPeriodID { get; set; }

        public byte? Month { get; set; }

        public int? Year { get; set; }

        public byte? WorkDayInMonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeAllowanceJob> tb_EmployeeAllowanceJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeePayperiod> tb_EmployeePayperiod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeReward> tb_EmployeeReward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SalaryAdvance> tb_SalaryAdvance { get; set; }
    }
}
