using System;
namespace VehicleManagement
{
    class Vehicle
    {
        public static double RegistrationFee { get; set; } 
        public readonly string RegistrationNumber;
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }
        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
        {
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            this.RegistrationNumber = registrationNumber;
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
        public void DisplayDetails()
        {
            if (this is Vehicle)
            {
                Console.WriteLine("Vehicle Details:");
                Console.WriteLine("Owner Name: " + OwnerName);
                Console.WriteLine("Vehicle Type: " + VehicleType);
                Console.WriteLine("Registration Number: " + RegistrationNumber);
                Console.WriteLine("Registration Fee: " + RegistrationFee);
            }
            else
            {
                Console.WriteLine("Invalid Object");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Vehicle.UpdateRegistrationFee(100.0);
            Vehicle vehicle1 = new Vehicle("Vatsal", "Car", "UP755015");
            Vehicle vehicle2 = new Vehicle("Suyash", "Car", "UP321723");
            vehicle1.DisplayDetails();
            Vehicle.UpdateRegistrationFee(150.0);
			vehicle2.DisplayDetails();
        }
    }
}
