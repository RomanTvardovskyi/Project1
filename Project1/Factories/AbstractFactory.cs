namespace Project1.Factories
{
    public abstract class AbstractFactory
    {
        public abstract Car.Car CreateCar();
        public abstract Truck.Truck CreateTruck();
        public abstract Bus.Bus CreateBus();
    }
}
