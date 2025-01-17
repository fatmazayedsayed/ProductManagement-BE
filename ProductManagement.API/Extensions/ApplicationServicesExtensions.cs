using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.CategoryEndpoint.Update;
using ProductManagement.Application.Identity;
using ProductManagement.Application.ProductEndpoint.Update;
using ProductManagement.Application.UserEndpoint;

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
            services.AddScoped<GetCategoryForViewHandler>();
            services.AddScoped<GetLookUpCategoryHandler>();
            services.AddScoped<GetLookUpParentCategoryHandler>();

            #endregion
            #region  Product

            services.AddScoped<CreateProductHandler>();
            services.AddScoped<GetProductHandler>();
            services.AddScoped<UpdateProductHandler>();
            services.AddScoped<DeleteProductHandler>();
            services.AddScoped<GetProductForViewHandler>();
            #endregion

            services.AddScoped<LoginHandler>();
            services.AddScoped<TokenAuthentication>();
             return services;
        }
    }

}
