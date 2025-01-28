using System;
namespace NumberCheck
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

        // Method to check if a number is a duck number
        public static bool IsDuckNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            foreach (int digit in digits)
            {
                if (digit != 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Method to check if the number is an Armstrong number
        public static bool IsArmstrongNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sum = 0;
            int power = digits.Length;
            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, power);
            }
            return sum == number;
        }

        // Method to find the largest and second largest elements in the digits array
        public static (int, int) FindLargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;
            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit != largest)
                {
                    secondLargest = digit;
                }
            }
            return (largest, secondLargest);
        }

        // Method to find the smallest and second smallest elements in the digits array
        public static (int, int) FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;
            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit != smallest)
                {
                    secondSmallest = digit;
                }
            }
            return (smallest, secondSmallest);
        }
    }

    class Program
    {
        static void Main()
        {
            // Example number
            int number = 153;

            // Call the methods and display results
            int digitCount = NumberChecker.CountDigits(number);
            Console.WriteLine("Count of digits: " + digitCount);

            int[] digits = NumberChecker.GetDigitsArray(number);
            Console.WriteLine("Digits array: " + string.Join(", ", digits));

            bool isDuck = NumberChecker.IsDuckNumber(number);
            Console.WriteLine("Is Duck Number: " + isDuck);

            bool isArmstrong = NumberChecker.IsArmstrongNumber(number);
            Console.WriteLine("Is Armstrong Number: " + isArmstrong);

            var (largest, secondLargest) = NumberChecker.FindLargestAndSecondLargest(digits);
            Console.WriteLine("Largest digit: " + largest);
            Console.WriteLine("Second largest digit: " + secondLargest);

            var (smallest, secondSmallest) = NumberChecker.FindSmallestAndSecondSmallest(digits);
            Console.WriteLine("Smallest digit: " + smallest);
            Console.WriteLine("Second smallest digit: " + secondSmallest);
        }
    }
}
