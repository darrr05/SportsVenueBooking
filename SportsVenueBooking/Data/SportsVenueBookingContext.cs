using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Configurations.Entities;
using SportsVenueBooking.Data;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Data
{
    public class SportsVenueBookingContext(DbContextOptions<SportsVenueBookingContext> options) : IdentityDbContext<SportsVenueBookingUser>(options)
    {
		public DbSet<Sport> Sport { get; set; } = default!;
		public DbSet<Bookings> Bookings { get; set; } = default!;
		public DbSet<Customer> Customer { get; set; } = default!;
		public DbSet<Location> Location { get; set; } = default!;
		public DbSet<Timeslot> Timeslot { get; set; } = default!;


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new LocationSeed());
			builder.ApplyConfiguration(new SportSeed());
			builder.ApplyConfiguration(new TimeslotSeed());
		}
	}
}
