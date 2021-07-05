using Bookshop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //IConfiguration umfasst die appsetting.json

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //IOC - Container 
        {
            //Welche Technologien werden hinzugef�gt (ASP.NET Core Feature (Session-Handling) oder drittanbieter wie DevExpress) 
            services.AddRazorPages(); //Bedeutet, wir verwenden Razor Pages + wir ben�tigen ein Pages-Verzeichnis
            #region andere Alternativen  zu AddRazorPages
            //services.AddControllersWithViews(); //Bedeutet, wir verwenden zus�tzlich noch MVC
            //services.AddMvc(); // Intern wird AddRazorPages + AddControllersWithViews verwendet 
            //services.AddControllers(); //WebAPI 
            //services.AddSession(); //Session Handling wurde hinzugenommen 

            #endregion



            services.Configure<SampleWebSettings>(Configuration);
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); //Aufsatz von Https
            }


            //Allgmein
            app.UseHttpsRedirection(); //https 
            app.UseStaticFiles(); //wwwroot verzeichnis wird mitverwendet

            app.UseRouting(); //Routing

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //Endpoint f�r Razor Pages -> Request findet seine RazorPage - Seite
            });
        }
    }
}