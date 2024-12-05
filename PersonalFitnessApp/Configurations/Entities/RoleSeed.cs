using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;
using System;
namespace PersonalFitnessApp.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "e731d37a-9f2c-4ce6-90ab-1f7b7244a561",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "5375ee94-cd25-4752-ace8-dfce3ff54acd",
                Name = "User",
                NormalizedName = "USER"
            }
            );
        }
    }
}
