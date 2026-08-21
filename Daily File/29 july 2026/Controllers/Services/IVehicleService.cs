using _29_july_2026.Controllers.Models;

namespace _29_july_2026.Controllers.Services
{
    public interface IVehicleService
    {
        List<Vehicle> getVehicle();
        Vehicle? getVehicle(int id);
        Vehicle? getVehicleName(string Name);
        Vehicle? addVehicle(Vehicle vehicle);
    }
}
