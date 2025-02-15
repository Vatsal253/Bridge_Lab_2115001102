using System;
class Program
{
    static void InsertionSort(int[] ids)
    {
        int n = ids.Length;
        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;
            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j = j - 1;
            }
            ids[j + 1] = key;
        }
    }

    static void PrintArray(int[] ids)
    {
        foreach (int id in ids)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] ids = { 104, 102, 109, 101, 105, 103, 106 };
        Console.WriteLine("Original array:");
        PrintArray(ids);
        InsertionSort(ids);
        Console.WriteLine("Sorted array:");
        PrintArray(ids);
    }
}
