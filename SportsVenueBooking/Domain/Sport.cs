

namespace SportsVenueBooking.Domain
{
	public class Sport : BaseDomainModel
	{
		public string Name { get; set; }
		public ICollection<Bookings>? Bookings { get; set; } // Navigation property
	}
}
