using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.Abstractions.DataAbstractions;

namespace ProductManagement.API.Extensions
{


    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register the CreateCategoryHandler class for DI
            services.AddScoped<CreateCategoryHandler>();

          
 
            return services;
        }
    }

}
