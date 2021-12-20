using CarRent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<UserStatisticDetails> UserStatisticDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
