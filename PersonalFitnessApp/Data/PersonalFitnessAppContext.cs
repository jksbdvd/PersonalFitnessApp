using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalFitnessApp.Data;
using PersonalFitnessApp.Configurations.Entities;
using PersonalFitnessApp.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PersonalFitnessApp.Data
{
    public class PersonalFitnessAppContext(DbContextOptions<PersonalFitnessAppContext> options) : IdentityDbContext<PersonalFitnessAppUser>(options)
    {
        /*public DbSet<PersonalFitnessApp.Domain.Make> Make { get; set; } = default!;*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WorkoutLog>()
                .HasOne(p => p.User)
				.WithMany()
				.HasForeignKey(p => p.UserId);
			modelBuilder.Entity<FoodTracking>()
			   .HasOne(p => p.User)
			   .WithMany()
			   .HasForeignKey(p => p.UserId);
			modelBuilder.Entity<Booking>()
			   .HasOne(p => p.User)
			   .WithMany()
			   .HasForeignKey(p => p.UserId);
			modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new FoodItemSeed());
        }
        public DbSet<PersonalFitnessApp.Domain.WorkoutLog> WorkoutLog { get; set; } = default!;
        public DbSet<PersonalFitnessApp.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<PersonalFitnessApp.Domain.FoodTracking> FoodTracking { get; set; } = default!;
        public DbSet<PersonalFitnessApp.Domain.TrackingItem> TrackingItem { get; set; } = default!;
        public DbSet<PersonalFitnessApp.Domain.FoodItem> FoodItem { get; set; } = default!;
    }
}
