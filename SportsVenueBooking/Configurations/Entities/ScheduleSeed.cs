using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations.Entities
{
	public class ScheduleSeed : IEntityTypeConfiguration<Schedule>
	{
		public void Configure(EntityTypeBuilder<Schedule> builder)
		{
			// Configure ScheduledDate column to store only the date part
			builder.Property(s => s.ScheduledDate)
				   .HasColumnType("date");  // Ensure the database column stores only the date part

			builder.HasData(
				// Sample Schedule entries with AvailableSlots and Prices
				new Schedule
				{
					Id = 1,
					SportLocationId = 1,    // References SportLocationId from SportLocationSeed
					TimeslotId = 1,         // References TimeslotId from TimeslotSeed
					ScheduledDate = new DateTime(2025, 1, 15),  // Date for the schedule
					AvailableSlots = 20,    // Available Slots for this schedule
					Price = 50.00f,         // Price for the schedule
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Schedule
				{
					Id = 2,
					SportLocationId = 2,    // References SportLocationId from SportLocationSeed
					TimeslotId = 2,         // References TimeslotId from TimeslotSeed
					ScheduledDate = new DateTime(2025, 1, 16),  // Date for the schedule
					AvailableSlots = 15,    // Available Slots for this schedule
					Price = 45.00f,         // Price for the schedule
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Schedule
				{
					Id = 3,
					SportLocationId = 3,    // References SportLocationId from SportLocationSeed
					TimeslotId = 1,         // References TimeslotId from TimeslotSeed
					ScheduledDate = new DateTime(2025, 1, 17),  // Date for the schedule
					AvailableSlots = 25,    // Available Slots for this schedule
					Price = 55.00f,         // Price for the schedule
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Schedule
				{
					Id = 4,
					SportLocationId = 4,    // References SportLocationId from SportLocationSeed
					TimeslotId = 2,         // References TimeslotId from TimeslotSeed
					ScheduledDate = new DateTime(2025, 1, 18),  // Date for the schedule
					AvailableSlots = 10,    // Available Slots for this schedule
					Price = 60.00f,         // Price for the schedule
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
