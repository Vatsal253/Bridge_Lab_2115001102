using System;
namespace FeeCalculator2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the fees: ");
			double fee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the discount percent: ");
			double discountPercent = Convert.ToDouble(Console.ReadLine());;
            
            double discount = (fee * discountPercent) / 100;
            double discountedFee = fee - discount;
            
            Console.WriteLine("The discount amount is INR"+discount+" and final discounted fee is INR" +discountedFee);
        }
    }
}