﻿using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Blog.Service.Services.Abstract;
using Blog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtentions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly= Assembly.GetExecutingAssembly();
            
            services.AddScoped<IArticleService, ArticleService>();
            
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
