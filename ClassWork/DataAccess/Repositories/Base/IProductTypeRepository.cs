using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories.Base
{
    public interface IProductTypeRepository
    {
        IEnumerable<ProductType> GeProductTypes();
        IEnumerable<ProductType> GeProductTypes(Expression<Func<ProductType, bool>> func);
    }
}