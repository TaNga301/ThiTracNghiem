namespace model.Framework
{
    using System;
    using System.Collections.Generic;
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
        public string question_text { get; set; }

        public string awnser_A { get; set; }

        public string awnser_B { get; set; }

        public string awnser_C { get; set; }

        public string awnser_D { get; set; }

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
