using RazorPageKurs.Models;
using DependecyInjectionSample;
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
using Westwind.AspNetCore.LiveReload;
using Microsoft.EntityFrameworkCore;
using RazorPageKurs.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using RazorPageKurs.Authorization;
using RazorPageKurs.Hubs;
using RazorPageKurs.Middleware;

namespace RazorPageKurs
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
            services.AddRazorPages(options => {
                //options.Conventions.AuthorizePage("/Contact");
                //options.Conventions.AuthorizeFolder("/Private");
                //options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
                //options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
                options.Conventions.AuthorizePage("/Modul008/Index1", "Admin");
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                    policy.Requirements.Add(new MinimumAgeRequirement(21)));
            });


            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});
            #region 
            //BEISPIEL 1:
            //Page-Directory -> wird /Content Directory jetzt sein
            //services.AddRazorPages().AddRazorPagesOptions(options =>
            //{
            //    options.RootDirectory = "/Content";
            //});


            //BEISPIEL 2:
            //services.AddRazorPages()
            //    .AddRazorPagesOptions(options =>
            //    {
            //        options.Conventions.AddPageRoute("/Modul006/AnyDirectory/FriendlyRoutesSample", "ABC/{year}/{month}/{day}/{title}");
            //    });
            #endregion

            //Welche Technologien werden hinzugef�gt (ASP.NET Core Feature (Session-Handling) oder drittanbieter wie DevExpress) 
            //services.AddRazorPages() //Bedeutet, wir verwenden Razor Pages + wir ben�tigen ein Pages-Verzeichnis
            //    .AddRazorRuntimeCompilation(); //Wird f�r LiveMiddleware Library ben�tigt -> WestWind


            //services.AddRazorPages(config => 
            //{ 

            //});

            #region andere Alternativen  zu AddRazorPages
            //services.AddControllersWithViews(); //Bedeutet, wir verwenden zus�tzlich noch MVC
            //services.AddMvc(); // Intern wird AddRazorPages + AddControllersWithViews verwendet 
            //services.AddControllers(); //WebAPI 
            //services.AddSession(); //Session Handling wurde hinzugenommen 
            //services.AddDbContext -> Intern wird services.AddScoped<DbContext> aufgerufen
            #endregion

            //Singleton -> Einmal verf�gbar, muss nicht wieder instanziiert werden
            services.AddSingleton<ICarService, CarService>(); //CarService - Klasse wurde als Singleton implementiert. 
            //Alternative Schreibweise
            services.AddSingleton(typeof(ICarService), typeof(CarService));
            //services.AddSingleton<ICar, Car>();
            services.AddSingleton<ICar, MockCar>(); //Car wird jetzt nicht mehr verwendet, statt dessen MockCar

            // Transient und Scope sind Request bezogene Lebenszeiten -> werden immer mal wieder erstellt. 
            services.AddTransient<ICarService, CarService>();
            services.AddScoped<ICarService, CarService>();

            services.Configure<SampleWebSettings>(Configuration);
            //services.AddLiveReload();

            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            //Intern wird in AddDbContext AddScoped 
            services.AddDbContext<MovieDbContext>(options =>
            {
                //options.UseInMemoryDatabase("MovieDB");
                options.UseSqlServer(Configuration.GetConnectionString("MovieDbContext"));
            });

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
                options.IdleTimeout = TimeSpan.FromSeconds(60); //TimeOut
            });

            services.AddResponseCaching();

            //services.AddAuthentication();
            services.AddSignalR();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseLiveReload(); //Ist nur f�r Entwickler
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); //Aufsatz von Https
            }

            //Allgmein
            app.UseResponseCaching();
            app.UseHttpsRedirection(); //https 
            app.UseStaticFiles(); //wwwroot verzeichnis wird mitverwendet
            app.UseRouting(); //Routing
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseCookiePolicy();


            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);

            #region Customize Middleware
            
            //Middleware wird aktiv, wenn im Request "imagegen" angegeben wird
            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbnailGen();
            });
            #endregion

            //Endpoints ist die letzte Zeile Code 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //Endpoint f�r Razor Pages -> Request findet seine RazorPage - Seite
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
