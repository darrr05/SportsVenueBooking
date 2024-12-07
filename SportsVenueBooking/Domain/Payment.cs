namespace SportsVenueBooking.Domain
{
	public class Payment : BaseDomainModel
	{
		public decimal Amount { get; set; }  // Amount of the payment
		public string PaymentMethod { get; set; }  // Payment method
		public DateTime PaymentDate { get; set; }  // Date and time of the payment
		public string Status { get; set; }  // Payment status (e.g., Completed, Pending, Failed)

		// Constructor to initialize the payment object
		public Payment(decimal amount, string paymentMethod, DateTime paymentDate, string status)
		{
			Amount = amount;
			PaymentMethod = paymentMethod;
			PaymentDate = paymentDate;
			Status = status;
		}
	}
}
