using System;
namespace Power
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the base number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power:");
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            Console.WriteLine("The result of " + number + " raised to the power of " + power + " is " + result + ".");
        }
    }
}
