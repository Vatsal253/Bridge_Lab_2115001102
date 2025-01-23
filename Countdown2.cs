using System;
namespace Countdown2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the countdown value: ");
            int count = int.Parse(Console.ReadLine());
			for (int i = count; i >= 1; i--)
            {
            Console.WriteLine(i);
            }
            Console.WriteLine("Launch!");
        }
    }
}
