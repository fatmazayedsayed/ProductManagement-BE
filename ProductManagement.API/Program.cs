using FastEndpoints;
using Microsoft.OpenApi.Models;
using NLog.Web;
using ProductManagement.API.Extensions;
using ProductManagement.API.Filters;

using ProductManagement.Infrastructure.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(corsBuilder =>
    {
        corsBuilder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// Add controllers and custom exception filter
builder.Services.AddControllers(config =>
{
    config.Filters.Add(typeof(ProductManagementExceptionHandler));
})
.AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

// Add Swagger configuration for categories and products
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("Authentication", new OpenApiInfo
    {
        Version = "v1",
        Title = "Authentication API",
        Description = "API documentation for Authentication management.",
    });
    c.SwaggerDoc("Category", new OpenApiInfo
    {
        Version = "v1",
        Title = "Category API",
        Description = "API documentation for Category management.",
    });


    c.SwaggerDoc("Product", new OpenApiInfo
    {
        Version = "v1",
        Title = "Product API",
        Description = "API documentation for Product management.",
    });


});

// Register authentication and application services
builder.InitSwagger();
builder.Services.AddHttpContextAccessor();
builder.RegisterAuthentication();



// Configure logging
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Error);
builder.Host.UseNLog();

builder.Services.AddApplicationServices(); // This will register CreateCategoryHandler and other services
builder.Services.AddDataServices(builder.Configuration);

// Register FastEndpoints services
builder.Services.AddFastEndpoints();

var app = builder.Build();

// Use Swagger middleware
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/Authentication/swagger.json", "Authentication API");
    c.SwaggerEndpoint("/swagger/Category/swagger.json", "Category API");
    c.SwaggerEndpoint("/swagger/Product/swagger.json", "Product API");

    c.RoutePrefix = "swagger"; // Swagger UI will be available at /swagger
    c.DisplayRequestDuration();
    c.DefaultModelsExpandDepth(-1);
    c.EnablePersistAuthorization();
});

// Enable middleware for CORS, HTTPS Redirection, Authorization
app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

// Register FastEndpoints in the request pipeline
app.UseFastEndpoints();

// Map Controllers (if needed, depending on your project structure)
app.MapControllers();

app.Run();
