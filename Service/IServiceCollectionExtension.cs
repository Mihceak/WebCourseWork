using System.Collections;
using CourseWork.Domain;
using CourseWork.Domain.Repositories.Abstract;
using CourseWork.Domain.Repositories.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CourseWork.Service
{
    public static class IServiceCollectionExtension
    {
        public static void AddProjectServices(this IServiceCollection services)
        {
            services.AddTransient<IIngredientRepository, EFIngredientRepository>();
            services.AddTransient<IIngredientListRepository, EFIngredientListRepository>();
            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            services.AddTransient<DataManager>();

            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "culinaryDiaries";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/access_denied";
                options.SlidingExpiration = true;
            });
        }
    }
}