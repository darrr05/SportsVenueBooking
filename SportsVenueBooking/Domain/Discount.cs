namespace SportsVenueBooking.Domain
{
	public class Discount : BaseDomainModel
	{
		public string Code { get; set; }
		public double Amount { get; set; } // Fixed Amount
		public double Percentage { get; set; } // Percentage Amount
		public int MaxUses { get; set; }
		public int UsageCount { get; set; }
		public bool IsElderlyDiscount { get; set; } // True or False
		public DateTime? ExpirationDate { get; set; }

		public bool IsValid()
		{
			if (IsElderlyDiscount)
			{
				return !IsExpired(); // Elderly discounts are valid unless expired
			}

			return UsageCount < MaxUses && !IsExpired();
		}

		private bool IsExpired()
		{
			if (ExpirationDate.HasValue && ExpirationDate.Value < DateTime.Now)
			{
				return true; // Expired
			}
			return false; // Not expired
		}

		public bool IncrementUsage()
		{
			if (UsageCount < MaxUses)
			{
				UsageCount++;
				return true;
			}
			return false;
		}
	}
}