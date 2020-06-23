using EDUN.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using EDUN.Application.Common.Interfaces;
using EDUN.Domain.Interfaces.Repositories;
using EDUN.Domain.Interfaces.UnitOfWork;
using EDUN.Infrastructure.Repositories;

namespace EDUN.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("Default"))
            );
            
            // Application Db Context
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            
            // Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            
            // EDUN Entities Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
    }
}
