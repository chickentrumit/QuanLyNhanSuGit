namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.ProgramParameters]")]
    public partial class tb_ProgramParameters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ProgramParametersID { get; set; }

        public byte? MaleStartAge { get; set; }

        public byte? MaleEndAge { get; set; }

        public byte? FemaleStartAge { get; set; }

        public byte? FemaleEndAge { get; set; }

        public double? HealthInsurancePercentage { get; set; }

        public double? SocialInsurancePercentage { get; set; }

        public double? PersonalIncomeTax { get; set; }

        public bool? State { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(25)]
        public string UpdateBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateDate { get; set; }

        [StringLength(25)]
        public string DeletedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedDate { get; set; }
    }
}
