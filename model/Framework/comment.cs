namespace model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("comment")]
    public partial class comment
    {
        [Key]
        public int comment_id { get; set; }

        [DisplayName("Nội dung bình luận")]
        [Required]
        public string comment_text { get; set; }

        [DisplayName("Ngày đăng tải bình luận")]
        [Required]
        [Column(TypeName = "date")]
        public DateTime? publishDate { get; set; }

        public int? exam_id { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
