using System;
namespace TemperatureConverter
{
    class Program
    {
        static void Main()
        {
            double temperature = GetTemperatureInput();
            string choice = GetConversionChoice();
            if (choice == "F to C")
            {
                double celsius = ConvertFahrenheitToCelsius(temperature);
                Console.WriteLine(+temperature+"°F is equal to "+celsius+"°C.");
            }
            else if (choice == "C to F")
            {
                double fahrenheit = ConvertCelsiusToFahrenheit(temperature);
                Console.WriteLine(+temperature+"°C is equal to "+fahrenheit+"°F.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static double GetTemperatureInput()
        {
            Console.WriteLine("Enter the temperature:");
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input.");
            }
            return input;
        }

        static string GetConversionChoice()
        {
            Console.WriteLine("Enter the conversion choice (F to C or C to F):");
            return Console.ReadLine().ToUpper();
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
