using DreamLines.Api.Presenters;
using DreamLines.Core.Interfaces.Gateways.Repositories;
using DreamLines.Core.Interfaces.UseCases;
using DreamLines.Core.UseCases;
using DreamLines.Infrastructure;
using DreamLines.Infrastructure.Data.EntityFramework.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace DreamLines.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Cruise API", Version = "v1" });
            });
            
            services.AddScoped<ICruiseUseCase, CruiseUseCase>();
            services.AddScoped<IShipUseCase, ShipUseCase>();
            services.AddScoped<ICruiseRepository, CruiseRepository>();
            services.AddScoped<CruiseLinePresenter, CruiseLinePresenter>();
            services.AddScoped<ShipPresenter, ShipPresenter>();
            services.AddScoped<CabinTypePresenter, CabinTypePresenter>();
            services.AddScoped<ICabinTypeUseCase, CabinTypeUseCase>();
            services.AddScoped<ICreateCruiseUseCase, CreateCruiseUseCase>();
            services.AddScoped<CreateCruisePresenter, CreateCruisePresenter>();

            services.AddCors(options => options.AddPolicy("CorsPolicy", builder => builder
                                .WithOrigins("http://localhost:4200"
                                             )
                                .AllowCredentials()
                                .AllowAnyHeader()
                                .AllowAnyMethod()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cruise V1");
                c.RoutePrefix = string.Empty;
            });
            app.UseMvc();
            app.UseCors("CorsPolicy");
        }
    }
}
