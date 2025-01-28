using System;
namespace NaturalNumbers
{
    class Program
    {
        static void Main()
        {
            // Take user input 
            Console.WriteLine("Enter the number of natural numbers:");
            int n = int.Parse(Console.ReadLine());

            // Calculate the sum of natural numbers
            int sum = CalculateSum(n);

            Console.WriteLine("The sum of the first " + n + " natural numbers is " + sum + ".");
        }

        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
