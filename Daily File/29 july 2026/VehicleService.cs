using _29_july_2026.Controllers.Models;
using System.ComponentModel.DataAnnotations;


namespace _29_july_2026.Controllers.Services
{
   
        public class VehicleService : IVehicleService
        {
            private static List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Vehicle{Id = 101 , Name = "Armaan", Model = 123, Brand = "armaangupta123@gmail.com"},
            new Vehicle{Id = 101 , Name = "Armaan", Model = 1, Brand = "armaangupta123@gmail.com"},

            new Vehicle{Id = 101 , Name = "Armaan", Model = 90, Brand = "armaangupta123@gmail.com"},
            new Vehicle{Id = 101 , Name = "Armaan", Model = 1290, Brand = "armaangupta123@gmail.com"},

        };

            public List<Vehicle> getVehicle()
            {
                return Vehicles;
            }

            public Vehicle getVehicle(int id)
            {
                return Vehicles.FirstOrDefault(e => e.Id == id);
            }


            public Vehicle? getVehicleName(string Name)

            {
                return Vehicles.FirstOrDefault(e => e.Name == e.Name);

            }


        public Vehicle? addVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            return vehicle;
        }


    }
    }

