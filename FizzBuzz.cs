using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                string[] results = new string[number + 1];

                for (int i = 1; i <= number; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        results[i] = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        results[i] = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        results[i] = "Buzz";
                    }
                    else
                    {
                        results[i] = i.ToString();
                    }
                }

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("Position " + i + " = " + results[i]);
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}
