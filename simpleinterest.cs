using System;
	class simpleinterest
	{
	static void Main()
	{
	Console.WriteLine("Enter the principal amount :");
	double principal = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the rate :");
	double rate = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the time  :");
	double time = Convert.ToDouble(Console.ReadLine());
	double SimpleInterest = (principal*rate*time)/100;
	Console.WriteLine("The Simple interest is: "+SimpleInterest);
	}
	}
	