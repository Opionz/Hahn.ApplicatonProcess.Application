using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;
using System.Reflection;

namespace Hahn.ApplicatonProcess.July2021.Web.Swagger
{
    public static class SwaggerServices
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Hahn.ApplicatonProcess.July2021.Web",
                    Version = "v1",
                    Description = "This is a screening stage app for Hahn Softwareentwicklung developed by Opeyemi Ajayi",
                    Contact = new OpenApiContact() { Email = "ope.ajayi@hotmail.com", Name = "Opeyemi Ajayi" }
                });

                c.ExampleFilters();
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            return services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        }
    }
}
