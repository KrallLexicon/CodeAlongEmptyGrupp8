using CodeAlongEmpty.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAlongEmpty.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }

        public DbSet<CarOwner> CarOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
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
        }



    }
}
