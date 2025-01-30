using System;
namespace DateComparison
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the first date(dd-MM-yyyy): ");
			string input1 = Console.ReadLine();
			DateTime date1;
			
			Console.WriteLine("Enter the second date(dd-MM-yyyy): ");
			string input2 = Console.ReadLine();
			DateTime date2;
			
			if(DateTime.TryParse(input1, out date1) && DateTime.TryParse(input2 , out date2))
			{
				int compare = DateTime.Compare(date1,date2);
				if(compare<0)
				{
					Console.WriteLine("The first date is before the second date");
				}
				else if(compare>0)
				{
					Console.WriteLine("The first date is after the second date");
				}
				else
				{
					Console.WriteLine("Both are on the same date");
				}
			}
			else
			{
				Console.WriteLine("Invalid Date Format");
			}
		}
	}
}
					
			