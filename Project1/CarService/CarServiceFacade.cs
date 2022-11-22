using Project1.Vehicles;

namespace Project1.CarService
{
    public static class CarServiceFacade
    {
        public static void InspectVehicle(Vehicle vehicle)
        {
            EngineService.CheckEngine();
            ChasisService.CheckChasis();
            ElectronicService.CheckElectronic();
            AccidentService.CheckForAnAccident(vehicle);
        }
    }
}
