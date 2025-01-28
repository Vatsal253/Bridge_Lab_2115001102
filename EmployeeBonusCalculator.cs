using System;
namespace EmployeeBonusCalculator
{
    class Program
    {
        static void Main()
        {
            // Generate random salaries and years of service for 10 employees
            double[,] employeeData = GenerateEmployeeData(10);

            // Calculate new salaries and bonuses
            double[,] newEmployeeData = CalculateNewSalariesAndBonuses(employeeData);

            // Display the results in a tabular format
            DisplayResults(employeeData, newEmployeeData);
        }

        static double[,] GenerateEmployeeData(int size)
        {
            Random random = new Random();
            double[,] data = new double[size, 2];

            for (int i = 0; i < size; i++)
            {
                data[i, 0] = random.Next(10000, 100000); // Generate a 5-digit salary
                data[i, 1] = random.Next(1, 11); // Generate years of service between 1 and 10
            }

            return data;
        }

        static double[,] CalculateNewSalariesAndBonuses(double[,] employeeData)
        {
            int size = employeeData.GetLength(0);
            double[,] newData = new double[size, 2];

            for (int i = 0; i < size; i++)
            {
                double salary = employeeData[i, 0];
                double yearsOfService = employeeData[i, 1];
                double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
                double bonus = salary * bonusPercentage;
                double newSalary = salary + bonus;

                newData[i, 0] = newSalary;
                newData[i, 1] = bonus;
            }

            return newData;
        }

        static void DisplayResults(double[,] oldData, double[,] newData)
        {
            int size = oldData.GetLength(0);
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\tNew Salary");
            for (int i = 0; i < size; i++)
            {
                double oldSalary = oldData[i, 0];
                double yearsOfService = oldData[i, 1];
                double newSalary = newData[i, 0];
                double bonus = newData[i, 1];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine($"{i + 1}\t\t{oldSalary}\t\t{yearsOfService}\t\t\t{bonus}\t{newSalary}");
            }

            Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
            Console.WriteLine("Total New Salary: " + totalNewSalary);
            Console.WriteLine("Total Bonus Amount: " + totalBonus);
        }
    }
}
