using System;
namespace EmployeeBonus
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter the years of service: ");
            int yearsOfService = int.Parse(Console.ReadLine());

            if (yearsOfService > 5)
            {
                double bonus = salary * 0.05;
                Console.WriteLine("The bonus amount is " + bonus);
            }
            else
            {
                Console.WriteLine("No bonus for employees with less than 5 years of service.");
            }
        }
    }
}
