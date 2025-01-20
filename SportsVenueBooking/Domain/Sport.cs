using Newtonsoft.Json;

namespace SportsVenueBooking.Domain
{
	public class Sport : BaseDomainModel
	{
		public string Name { get; set; }
		public string ImagePath { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; }
		public string CreatedBy { get; set; }
		public string UpdatedBy { get; set; }

	}
}
