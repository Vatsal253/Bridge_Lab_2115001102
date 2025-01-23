using System;
namespace SpringCheck
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the month: ");
            int month = int.Parse(Console.ReadLine());
			Console.Write("Enter the day: ");
            int day = int.Parse(Console.ReadLine());
			if ((month == 3 && day >= 20) || (month == 6 && day <= 20) || (month > 3 && month < 6))
            {
                Console.WriteLine("It's a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
    }
}
