using System;
namespace DigitAnalyzer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            // Storing the digits of the number in the array
            while (number != 0)
            {
                if (index == maxDigit)
                {
                    maxDigit += 10;
                    int[] temp = new int[maxDigit];
                    for (int j = 0; j < digits.Length; j++)
                    {
                        temp[j] = digits[j];
                    }
                    digits = temp;
                }

                digits[index] = number % 10;
                number /= 10;
                index++;
            }

            // Finding the largest and second largest digits
            int largest = 0;
            int secondLargest = 0;

            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            // Displaying the results
            Console.WriteLine("The largest digit is " + largest + ".");
            Console.WriteLine("The second largest digit is " + secondLargest + ".");
        }
    }
}
