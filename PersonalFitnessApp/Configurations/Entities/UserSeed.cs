using PersonalFitnessApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PersonalFitnessApp.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<PersonalFitnessAppUser>
    {
        public void Configure(EntityTypeBuilder<PersonalFitnessAppUser> builder)
        {
            var hasher = new PasswordHasher<PersonalFitnessAppUser>();
            builder.HasData(
            new PersonalFitnessAppUser
            {
                Id = "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "istrator",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
            );
        }
    }
}