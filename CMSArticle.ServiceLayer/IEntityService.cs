using CMSArticle.ModelsLayer;
using CMSArticle.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public interface IEntityService<T> where T : BaseEntity
    {
    }
}
