namespace Project1.Vehicles.Bus
{
    public abstract class Bus : Vehicle
    {
        public string? BusType { get; set; }

        public abstract void MakeBusSound();
    }
}
