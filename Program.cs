using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
public class Dog : Animal
{
   /* public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound(); 
    }*/
}
