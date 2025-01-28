using System;
namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a natural number:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("The input is not a natural number. Exiting the program.");
                return;
            }

            int recursiveSum = CalculateSumRecursive(n);

            int formulaSum = CalculateSumFormula(n);

            Console.WriteLine("Sum of the first " + n + " natural numbers using recursion: " + recursiveSum);
            Console.WriteLine("Sum of the first " + n + " natural numbers using the formula: " + formulaSum);

            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("Both computations are correct.");
            }
            else
            {
                Console.WriteLine("There is a discrepancy between the two computations.");
            }
        }

        static int CalculateSumRecursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + CalculateSumRecursive(n - 1);
        }

        static int CalculateSumFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
