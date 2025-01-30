using System;
namespace DateTimeZones
{
	class Program
	{
		static void Main()
		{
			DateTimeOffset currentTime = DateTimeOffset.Now;
			
			TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard time");
			TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("IST Standard time");
			TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard time");
			
			DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentTime, gmtZone);
			DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentTime, istZone);
			DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentTime, pstZone);
			
			Console.WriteLine("Current time in GMT is: "+gmtTime);
			Console.WriteLine("Current time in IST is: "+istTime);
			Console.WriteLine("Current time in PST is: "+pstTime);
		}
	}
}