using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,9);
        Console.WriteLine("Choose a number between 1 to 9");
        string selectedNumber = Console.ReadLine();
        int number = int.Parse(selectedNumber);
         
        while (number != magicNumber)
        {
            if (number < magicNumber)
            {
                Console.WriteLine("Higer");
            }
             if (number > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

    }
}