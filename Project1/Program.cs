using Project1.Factories;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing with the first factory");
            MakeVehicleSounds(new BMWFactory());

            Console.WriteLine("Testing with the second factory");
            MakeVehicleSounds(new VolvoFactory());
        }

        private static void MakeVehicleSounds(AbstractFactory factory)
        {
            var car = factory.CreateCar();
            var bus = factory.CreateBus();
            var truck = factory.CreateTruck();

            car.MakeCarSound();
            bus.MakeBusSound();
            truck.MakeTruckSound();
        }
    }
}