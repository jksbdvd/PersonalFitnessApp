using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PersonalFitnessApp.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e731d37a-9f2c-4ce6-90ab-1f7b7244a561",
                UserId = "ebc7974b-6cb5-497a-b5e4-bdb31c58c886"
            }
            );
        }
    }
}