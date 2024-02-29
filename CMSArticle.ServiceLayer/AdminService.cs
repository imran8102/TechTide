using CMSArticle.ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.ServiceLayer
{
    public class AdminService : EntityService<Admin> , IAdminService
    {
        public AdminService(CmsContext context) : base(context)
        {
        }
    }
}
