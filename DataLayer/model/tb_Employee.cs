namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.Employee]")]
    public partial class tb_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Employee()
        {
            tb_EmployeeAllowanceJob = new HashSet<tb_EmployeeAllowanceJob>();
            tb_EmployeeDiscipline = new HashSet<tb_EmployeeDiscipline>();
            tb_EmployeePayperiod = new HashSet<tb_EmployeePayperiod>();
            tb_EmployeePromotionTranfer = new HashSet<tb_EmployeePromotionTranfer>();
            tb_EmployeeReward = new HashSet<tb_EmployeeReward>();
            tb_EmployeeSalaryIncrease = new HashSet<tb_EmployeeSalaryIncrease>();
            tb_EmplymentContract = new HashSet<tb_EmplymentContract>();
            tb_HealthInsurance = new HashSet<tb_HealthInsurance>();
            tb_Resignation = new HashSet<tb_Resignation>();
            tb_SalaryAdvance = new HashSet<tb_SalaryAdvance>();
            tb_SalaryCalculation = new HashSet<tb_SalaryCalculation>();
            tb_SocialInsurance = new HashSet<tb_SocialInsurance>();
        }

        [Key]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        [StringLength(40)]
        public string MiddleName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        public bool? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(15)]
        public string CitizenIdentification { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? JoinDate { get; set; }

        public bool? State { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(25)]
        public string DeletedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeAllowanceJob> tb_EmployeeAllowanceJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeDiscipline> tb_EmployeeDiscipline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeePayperiod> tb_EmployeePayperiod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeePromotionTranfer> tb_EmployeePromotionTranfer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeReward> tb_EmployeeReward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeSalaryIncrease> tb_EmployeeSalaryIncrease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmplymentContract> tb_EmplymentContract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HealthInsurance> tb_HealthInsurance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Resignation> tb_Resignation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SalaryAdvance> tb_SalaryAdvance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SalaryCalculation> tb_SalaryCalculation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SocialInsurance> tb_SocialInsurance { get; set; }
    }
}
