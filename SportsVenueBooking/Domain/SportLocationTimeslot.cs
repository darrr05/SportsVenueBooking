	namespace SportsVenueBooking.Domain
	{
		public class SportLocationTimeslot : BaseDomainModel
		{
			public int SportLocationId { get; set; }   // Foreign key to SportLocation
			public SportLocation SportLocation { get; set; } // Navigation property to SportLocation

			public int TimeslotId { get; set; }   // Foreign key to Timeslot
			public Timeslot Timeslot { get; set; } // Navigation property to Timeslot

			public double Price { get; set; } // Price for the SportLocationTimeslot
		}
	}
