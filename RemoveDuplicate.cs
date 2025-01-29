using System;
namespace RemoveDuplicate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < result.Length; j++)
                {
                    if (input[i] == result[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    result += input[i];
                }
            }

            Console.WriteLine("Modified string: " + result);
        }
    }
}
