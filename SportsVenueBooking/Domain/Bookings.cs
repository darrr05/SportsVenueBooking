using SportsVenueBooking.Data;

namespace SportsVenueBooking.Domain
{
	public class Bookings : BaseDomainModel
	{
		public int CustomerId { get; set; } // FK for Customer table

		// New properties for booking management
		public int? SportLocationTimeslotId1 { get; set; }
		public int? SportLocationTimeslotId2 { get; set; }
		public DateTime BookingDate { get; set; }
		public double TotalAmount { get; set; }
		public string BookingStatus { get; set; } // Pending, Confirmed, Cancelled, Completed
		public string? CancellationReason { get; set; }
		public DateTime? CancellationDate { get; set; }

		// Payment tracking
		public bool IsPaid { get; set; } = false;
		public DateTime? PaymentDate { get; set; }
		public SportLocationTimeslot? SportLocationTimeslot1 { get; set; }
		public SportLocationTimeslot? SportLocationTimeslot2 { get; set; }
	}

}