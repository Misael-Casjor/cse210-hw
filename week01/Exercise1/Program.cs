using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;
        Console.WriteLine("What its your first name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your Last Name");
        lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
        
    }
}