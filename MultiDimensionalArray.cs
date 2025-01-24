using System;
namespace MultiDimensionalArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            // Taking user input for the 2D array (Matrix)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Enter the element at position [" + i + "," + j + "]:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] array = new int[rows * columns];
            int index = 0;

            // Copying elements from the 2D array to the 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }
            Console.WriteLine("The elements of the 1D array are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}