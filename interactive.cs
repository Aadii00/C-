using System;
 
class InteractiveWelcome
{
    public static void Main()
    {
        Console.Write("What is your name?: ");
        Console.Write("Hello, {0}! ", Console.ReadLine());
        Console.WriteLine("Welcome to the C# Tutorial!");
        Console.ReadLine();
    }
}