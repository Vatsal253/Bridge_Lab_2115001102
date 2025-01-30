using System;
namespace DateFormatting
{
	class Program
	{
		static void Main()
		{
			DateTime currentDate = DateTime.Now;
			Console.WriteLine("Current date in dd/MM/yyyy is: "+ currentDate.ToString("dd/MM/yyyy"));
			Console.WriteLine("Current date in yyyy/MM/dd is: "+ currentDate.ToString("yyyy/MM/dd"));
			Console.WriteLine("Current date in EEE, MMM dd,yyyy is: "+ currentDate.ToString("EEE, MMM dd,yyyy"));
		}
	}
}