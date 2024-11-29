
namespace SportsVenueBooking.Domain
{
	public class Customer : BaseDomainModel
	{
		public string FirstName { get; set; } // Customer's first name
		public string LastName { get; set; }  // Customer's last name
		public string Email { get; set; }     // Email address
		public string PhoneNumber { get; set; } // Contact number
		public string Address { get; set; }   // Optional: Address details

		// Navigation properties for relationships
		public virtual ICollection<Bookings> Bookings { get; set; } // A customer can have multiple bookings
	}
}
