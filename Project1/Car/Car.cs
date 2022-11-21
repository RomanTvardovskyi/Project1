namespace Project1.Car
{
    public abstract class Car : Vehicle
    {
        public bool HasLiftingRoof { get; set; }

        public abstract void MakeCarSound();
    }
}
