using System;
class Program
{
    static int FindFirstNegative(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                return array[i];
            }
        }
        return int.MinValue; // or any other value that indicates no negative number was found
    }
    static void Main(string[] args)
    {
        int[] array = { 3, 7, -1, 4, 8, -5, 10 };

        int firstNegative = FindFirstNegative(array);

        if (firstNegative != int.MinValue)
        {
            Console.WriteLine("The first negative number in the array is: " + firstNegative);
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
