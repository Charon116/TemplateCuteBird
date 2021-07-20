using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.Data.Entities;
using TemplateCuteBird.Data.Enums;

namespace TemplateCuteBird.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var roleId = new Guid("1F66C1E2-11B5-44C1-B371-967B700F3395");
            var adminId = new Guid("834ED512-9D91-43AA-8C12-C7B2F11E5D5D");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "lcquang116@gmail.com",
                NormalizedEmail = "lcquang116@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Quang",
                LastName = "Le Chi",
                
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Template Cute Bird", SortOrder = 1, Url = "#", Image = "./image/user/carousel1.jpg", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Template Cute Bird", SortOrder = 2, Url = "#", Image = "./image/user/carousel2.jpg", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Template Cute Bird", SortOrder = 3, Url = "#", Image = "./image/user/carousel3.jpg", Status = Status.Active }
              
              
              );
        }
    }
}
