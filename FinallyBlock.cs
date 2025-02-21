using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }
}
