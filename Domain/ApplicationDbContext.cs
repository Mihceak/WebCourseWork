using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Domain
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientList> IngredientLists { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ee61c5c6-7dad-4194-839a-99aa683f2e4a",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "85219cde-09da-4f6e-9fdc-d89aae590a3d",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "www.m.d.k.05@gmail.com",
                NormalizedEmail = "WWW.M.D.K.05@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "SuperTank1"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ee61c5c6-7dad-4194-839a-99aa683f2e4a",
                UserId = "85219cde-09da-4f6e-9fdc-d89aae590a3d"
            });

            builder.Entity<Recipe>()
                .Property(e => e.Steps)
                .HasConversion(
                    v => string.Join(',', v),
                    v => new List<string>(v.Split(',', StringSplitOptions.RemoveEmptyEntries)));
        }
    }
}