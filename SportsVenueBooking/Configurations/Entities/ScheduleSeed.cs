using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations.Entities
{
	public class ScheduleSeed : IEntityTypeConfiguration<Schedule>
	{
		public void Configure(EntityTypeBuilder<Schedule> builder)
		{
			builder.HasData(
				new Schedule
				{
					Id = 1,
					SportLocationTimeslotId = 1,
					AvailableSlots = 20,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					ScheduledDate = new DateTime(2025, 1, 20) // Custom scheduled date
				},
				new Schedule
				{
					Id = 2,
					SportLocationTimeslotId = 2,
					AvailableSlots = 15,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					ScheduledDate = new DateTime(2025, 1, 21) // Custom scheduled date
				},
				new Schedule
				{
					Id = 3,
					SportLocationTimeslotId = 3,
					AvailableSlots = 25,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					ScheduledDate = new DateTime(2025, 1, 22) // Custom scheduled date
				},
				new Schedule
				{
					Id = 4,
					SportLocationTimeslotId = 4,
					AvailableSlots = 10,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					ScheduledDate = new DateTime(2025, 1, 23) // Custom scheduled date
				},
				new Schedule
				{
					Id = 5,
					SportLocationTimeslotId = 6,
					AvailableSlots = 20,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					ScheduledDate = new DateTime(2025, 1, 20) // Custom scheduled date
				}
			);
		}
	}
}
