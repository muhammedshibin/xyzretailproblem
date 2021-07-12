using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYZRetail.Core.Interfaces;
using XYZRetail.Infrastructure.Data;
using XYZRetail.Infrastructure.Data.Repositories;
using XYZRetail.Infrastructure.Service;
using XYZRetail.Web.Helpers;

namespace XYZRetail.Web
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //adding db

            services.AddDbContext<DataContext>(options => options.UseSqlServer(_config.GetConnectionString("DefaultConnection")));


            //adding dependencies

            services.AddScoped<IBasketRepository,BasketRepository>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IBasketService,BasketService>();

            //adding mapper

            services.AddAutoMapper(typeof(MappingProfile));
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ProductsMVC}/{action=Index}/{id?}");
            });
        }
    }
}
