using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ProductManagement.Application.Identity;
using System.Text;
namespace ProductManagement.API.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplicationBuilder RegisterAuthentication(this WebApplicationBuilder builder)
        {
            var jwtSettings = new JwtSettings();
            builder.Configuration.Bind(nameof(JwtSettings), jwtSettings);

            var jwtSection = builder.Configuration.GetSection(nameof(JwtSettings));
            builder.Services.Configure<JwtSettings>(jwtSection);

            builder.Services
                .AddAuthentication(a =>
                {
                    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    a.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(jwt =>
                {
                    jwt.SaveToken = true;
                    jwt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SecretKey
                            ?? throw new InvalidOperationException())),
                        ValidateIssuer = true,
                        ValidIssuer = jwtSettings.Issuer,
                        ValidateAudience = true,
                        ValidAudience = jwtSettings.Audience,
                        RequireExpirationTime = false,
                        ValidateLifetime = true
                    };
                    jwt.Audience = jwtSettings.Audience;
                    jwt.ClaimsIssuer = jwtSettings.Issuer;
                });


            return builder;
        }

        //public static IServiceCollection AddSwagger(this IServiceCollection services)
        //{
        //    services.AddEndpointsApiExplorer();
        //    services.AddSwaggerGen(option =>
        //    {
        //        option.SwaggerDoc("v1", new OpenApiInfo { Title = "Physiqube API", Version = "v1" });
        //        option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        //        {
        //            In = ParameterLocation.Header,
        //            Description = "Please enter a valid token",
        //            Name = "Authorization",
        //            Type = SecuritySchemeType.Http,
        //            BearerFormat = "JWT",
        //            Scheme = "Bearer"
        //        });
        //        option.AddSecurityRequirement(new OpenApiSecurityRequirement
        //    {
        //        {
        //            new OpenApiSecurityScheme
        //            {
        //                Reference = new OpenApiReference
        //                {
        //                    Type=ReferenceType.SecurityScheme,
        //                    Id="Bearer"
        //                }
        //            },
        //            new string[]{}
        //        }
        //    });
        //    });
        //    return services;
        //}
    }
}
