using PersonalFitnessApp.Data;

namespace PersonalFitnessApp.Domain
{
    public class WorkoutLog : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public string? Exercise {  get; set; }
        public DateTime Duration { get; set; }
        public int CaloriesBurnt { get; set; }
        public string? UserId { get; set; }
		public PersonalFitnessAppUser User { get; set; }

	}
}
