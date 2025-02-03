using PersonalFitnessApp.Data;

namespace PersonalFitnessApp.Domain
{
    public class FoodTracking : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public string? UserId { get; set; }
		public PersonalFitnessAppUser User { get; set; }

	}
}
