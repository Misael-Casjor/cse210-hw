using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter the your percentage grade");
        string percentage = Console.ReadLine();
        int forCalculation = int.Parse(percentage);
        string message = "Your grade is";
        if (forCalculation < 60)
        {
            Console.Write($"{message} F");
        }
        if (forCalculation >= 60)
        {
            Console.Write($"{message} D");
        }
        if (forCalculation >= 70)
        {
            Console.Write($"{message} C");

        }
        

    }
}