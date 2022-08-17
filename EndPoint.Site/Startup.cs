using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using asp_store_bugeto.Persistence.Contexts;
using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Services.Users.Queries.GetUsers;
using asp_store_bugeto.Application.Services.Users.Queries.GetRoles;
using asp_store_bugeto.Application.Services.Users.Commands.RegisterUsers;
using asp_store_bugeto.Application.Services.Users.Commands.RemoveUser;
using asp_store_bugeto.Application.Services.Users.Commands.ChangeUserState;
using asp_store_bugeto.Application.Services.Users.Commands.EditeUser;
using asp_store_bugeto.Application.Services.Roles.GetRoleByName;
using asp_store_bugeto.Application.Services.Users.Queries.LoginUser;
using Microsoft.AspNetCore.Http;
using asp_store_bugeto.Application.Services.Temp.Queries.GetDataWithKey;
using asp_store_bugeto.Application.Services.Users.Queries.GetUserByEmail;
using asp_store_bugeto.Application.Services.Temp.Commands.RemoveTempData;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Products.FacadPattern;
using AutoMapper;
using asp_store_bugeto.Application.Services.Products.Mapper;
using asp_store_bugeto.Application.Services.Emails.FacadPattern;
using asp_store_bugeto.Application.Services.Common.FacadPattern;
using asp_store_bugeto.Application.Services.HomePage.FacadPattern;
using asp_store_bugeto.Application.Services.Carts.FacadPattern;
using asp_store_bugeto.Application.Services.Finances.FacadPattern;
using asp_store_bugeto.Common.Roles;

namespace EndPoint.Site
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
            services.AddAuthorization(options =>
            {
                options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
                options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
            });
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Authentication/Login");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
            });

            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUsersService, RegisterUsersService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IChangeUserStateService, ChangeUserStateService>();
            services.AddScoped<IEditeUserService, EditeUserService>();
            services.AddScoped<IGetRoleByNameService, GetRoleByNameService>();
            services.AddScoped<ILoginUserService, LoginUserService>();
            services.AddScoped<IGetDataWithKeyService, GetDataWithKeyService>();
            services.AddScoped<IGetUserByEmailService, GetUserByEmailService>();
            services.AddScoped<IRemoveTempDataService, RemoveTempDataService>();
            services.AddScoped<IHomePageFacadPattern, HomePageFacadPattern>();
            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfile());

            }).CreateMapper());




            services.AddScoped<IProductFacad, ProductFacad>();
            services.AddScoped<IEmailFacad, EmailFacad>();
            services.AddScoped<ICommonFacad, CommonFacad>();
            services.AddScoped<ICartFacad, CartFacad>();
            services.AddScoped<IFinancesFacad, FinancesFacad>();



            string contectionString = @"Data Source=. ; Initial Catalog=Bugeto_StoreDb1; Integrated Security=True;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(contectionString));
            services.AddControllersWithViews();
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
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
