using System;
using System.Collections.Generic;
class Program
{
    static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> binaryNumbers = new List<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            binaryNumbers.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return binaryNumbers;
    }

    static void Main(string[] args)
    {
        int n = 10; // Number of binary numbers to generate

        List<string> binaryNumbers = GenerateBinaryNumbers(n);

        Console.WriteLine("The first " + n + " binary numbers are:");
        foreach (string binaryNumber in binaryNumbers)
        {
            Console.WriteLine(binaryNumber);
        }
    }
}
