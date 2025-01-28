using System;
namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of c:");
            double c = double.Parse(Console.ReadLine());

            double[] roots = FindRoots(a, b, c);

            if (roots.Length == 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("The equation has one real root: " + roots[0]);
            }
            else
            {
                Console.WriteLine("The equation has two real roots: " + roots[0] + " and " + roots[1]);
            }
        }

        static double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }
    }
}
