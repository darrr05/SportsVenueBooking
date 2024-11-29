

namespace SportsVenueBooking.Domain
{
	public class Location : BaseDomainModel
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public ICollection<Bookings>? Bookings { get; set; } // Navigation property

	}
}
