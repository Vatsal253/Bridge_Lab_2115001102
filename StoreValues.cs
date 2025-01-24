using System;
namespace StoreValues
{
    class Program
    {
        static void Main()
        {
            double[] values = new double[10];
            double total = 0.0;
            int index = 0;

            while (true)
            {
                Console.WriteLine("Enter a number:");
                double number = double.Parse(Console.ReadLine());

                if (number <= 0 || index == 10)
                {
                    break;
                }

                values[index] = number;
                index++;
            }

            Console.WriteLine("The numbers entered are:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(values[i]);
                total += values[i];
            }

            Console.WriteLine("The sum of all numbers is " + total + ".");
        }
    }
}
