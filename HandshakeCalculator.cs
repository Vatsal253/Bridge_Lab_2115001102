using System;
namespace HandshakeCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Calculate the maximum number of handshakes
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            // Display the result
            Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes + ".");
        }

        static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
    }
}
