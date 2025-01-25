using System;
namespace BMI
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of persons:");
            int numberOfPersons = int.Parse(Console.ReadLine());

            double[][] personData = new double[numberOfPersons][];
            string[] weightStatus = new string[numberOfPersons];

            // Initialize the multi-dimensional array
            for (int i = 0; i < numberOfPersons; i++)
            {
                personData[i] = new double[3];
            }

            // Taking input for weight and height of the persons
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Enter the weight (in kg) of person " + (i + 1) + ":");
                personData[i][0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height (in cm) of person " + (i + 1) + ":");
                personData[i][1] = double.Parse(Console.ReadLine());

                if (personData[i][0] <= 0 || personData[i][1] <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter positive values.");
                    i--;
                }
            }

            // Calculating BMI and weight status
            for (int i = 0; i < numberOfPersons; i++)
            {
                double heightInMeters = personData[i][1] / 100;
                personData[i][2] = personData[i][0] / (heightInMeters * heightInMeters);

                if (personData[i][2] < 18.5)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                {
                    weightStatus[i] = "Normal weight";
                }
                else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obesity";
                }
            }

            // Displaying the results
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Person " + (i + 1) + ":");
                Console.WriteLine("Height: " + personData[i][1] + " cm");
                Console.WriteLine("Weight: " + personData[i][0] + " kg");
                Console.WriteLine("BMI: " + personData[i][2]);
                Console.WriteLine("Weight status: " + weightStatus[i]);
                Console.WriteLine();
            }
        }
    }
}
