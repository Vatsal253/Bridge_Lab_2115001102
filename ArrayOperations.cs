using System;
namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 1, 2, 3, 4, 5 };
                Console.Write("Enter an index number: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Value at index {0}: {1}", index, array[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: The index is out of range.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: The array is null.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
