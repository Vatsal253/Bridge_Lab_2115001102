using System;
namespace MultiplicationTable2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 6 && number <= 9)
            {
                int[] multiplicationResult = new int[10];

                for (int i = 1; i <= 10; i++)
                {
                    multiplicationResult[i - 1] = number * i;
                }
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 1]);
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 6 and 9.");
            }
        }
    }
}
