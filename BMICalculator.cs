using System;
namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of persons:");
            int numberOfPersons = int.Parse(Console.ReadLine());

            double[] weights = new double[numberOfPersons];
            double[] heights = new double[numberOfPersons];
            double[] bmis = new double[numberOfPersons];
            string[] weightStatuses = new string[numberOfPersons];

            // Taking input for weight and height of the persons
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Enter the weight (in kg) of person " + (i + 1) + ":");
                weights[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height (in cm) of person " + (i + 1) + ":");
                heights[i] = double.Parse(Console.ReadLine());
            }

            // Calculating BMI and weight status
            for (int i = 0; i < numberOfPersons; i++)
            {
                double heightInMeters = heights[i] / 100;
                bmis[i] = weights[i] / (heightInMeters * heightInMeters);

                if (bmis[i] < 18.5)
                {
                    weightStatuses[i] = "Underweight";
                }
                else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                {
                    weightStatuses[i] = "Normal";
                }
                else if (bmis[i] >= 25 && bmis[i] < 39.9)
                {
                    weightStatuses[i] = "Overweight";
                }
                else
                {
                    weightStatuses[i] = "Obese";
                }
            }
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Person " + (i + 1) + ":");
                Console.WriteLine("Height: " + heights[i] + " cm");
                Console.WriteLine("Weight: " + weights[i] + " kg");
                Console.WriteLine("BMI: " + bmis[i]);
                Console.WriteLine("Weight status: " + weightStatuses[i]);
                Console.WriteLine();
            }
        }
    }
}
