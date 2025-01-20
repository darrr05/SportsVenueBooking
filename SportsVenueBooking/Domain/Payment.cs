using SportsVenueBooking.Domain;

public class Payment : BaseDomainModel
{
	public int BookingId { get; set; }
	public decimal Amount { get; set; }
	public string PaymentMethod { get; set; }
	public DateTime PaymentDate { get; set; }
	public string Status { get; set; }  // Pending, Successful, Failed

	// Stripe-specific properties
	public string? StripePaymentIntentId { get; set; }
	public string? StripeChargeId { get; set; }
	public string? StripeReceiptUrl { get; set; }
	public string? LastFourDigits { get; set; }
	public string? CardBrand { get; set; }

	// Navigation property
	public Bookings Booking { get; set; }

	// Constructor with required fields
	public Payment()
	{
		PaymentDate = DateTime.Now;
		Status = "Pending";
	}
}