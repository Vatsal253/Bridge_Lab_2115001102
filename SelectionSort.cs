using System;
class Program
{
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the unsorted part of the array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    static void PrintArray(int[] scores)
    {
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] scores = { 85, 78, 92, 68, 88, 76, 95, 89 };
        Console.WriteLine("Original array:");
        PrintArray(scores);
        SelectionSort(scores);
        Console.WriteLine("Sorted array:");
        PrintArray(scores);
    }
}
