namespace PersonalFitnessApp.Domain
{
    public class TrackingItem : BaseDomainModel
    {
        public int FoodQty { get; set; }
        public int FoodTrackingId { get; set; }
        public int FoodItemId { get; set; }
    }
}
