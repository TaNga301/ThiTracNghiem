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

        public virtual Subject Subject { get; set; }
    }
}
