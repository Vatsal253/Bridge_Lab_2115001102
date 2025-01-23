using System;
namespace ArmstrongCheck
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int ogNumber = number;
            int sum = 0;

            while (ogNumber != 0)
            {
                int remainder = ogNumber % 10;
                sum += remainder * remainder * remainder;
                ogNumber /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number.");
            }
        }
    }
}
