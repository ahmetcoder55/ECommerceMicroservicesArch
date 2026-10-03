using Microsoft.EntityFrameworkCore;
using Order.DataAccess.Concrete.Data;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Concrete.Repositories
{
    public class OrderRepository : GenericRepository<OrderEntity, OrderContext>
    {
        public OrderRepository(OrderContext context, DbSet<OrderEntity> dbSet) : base(context, dbSet)
        {
        }
    }
}
