using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Admin")]
    public class Admin:BaseEntity
    {
        [Key]
        [Required]
        public int AdminId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Family { get; set; }
        [MaxLength(13)]
        [Required]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public IEnumerable<Article> Articles { get; set; }

    }
}
