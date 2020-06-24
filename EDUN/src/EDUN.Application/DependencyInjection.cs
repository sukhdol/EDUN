using System.Reflection;
using AutoMapper;
using EDUN.Application.Services;
using EDUN.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EDUN.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            // Service Layer
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<ICategoryService, CategoryService>();

            return services;
        }
    }
}