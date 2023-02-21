﻿using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extensions
{
	public static class DataExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
			return services;
		}
	}
}
