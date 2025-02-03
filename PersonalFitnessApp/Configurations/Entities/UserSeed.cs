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
                UserName = "Admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },
            new PersonalFitnessAppUser
            {
                Id = "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                Email = "coach@coaching.com",
                NormalizedEmail = "COACH@COACHING.COM",
                FirstName = "Coach",
                LastName = "Coach",
                UserName = "Coach@coaching.com",
                NormalizedUserName = "COACH@COACHING.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
            );
        }
    }
}