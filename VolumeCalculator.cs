using System;
namespace VolumeCalculator
{
	class Program
	{
		static void Main()
		{
			double radius = 6378.0;
			double volumeKilometers = (4/3)*Math.PI*Math.Pow(radius,3);
			double volumeMiles = volumeKilometers*0.62137119;
			Console.WriteLine("The volume of earth in cubic kilometers is "+volumeKilometers+" and cubic miles is "+volumeMiles);
		}
	}
}