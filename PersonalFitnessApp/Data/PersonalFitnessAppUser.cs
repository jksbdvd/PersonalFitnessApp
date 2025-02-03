using Microsoft.AspNetCore.Identity;

namespace PersonalFitnessApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class PersonalFitnessAppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Steps { get; set; }
    }
}
