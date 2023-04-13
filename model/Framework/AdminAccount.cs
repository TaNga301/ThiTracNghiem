namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminAccount")]
    public partial class AdminAccount
    {
        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string user_pass { get; set; }

        public int? role_id { get; set; }

        public int? admin_id { get; set; }

        [Key]
        public int userAccount_id { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Role Role { get; set; }
    }
}
