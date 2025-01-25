using System;
namespace DigitFrequency
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            // Find the count of digits in the number
            int temp = number;
            int count = 0;
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }

            // Store the digits of the number in an array
            int[] digits = new int[count];
            temp = number;
            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            // Find the frequency of each digit
            int[] frequency = new int[10];
            for (int i = 0; i < count; i++)
            {
                frequency[digits[i]]++;
            }

            // Display the frequency of each digit
            Console.WriteLine("The frequency of each digit in the number is:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Digit " + i + ": " + frequency[i]);
                }
            }
        }
    }
}
