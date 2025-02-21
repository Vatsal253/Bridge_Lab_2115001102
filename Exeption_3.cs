using System;
namespace CustomExceptionExample
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }
            else
            {
                Console.WriteLine("Access granted!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
