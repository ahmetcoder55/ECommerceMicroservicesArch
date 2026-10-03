using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Order.DataAccess.Abstract.Repositories;
using Order.DataAccess.Abstract.UnitOfWorks;
using Order.DataAccess.Concrete.Data;
using Order.DataAccess.Concrete.Repositories;
using Order.DataAccess.Concrete.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.DataAccess.Concrete.Extensions
{
    public static class DataAccessExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<OrderContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("OrderConfiguration"));
            });
        }
        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
