using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace EDUN.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}