namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [Key]
        public int user_id { get; set; }
        [DisplayName("Họ")]

        [StringLength(10)]
        public string firstName { get; set; }

        [DisplayName("Tên")]

        [StringLength(50)]
        public string lastName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [DataType(DataType.Password)]

        [StringLength(50)]
        public string userpass { get; set; }


        [DisplayName("Tài khoản")]
        [StringLength(50)]
        public string username { get; set; }

        [DisplayName("Ngày sinh")]
        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [DisplayName("Email")]
        [StringLength(100)]
        public string email { get; set; }

        [DisplayName("Số điện thoại")]
        [StringLength(15)]
        public string phone { get; set; }

        [DisplayName("Địa chỉ")]
        [StringLength(250)]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
