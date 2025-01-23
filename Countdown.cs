using System;
namespace Countdown
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the countdown value: ");
            int count = int.Parse(Console.ReadLine());
			while (count >= 1)
            {
            Console.WriteLine(count);
            count--;
            }
            Console.WriteLine("Launch!");
        }
    }
}
