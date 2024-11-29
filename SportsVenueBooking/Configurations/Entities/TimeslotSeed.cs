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
				new Timeslot
				{
					Id = 1,
					Description = "08:00 AM - 09:00 AM"
				},
				new Timeslot
				{
					Id = 2,
					Description = "09:00 AM - 10:00 AM"
				});
		}
	}
}

