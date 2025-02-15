using System;
class Program
{
    static void CountingSort(int[] ages, int min, int max)
    {
        int[] count = new int[max - min + 1];
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - min]++;
        }
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - min] - 1] = ages[i];
            count[ages[i] - min]--;
        }
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] ages = { 13, 10, 15, 14, 13, 16, 12, 11, 14, 15, 17 };
        Console.WriteLine("Original array:");
        PrintArray(ages);
        CountingSort(ages, 10, 18);
        Console.WriteLine("Sorted array:");
        PrintArray(ages);
    }
}
