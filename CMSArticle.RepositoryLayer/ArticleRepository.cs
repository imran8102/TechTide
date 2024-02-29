using CMSArticle.ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public class ArticleRepository : GenericReposity<Article>, IArticleRepository
    {
        public ArticleRepository(CmsContext context) : base(context)
        {
        }
    }
}
