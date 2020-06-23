using System.Reflection;
using AutoMapper;
using EDUN.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EDUN.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            // Service Layer
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}