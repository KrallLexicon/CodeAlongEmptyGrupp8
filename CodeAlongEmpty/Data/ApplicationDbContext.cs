using CodeAlongEmpty.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeAlongEmpty.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }

        public DbSet<CarOwner> CarOwners { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<CarOwner>().HasKey(co => new { co.RegNumber, co.SSN });

            modelbuilder.Entity<CarOwner>()
                .HasOne(co => co.Owner)
                .WithMany(o => o.CarOwners)
                .HasForeignKey(co => co.SSN);

            modelbuilder.Entity<CarOwner>()
                .HasOne(co => co.Car)
                .WithMany(c => c.CarOwners)
                .HasForeignKey(co => co.RegNumber);

            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "ABC-123", Brand = "Volvo", CarModel = "V70" });
            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "DEF-456", Brand = "SAAB", CarModel = "93" });
            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "GHI-789", Brand = "BMW", CarModel = "E93" });

            modelbuilder.Entity<Person>().HasData(new Person { SSN = "880216", Name = "Jonathan Krall" });
            modelbuilder.Entity<Person>().HasData(new Person { SSN = "123156", Name = "Sven Svensson" });
            modelbuilder.Entity<Person>().HasData(new Person { SSN = "423434", Name = "Anna Andersson" });

            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"

            });
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Name = "Admin Adminsson",
                Age = 9001,
                City = "Admintown",
                PasswordHash = hasher.HashPassword(null, "password")

            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });






        }
    }
}