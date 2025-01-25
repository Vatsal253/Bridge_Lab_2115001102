using System;
namespace ReverseNumber
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
            for (int i = 0; i < count; i++)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            // Display the elements of the array in reverse order
            Console.WriteLine("The digits of the number in reverse order are:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();
        }
    }
}
