namespace SportsVenueBooking.Domain
{
	public class Reviews : BaseDomainModel
	{
		public int Rating { get; set; }  // Rating given by the user (e.g., 1 to 5 stars)
		public string Comment { get; set; }  // Review comment or feedback from the user
		public int UserId { get; set; }  // User ID of the person leaving the review
		public int VenueId { get; set; }  // ID of the venue being reviewed
		public DateTime ReviewDate { get; set; }  // Date when the review was submitted

		// Constructor to initialize the review object
		public Reviews(int rating, string comment, int userId, int venueId, DateTime reviewDate)
		{
			Rating = rating;
			Comment = comment;
			UserId = userId;
			VenueId = venueId;
			ReviewDate = reviewDate;
		}
	}
}
