using Project1.CarService;
using Project1.Vehicles.Factories;
using Project1.Vehicles.Truck;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing with the Volvo factory");
            MakeVehicleSounds(new VolvoFactory());

            var bmwTruck = MakeTruckForInspection(new BMWFactory());
            CarServiceFacade.InspectVehicle(bmwTruck);
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

        private static Truck MakeTruckForInspection(AbstractFactory factory)
        {
            var truck = factory.CreateTruck();
            return truck;
        }
    }
}