namespace SportsVenueBooking.Domain
{
	public class Notification : BaseDomainModel
	{
		public string Message { get; set; }  // The content of the notification
		public int UserId { get; set; }  // The ID of the user receiving the notification
		public DateTime NotificationDate { get; set; }  // The date and time when the notification was sent
		public string Status { get; set; }  // Status of the notification (e.g., Sent, Read, Pending)
		public string NotificationType { get; set; }  // Type of notification (e.g., Booking Reminder, Payment Confirmation)

		// Constructor to initialize the notification object
		public Notification(string message, int userId, DateTime notificationDate, string status, string notificationType)
		{
			Message = message;
			UserId = userId;
			NotificationDate = notificationDate;
			Status = status;
			NotificationType = notificationType;
		}

		
	}
}
