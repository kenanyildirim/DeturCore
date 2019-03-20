using Detur.Cms.DataAccess.Abstract;
using Detur.Cms.DataAccess.Concrete.EntityFramework.Contexts;
using Detur.Cms.Entities.Concrete;
using Detur.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Detur.Cms.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,CmsContext>, IProductDal
    {
       
    }
}
