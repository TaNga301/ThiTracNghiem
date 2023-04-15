namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admin()
        {
            Subjects = new HashSet<Subject>();
        }

        public int? role_id { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string user_pass { get; set; }

        [Key]
        public int admin_id { get; set; }

        [StringLength(50)]
        public string admin_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
