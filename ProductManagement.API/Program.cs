using FastEndpoints;
using FastEndpoints.Swagger;
using NLog.Web;
using ProductManagement.API.Extensions;
using ProductManagement.API.Filters;

using ProductManagement.Infrastructure.Extensions;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
   options.AddDefaultPolicy(corsBuilder =>
   {
       corsBuilder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
   });
});

builder.Services.AddControllers(config =>
{
   config.Filters.Add(typeof(ProductManagementExceptionHandler));
})
.AddJsonOptions(options =>
{
   options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
   options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.SwaggerDocument(o =>
{
    o.DocumentSettings = s =>
    {
        s.Title = "My product management";
        s.Version = "v1";
    };
});
builder.Services.AddHttpContextAccessor();
builder.RegisterAuthentication();

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Error);
builder.Host.UseNLog();

builder.Services.AddApplicationServices(); // This will register CreateCategoryHandler and other services
builder.Services.AddDataServices(builder.Configuration);

// Register FastEndpoints services
builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.MapControllers();

app.Run();
