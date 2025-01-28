using System;
namespace UnitConverter
{
    public static class UnitConverter
    {
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        // Method to convert feet to yards
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }
    }

    class Program
    {
        static void Main()
        {
            
            double yards = 10;
            double feetFromYards = UnitConverter.ConvertYardsToFeet(yards);
            Console.WriteLine(yards + " yards is equal to " + feetFromYards + " feet.");

            double feet = 30;
            double yardsFromFeet = UnitConverter.ConvertFeetToYards(feet);
            Console.WriteLine(feet + " feet is equal to " + yardsFromFeet + " yards.");

            double meters = 5;
            double inchesFromMeters = UnitConverter.ConvertMetersToInches(meters);
            Console.WriteLine(meters + " meters is equal to " + inchesFromMeters + " inches.");

            double inches = 20;
            double metersFromInches = UnitConverter.ConvertInchesToMeters(inches);
            Console.WriteLine(inches + " inches is equal to " + metersFromInches + " meters.");

            double centimetersFromInches = UnitConverter.ConvertInchesToCentimeters(inches);
            Console.WriteLine(inches + " inches is equal to " + centimetersFromInches + " centimeters.");
        }
    }
}
