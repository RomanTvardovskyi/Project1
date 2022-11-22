using Project1.Vehicles.Bus;
using Project1.Vehicles.Car;
using Project1.Vehicles.Truck;

namespace Project1.Vehicles.Factories
{
    public class BMWFactory : AbstractFactory
    {
        public override Bus.Bus CreateBus()
        {
            return new BMWBus();
        }

        public override Car.Car CreateCar()
        {
            return new BMWCar();
        }

        public override Truck.Truck CreateTruck()
        {
            return new BMWTruck();
        }
    }
}
