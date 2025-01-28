using System;
namespace WindChill
{
    class Program
    {
        static void Main()
        {
            // Take user input for temperature and wind speed
            Console.WriteLine("Enter the temperature (in Fahrenheit):");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the wind speed (in mph):");
            double windSpeed = double.Parse(Console.ReadLine());

            // Calculate the wind chill temperature
            double windChill = CalculateWindChill(temperature, windSpeed);

            // Display the result
            Console.WriteLine("The wind chill temperature is " + windChill + " degrees Fahrenheit.");
        }

        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        }
    }
}
