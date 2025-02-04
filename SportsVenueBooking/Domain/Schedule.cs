namespace SportsVenueBooking.Domain
{
	public class Schedule : BaseDomainModel
	{
		public int SportLocationTimeslotId { get; set; }  // Foreign key to SportLocationTimeslot

		public SportLocationTimeslot? SportLocationTimeslot { get; set; }  // Navigation property to SportLocation

		public int AvailableSlots { get; set; }

		private DateTime _scheduledDate;

		public DateTime ScheduledDate
		{
			get => _scheduledDate.Date;  // Always return just the date part
			set => _scheduledDate = value.Date;  // Store only the date part
		}
	}
}