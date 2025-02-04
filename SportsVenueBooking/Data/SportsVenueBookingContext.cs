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
		public DbSet<Payment> Payment { get; set; } = default!;
		public DbSet<Discount> Discounts { get; set; } = default!;
		public DbSet<ContactUs> ContactUs { get; set; } = default!;
		public DbSet<SportLocation> SportLocation { get; set; } = default!;
		public DbSet<SportLocationTimeslot> SportLocationTimeslots { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Configure primary key and relationships for SportLocation
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

			// Configure the relationship between SportLocation and Schedule
			builder.Entity<Schedule>()
				.HasOne(s => s.SportLocationTimeslot)  // Correct navigation property to SportLocationTimeslot
				.WithMany()  // Assuming no back-reference is needed in SportLocationTimeslot
				.HasForeignKey(s => s.SportLocationTimeslotId);  // Correct foreign key


			// Configure the relationship between SportLocationTimeslot and Timeslot
			builder.Entity<SportLocationTimeslot>()
				.HasOne(st => st.Timeslot)
				.WithMany()
				.HasForeignKey(st => st.TimeslotId);

			// Apply entity configurations for seeding data
			builder.ApplyConfiguration(new LocationSeed());
			builder.ApplyConfiguration(new SportSeed());
			builder.ApplyConfiguration(new SportLocationSeed());
			builder.ApplyConfiguration(new TimeslotSeed());
			builder.ApplyConfiguration(new ScheduleSeed());
			builder.ApplyConfiguration(new SportLocationTimeslotSeed());
			builder.ApplyConfiguration(new UserSeed());
			builder.ApplyConfiguration(new UserRoleSeed());
			builder.ApplyConfiguration(new RoleSeed());
		}

	}
}