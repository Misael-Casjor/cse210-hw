using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine("Choose a number between 1 to 100");
        string selectedNumber = Console.ReadLine();
        int number = int.Parse(selectedNumber);
         
        while (number != magicNumber)
        {
            number = int.Parse(selectedNumber);

            if (number < magicNumber)
            {
                Console.WriteLine("Higer, gess again");
                selectedNumber =  Console.ReadLine();
            }
            else if (number > magicNumber)
            {
                Console.WriteLine("Lower, gess again");
                selectedNumber =  Console.ReadLine();
            }
        }
        if (number == magicNumber)
        {
        Console.WriteLine($"you gessed it! the magic number was {magicNumber}");
        }
    }
}