using SportsVenueBooking.Data;

namespace SportsVenueBooking.Domain
{
	public class Bookings : BaseDomainModel
	{
		public int CustomerId { get; set; } // FK for Customer table

		// New properties for booking management
		// Existing properties
		public int? SportLocationTimeslotId { get; set; }
		public DateTime BookingDate { get; set; }
		public double TotalAmount { get; set; }
		public string BookingStatus { get; set; } // Pending, Confirmed, Cancelled, Completed
		public string? CancellationReason { get; set; }
		public DateTime CancellationDate { get; set; }

		// Payment tracking
		public bool IsPaid { get; set; } = false;
		public DateTime PaymentDate { get; set; }

		// Navigation properties
		public Customer? Customer { get; set; }
		public SportLocation? SportLocation { get; set; }
		public SportLocationTimeslot? SportLocationTimeslot { get; set; }
		public SportsVenueBookingUser? User { get; set; }
		public Payment Payment { get; set; }

		// Validation method
		public bool IsValidBooking()
		{
			return BookingDate.Date >= DateTime.Now.Date && SportLocationTimeslot != null;
		}
	}
}