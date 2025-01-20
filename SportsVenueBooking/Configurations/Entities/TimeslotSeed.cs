using SportsVenueBooking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsVenueBooking.Configurations.Entities
{
	public class TimeslotSeed : IEntityTypeConfiguration<Timeslot>
	{
		public void Configure(EntityTypeBuilder<Timeslot> builder)
		{
			builder.HasData(
				// Existing Timeslots without AvailableSlots
				new Timeslot
				{
					Id = 1,
					Description = "08:00 AM - 09:00 AM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 2,
					Description = "09:00 AM - 10:00 AM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 3,
					Description = "10:00 AM - 11:00 AM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 4,
					Description = "11:00 AM - 12:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 5,
					Description = "12:00 PM - 01:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 6,
					Description = "01:00 PM - 02:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 7,
					Description = "02:00 PM - 03:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 8,
					Description = "03:00 PM - 04:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 9,
					Description = "04:00 PM - 05:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 10,
					Description = "05:00 PM - 06:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 11,
					Description = "06:00 PM - 07:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Timeslot
				{
					Id = 12,
					Description = "07:00 PM - 08:00 PM",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
