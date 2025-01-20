using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Domain;
using System;

namespace SportsVenueBooking.Configurations.Entities
{
	public class SportLocationSeed : IEntityTypeConfiguration<SportLocation>
	{
		public void Configure(EntityTypeBuilder<SportLocation> builder)
		{
			// Seed data with Id
			builder.HasData(
				// Badminton (SportId = 1)
				new SportLocation
				{
					Id = 1,
					SportId = 1, // Corrected property name
					LocationId = 2, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Badminton at Sengkang Sports Hall

				new SportLocation
				{
					Id = 2,
					SportId = 1, // Corrected property name
					LocationId = 1, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Badminton at Bishan Sports Hall

				// Basketball (SportId = 2)
				new SportLocation
				{
					Id = 3,
					SportId = 2, // Corrected property name
					LocationId = 2, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Basketball at Sengkang Sports Hall

				new SportLocation
				{
					Id = 4,
					SportId = 2, // Corrected property name
					LocationId = 14, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Basketball at Bukit Canberra Sports Centre

				// Beach Volleyball (SportId = 3)
				new SportLocation
				{
					Id = 5,
					SportId = 3, // Corrected property name
					LocationId = 1, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Beach Volleyball at Bishan Sports Hall

				new SportLocation
				{
					Id = 6,
					SportId = 3, // Corrected property name
					LocationId = 17, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Beach Volleyball at Delta Sports Centre

				// Volleyball (SportId = 4)
				new SportLocation
				{
					Id = 7,
					SportId = 4, // Corrected property name
					LocationId = 2, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Volleyball at Sengkang Sports Hall

				new SportLocation
				{
					Id = 8,
					SportId = 4, // Corrected property name
					LocationId = 15, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Volleyball at Changi Simei Sports Hall

				// Dance (SportId = 5)
				new SportLocation
				{
					Id = 9,
					SportId = 5, // Corrected property name
					LocationId = 1, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Dance at Bishan Sports Hall

				new SportLocation
				{
					Id = 10,
					SportId = 5, // Corrected property name
					LocationId = 16, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Dance at Serangoon Sports Centre

				// Tennis (SportId = 6)
				new SportLocation
				{
					Id = 11,
					SportId = 6, // Corrected property name
					LocationId = 3, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Tennis at Jurong East Sports Hall

				new SportLocation
				{
					Id = 12,
					SportId = 6, // Corrected property name
					LocationId = 18, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Tennis at Choa Chu Kang Sports Centre

				// Table Tennis (SportId = 7)
				new SportLocation
				{
					Id = 13,
					SportId = 7, // Corrected property name
					LocationId = 4, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Table Tennis at Tampines Sports Hall

				// Squash (SportId = 8)
				new SportLocation
				{
					Id = 14,
					SportId = 8, // Corrected property name
					LocationId = 5, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Squash at Woodlands Sports Hall

				// Futsal (SportId = 9)
				new SportLocation
				{
					Id = 15,
					SportId = 9, // Corrected property name
					LocationId = 6, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Futsal at Pasir Ris Sports Hall

				new SportLocation
				{
					Id = 16,
					SportId = 9, // Corrected property name
					LocationId = 19, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Futsal at Woodlands Sports Hall

				// Swimming (SportId = 10)
				new SportLocation
				{
					Id = 17,
					SportId = 10, // Corrected property name
					LocationId = 7, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Swimming at Yishun Sports Hall

				// Gymnastics (SportId = 11)
				new SportLocation
				{
					Id = 18,
					SportId = 11, // Corrected property name
					LocationId = 8, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Gymnastics at Bukit Gombak Sports Hall

				// Archery (SportId = 12)
				new SportLocation
				{
					Id = 19,
					SportId = 12, // Corrected property name
					LocationId = 9, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Archery at Queenstown Sports Centre

				new SportLocation
				{
					Id = 20,
					SportId = 12, // Corrected property name
					LocationId = 2, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Archery at Sengkang Sports Hall

				// Football (SportId = 13)
				new SportLocation
				{
					Id = 21,
					SportId = 13, // Corrected property name
					LocationId = 10, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Football at Bedok Sports Centre

				// Hockey (SportId = 14)
				new SportLocation
				{
					Id = 22,
					SportId = 14, // Corrected property name
					LocationId = 11, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Hockey at Bukit Canberra Sports Centre

				// Handball (SportId = 15)
				new SportLocation
				{
					Id = 23,
					SportId = 15, // Corrected property name
					LocationId = 12, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Handball at Changi Simei Sports Hall

				// Petanque (SportId = 16)
				new SportLocation
				{
					Id = 24,
					SportId = 16, // Corrected property name
					LocationId = 13, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}, // Petanque at Serangoon Sports Centre

				// Sepak (SportId = 17)
				new SportLocation
				{
					Id = 25,
					SportId = 17, // Corrected property name
					LocationId = 14, // Corrected property name
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				} // Sepak at Bukit Canberra Sports Centre
			);
		}
	}
}
