using System;
using System.Collections.Generic;
namespace VehicleRental
{
	abstract class Vehicle
	{
		private int vehicleNumber;
		private string type;
		private double rentalRate;
		public int vehicleNumber
		{
			get { return vehicleNumber; }
            set { vehicleNumber = value; }
		}
		public string type
        {
            get { return type; }
            set { type= value; }
        }
        public double rentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }
		 protected Employee(int vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }
		public abstract double CalculateRentalCost();
		public virtual void DisplayDetails()
		{
            Console.WriteLine("Vehicle Number: " + vehicleNumber);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Reantal Rate: " +rentalRate);
        }
    }
	class Car : Vehicle, IInsurable
    {
        public Car(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 50000; 
        }

        public string GetInsuranceDetails()
        {
            return "Insurance Policy Number: " + InsurancePolicyNumber;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Vehicle Type: Car");
        }
    }
	class Bike : Vehicle, IInsurable
    {
        public Bike(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
		public double CalculateInsurance()
		{
			return 2000;
		}
		public string GetInsuranceDetails()
        {
            return "Insurance Policy Number: " + InsurancePolicyNumber;
        }
		 public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Vehicle Type: Bike");
        }
    }
	class Truck : Vehicle, IInsurable
    {
        public Truck(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, type, rentalRate, insurancePolicyNumber) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
			return 4000;
		}
		 public string GetInsuranceDetails()
        {
            return "Insurance Policy Number: " + InsurancePolicyNumber;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Vehicle Type: Truck");
        }
    }
	class Program
	{
		static void Main()
		{
			List<Vehicle> vehicles = new List<Vehicle>
            {
				new Car("UP765" , "Sedan" , 50 , "Car1");
				new bike("MH023" , "Sports" , 20 , "Bike1");
				new truck("HR234" , "6Wheel" , 100 , "Truck1");
				foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                Console.WriteLine("Rental Cost for 5 days: $" + vehicle.CalculateRentalCost(5));

                if (vehicle is IInsurable insurableVehicle)
                {
                    Console.WriteLine("Insurance Cost: $" + insurableVehicle.CalculateInsurance());
                    Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                }

                Console.WriteLine();
            }
        }
    }
}
}
