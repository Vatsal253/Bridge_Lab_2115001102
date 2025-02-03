using System;
namespace CarRentDetails
{
    class CarRental
    {
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public int RentalDays { get; set; }
        public double DailyRate { get; set; }

        public CarRental()
        {
            CustomerName = "Unknown";
            CarModel = "Unknown";
            RentalDays = 0;
            DailyRate = 0.0;
        }
        public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
            DailyRate = dailyRate;
        }
        public CarRental(CarRental other)
        {
            CustomerName = other.CustomerName;
            CarModel = other.CarModel;
            RentalDays = other.RentalDays;
            DailyRate = other.DailyRate;
        }
        public double CalculateTotalCost()
        {
            return RentalDays * DailyRate;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Car Rental Details:");
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Car Model: " + CarModel);
            Console.WriteLine("Rental Days: " + RentalDays);
            Console.WriteLine("Daily Rate: " + DailyRate);
            Console.WriteLine("Total Cost: " + CalculateTotalCost());
        }
    }

    class Program
    {
        static void Main()
        {
            CarRental defaultRental = new CarRental();
            defaultRental.DisplayDetails();
            CarRental parameterizedRental = new CarRental("Vatsal Jain", "Toyota Supra", 7, 100000);
            parameterizedRental.DisplayDetails();
            CarRental copyRental = new CarRental(parameterizedRental);
            copyRental.DisplayDetails();
        }
    }
}
