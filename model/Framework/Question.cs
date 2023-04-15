namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Results = new HashSet<Result>();
        }

        [Key]
        public int question_id { get; set; }

        [StringLength(250)]
        [DisplayName("Câu hỏi")]
        [Required]
        public string question_text { get; set; }

        [DisplayName("Đáp án A")]
        public string awnser_A { get; set; }

        [DisplayName("Đáp án B")]
        public string awnser_B { get; set; }

        [DisplayName("Đáp án C")]
        public string awnser_C { get; set; }

        [DisplayName("Đáp án D")]
        public string awnser_D { get; set; }

        [DisplayName("Đáp án chính xác")]
        public string correctAwnser { get; set; }

        public int? level_id { get; set; }

        public int? subject_id { get; set; }

        public int? chapter_id { get; set; }

        public virtual Chapter Chapter { get; set; }

        public virtual Level Level { get; set; }

        public virtual Subject Subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
