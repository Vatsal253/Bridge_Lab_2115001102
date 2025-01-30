using System;
namespace DateArithmetic
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the date(yyyy-mm-dd): ");
			string input = Console.ReadLine();
			DateTime date;
			if (DateTime.TryParse(input, out date))
			{
				date = date.AddDays(7);
				date = date.AddMonths(1);
				date = date.AddYears(2);
				
				date = date.AddDays(-21);
				Console.WriteLine("The final date is: "+date.ToString("yyyy-MM-dd"));
			}
			else
			{
				Console.WriteLine("Invalid date format");
			}
		}
	}
}