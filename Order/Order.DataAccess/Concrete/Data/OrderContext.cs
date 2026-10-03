using Microsoft.EntityFrameworkCore;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Concrete.Data
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<OrderEntity> Orders { get; set; }
    }
}
