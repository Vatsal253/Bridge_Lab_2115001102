using System;
class Program
{
    static void QuickSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(prices, left, right);
            QuickSort(prices, left, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] prices, int left, int right)
    {
        int pivot = prices[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                Swap(prices, i, j);
            }
        }

        Swap(prices, i + 1, right);
        return i + 1;
    }
    static void Swap(int[] prices, int i, int j)
    {
        int temp = prices[i];
        prices[i] = prices[j];
        prices[j] = temp;
    }

    static void PrintArray(int[] prices)
    {
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int[] prices = { 99, 19, 45, 29, 55, 10, 85 };
        Console.WriteLine("Original array:");
        PrintArray(prices);
        QuickSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted array:");
        PrintArray(prices);
    }
}
