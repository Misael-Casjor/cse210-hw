using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        string firstName;
        string lastName;
        Console.WriteLine("What is your first name?");
        firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        lastName = Console.ReadLine();
        Console.WriteLine($"Your Name is {lastName}, {firstName} {lastName}");


    }
}