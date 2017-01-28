using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories.Base;

namespace Services.BusinessLogic
{
    public class ProductTypeService
        : Base.IProductTypeService
    {
        private IProductTypeRepository _productTypeRepository = null;

        public ProductTypeService(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }

        public IEnumerable<ProductType> GeProductTypes()
        {
            return _productTypeRepository.GeProductTypes();
        }

        public IEnumerable<ProductType> GeProductTypes(Expression<Func<ProductType, bool>> func)
        {
            return _productTypeRepository.GeProductTypes(func);
        }
    }
}