namespace SportsVenueBooking.Domain
{
	public class Bidding : BaseDomainModel
	{
		public int UserId { get; set; }  // The ID of the user placing the bid
		public int VenueId { get; set; }  // The ID of the venue being bid on
		public decimal BidAmount { get; set; }  // The amount of the bid
		public DateTime BidDate { get; set; }  // The date and time the bid was placed
		public string Status { get; set; }  // Status of the bid (e.g., Pending, Accepted, Rejected)
		public int BidIncrement { get; set; }  // The minimum increment in which the bid can be increased
		public decimal MaxBid { get; set; }  // Maximum allowed bid for the venue
		public DateTime BidEndTime { get; set; }  // The end time for the bidding period (if applicable)

		// Constructor to initialize the Bidding object
		public Bidding(int userId, int venueId, decimal bidAmount, DateTime bidDate, string status, int bidIncrement, decimal maxBid, DateTime bidEndTime)
		{
			UserId = userId;
			VenueId = venueId;
			BidAmount = bidAmount;
			BidDate = bidDate;
			Status = status;
			BidIncrement = bidIncrement;
			MaxBid = maxBid;
			BidEndTime = bidEndTime;
		}
	}
}
