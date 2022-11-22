using Project1.Vehicles;

namespace Project1.CarService
{
    public static class AccidentService
    {
        public static void CheckForAnAccident(Vehicle vehicle)
        {
            if (vehicle.BeenInAnAccident == true)
            {
                Console.WriteLine("Car been in an accident");
            }
        }
    }
}
