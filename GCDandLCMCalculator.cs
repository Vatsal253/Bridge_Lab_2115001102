using System;
namespace GCDandLCMCalculator 
{
    class Program
    {
        static void Main()
        {
            int num1 = GetIntegerInput("Enter the first number:");
            int num2 = GetIntegerInput("Enter the second number:");
            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2, gcd);
            Console.WriteLine("The GDC of " + num1 + " and " + num2 + " is: " + gcd);
            Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
        }

        static int GetIntegerInput(string user)
        {
            Console.WriteLine(user);
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
            return input;
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int CalculateLCM(int a, int b, int gcd)
        {
            return (a * b) / gcd;
        }
    }
}
