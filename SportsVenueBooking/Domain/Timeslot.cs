

namespace SportsVenueBooking.Domain
{
	public class Timeslot : BaseDomainModel
	{
		public string Description { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int AvailableSlots { get; set; }
		public ICollection<Bookings>? Bookings { get; set; } // Navigation property
	}
}
