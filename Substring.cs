using System;
namespace Substring
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the original string:");
            string oString = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            string substring = Console.ReadLine();
            int count = 0;
            for (int i = 0; i <= oString.Length - substring.Length; i++)
            {
                bool isSame = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (oString[i + j] != substring[j])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    count++;
                }
            }
            Console.WriteLine("The substring occurs " + count + " times in the main string.");
        }
    }
}
