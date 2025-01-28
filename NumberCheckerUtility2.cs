using System;
namespace NumberCheckerUtility2
{
    public static class NumberChecker
    {
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

        // Method to reverse the digits array
        public static int[] ReverseDigitsArray(int[] digits)
        {
            Array.Reverse(digits);
            return digits;
        }

        // Method to compare two arrays and check if they are equal
        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Method to check if a number is a palindrome using the digits
        public static bool IsPalindrome(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[] reversedDigits = ReverseDigitsArray((int[])digits.Clone());
            return AreArraysEqual(digits, reversedDigits);
        }

        // Method to check if a number is a duck number using the digits array
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
    }

    class Program
    {
        static void Main()
        {
            // Example number
            int number = 12321;

            // Call the methods and display results
            int digitCount = NumberChecker.CountDigits(number);
            Console.WriteLine("Count of digits: " + digitCount);

            int[] digits = NumberChecker.GetDigitsArray(number);
            Console.WriteLine("Digits array: " + string.Join(", ", digits));

            int[] reversedDigits = NumberChecker.ReverseDigitsArray((int[])digits.Clone());
            Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits));

            bool areArraysEqual = NumberChecker.AreArraysEqual(digits, reversedDigits);
            Console.WriteLine("Are original and reversed arrays equal? " + areArraysEqual);

            bool isPalindrome = NumberChecker.IsPalindrome(number);
            Console.WriteLine("Is Palindrome: " + isPalindrome);

            bool isDuckNumber = NumberChecker.IsDuckNumber(number);
            Console.WriteLine("Is Duck Number: " + isDuckNumber);
        }
    }
}
