using System;
namespace BasicCalculator
{
    class Program
    {
        static void Main()
        {
            double num1 = GetNumberInput("Enter the first number:");
            double num2 = GetNumberInput("Enter the second number:");
            string operation = GetOperationChoice();
            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine("The result is: " + result);
        }

        static double GetNumberInput(string prompt)
        {
            Console.WriteLine(prompt);
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input.");
            }
            return input;
        }

        static string GetOperationChoice()
        {
            Console.WriteLine("Choose an operation (add, subtract, multiply, divide):");
            return Console.ReadLine().ToLower();
        }

        static double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "add":
                    return Add(num1, num2);
                case "subtract":
                    return Subtract(num1, num2);
                case "multiply":
                    return Multiply(num1, num2);
                case "divide":
                    return Divide(num1, num2);
                default:
                    Console.WriteLine("Invalid operation. Please choose add, subtract, multiply, or divide.");
                    return 0;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }
}
