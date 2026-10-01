using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Abstract.Repositories
{
    public interface IProductRepository:IGenericRepository<ProductEntity>
    {

    }
}
