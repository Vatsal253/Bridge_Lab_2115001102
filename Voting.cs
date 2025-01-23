using System;
namespace Voting
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the person's age: ");
            int age = int.Parse(Console.ReadLine());
			if (age >= 18)
            {
                Console.WriteLine("The person's age is " + age + " and can vote.");
            }
            else
            {
                Console.WriteLine("The person's age is " + age + " and cannot vote.");
            }
        }
    }
}
