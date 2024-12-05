using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalFitnessApp.Data;
using PersonalFitnessApp.Configurations.Entities;


namespace PersonalFitnessApp.Data
{
    public class PersonalFitnessAppContext(DbContextOptions<PersonalFitnessAppContext> options) : IdentityDbContext<PersonalFitnessAppUser>(options)
    {
        /*public DbSet<PersonalFitnessApp.Domain.Make> Make { get; set; } = default!;*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
        }
    }
}
