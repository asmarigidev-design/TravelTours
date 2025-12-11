using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TravelContext:IdentityDbContext<AppUser,AppRole,Guid>
    {
        public TravelContext(DbContextOptions options) : base(options)
        {
        }

        protected TravelContext()
        {
        }

        public DbSet<Agency> Agencies { get; set; } 
       public DbSet<Category> Categories { get; set; } 
       public DbSet<Image> Images { get; set; } 
       public DbSet<City> Cities { get; set; } 
       public DbSet<Payment> Payments { get; set; } 
       public DbSet<Reservation> Reservations { get; set; } 
       public DbSet<Review> Reviews { get; set; } 
       public DbSet<Tour> Tours { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Agency>()
                .HasMany(a => a.Tours)
                .WithOne(t => t.Agency)
                .HasForeignKey(t=>t.AgencyId);

            builder.Entity<Category>()
               .HasMany(c => c.Tours)
               .WithOne(t => t.Category)
               .HasForeignKey(t => t.CategoryId);

            builder.Entity<City>()
               .HasMany(c => c.Tours)
               .WithOne(t => t.City)
               .HasForeignKey(t => t.CityId);

            builder.Entity<Tour>()
               .HasMany(t => t.Images)
               .WithOne(i => i.Tour).
               HasForeignKey(t => t.TourId);

            builder.Entity<Reservation>()
               .HasMany(r => r.Payments)
               .WithOne(p => p.Reservation)
               .HasForeignKey(p => p.ReservationId);

            builder.Entity<AppUser>()
               .HasMany(a => a.Reservations)
               .WithOne(r => r.AppUser)
               .HasForeignKey(r => r.UserId);

            builder.Entity<Tour>()
               .HasMany(t => t.Reviews)
               .WithOne(r => r.Tour)
               .HasForeignKey(r => r.TourId);

            builder.Entity<Tour>()
               .HasMany(t => t.Reservations)
               .WithOne(r => r.Tour)
               .HasForeignKey(r => r.TourId);

            base.OnModelCreating(builder);
        }
       
        

    }
}
