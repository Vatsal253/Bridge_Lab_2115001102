using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader("info.txt"))
            {
                string firstLine = sr.ReadLine();
                Console.WriteLine("First line of the file: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
