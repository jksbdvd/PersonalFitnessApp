using PersonalFitnessApp.Data;

namespace PersonalFitnessApp.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public string? UserId { get; set; }
		public PersonalFitnessAppUser User { get; set; }

	}
}
