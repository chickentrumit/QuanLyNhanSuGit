namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.Account]")]
    public partial class tb_Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Account()
        {
            tb_AccountPermission = new HashSet<tb_AccountPermission>();
        }

        [Key]
        [StringLength(25)]
        public string AccountName { get; set; }

        [StringLength(25)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Role { get; set; }

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
        public virtual ICollection<tb_AccountPermission> tb_AccountPermission { get; set; }
    }
}
