using System;

namespace UntilZero
{
    class Program
    {
        static void Main()
        {
            double total = 0.0;
            double inputUser;
			do
            {
            Console.Write("Enter a number (0 to stop): ");
            inputUser = double.Parse(Console.ReadLine());
            total += inputUser;
            } 
			while (inputUser != 0);
			Console.WriteLine("Total sum is " + total);
        }
    }
}
