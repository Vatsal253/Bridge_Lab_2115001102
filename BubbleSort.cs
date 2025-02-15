using System;
class Program
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] marks)
    {
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] marks = { 85, 78, 92, 68, 88, 76, 95, 89 };

        Console.WriteLine("Original array:");
        PrintArray(marks);

        BubbleSort(marks);

        Console.WriteLine("Sorted array:");
        PrintArray(marks);
    }
}
