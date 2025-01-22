using System;

namespace TriangularParkRun
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the length of the first side of the park in meters: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the second side of the park in meters: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the third side of the park in meters: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double perimeter = side1 + side2 + side3;
            double distance = 5000; // 5 km in meters
            double rounds = distance / perimeter;

            Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
        }
    }
}
