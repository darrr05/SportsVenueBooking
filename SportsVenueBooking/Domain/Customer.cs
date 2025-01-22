
using SportsVenueBooking.Data;

namespace SportsVenueBooking.Domain
{
	public class Customer : BaseDomainModel
	{
		public string FirstName { get; set; } // Customer's first name
		public string LastName { get; set; }  // Customer's last name
		public string Email { get; set; }     // Email address
		public string PhoneNumber { get; set; } // Contact number
		public int Age { get; set; }  //Age
		public string Address { get; set; }   // Optional: Address details

	}
}
