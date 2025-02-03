namespace PersonalFitnessApp.Domain
{
    public class FoodItem : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Calories { get; set; }
        public int Carbohydrates { get; set; }
        public int Protein { get; set; }
        public int Fibre { get; set; }
    }
}
