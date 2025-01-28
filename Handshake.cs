using System;
namespace Handshake
{
    class Program
    {
        static void Main()
        {
            // Take user input for the number of students
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes + ".");
        }

        static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
    }
}
