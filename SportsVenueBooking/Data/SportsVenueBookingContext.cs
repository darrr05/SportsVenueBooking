using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Configurations.Entities;
using SportsVenueBooking.Domain;
using CarRentalManagement.Configurations.Entities;

namespace SportsVenueBooking.Data
{
	public class SportsVenueBookingContext : IdentityDbContext<SportsVenueBookingUser>
	{
		public SportsVenueBookingContext(DbContextOptions<SportsVenueBookingContext> options)
			: base(options)
		{
		}

		public DbSet<Sport> Sport { get; set; } = default!;
		public DbSet<Bookings> Bookings { get; set; } = default!;
		public DbSet<Customer> Customer { get; set; } = default!;
		public DbSet<Location> Location { get; set; } = default!;
		public DbSet<Timeslot> Timeslot { get; set; } = default!;
		public DbSet<Schedule> Schedules { get; set; } = default!;
		public DbSet<SportLocation> SportLocation { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Configure single primary key for SportLocation
			builder.Entity<SportLocation>()
				.HasKey(sl => sl.Id);

			builder.Entity<SportLocation>()
				.HasOne(sl => sl.Sport)
				.WithMany()
				.HasForeignKey(sl => sl.SportId);

			builder.Entity<SportLocation>()
				.HasOne(sl => sl.Location)
				.WithMany()
				.HasForeignKey(sl => sl.LocationId);

			// Configure the relationship between Schedule and SportLocation using SportLocationId
			builder.Entity<Schedule>()
				.HasOne(s => s.SportLocation)
				.WithMany()
				.HasForeignKey(s => s.SportLocationId);  // Foreign key to SportLocationId

			builder.Entity<Schedule>()
				.HasOne(s => s.Timeslots)
				.WithMany()
				.HasForeignKey(s => s.TimeslotId);

			// Apply entity configurations for seeding data
			builder.ApplyConfiguration(new LocationSeed());
			builder.ApplyConfiguration(new SportSeed());
			builder.ApplyConfiguration(new SportLocationSeed());
			builder.ApplyConfiguration(new TimeslotSeed());
			builder.ApplyConfiguration(new ScheduleSeed());
			builder.ApplyConfiguration(new UserSeed());
			builder.ApplyConfiguration(new UserRoleSeed());
			builder.ApplyConfiguration(new RoleSeed());
		}

	}
}