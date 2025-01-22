using System;

namespace IncomeCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            double totalIncome = salary + bonus;

            Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+" Hence Total Income is INR "+totalIncome);
        }
    }
}
