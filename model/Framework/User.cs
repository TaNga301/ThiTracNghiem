namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Results = new HashSet<Result>();
        }

        [StringLength(50)]
        public string userpass { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [Key]
        public int user_id { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        [StringLength(10)]
        public string firstName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
