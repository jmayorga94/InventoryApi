using Inventory.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Extensions
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<InventoryDbContext>(options =>
            {
                options.UseSqlServer((connectionString),
                b => b.MigrationsAssembly(typeof(InventoryDbContext).Assembly.FullName));

             }, ServiceLifetime.Transient);


            return services;
        }

    }
}
