namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.SocialInsurance]")]
    public partial class tb_SocialInsurance
    {
        [Key]
        [StringLength(10)]
        public string SocialInsuranceID { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SocialInsuranceCreatedDate { get; set; }

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

        public virtual tb_Employee tb_Employee { get; set; }
    }
}
