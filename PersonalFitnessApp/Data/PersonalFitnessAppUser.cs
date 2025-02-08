using Microsoft.AspNetCore.Identity;
using PersonalFitnessApp.Domain;

namespace PersonalFitnessApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class PersonalFitnessAppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Steps { get; set; }
        public int Calories { get; set; }
    }
}
