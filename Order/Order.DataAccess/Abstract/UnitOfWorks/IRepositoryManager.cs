using Order.DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Abstract.UnitOfWorks
{
    public interface IRepositoryManager:IAsyncDisposable
    {
        public IOrderRepository OrderRepository { get; }

        Task<int> SaveAsync();
    }
}
