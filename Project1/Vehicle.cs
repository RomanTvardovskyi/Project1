namespace Project1
{
    public abstract class Vehicle
    {
        public string? Name { get; set; }

        public string? Color { get; set; }

        public int NumberOfWheels { get; set; }

        public int NumberOfSeats { get; set; }

        public bool BeenInAnAccident { get; set; }

        public bool PartWereReplaced { get; set; }
    }
}
