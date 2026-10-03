using Microsoft.EntityFrameworkCore;
using Order.DataAccess.Abstract.Repositories;
using Order.DataAccess.Concrete.Data;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Concrete.Repositories
{
    public class OrderRepository : GenericRepository<OrderEntity, OrderContext>,IOrderRepository
    {
        public OrderRepository(OrderContext context, DbSet<OrderEntity> dbSet) : base(context, dbSet)
        {
        }
    }
}
