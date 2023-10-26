namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.EmplymentContract]")]
    public partial class tb_EmplymentContract
    {
        [Key]
        [StringLength(15)]
        public string EmploymentContracID { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeID { get; set; }

        public int? ContractDuration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractEndDate { get; set; }

        public int? ContractSignCount { get; set; }

        public bool? State { get; set; }

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
