using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "output.txt"; 

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Enter text to write to the file (type 'exit' to finish):");

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        break;
                    }

                    writer.WriteLine(input);
                }
            }
            Console.WriteLine("User input has been written to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
