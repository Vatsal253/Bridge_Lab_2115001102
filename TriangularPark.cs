using System;
namespace TriangularPark
{
    class Program
    {
        static void Main()
        {
            // Take user input for the three sides of the triangle
            Console.WriteLine("Enter the length of side A (in meters):");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side B (in meters):");
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side C (in meters):");
            double sideC = double.Parse(Console.ReadLine());

            // Calculate the perimeter of the triangle
            double perimeter = CalculatePerimeter(sideA, sideB, sideC);

            // Calculate the number of rounds needed to complete a 5 km run
            double distanceToRun = 5000; // 5 km in meters
            double rounds = CalculateRounds(distanceToRun, perimeter);

            // Display the result
            Console.WriteLine("The athlete needs to complete " + rounds + " rounds to run 5 km.");
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculateRounds(double distance, double perimeter)
        {
            return distance / perimeter;
        }
    }
}
