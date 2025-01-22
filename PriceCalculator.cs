using System;
namespace PriceCalculator
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the price of the item: ");
			double unitPrice = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the number of the item: ");
			double quantity = Convert.ToDouble(Console.ReadLine());
			double totalPrice = unitPrice * quantity;
			Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity is "+quantity+" and unit price is INR "+unitPrice);
		}
	}
}