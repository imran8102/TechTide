using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageName { get; set; }
        public int Like { get; set; }
        public int Visit { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }
    }
}
