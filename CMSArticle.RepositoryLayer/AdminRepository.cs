using CMSArticle.ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public class AdminRepository : GenericReposity<Admin>, IAdminRepository
    {
        public AdminRepository(CmsContext context) : base(context)
        {
        }
    }
}
