using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application.Abstractions.DataAbstractions;
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
            return services;
        }

       

        private static void setInterfaces(MediatRServiceConfiguration cfg)
        {
               cfg.RegisterServicesFromAssembly(typeof(ICategoryRepository).Assembly);
          
        }
    }
}
