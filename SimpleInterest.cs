using System;
namespace SimpleInterest
{
    class Program
    {
        static void Main()
        {
            // Take user input for Principal, Rate, and Time
            Console.WriteLine("Enter the Principal amount:");
            double principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest:");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Time (in years):");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = CalculateSimpleInterest(principal, rate, time);

            // Display the result
            Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time + " years.");
        }

        static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
}
