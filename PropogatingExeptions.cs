using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }

    static void Method1()
    {
		int x = 0;
        int result = 10 / x;
    }

    static void Method2()
    {
        Method1();
    }
}
