using System;
namespace NumberGuessingGame
{
	class Program
	{
		static void Main(String[] args)
		{
			Console.WriteLine("Think of a number between 1 and 100: ");
			int min = 1;
			int max = 100;
			bool correctGuess = false;
			
			while(!correctGuess)
			{
				int guess = GenerateGuess(min , max);
				Console.WriteLine("Is your guess "+guess+"? (Enter 'high','low' or 'correct'):");
				string feedback = Console.ReadLine().ToLower();
				correctGuess = ProcessFeedback(feedback, ref min, ref max, guess);
		    }
			Console.WriteLine("This is your number");
		}
		static int GenerateGuess(int min , int max)
		{
			Random random = new Random();
			return random.Next(min , max + 1);
		}
		static bool ProcessFeedback(string feedback , ref int min , ref int max ,int guess)
		{
			if(feedback == "high"){
				max = guess -1;
			}
			else if (feedback == "low"){
				min = guess + 1;
			}
			else if (feedback == "correct"){
				return true;
			}
			else{
				Console.WriteLine("Invalid feedback");
			}
			
			return false;
		}
	}
}
			
			
		
