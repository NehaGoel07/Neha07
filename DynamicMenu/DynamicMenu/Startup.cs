using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DynamicMenu.Models;
using DynamicMenu.Models.IRepository;
using DynamicMenu.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DynamicMenu
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
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("conn"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<IMenuMasterService, MenuMasterService>();
            services.AddTransient<IMyTasksRepository, MyTasksRepository>();
           
            services.AddTransient<RoleHandlerFilter>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AuthorizedUSer",
                  policy => policy
                    .Requirements
                    .Add(new RoleRequirement("Admin","CreateRole")));
            });

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AuthorizedRole", policy =>
            //     policy.RequireRole("User", "Admin"));
            //});

            //Policy based on claims
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Role", policy =>
            //     policy.RequireClaim(ClaimTypes.Email));
            //});

            //Redirect when access denied is encountered
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Home/AccessDenied");
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 2;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 5;
            });

            services.AddMvc();
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
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
