using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.Update;

namespace ProductManagement.API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            #region  Category

            services.AddScoped<CreateCategoryHandler>();
            services.AddScoped<GetCategoryHandler>();
            services.AddScoped<UpdateCategoryHandler>();
            services.AddScoped<DeleteCategoryHandler>();

            #endregion  

            return services;
        }
    }

}
