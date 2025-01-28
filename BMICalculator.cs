using System;
namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            double[,] members = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the weight (in kg) of member " + (i + 1) + ":");
                members[i, 0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height (in cm) of member " + (i + 1) + ":");
                members[i, 1] = double.Parse(Console.ReadLine());

                // Calculate BMI and store it in the array
                members[i, 2] = CalculateBMI(members[i, 0], members[i, 1]);
            }

            // Display the height, weight, BMI, and status of each individual
            for (int i = 0; i < 10; i++)
            {
                string status = DetermineBMIStatus(members[i, 2]);
                Console.WriteLine("Member " + (i + 1) + ":");
                Console.WriteLine("Weight: " + members[i, 0] + " kg");
                Console.WriteLine("Height: " + members[i, 1] + " cm");
                Console.WriteLine("BMI: " + members[i, 2]);
                Console.WriteLine("Status: " + status);
                Console.WriteLine();
            }
        }

        static double CalculateBMI(double weight, double heightCm)
        {
            double heightM = heightCm / 100; // Convert height from cm to meters
            return weight / (heightM * heightM);
        }

        static string DetermineBMIStatus(double bmi)
        {
            if (bmi < 18.4)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi < 39.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
