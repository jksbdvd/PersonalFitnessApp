using PersonalFitnessApp.Data;

namespace PersonalFitnessApp.Domain
{
    public class Feedback : BaseDomainModel
    {
        public string? GiverName { get; set; }
        public DateTime GivenDate { get; set; }
        public string? Message { get; set; }
        public string? UserId { get; set; }
        public PersonalFitnessAppUser User { get; set; }
    }
}
