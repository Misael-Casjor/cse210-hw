using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter the your percentage grade:");
        string percentage = Console.ReadLine();
        int forCalculation = int.Parse(percentage);
        string message = "Your grade is";
        if (forCalculation < 60)
        {
            Console.Write($"{message} F");
        }
        else if (forCalculation >= 60)
        {
            Console.Write($"{message} D");
        }
        else if (forCalculation >= 70)
        {
            Console.Write($"{message} C");

        }
        else if (forCalculation >= 80)
        {
            Console.Write($"{message} B");

        }
        else if (forCalculation >= 90)
        {
            Console.Write($"{message} A");

        }
        if (forCalculation >= 70)
        {
            Console.Write(". Congratulation! you passed");
        }
        else if (forCalculation < 70)
        {
            Console.Write(", dint pass this time, remember to keep going you can do it");
        }

    }
}