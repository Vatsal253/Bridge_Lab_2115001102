using System;
namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the weight (in kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height (in cm):");
            double heightCm = double.Parse(Console.ReadLine());

            // Convert height from cm to meters
            double heightM = heightCm / 100;

            // Calculate BMI
            double bmi = weight / (heightM * heightM);

            // Determine weight status
            string weightStatus;
            if (bmi < 18.4)
            {
                weightStatus = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                weightStatus = "Normal";
            }
            else if (bmi >= 25 && bmi < 89.9)
            {
                weightStatus = "Overweight";
            }
            else
            {
                weightStatus = "Obese";
            }

            // Display BMI and weight status
            Console.WriteLine("Your BMI is " + bmi + ".");
            Console.WriteLine("Weight status: " + weightStatus + ".");
        }
    }
}
