using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] array = { 10, 20, 30, 40, 50 };
            Console.Write("Enter an index number: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Enter a divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                int element = array[index];

                try
                {
                    int result = element / divisor;
                    Console.WriteLine("Division result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
