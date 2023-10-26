namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.Resignation]")]
    public partial class tb_Resignation
    {
        [Key]
        [StringLength(15)]
        public string ResignationID { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ResignationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public bool? KeyResiqnation { get; set; }

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
