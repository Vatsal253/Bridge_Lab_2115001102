using System;
class Program
{
    static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(prices, left, middle);
            MergeSort(prices, middle + 1, right);
            Merge(prices, left, middle, right);
        }
    }

    static void Merge(int[] prices, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];
        Array.Copy(prices, left, leftArray, 0, n1);
        Array.Copy(prices, middle + 1, rightArray, 0, n2);
        int i = 0, j = 0;
        int k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                prices[k] = leftArray[i];
                i++;
            }
            else
            {
                prices[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            prices[k] = leftArray[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            prices[k] = rightArray[j];
            j++;
            k++;
        }
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
        int[] prices = { 19, 29, 15, 49, 25, 39, 45 };
        Console.WriteLine("Original array:");
        PrintArray(prices);
        MergeSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted array:");
        PrintArray(prices);
    }
}
