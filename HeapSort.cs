using System;
class Program
{
    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;
            Heapify(salaries, i, 0);
        }
    }
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            int swap = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = swap;
            Heapify(salaries, n, largest);
        }
    }
    static void PrintArray(int[] salaries)
    {
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] salaries = { 45000, 32000, 60000, 50000, 42000, 58000 };
        Console.WriteLine("Original array:");
        PrintArray(salaries);
        HeapSort(salaries);
        Console.WriteLine("Sorted array:");
        PrintArray(salaries);
    }
}
