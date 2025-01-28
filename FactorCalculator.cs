using System;
namespace FactorCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int[] factors = FindFactors(number);

            Console.WriteLine("Factors of " + number + ":");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();

            int sum = CalculateSum(factors);
            Console.WriteLine("Sum of the factors: " + sum);

            int product = CalculateProduct(factors);
            Console.WriteLine("Product of the factors: " + product);

            double sumOfSquares = CalculateSumOfSquares(factors);
            Console.WriteLine("Sum of squares of the factors: " + sumOfSquares);
        }

        static int[] FindFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }

            return factors;
        }

        static int CalculateSum(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        static int CalculateProduct(int[] factors)
        {
            int product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        static double CalculateSumOfSquares(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                sumOfSquares += Math.Pow(factor, 2);
            }
            return sumOfSquares;
        }
    }
}
