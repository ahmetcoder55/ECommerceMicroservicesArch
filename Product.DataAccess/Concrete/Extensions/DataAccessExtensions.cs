using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.DataAccess.Abstract.Repositories;
using Product.DataAccess.Abstract.UnitOfWorks;
using Product.DataAccess.Concrete.Data.Context.EntityFramework;
using Product.DataAccess.Concrete.Repositories;
using Product.DataAccess.Concrete.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DataAccess.Concrete.Extensions
{
    public static class DataAccessExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ProductContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("ProductConfiguration"));
            });
        }
        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
