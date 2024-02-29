using CMSArticle.ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public class CommentRepository : GenericReposity<Comment>, ICommentRepository
    {
        public CommentRepository(CmsContext context) : base(context)
        {
        }
    }
}
