using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
        }
    }
}
