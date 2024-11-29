using Microsoft.AspNetCore.Identity;

namespace SportsVenueBooking.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class SportsVenueBookingUser : IdentityUser
    {
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}
