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
					ImagePath = "images/badminton.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 2,
					Name = "Basketball",
					ImagePath = "images/basketball.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 3,
					Name = "Beach Volleyball",
					ImagePath = "images/beach_volleyball.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 4,
					Name = "Volleyball",
					ImagePath = "images/volleyball.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 5,
					Name = "Dance",
					ImagePath = "images/dance.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 6,
					Name = "Floorball",
					ImagePath = "images/floorball logo.jpg",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 7,
					Name = "Frisbee",
					ImagePath = "images/frisbee logo.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 8,
					Name = "Handball",
					ImagePath = "images/handball.jpg",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 9,
					Name = "Lawn Bowl",
					ImagePath = "images/lawnbowl.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 10,
					Name = "Netball",
					ImagePath = "images/netball.jpg",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 11,
					Name = "Petanque",
					ImagePath = "images/petanque.jpg",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 12,
					Name = "Pickleball",
					ImagePath = "images/pickleball.jpg",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 13,
					Name = "Sepak",
					ImagePath = "images/sepak.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 14,
					Name = "Squash",
					ImagePath = "images/squash.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 15,
					Name = "Table Tennis",
					ImagePath = "images/table_tennis.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 16,
					Name = "Soccer",
					ImagePath = "images/soccer.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 17,
					Name = "Hockey",
					ImagePath = "images/hockey.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Sport
				{
					Id = 18,
					Name = "Tennis",
					ImagePath = "images/tennis.png",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
