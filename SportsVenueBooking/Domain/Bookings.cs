
namespace SportsVenueBooking.Domain
{
	public class Bookings : BaseDomainModel
	{
		public string? SportName { get; set; } // Optional display property
		public string? LocationName { get; set; } // Optional display property
		public string? TimeslotDescription { get; set; } // Optional display property

		public int SportId { get; set; } // FK for Sports table
		public int LocationId { get; set; } // FK for Locations table
		public int TimeslotId { get; set; } // FK for Timeslots table

		// Navigation properties (optional for Entity Framework relationships)
		public Sport? Sport { get; set; }
		public Location? Location { get; set; }
		public Timeslot? Timeslot { get; set; }
	}
}
