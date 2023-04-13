namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAccount")]
    public partial class UserAccount
    {
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string userpass { get; set; }

        public int? user_id { get; set; }

        [Key]
        public int userAccount_id { get; set; }

        public virtual User User { get; set; }
    }
}
