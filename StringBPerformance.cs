using System;
using System.Text;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        int iterations = 10000;
        string baseString = "Hello";
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string concatenatedString = "";
        for (int i = 0; i < iterations; i++)
        {
            concatenatedString += baseString;
        }

        stopwatch.Stop();
        Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Reset();
        stopwatch.Start();
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            stringBuilder.Append(baseString);
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
