using Microsoft.Extensions.DependencyInjection;
using Product.Business.Concrete.Mappings;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Product.Business.Concrete.Extensions
{
    public static class BusinessLayerExtensions
    {
        public static void ConfigureBusinessLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddMaps(typeof(MappingProfile)));

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
        }
    }
}
