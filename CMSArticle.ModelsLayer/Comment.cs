using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Comment")]
    public class Comment
    {
        [Key]
        [Required]
        public int CommentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Content { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public Article Article { get; set; }
    }
}
