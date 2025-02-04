namespace SportsVenueBooking.Domain
{
	public class ContactUs : BaseDomainModel
	{
		public string CustomerEmail { get; set; }  // Email will be stored here for easy querying
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime SubmittedAt { get; set; } = DateTime.Now;
	}
}