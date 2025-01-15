using ProductManagement.Infrastructure.Repositories;
using ProductManagement.Application.Abstractions.DataAbstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using ProductManagement.Domain.Models;
using ProductManagement.Application.Abstractions;

namespace ProductManagement.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductManagementDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            // services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            services.AddScoped<IUnitOfWork, ProductManagementUoW>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
