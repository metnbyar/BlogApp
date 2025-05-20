using BlogApp.Data.Context;
using BlogApp.Data.Repositories.Abstractsions;
using BlogApp.Data.Repositories.Concretes;
using BlogApp.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Extensions
{
    public static class DataLayerExtentions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services , IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            

            services.AddScoped<IUnitOfWork,UnitOfWork>();
            return services;
        }
    }
}
