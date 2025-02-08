namespace SportsVenueBooking.Domain
{
	public class Bidding : BaseDomainModel
	{
		public int SportLocationTimeSlotId { get; set; }  // The ID of the venue being bid on
		public int? CustomerId { get; set; }  // The ID of the user placing the bid
		public DateTime AppointtedDate { get; set; }
		public SportLocationTimeslot? SportLocationTimeslots { get; set; }
		public double BidAmount { get; set; }  // The amount of the bid
		public DateTime BidDate { get; set; }  // The date and time the bid was placed
		public string? BidStatus { get; set; }  // Status of the bid (e.g., Pending, Accepted, Rejected)
		public DateTime BidEndTime { get; set; }  // The end time for the bidding period (if applicable)

		public int AddHours { get; set; }
		public int AddMinutes { get; set; }
	}
}