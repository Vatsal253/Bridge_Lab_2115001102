using System;
namespace NumberCheckerUtility3
{
    public static class NumberChecker
    {
        // Method to find factors of a number and return them as an array
        public static int[] FindFactors(int number)
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

        // Method to find the greatest factor of a number using the factors array
        public static int FindGreatestFactor(int[] factors)
        {
            int greatest = factors[0];
            foreach (int factor in factors)
            {
                if (factor > greatest)
                {
                    greatest = factor;
                }
            }
            return greatest;
        }

        // Method to find the sum of the factors using the factors array and return the sum
        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        // Method to find the product of the factors using the factors array and return the product
        public static int ProductOfFactors(int[] factors)
        {
            int product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        // Method to find the product of the cube of the factors using the factors array
        public static double ProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            foreach (int factor in factors)
            {
                product *= Math.Pow(factor, 3);
            }
            return product;
        }

        // Method to check if a number is a perfect number
        public static bool IsPerfectNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum == number;
        }

        // Method to check if a number is an abundant number
        public static bool IsAbundantNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum > number;
        }

        // Method to check if a number is a deficient number
        public static bool IsDeficientNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum < number;
        }

        // Method to check if a number is a strong number
        public static bool IsStrongNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sumOfFactorials = 0;
            foreach (int digit in digits)
            {
                sumOfFactorials += Factorial(digit);
            }
            return sumOfFactorials == number;
        }

        // Helper method to get the digits of a number as an array
        public static int[] GetDigitsArray(int number)
        {
            string numberStr = number.ToString();
            int[] digits = new int[numberStr.Length];
            for (int i = 0; i < numberStr.Length; i++)
            {
                digits[i] = int.Parse(numberStr[i].ToString());
            }
            return digits;
        }

        // Helper method to find the factorial of a number
        public static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }

    class Program
    {
        static void Main()
        {
            // Example number
            int number = 28;

            // Call the methods and display results
            int[] factors = NumberChecker.FindFactors(number);
            Console.WriteLine("Factors: " + string.Join(", ", factors));

            int greatestFactor = NumberChecker.FindGreatestFactor(factors);
            Console.WriteLine("Greatest Factor: " + greatestFactor);

            int sumOfFactors = NumberChecker.SumOfFactors(factors);
            Console.WriteLine("Sum of Factors: " + sumOfFactors);

            int productOfFactors = NumberChecker.ProductOfFactors(factors);
            Console.WriteLine("Product of Factors: " + productOfFactors);

            double productOfCubeOfFactors = NumberChecker.ProductOfCubeOfFactors(factors);
            Console.WriteLine("Product of Cube of Factors: " + productOfCubeOfFactors);

            bool isPerfectNumber = NumberChecker.IsPerfectNumber(number);
            Console.WriteLine("Is Perfect Number: " + isPerfectNumber);

            bool isAbundantNumber = NumberChecker.IsAbundantNumber(number);
            Console.WriteLine("Is Abundant Number: " + isAbundantNumber);

            bool isDeficientNumber = NumberChecker.IsDeficientNumber(number);
            Console.WriteLine("Is Deficient Number: " + isDeficientNumber);

            bool isStrongNumber = NumberChecker.IsStrongNumber(number);
            Console.WriteLine("Is Strong Number: " + isStrongNumber);
        }
    }
}
