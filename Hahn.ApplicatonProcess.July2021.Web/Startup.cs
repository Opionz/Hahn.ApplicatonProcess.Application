using FluentValidation.AspNetCore;
using Hahn.ApplicatonProcess.July2021.Data.AutoMapper;
using Hahn.ApplicatonProcess.July2021.Data.Models;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;
using Hahn.ApplicatonProcess.July2021.Domain.Validation;
using Hahn.ApplicatonProcess.July2021.Web.Filter;
using Hahn.ApplicatonProcess.July2021.Web.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hahn.ApplicatonProcess.July2021.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperConfig));
            services.AddRepositories();
            services.AddControllers(configure =>
            {
                configure.Filters.Add(typeof(ValidationMiddleware));
            });

            services.AddFluentValidation(
                configure =>
                {
                    configure.RegisterValidatorsFromAssemblyContaining<UserPostDtoValidation>();
                });

            services.Configure<ApiBehaviorOptions>(config =>
            {
                config.SuppressModelStateInvalidFilter = true;
            });

            services
                .AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<HahnContext>(
                (options) => options.UseInMemoryDatabase("hahnContext"));

            services.AddSwaggerConfig();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hahn.ApplicatonProcess.July2021.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
