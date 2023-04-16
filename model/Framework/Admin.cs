namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int admin_id { get; set; }
        
        [DisplayName("Họ tên")]
        [Required]
        [StringLength(10)]
        public string fullName { get; set; }


        [DisplayName("Tài khoản")]
        [Required]
        [StringLength(50)]
        public string user_name { get; set; }


        [DisplayName("Mật khẩu")]
        [Required]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string user_pass { get; set; }


        [DisplayName("Ngày sinh")]
        [Column(TypeName = "date")]
        [Required(ErrorMessage ="Vui lòng nhập ngày sinh theo định dạng mm/dd/yyyy")]
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


        public int? role_id { get; set; }

        [DisplayName("Quyền hạn")]
        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
