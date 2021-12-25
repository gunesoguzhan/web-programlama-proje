using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Role
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            //User
            var passwordHasher = new PasswordHasher<UserDetails>();
            List<UserDetails> users = new List<UserDetails>()
            {
                 new UserDetails {
                    UserName = "g181210068@sakarya.edu.tr",
                    NormalizedUserName = "G181210068@SAKARYA.EDU.TR",
                    Email = "g181210068@sakarya.edu.tr",
                    NormalizedEmail = "G181210068@SAKARYA.EDU.TR",
                    Name = "Admin",
                    Surname = "Admin",
                    EmailConfirmed = true
                },
            };
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "123");
            builder.Entity<UserDetails>().HasData(users);

            //UserRole
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            });
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}