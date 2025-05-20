using BlogApp.Data.Context;
using BlogApp.Data.Repositories.Abstractsions;
using BlogApp.Data.Repositories.Concretes;
using BlogApp.Data.UnitOfWorks;
using BlogApp.Service.Services.Abstractions;
using BlogApp.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
