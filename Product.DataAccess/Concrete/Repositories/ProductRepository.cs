using Product.DataAccess.Abstract.Repositories;
using Product.DataAccess.Concrete.Data.Context.EntityFramework;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Concrete.Repositories
{
    public class ProductRepository : EfRepositoryBase<ProductEntity, ProductContext>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }
    }
}
