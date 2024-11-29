using SportsVenueBooking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsVenueBooking.Configurations.Entities
{
	public class SportSeed : IEntityTypeConfiguration<Sport>
	{
		public void Configure(EntityTypeBuilder<Sport> builder)
		{
			builder.HasData(
				new Sport
				{
					Id = 1,
					Name = "Badminton",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 2,
					Name = "Basketball",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}