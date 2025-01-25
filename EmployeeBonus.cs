using System;
namespace EmployeeBonus
{
    class Program
    {
        static void Main()
        {
            double[] salaries = new double[10];
            double[] yearsOfService = new double[10];
            double[] bonuses = new double[10];
            double[] newSalaries = new double[10];
            double totalBonus = 0.0;
            double totalOldSalary = 0.0;
            double totalNewSalary = 0.0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the salary of employee " + (i + 1) + ":");
                salaries[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the years of service of employee " + (i + 1) + ":");
                yearsOfService[i] = double.Parse(Console.ReadLine());

                if (salaries[i] <= 0 || yearsOfService[i] < 0)
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                    i--;
                }
            }

            // Calculating bonuses and new salaries
            for (int i = 0; i < 10; i++)
            {
                if (yearsOfService[i] > 5)
                {
                    bonuses[i] = salaries[i] * 0.05;
                }
                else
                {
                    bonuses[i] = salaries[i] * 0.02;
                }
                newSalaries[i] = salaries[i] + bonuses[i];
                totalBonus += bonuses[i];
                totalOldSalary += salaries[i];
                totalNewSalary += newSalaries[i];
            }
            Console.WriteLine("Total bonus payout: " + totalBonus);
            Console.WriteLine("Total old salary: " + totalOldSalary);
            Console.WriteLine("Total new salary: " + totalNewSalary);
        }
    }
}
