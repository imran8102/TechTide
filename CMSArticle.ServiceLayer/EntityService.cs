using CMSArticle.ModelsLayer;
using CMSArticle.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public class EntityService<T> : GenericReposity<T> where T : BaseEntity
    {
        public EntityService(CmsContext context) : base(context)
        {
        }
    }
}
