using System;
namespace FactorsFinder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The factors of " + number + " are:");
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
