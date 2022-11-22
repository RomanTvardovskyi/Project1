namespace Project1.Vehicles.Truck
{
    public abstract class Truck : Vehicle
    {
        public string? CabConfiguration { get; set; }

        public abstract void MakeTruckSound();
    }
}
