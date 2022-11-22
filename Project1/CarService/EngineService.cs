using Project1.CarService.EngineStrategies;
using Project1.Vehicles;
using Project1.Vehicles.Bus;
using Project1.Vehicles.Car;

namespace Project1.CarService
{
    public static class EngineService
    {
        private static IEngineStrategy _engineStrategy;

        public static void SetEngineType(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                _engineStrategy = new CarEngineStrategy();
            }
            else if (vehicle is Bus)
            {
                _engineStrategy = new BusEngineStrategy();
            }
            else
            {
                _engineStrategy = new TruckEngineStrategy();
            }
        }

        public static void CheckEngine()
        {
            _engineStrategy.CheckEngine();
        }
    }
}
