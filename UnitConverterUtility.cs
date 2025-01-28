using System;
namespace UnitConverterUtility
{
    public static class UnitConverter
    {
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }
    }

    class Program
    {
        static void Main()
        {
            double fahrenheit = 98.6;
            double celsius = UnitConverter.ConvertFahrenheitToCelsius(fahrenheit);
            Console.WriteLine(fahrenheit + " Fahrenheit is equal to " + celsius + " Celsius.");

            double celsiusInput = 37;
            double fahrenheitResult = UnitConverter.ConvertCelsiusToFahrenheit(celsiusInput);
            Console.WriteLine(celsiusInput + " Celsius is equal to " + fahrenheitResult + " Fahrenheit.");

            double pounds = 150;
            double kilograms = UnitConverter.ConvertPoundsToKilograms(pounds);
            Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms.");

            double kilogramsInput = 68;
            double poundsResult = UnitConverter.ConvertKilogramsToPounds(kilogramsInput);
            Console.WriteLine(kilogramsInput + " kilograms is equal to " + poundsResult + " pounds.");

            double gallons = 10;
            double liters = UnitConverter.ConvertGallonsToLiters(gallons);
            Console.WriteLine(gallons + " gallons is equal to " + liters + " liters.");

            double litersInput = 25;
            double gallonsResult = UnitConverter.ConvertLitersToGallons(litersInput);
            Console.WriteLine(litersInput + " liters is equal to " + gallonsResult + " gallons.");
        }
    }
}
