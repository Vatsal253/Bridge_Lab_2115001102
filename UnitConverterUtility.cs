using System;
namespace UnitConverterUtility
{
    public static class UnitConverter
    {
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
    }

    class Program
    {
        static void Main()
        {
            double km = 10;
            double miles = UnitConverter.ConvertKmToMiles(km);
            Console.WriteLine(km + " kilometers is equal to " + miles + " miles.");

            double milesInput = 5;
            double kmResult = UnitConverter.ConvertMilesToKm(milesInput);
            Console.WriteLine(milesInput + " miles is equal to " + kmResult + " kilometers.");

            double meters = 100;
            double feet = UnitConverter.ConvertMetersToFeet(meters);
            Console.WriteLine(meters + " meters is equal to " + feet + " feet.");

            double feetInput = 50;
            double metersResult = UnitConverter.ConvertFeetToMeters(feetInput);
            Console.WriteLine(feetInput + " feet is equal to " + metersResult + " meters.");
        }
    }
}
