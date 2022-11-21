namespace Project1.Bus
{
    public abstract class Bus : Vehicle
    {
        public string? BusType { get; set; }

        public abstract void MakeBusSound();
    }
}
