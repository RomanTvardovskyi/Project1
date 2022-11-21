namespace Project1.Truck
{
    public abstract class Truck : Vehicle
    {
        public string? CabConfiguration { get; set; }

        public abstract void MakeTruckSound();
    }
}
