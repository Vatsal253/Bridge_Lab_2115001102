using System;

namespace NumberSwapper
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
        }
    }
}
