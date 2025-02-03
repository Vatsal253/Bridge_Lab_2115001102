using System;
namespace CircleDetails
{
    class Circle
    {
        public double Radius { get; set; }
        public Circle() : this(1.0) 
        {
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Circle Details:");
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }

    class Program
    {
        static void Main()
        {
            Circle defaultCircle = new Circle();
            defaultCircle.DisplayDetails();
            Console.WriteLine("Enter the radius of the circle:");
            double userRadius = Convert.ToDouble(Console.ReadLine());
            Circle userCircle = new Circle(userRadius);
            userCircle.DisplayDetails();
        }
    }
}
