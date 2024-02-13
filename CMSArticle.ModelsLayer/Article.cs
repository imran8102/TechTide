using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Article")]
    public class Article
    {
        [Key]
        [Required]
        public int ArticleId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageName { get; set; }
        public int Like { get; set; }
        public int Visit { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        public Category Category { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
