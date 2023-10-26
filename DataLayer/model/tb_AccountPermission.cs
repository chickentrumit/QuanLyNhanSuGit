namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.AccountPermission]")]
    public partial class tb_AccountPermission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_AccountPermission()
        {
            tb_PermissionList = new HashSet<tb_PermissionList>();
        }

        [Key]
        [StringLength(30)]
        public string PermissionID { get; set; }

        [Required]
        [StringLength(25)]
        public string AccountName { get; set; }

        public bool? AddPermission { get; set; }

        public bool? DeletedPermission { get; set; }

        public bool? UpdatedPermission { get; set; }

        public bool? Disable { get; set; }

        public virtual tb_Account tb_Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PermissionList> tb_PermissionList { get; set; }
    }
}
