using System;
namespace MaxOfThreeNumbers
{
	class Program
	{
		static void Main()
		{
			int num1 = GetIntegerInput("Enter the first number:");
			int num2 = GetIntegerInput("Enter the second number:");
			int num3 = GetIntegerInput("Enter the third number:");
			int max = FindMax(num1,num2,num3);
			Console.WriteLine("The max of the numbers is: "+max);
		}
		
		static int GetIntegerInput(string prompt)
        {
            Console.WriteLine(prompt);
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
            return input;
        }
		
		static int FindMax(int a,int b, int c)
		{
		  int max = 0;
		  if(a>b && a>c){
			max = a;
		}
		else if(b>a && b>c)
		{
			max = b;
		}
		else{
			max = c;
		}

		return max;
		}
	}
}
	
		