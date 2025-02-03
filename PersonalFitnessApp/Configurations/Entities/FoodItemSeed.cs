using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFitnessApp.Domain;

namespace PersonalFitnessApp.Configurations.Entities
{
    public class FoodItemSeed : IEntityTypeConfiguration<FoodItem>
    {
        public void Configure(EntityTypeBuilder<FoodItem> builder)
        {
            builder.HasData(
                new FoodItem
                {
                    Id = 1,
                    Name = "Mcdonalds Hamburger",
                    Calories = 418,
                    Carbohydrates = 30,
                    Protein = 25,
                    Fibre = 1,
                },
                new FoodItem
                {
                    Id = 2,
                    Name = "KFC drumstick",
                    Calories = 377,
                    Carbohydrates = 4,
                    Protein = 40,
                    Fibre = 0,
                },
                new FoodItem
                {
                    Id = 3,
                    Name = "Chicken Rice",
                    Calories = 299,
                    Carbohydrates = 38,
                    Protein = 30,
                    Fibre = 1,
                },
                new FoodItem
                {
                    Id = 4,
                    Name = "Dominos Chesse Pizza (1 Slice)",
                    Calories = 285,
                    Carbohydrates = 36,
                    Protein = 12,
                    Fibre = 3,
                },
                new FoodItem
                {
                    Id = 5,
                    Name = "Salad",
                    Calories = 20,
                    Carbohydrates = 4,
                    Protein = 1,
                    Fibre = 2,
                }
                );
        }
    }
}
