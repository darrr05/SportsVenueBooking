using SportsVenueBooking.Data;

namespace SportsVenueBooking.Domain
{
	public class Payment : BaseDomainModel
	{
		public int BookingId { get; set; }
		public double Amount { get; set; }
		public string PaymentMethod { get; set; }
		public DateTime PaymentDate { get; set; }
		public string Status { get; set; }  // Pending, Successful, Failed

		// Additional fields for Credit Card
		public string NameOnCard { get; set; }
		public string CardNumber { get; set; }
		public string ExpiryDate { get; set; }
		public string CVV { get; set; }

		// Navigation property
		public Bookings Booking { get; set; }

		// Constructor with required fields
		public Payment()
		{
			PaymentDate = DateTime.Now;
			Status = "Pending";
		}
	}
}