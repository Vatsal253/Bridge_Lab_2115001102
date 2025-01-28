using System;
namespace CollinearPoints
{
    class Program
    {
        static void Main()
        {
            // Take inputs for 3 points
            Console.WriteLine("Enter the coordinates of point A (x1, y1):");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point B (x2, y2):");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point C (x3, y3):");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            // Check if the points are collinear using the slope formula
            bool areCollinearSlope = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);

            // Check if the points are collinear using the area of the triangle formula
            bool areCollinearArea = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);

            // Display the results
            Console.WriteLine("Using the slope formula, the points are " + (areCollinearSlope ? "collinear." : "not collinear."));
            Console.WriteLine("Using the area of the triangle formula, the points are " + (areCollinearArea ? "collinear." : "not collinear."));
        }

        static bool AreCollinearUsingSlope(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            // Calculate the slopes
            double slopeAB = (double)(y2 - y1) / (x2 - x1);
            double slopeBC = (double)(y3 - y2) / (x3 - x2);
            double slopeAC = (double)(y3 - y1) / (x3 - x1);

            // Check if the slopes are equal
            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        static bool AreCollinearUsingArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            // Calculate the area of the triangle
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            // Check if the area is 0
            return area == 0;
        }
    }
}
