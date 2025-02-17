using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "binaryfile.bin"; 
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    int data;
                    while ((data = reader.Read()) != -1)
                    {
                        char character = (char)data;
                        Console.Write(character);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
