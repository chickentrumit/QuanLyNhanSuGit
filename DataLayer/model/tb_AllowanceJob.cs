namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.AllowanceJob]")]
    public partial class tb_AllowanceJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_AllowanceJob()
        {
            tb_EmployeeAllowanceJob = new HashSet<tb_EmployeeAllowanceJob>();
        }

        [Key]
        public short AllowanceJobID { get; set; }

        [StringLength(40)]
        public string AllowanceJobName { get; set; }

        public int? AllowanceAmount { get; set; }

        public bool? State { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(25)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EmployeeAllowanceJob> tb_EmployeeAllowanceJob { get; set; }
    }
}
