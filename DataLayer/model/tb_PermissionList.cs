namespace DataLayer.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[tb.PermissionList]")]
    public partial class tb_PermissionList
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string PermissionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Role { get; set; }

        [StringLength(30)]
        public string PermissionName { get; set; }

        [StringLength(30)]
        public string PermissionParent { get; set; }

        public virtual tb_AccountPermission tb_AccountPermission { get; set; }
    }
}
