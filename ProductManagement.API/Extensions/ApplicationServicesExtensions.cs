using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.CategoryEndpoint.Update;
using ProductManagement.Application.Identity;
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

            #endregion


            services.AddScoped<LoginHandler>();
            services.AddScoped<TokenAuthentication>();
            return services;
        }
    }

}
