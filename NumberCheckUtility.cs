using System;
namespace NumberCheckUtility
{
    public static class NumberChecker
    {
        // Method to check if a number is a prime number
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Method to check if a number is a neon number
        public static bool IsNeon(int number)
        {
            int square = number * number;
            int sumOfDigits = SumOfDigits(square);
            return sumOfDigits == number;
        }

        // Method to check if a number is a spy number
        public static bool IsSpy(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sumOfDigits = SumOfDigits(digits);
            int productOfDigits = ProductOfDigits(digits);
            return sumOfDigits == productOfDigits;
        }

        // Method to check if a number is an automorphic number
        public static bool IsAutomorphic(int number)
        {
            int square = number * number;
            return square.ToString().EndsWith(number.ToString());
        }

        // Method to check if a number is a buzz number
        public static bool IsBuzz(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
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

        // Helper method to find the sum of the digits of a number
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        // Helper method to find the sum of the digits of a number (using digits array)
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        // Helper method to find the product of the digits of a number
        public static int ProductOfDigits(int[] digits)
        {
            int product = 1;
            foreach (int digit in digits)
            {
                product *= digit;
            }
            return product;
        }
    }

    class Program
    {
        static void Main()
        {
            // Example number
            int number = 153;

            // Call the methods and display results
            Console.WriteLine("Is Prime: " + NumberChecker.IsPrime(number));
            Console.WriteLine("Is Neon: " + NumberChecker.IsNeon(number));
            Console.WriteLine("Is Spy: " + NumberChecker.IsSpy(number));
            Console.WriteLine("Is Automorphic: " + NumberChecker.IsAutomorphic(number));
            Console.WriteLine("Is Buzz: " + NumberChecker.IsBuzz(number));
        }
    }
}
