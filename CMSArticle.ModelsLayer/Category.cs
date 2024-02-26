using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Category")]
    public class Category:BaseEntity
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string ImageName { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
