using Product.DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Abstract.UnitOfWorks
{
    public interface IRepositoryManager:IAsyncDisposable
    {
        public IProductRepository Product { get;}

        Task<int> SaveAsync();
    }
}
