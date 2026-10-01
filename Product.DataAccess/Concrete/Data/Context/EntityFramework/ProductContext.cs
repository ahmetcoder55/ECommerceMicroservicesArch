using Microsoft.EntityFrameworkCore;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Concrete.Data.Context.EntityFramework
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
