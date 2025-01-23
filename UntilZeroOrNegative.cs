using System;
namespace UntilZeroOrNegative
{
    class Program
    {
        static void Main()
        {
            double total = 0.0;
			while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double userInput = double.Parse(Console.ReadLine());

                if (userInput <= 0)
                {
                    break;
                }

                total += userInput;
            }

            Console.WriteLine("Total sum is " + total);
        }
    }
}
