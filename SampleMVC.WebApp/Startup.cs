using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampleMVC.Infraestructure.Interfaces;
using SampleMVC.Infraestructure.Api;
using Microsoft.Extensions.Logging;
using AutoMapper;
using SmapleMVC.Core.Interfaces;
using SampleMVC.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SampleMVC.WebApp
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
            services.AddControllersWithViews();

            services.AddDbContext<SampleMvcContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SampleMVC")));

            services.AddScoped<IPropertyApiService, PropertyApiService>();
            services.AddScoped<ILogger, Logger<PropertyApiService>>();
            services.AddScoped<IRepository, EFRepository>();

            services.AddAutoMapper(m => m.AddProfile<AutoMapping>(), typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Property}/{action=Index}/{id?}");
            });
        }
    }
}
