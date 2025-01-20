using SportsVenueBooking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
					UpdatedBy = "System",
					capacity = 5000
				},
				new Location
				{
					Id = 2,
					Name = "Sengkang Sports Hall",
					Address = "57 Anchorvale Rd, Singapore 544964",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2000
				},
				new Location
				{
					Id = 3,
					Name = "Jurong East Sports Hall",
					Address = "21 Jurong East St 31, Singapore 609517",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 4000
				},
				new Location
				{
					Id = 4,
					Name = "Tampines Sports Hall",
					Address = "1 Tampines Walk, Singapore 528523",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 3500
				},
				new Location
				{
					Id = 5,
					Name = "Woodlands Sports Hall",
					Address = "3 Woodlands St 13, Singapore 738600",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2500
				},
				new Location
				{
					Id = 6,
					Name = "Pasir Ris Sports Hall",
					Address = "120 Pasir Ris Central, Singapore 519640",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2200
				},
				new Location
				{
					Id = 7,
					Name = "Yishun Sports Hall",
					Address = "1 Yishun Ave 3, Singapore 768101",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2700
				},
				new Location
				{
					Id = 8,
					Name = "Bukit Gombak Sports Hall",
					Address = "2 Bukit Batok St 21, Singapore 659604",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 3000
				},
				new Location
				{
					Id = 9,
					Name = "Queenstown Sports Centre",
					Address = "473 Stirling Rd, Singapore 148947",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 1500
				},
				new Location
				{
					Id = 10,
					Name = "Bedok Sports Centre",
					Address = "30 Bedok North Dr, Singapore 469658",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2200
				},
				new Location
				{
					Id = 11,
					Name = "Bukit Canberra Sports Centre",
					Address = "21 Canberra Link, Singapore 768137",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 4000
				},
				new Location
				{
					Id = 12,
					Name = "Changi Simei Sports Hall",
					Address = "60 Simei St 1, Singapore 529944",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 1800
				},
				new Location
				{
					Id = 13,
					Name = "Serangoon Sports Centre",
					Address = "23 Serangoon North Ave 1, Singapore 555881",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2800
				},
				new Location
				{
					Id = 14,
					Name = "Delta Sports Centre",
					Address = "900 Tiong Bahru Rd, Singapore 158790",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 3500
				},
				new Location
				{
					Id = 15,
					Name = "Choa Chu Kang Sports Centre",
					Address = "21 Choa Chu Kang Ave 4, Singapore 689812",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 2500
				},
				// Additional primary school halls and other venues
				new Location
				{
					Id = 16,
					Name = "St. Andrew's Secondary School Sports Hall",
					Address = "15 Francis Thomas Dr, Singapore 359342",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 800
				},
				new Location
				{
					Id = 17,
					Name = "Raffles Institution Sports Hall",
					Address = "1 Raffles Institution Lane, Singapore 575954",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 600
				},
				new Location
				{
					Id = 18,
					Name = "Anglo-Chinese School Sports Hall",
					Address = "25 Winstedt Rd, Singapore 227977",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 900
				},
				new Location
				{
					Id = 19,
					Name = "Nanyang Primary School Hall",
					Address = "40 Nanyang Walk, Singapore 639798",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
					capacity = 500
				}
			);
		}
	}
}
