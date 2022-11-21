using Project1.Bus;
using Project1.Car;
using Project1.Truck;

namespace Project1.Factories
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
