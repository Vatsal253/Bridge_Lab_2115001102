using System;
namespace VehicleRegistration
{
    class Vehicle
    {
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }
        public static double RegistrationFee { get; private set; } ;
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Vehicle Details:");
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
    }
    class Program
    {
        static void Main()
        {
            Vehicle.UpdateRegistrationFee(15000.0);
            Vehicle vehicle1 = new Vehicle("Apple", "Car");
            Vehicle vehicle2 = new Vehicle("Banana", "Cycle");
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
        }
    }
}
