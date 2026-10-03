using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Abstract.Repositories
{
    public interface IOrderRepository:IGenericRepository<OrderEntity>
    {
    }
}
