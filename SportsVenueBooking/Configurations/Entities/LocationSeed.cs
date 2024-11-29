using SportsVenueBooking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsVenueBooking.Configurations.Entities
{
	public class LocationSeed : IEntityTypeConfiguration<Location>
	{
		public void Configure(EntityTypeBuilder<Location> builder)
		{
			builder.HasData(
				new Location
				{
					Id = 1,
					Name = "Bishan Sports Hall",
					Address = "5 Bishan St 14, Singapore 579783",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Location
				{
					Id = 2,
					Name = "Sengkang Sports Hall",
					Address = "57 Anchorvale Rd, Singapore 544964",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				});
		}
	}
}
