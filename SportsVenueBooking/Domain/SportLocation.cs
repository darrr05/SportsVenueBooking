using Newtonsoft.Json;

namespace SportsVenueBooking.Domain
{
	public class SportLocation : BaseDomainModel
	{
		public int SportId { get; set; }
		public int LocationId { get; set; }
		public Sport Sport { get; set; }
		public Location Location { get; set; }


	}
}
