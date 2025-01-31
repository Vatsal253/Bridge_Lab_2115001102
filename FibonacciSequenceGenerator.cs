using System;
namespace FibonacciSequenceGenerator
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the number of terms: ");
			int terms;
			while (!int.TryParse(Console.ReadLine(), terms) || terms <= 0)
			{
				Console.WriteLine("Invalid Input");
			}
			GenerateFibonacci(terms);
		}
		static void GenerateFibonacci(int terms)
		{
			int first = 0,second = 1,next;
			Console.WriteLine("Fibonacci Numbers up to "+terms+" terms:");
			for (int i = 1; i <= terms; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(first);
                    continue;
                }
                if (i == 2)
                {
                    Console.WriteLine(second);
                    continue;
                }
                next = first + second;
                first = second;
                second = next;
				Console.WriteLine(next);
			}
		}
	}
}
			
				
				