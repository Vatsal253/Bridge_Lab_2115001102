using System;
namespace VowelConsonent
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the string: ");
			string input = Console.ReadLine().ToLower();
			int countV = 0;
			int countC = 0;
			char[]vowels = {'a','e','i','o','u'};
			foreach(char c in input){
				if(char.IsLetter(c))
				{
					if (Array.Exists(vowels, element => element == c))
					{
						countV++;
					}
					else
					{
					countC++;
					}
				}
			}
			Console.WriteLine("The number of vowels are: "+countV);
			Console.WriteLine("The number of consonants are: "+countC);
		}
	}
}
	