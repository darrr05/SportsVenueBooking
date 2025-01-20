using System.Security.Cryptography.X509Certificates;

namespace SportsVenueBooking.Domain
{
	public class Schedule : BaseDomainModel
	{
		// Foreign keys for composite key in SportLocation (SportId and LocationId)
		public int SportLocationId { get; set; }  // Foreign key to SportLocation

		public SportLocation? SportLocation { get; set; }  // Navigation property to SportLocation

		public int TimeslotId { get; set; }  // Foreign key to Timeslot
		public Timeslot Timeslots { get; set; }  // Navigation property to Timeslot

		public int AvailableSlots { get; set; }

		private DateTime _scheduledDate;

		public DateTime ScheduledDate
		{
			get => _scheduledDate.Date;  // Always return just the date part
			set => _scheduledDate = value.Date;  // Store only the date part
		}
		public float Price { get; set; }
	}
}