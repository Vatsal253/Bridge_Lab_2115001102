using System;
namespace TrigonometricFunctions
{
    class Program
    {
        static void Main()
        {
      
            Console.WriteLine("Enter the angle in degrees:");
            double angleInDegrees = double.Parse(Console.ReadLine());

            // Calculate the trigonometric functions
            double[] results = CalculateTrigonometricFunctions(angleInDegrees);

            // Display the results
            Console.WriteLine("Sine: " + results[0]);
            Console.WriteLine("Cosine: " + results[1]);
            Console.WriteLine("Tangent: " + results[2]);
        }

        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert angle to radians
            double angleInRadians = angle * (Math.PI / 180);

            // Calculate sine, cosine, and tangent
            double sine = Math.Sin(angleInRadians);
            double cosine = Math.Cos(angleInRadians);
            double tangent = Math.Tan(angleInRadians);

            return new double[] { sine, cosine, tangent };
        }
    }
}
