using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Data;
using MyProject.Data.interfaces;
using MyProject.Data.Repository;
using MyProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using MyProject.Hubs;
using Microsoft.AspNetCore.Routing.Constraints;

namespace MyProject
{
    public class Startup
    {
       
        public IConfigurationRoot confString;
        public IConfiguration Configuration { get; set; }
       

        public Startup(IHostingEnvironment hostEnv, IConfiguration configuration)
        {
            confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
            Configuration = configuration;      
        }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(confString.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAllPhone, PhoneRepository>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<IPhonesCategory, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
           /* services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromTicks(0);
            });*/
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddDataAnnotationsLocalization()
                .AddViewLocalization();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("de"),
                    new CultureInfo("ru")
                };

                options.DefaultRequestCulture = new RequestCulture("ru");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            services.AddSignalR();

        }


        public void Configure(IApplicationBuilder app)
        {

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHubs>("/Chat");

            });
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();      
            app.UseAuthentication();
            app.UseDeveloperExceptionPage();
            /* var supportedCultures = new[]
            {
                 new CultureInfo("en"),
                 new CultureInfo("ru"),
                 new CultureInfo("de")
             };
             app.UseRequestLocalization(new RequestLocalizationOptions
             {
                 DefaultRequestCulture = new RequestCulture("en"),
                 SupportedCultures = supportedCultures,
                 SupportedUICultures = supportedCultures
             });*/
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);
            app.UseStaticFiles();
            

            app.UseMvc(routes =>
              {             
                  routes.MapRoute(
                      name: "default",
                      template: "{controller=Home}/{action=Index}/{id?}");
                  routes.MapRoute(
                     name: "default2",
                     template: "{controller}/{action}/{id?}",
                     constraints: new { id = new IntRouteConstraint() },
                     defaults: new { controller = "Phones", action = "Information" }
                     );
                  routes.MapRoute(
                         name: "ForContact",
                         template: "{controller=Home}/{action=Contact}/{id?}");
                  routes.MapRoute(
                       name: "ForIndex",
                       template: "{controller=Phones}/{action=Index}/{id?}");
                  routes.MapRoute(
                      name: "ForUsersIndex",
                      template: "{controller=Users}/{action=Index}/{id?}");
                  routes.MapRoute(
                      name: "ForUsersEdit",
                      template: "{controller=Users}/{action=Edit}/{id?}");
                  routes.MapRoute(
                      name: "ForHomePrivacy",
                      template: "{controller=Home}/{action=Privacy}/{id?}");
                  routes.MapRoute(
                      name: "ForRolesIndex",
                      template: "{controller=Roles}/{action=Index}/{id?}");
                  routes.MapRoute(
                      name: "ForRolesCreate",
                      template: "{controller=Roles}/{action=Create}/{id?}");
                  routes.MapRoute(
                      name: "ForRolesUserList",
                      template: "{controller=Roles}/{action=UserList}/{id?}");
                  routes.MapRoute(
                     name: "ForUsersCreate",
                     template: "{controller=Users}/{action=Create}/{id?}");

              });
           
            using (var scope = app.ApplicationServices.CreateScope())
            {
               AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                ObjectsDB.Initial(context);
            }                                  
        }
    }
}


