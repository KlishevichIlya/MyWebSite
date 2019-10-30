using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Data;
using MyProject.Data.interfaces;
using MyProject.Data.Mocks;
using MyProject.Data.Repository;
using MyProject.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace MyProject
{
    public class Startup
    {
       
        public IConfigurationRoot confString;
        public IConfiguration Configuration { get; }

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
            services.AddMvc();


        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();           
            app.UseStaticFiles();            
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
               AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                ObjectsDB.Initial(context);
            }


           
        }


    }
}


