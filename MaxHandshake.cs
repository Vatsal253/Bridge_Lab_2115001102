using System;
namespace MaxHandshake
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the number of students: ");
			int student = Convert.ToInt32(Console.ReadLine());
			int maxHandshakes = (student *(student-1))/2;
			Console.WriteLine("The maximum possible number of handshakes is "+maxHandshakes);
		}
	}
}