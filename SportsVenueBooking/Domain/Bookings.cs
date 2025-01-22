﻿
using SportsVenueBooking.Data;

namespace SportsVenueBooking.Domain
{
	public class Bookings : BaseDomainModel
	{
		public DateTime DateOut { get; set; }
		public DateTime DateIn { get; set; }
		public int CustomerId { get; set; } // FK for Customer table

		// New properties for booking management
		// Existing properties
		public string? SportName { get; set; }
		public string? LocationName { get; set; }
		public string? TimeslotDescription { get; set; }
		public int SportId { get; set; }
		public int LocationId { get; set; }
		public DateTime BookingDate { get; set; }
		public double TotalAmount { get; set; }
		public string BookingStatus { get; set; } = "Pending"; // Pending, Confirmed, Cancelled, Completed
		public string? CancellationReason { get; set; }
		public DateTime? CancellationDate { get; set; }

		// Payment tracking
		public bool IsPaid { get; set; } = false;
		public string? StripePaymentIntentId { get; set; }
		public DateTime? PaymentDate { get; set; }

		// Navigation properties
		public Sport? Sport { get; set; }
		public Location? Location { get; set; }
		public Customer? Customer{ get; set; }
		public SportsVenueBookingUser? User { get; set; }
		public Payment Payment { get; set; }

		// Validation method
		public bool IsValidBooking()
		{
			return BookingDate.Date >= DateTime.Now.Date;
		}
	}
}
