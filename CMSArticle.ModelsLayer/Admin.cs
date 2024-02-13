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
    public class Admin
    {
        [Key]
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        public int AdminId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        [MaxLength(30)]
        public string Family { get; set; }
        [MaxLength(13)]
        [RegularExpression("09[0-9]{9}", ErrorMessage = "{0} نامعتبر است.")]
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "لطفا از کاراکتر های انگلیسی استفاده کنید.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        public DateTime RegisterDate { get; set; }
        [Required(ErrorMessage = "فیلد {0} اجباری است.")]
        public bool IsActive { get; set; }

        public IEnumerable<Article> Articles { get; set; }

    }
}
