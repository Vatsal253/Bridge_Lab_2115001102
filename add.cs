using System;
	class add
	{ 
    static void Main()
	{
	Console.WriteLine("Enter the first number:");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the second number:");
	int num2 = Convert.ToInt32(Console.ReadLine());
	int sum = num1 + num2;
	Console.WriteLine("The sum is: "+sum);
	
	}
	}