using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.Abstractions.DataAbstractions;

namespace ProductManagement.API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            #region  Category

            services.AddScoped<CreateCategoryHandler>();
            services.AddScoped<GetCategoryHandler>();

            #endregion  

            return services;
        }
    }

}
