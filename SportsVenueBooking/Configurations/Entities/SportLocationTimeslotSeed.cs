using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations.Entities
{
	public class SportLocationTimeslotSeed : IEntityTypeConfiguration<SportLocationTimeslot>
	{
		public void Configure(EntityTypeBuilder<SportLocationTimeslot> builder)
		{
			builder.HasData(
				new SportLocationTimeslot
				{
					Id = 1,
					SportLocationId = 1, // For example: Badminton at Sengkang Sports Hall
					TimeslotId = 1,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 50.00f       // Price for this SportLocationTimeslot
				},
				new SportLocationTimeslot
				{
					Id = 2,
					SportLocationId = 1, // For example: Badminton at Sengkang Sports Hall
					TimeslotId = 2,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 45.00f       // Price for this SportLocationTimeslot
				},
				new SportLocationTimeslot
				{
					Id = 3,
					SportLocationId = 2, // For example: Badminton at Bishan Sports Hall
					TimeslotId = 2,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 55.00f       // Price for this SportLocationTimeslot
				},
				new SportLocationTimeslot
				{
					Id = 4,
					SportLocationId = 3, // For example: Basketball at Sengkang Sports Hall
					TimeslotId = 3,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 60.00f       // Price for this SportLocationTimeslot
				},
				new SportLocationTimeslot
				{
					Id = 5,
					SportLocationId = 4, // For example: Basketball at Bukit Canberra Sports Centre
					TimeslotId = 4,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 65.00f       // Price for this SportLocationTimeslot
				},
				new SportLocationTimeslot
				{
					Id = 6,
					SportLocationId = 1, // For example: Badminton at Sengkang Sports Hall
					TimeslotId = 3,      // Reference to the Timeslot table (you will need to know the valid TimeslotIds)
					Price = 50.00f       // Price for this SportLocationTimeslot
				}
			);
		}
	}
}
