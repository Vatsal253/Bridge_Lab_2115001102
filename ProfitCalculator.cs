using System;
namespace ProfitCalculator
{
	class System
	{
		static void Main()
		{
			double costPrice = 129;
			double sellingPrice = 191;
			Console.WriteLine("The Cost Price is INR"+costPrice+" and Selling Price is INR" +sellingPrice);
		
			double profit = sellingPrice - costPrice;
			double profitPercent = (profit/costPrice)*100;
			Console.WriteLine("The Profit is INR "+profit+" and the Profit Percentage is "+profitPercent+"%");
		}
	}
}