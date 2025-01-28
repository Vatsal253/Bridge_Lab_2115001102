using System;
namespace NumberCheckerUtility
{
    public static class NumberChecker
    {
        // Method to find the count of digits in the number
        public static int CountDigits(int number)
        {
            return number.ToString().Length;
        }

        // Method to store the digits of the number in a digits array
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

        // Method to find the sum of the digits of a number
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        // Method to find the sum of the squares of the digits of a number
        public static int SumOfSquaresOfDigits(int[] digits)
        {
            int sumOfSquares = 0;
            foreach (int digit in digits)
            {
                sumOfSquares += (int)Math.Pow(digit, 2);
            }
            return sumOfSquares;
        }

        // Method to check if a number is a Harshad number
        public static bool IsHarshadNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sumOfDigits = SumOfDigits(digits);
            return number % sumOfDigits == 0;
        }

        // Method to find the frequency of each digit in the number
        public static int[,] FindDigitFrequency(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[,] frequency = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
                frequency[i, 1] = 0;
            }

            foreach (int digit in digits)
            {
                frequency[digit, 1]++;
            }

            return frequency;
        }
    }

    class Program
    {
        static void Main()
        {
            // Example number
            int number = 1729;

            // Call the methods and display results
            int digitCount = NumberChecker.CountDigits(number);
            Console.WriteLine("Count of digits: " + digitCount);

            int[] digits = NumberChecker.GetDigitsArray(number);
            Console.WriteLine("Digits array: " + string.Join(", ", digits));

            int sumOfDigits = NumberChecker.SumOfDigits(digits);
            Console.WriteLine("Sum of digits: " + sumOfDigits);

            int sumOfSquaresOfDigits = NumberChecker.SumOfSquaresOfDigits(digits);
            Console.WriteLine("Sum of squares of digits: " + sumOfSquaresOfDigits);

            bool isHarshad = NumberChecker.IsHarshadNumber(number);
            Console.WriteLine("Is Harshad Number: " + isHarshad);

            int[,] digitFrequency = NumberChecker.FindDigitFrequency(number);
            Console.WriteLine("Digit frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (digitFrequency[i, 1] > 0)
                {
                    Console.WriteLine("Digit " + digitFrequency[i, 0] + ": " + digitFrequency[i, 1] + " times");
                }
            }
        }
    }
}
