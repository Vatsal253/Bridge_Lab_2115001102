using System;

namespace SimpleInterestCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the Principal amount (INR): ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Rate of Interest (%): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Time (years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
        }
    }
}
