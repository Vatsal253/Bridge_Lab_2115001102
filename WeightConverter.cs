using System;

namespace WeightConverter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the weight in pounds: ");
            double weightPounds = Convert.ToDouble(Console.ReadLine());

            double weightKg = weightPounds / 2.2;

            Console.WriteLine("The weight of the person in pounds is " + weightPounds + " and in kg is " + weightKg);
        }
    }
}
