namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            comments = new HashSet<comment>();
            Results = new HashSet<Result>();
        }

        [Key]
        public int exam_id { get; set; }


        [DisplayName("Tên đề thi")]
        [Required]
        [StringLength(250)]
        public string tile { get; set; }

        [DisplayName("Thời gian làm bài thi")]
        [Required]
        
        public TimeSpan? exame_time { get; set; }

        [DisplayName("Ngày cập nhật")]
        [Required]
        [Column(TypeName = "date")]
        public DateTime? publishDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
