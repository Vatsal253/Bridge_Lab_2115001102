using System;
namespace FactorialRecursion
{
	class Program
	{
		static void Main()
		{
			int number = GetInput();
			long facorial = DisplayFactorial(number);
			DisplayResult(number , facorial);
			
		}
		static int GetInput()
		{
			Console.WriteLine("Enter a number:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer:");
            }
            return num;
		}
		 static long DisplayFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            return num * DisplayFactorial(num - 1);
        }
		static void DisplayResult(int num, long factorial)
        {
			Console.WriteLine("The factorial of "+num+" is "+factorial);
		}
	}
}