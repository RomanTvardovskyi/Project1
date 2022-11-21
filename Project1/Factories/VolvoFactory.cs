using Project1.Bus;
using Project1.Car;
using Project1.Truck;

namespace Project1.Factories
{
    public class VolvoFactory : AbstractFactory
    {
        public override Bus.Bus CreateBus()
        {
            return new VolvoBus();
        }

        public override Car.Car CreateCar()
        {
            return new VolvoCar();
        }

        public override Truck.Truck CreateTruck()
        {
            return new VolvoTruck();
        }
    }
}
