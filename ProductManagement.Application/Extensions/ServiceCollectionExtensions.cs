using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.Identity;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                setInterfaces(cfg);
            });
            services.AddScoped<IdentityService>();
            services.AddScoped<TokenAuthentication>();
 
            services.AddScoped<ICurrentSessionProvider, CurrentSessionProvider>();

            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            return services;
        }



        private static void setInterfaces(MediatRServiceConfiguration cfg)
        {
            cfg.RegisterServicesFromAssembly(typeof(ICategoryRepository).Assembly);
            cfg.RegisterServicesFromAssembly(typeof(IUserRepository).Assembly);

        }
    }
}
