using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "largefile.txt"; 
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null) { }
        }
        stopwatch.Stop();
        Console.WriteLine("StreamReader time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Reset();
        stopwatch.Start();

        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (reader.ReadLine() != null) { }
            }
        }

        stopwatch.Stop();
        Console.WriteLine("FileStream time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
